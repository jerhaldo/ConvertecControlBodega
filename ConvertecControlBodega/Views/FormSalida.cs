using ConvertecControlBodega.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class FormSalida : System.Windows.Forms.Form
    {
        private bool unidad;
        private int idProd = -1;
        private int idTrabajador;

        public FormSalida(String id, String ot)
        {
            InitializeComponent();
            AutoCompleteTextID();
            lblIdValue.Text = id;
            lblOtValue.Text = ot;
            pictureBoxProducto.Image = Properties.Resources.image_unavailable;
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            //Genera folio a partir de la fecha Ej: 20/01/2021 => 20012021
            lblFolioValue.Text = DateTime.Now.ToString("ddMMyyyy");
            this.idTrabajador = Int32.Parse(lblIdValue.Text);
            lblNombreValue.Text = $"{MovimientoBusiness.GetNombre(this.idTrabajador).nombre} {MovimientoBusiness.GetNombre(idTrabajador).apellidos}";
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

        private void CheckCodigoBodega(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                AlertMessage("Por favor ingrese un código de producto.", MessageBoxIcon.Error);
                CleanData();
                txtCodigo.Focus();
            }
        }

        private void CargarDescripcion(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                //Chequea si existe conexión con la BD
                if (MovimientoBusiness.CheckDBConnection(true))
                {
                    if (MovimientoBusiness.CheckProducto(Int64.Parse(txtCodigo.Text), true))
                    {
                        var data = MovimientoBusiness.GetDescProductos(Int64.Parse(txtCodigo.Text));
                        lblDescripcion.Text = data.descripcion;
                        lblPartePlano.Text = data.parte_plano;
                        this.idProd = data.id_producto;
                        lblStock.Text = data.stock.ToString();
                        this.unidad = data.unidad;

                        if (this.unidad)
                            lblUnidad.Text = "Unidad";
                        else
                            lblUnidad.Text = "Metros";

                        var img = MovimientoBusiness.GetImages(Int64.Parse(txtCodigo.Text));
                        
                        if (img != null)
                            try
                            {
                                pictureBoxProducto.Image = Image.FromFile(@"D:\OneDrive\ConvertecImages\ImgProductos\" + img.image);
                            }
                            catch (System.IO.FileNotFoundException)
                            {
                                AlertMessage("Error al cargar imagen.", MessageBoxIcon.Error);
                                pictureBoxProducto.Image = Properties.Resources.image_unavailable;
                            }
                            
                        //pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/imgProductos/" + img.image);
                        else
                            pictureBoxProducto.Image = Properties.Resources.image_unavailable;

                    }
                    else
                    {
                        AlertMessage("Error, el código de producto ingresado no se encuentra en el sistema.", MessageBoxIcon.Error);
                        CleanData();
                        txtCodigo.Focus();
                    }
                }
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

            this.idProd = -1;
            lblDescripcion.Text = "";
            lblPartePlano.Text = "";
            lblStock.Text = "";
            lblUnidad.Text = "";
            pictureBoxProducto.Image = Properties.Resources.image_unavailable;
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
                            ot = lblOtValue.Text,
                            cantidad = Double.Parse(row.Cells["cantidad"].Value.ToString()),
                            obs_mov = row.Cells["obs_mov"].Value.ToString(),
                            id_trabajador = this.idTrabajador,
                            folio = Int32.Parse(lblFolioValue.Text)
                        };
                        prodSalList.Add(prodSalida);
                    }
                }
                var result = MessageBox.Show("Desea finalizar y confirmar el proceso?"
                                , "Confirmación de guardado.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes && MovimientoBusiness.CheckDBConnection(true))
                {
                    MovimientoBusiness.InsertSalida(prodSalList);
                    IngresoTrabajador ingreso = new IngresoTrabajador();
                    ingreso.Show();
                    this.Hide();
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
            if (!this.unidad)
            {
                txtCant.Text = txtCant.Text.Replace(".", ",");
                if (!decimal.TryParse(txtCant.Text, out decimal cantidad))
                {
                    AlertMessage("Por favor ingrese un número válido.", MessageBoxIcon.Error);
                    txtCant.Text = "1";
                    txtCant.Focus();
                }
            }
            CheckCantidad(Double.Parse(txtCant.Text));
        }

        private void CheckCantidad(double cantidad)
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

        private void CheckUnidad(object sender, KeyPressEventArgs e)
        {
            if (this.unidad)
            {
                CheckNumber(sender, e);
            }
        }

        private void FormSalida_FormClosed(object sender, FormClosedEventArgs e)
        {
            IngresoTrabajador ingreso = new IngresoTrabajador();
            ingreso.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
            {
                if (row.Cells["id_producto"].Value == null)
                {
                    if (MovimientoBusiness.GetDisponibilidad(Double.Parse(lblStock.Text), Double.Parse(txtCant.Text)))
                    {
                        dataGridViewProdSalientes.Rows.Add(this.idProd, txtCodigo.Text, lblDescripcion.Text, txtCant.Text, DateTime.Now, txtObsSalida.Text);
                        CleanData();
                        txtCodigo.Focus();
                        break;
                    }
                    else
                    {
                        AlertMessage("No hay Stock suficiente.\n\nPor favor notificar.", MessageBoxIcon.Error);
                        txtCant.Focus();
                        break;
                    }
                }
                else if (row.Cells["id_producto"].Value.ToString().Equals(this.idProd.ToString()))
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewProdSalientes.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridViewProdSalientes.Rows.RemoveAt(selectedIndex);
                    dataGridViewProdSalientes.Refresh();
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is NullReferenceException)
                {
                    MessageBox.Show("Debe seleccionar una fila para quitar.", "Error al quitar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                throw;
            }
        }
    }
}
