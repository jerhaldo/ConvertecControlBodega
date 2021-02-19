using ConvertecControlBodega.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class FormIngreso : System.Windows.Forms.Form
    {
        public FormIngreso()
        {
            InitializeComponent();
            AutoCompleteTextID();
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            //Genera folio a partir de la fecha 20/01/2021 => 20012021
            lblFolioValue.Text = DateTime.Now.ToString("d").Replace("/", "");
            var idTrabajador = Int32.Parse(lblIdValue.Text);
            lblNombreValue.Text = $"{MovimientoBusiness.GetNombre(idTrabajador).nombre} {MovimientoBusiness.GetNombre(idTrabajador).apellidos}";
        }

        private void AutoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.CodBodegaProducto cod in MovimientoBusiness.GetCodBodegaProductos(true))
            {
                collId.Add(cod.cod_bodega.ToString());
            }

            txtCodigo.AutoCompleteCustomSource = collId;

        }

        private void CargarDescripcion(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (MovimientoBusiness.CheckProducto(Int32.Parse(txtCodigo.Text), true))
                {
                    var data = MovimientoBusiness.GetDescProductos(Int32.Parse(txtCodigo.Text));
                    lblDescripcion.Text = data.descripcion;
                    lblMarca.Text = data.nom_marca;
                    lblProveedor.Text = data.nom_proveedor;
                    lblPartePlano.Text = data.parte_plano;
                    txtIdProd.Text = data.id_producto.ToString();
                    lblStock.Text = data.stock.ToString();
                    var img = MovimientoBusiness.GetImages(Int32.Parse(txtCodigo.Text));
                    if (img != null)
                    {
                        pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/imgProductos/" + img.image);
                    }
                    else
                    {
                        pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
                    }

                }
                else
                {
                    AlertMessage("Error, el código de producto ingresado no se encuentra en el sistema.", MessageBoxIcon.Error);
                    CleanData();
                    txtCodigo.Focus();
                }
            }
            else
            {
                AlertMessage("Por favor ingrese un código de producto.", MessageBoxIcon.Error);
                CleanData();
                txtCodigo.Focus();
            }
        }

        private void AlertMessage(string message, MessageBoxIcon icon)
        {
            string caption = "Error Detectado en el Código de Producto";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Muestra el MessageBox.
            MessageBox.Show(message, caption, buttons, icon);
        }

        private void NextFocus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //no ding
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void CleanData()
        {
            txtCodigo.Clear();
            txtCant.Text = "1";
            txtObsSalida.Clear();

            txtIdProd.Clear();
            lblDescripcion.Text = "";
            lblProveedor.Text = "";
            lblMarca.Text = "";
            lblPartePlano.Text = "";
            lblStock.Text = "";
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
            {
                if (row.Cells["id_producto"].Value == null)
                {
                    if (MovimientoBusiness.GetDisponibilidad(Double.Parse(lblStock.Text), Double.Parse(txtCant.Text)))
                    {
                        dataGridViewProdSalientes.Rows.Add(txtIdProd.Text, txtCodigo.Text, lblDescripcion.Text, txtCant.Text, DateTime.Now, txtObsSalida.Text);
                        CleanData();
                        txtCodigo.Focus();
                        break;
                    }
                    else
                    {
                        AlertMessage("No hay Stock suficiente.\n\nEn caso de que sea un error, notificar.", MessageBoxIcon.Error);
                        txtCant.Focus();
                        break;
                    }
                }
                else if (row.Cells["id_producto"].Value.ToString().Equals(txtIdProd.Text))
                {
                    var sumCantidad = Double.Parse(txtCant.Text) + Double.Parse(row.Cells["cantidad"].Value.ToString());

                    if (MovimientoBusiness.GetDisponibilidad(Double.Parse(lblStock.Text), sumCantidad))
                    {
                        row.Cells["cantidad"].Value = sumCantidad;
                        row.Cells["fecha_mov"].Value = DateTime.Now;
                        if (!string.IsNullOrWhiteSpace(txtObsSalida.Text))
                        {
                            row.Cells["obs_mov"].Value = txtObsSalida.Text;
                        }
                        CleanData();
                        txtCodigo.Focus();
                        break;
                    }
                    else
                    {
                        AlertMessage("No hay Stock suficiente.\n\nEn caso de que sea un error, notificar.", MessageBoxIcon.Error);
                        txtCant.Focus();
                        break;
                    }
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdSalientes.Rows != null && dataGridViewProdSalientes.Rows.Count > 1)
            {
                List<Model.ProdSalida> prodSalList = new List<Model.ProdSalida>();

                foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
                {
                    if (row.Cells["id_producto"].Value != null)
                    {
                        Model.ProdSalida prodSalida = new Model.ProdSalida
                        {
                            id_producto = Int32.Parse(row.Cells["id_producto"].Value.ToString()),
                            fecha_mov = DateTime.Parse(row.Cells["fecha_mov"].Value.ToString()),
                            cantidad = Double.Parse(row.Cells["cantidad"].Value.ToString()),
                            obs_mov = row.Cells["obs_mov"].Value.ToString(),
                            id_trabajador = Int32.Parse(lblIdValue.Text),
                            folio = Int32.Parse(lblFolioValue.Text)
                        };
                        prodSalList.Add(prodSalida);
                    }
                }
                var result = MessageBox.Show("Si continua se guardarán los elementos que se encuentran en las lista.\nDesea confirmar?"
                                , "Confirmación de guardado.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    MovimientoBusiness.InsertSalida(prodSalList);

                    if (System.Windows.Forms.Application.OpenForms["Principal"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Principal"] as Principal).PopulateData();
                    }
                    this.Close();
                }

            }
            else
            {
                AlertMessage("La lista de elementos se encuentra vacía, por favor ingrese elementos a la lista.", MessageBoxIcon.Error);
            }
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CheckDecimalCantidad(object sender, EventArgs e)
        {
            //
            if (!decimal.TryParse(txtCant.Text.ToString().Replace(",", "."), out decimal cantidad))
            {
                AlertMessage("Por favor ingrese un número válido.", MessageBoxIcon.Error);
                txtCant.Clear();
                txtCant.Focus();
            }
            else
            {
                if (!(cantidad > 0))
                {
                    AlertMessage("Por favor ingrese un número mayor a 0.", MessageBoxIcon.Error);
                    txtCant.Clear();
                    txtCant.Focus();
                }
                else
                {
                    txtCant.Text = cantidad.ToString();
                }

            }
        }
    }
}
