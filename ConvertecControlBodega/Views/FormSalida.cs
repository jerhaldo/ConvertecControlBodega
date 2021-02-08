using ConvertecControlBodega.Business;
using System;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class FormSalida : Form
    {
        public FormSalida(String id, String ot)
        {
            InitializeComponent();
            autoCompleteTextID();
            txtId.Text = id;
            txtOt.Text = ot;
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            txtFolio.Text = DateTime.Now.ToString("d").Replace("/", "");
            txtNombre.Text = $"{MovimientoBusiness.GetNombre(Int32.Parse(txtId.Text)).nombre} {MovimientoBusiness.GetNombre(Int32.Parse(txtId.Text)).apellidos}";
        }

        private void autoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.CodBodegaProducto cod in MovimientoBusiness.GetCodBodegaProductos())
            {
                collId.Add(cod.cod_bodega.ToString());
            }

            txtCodigo.AutoCompleteCustomSource = collId;

        }

        private void cargarDescripcion(object sender, EventArgs e)
        {
            CheckProducto();
        }

        private void CheckProducto()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                AlertMessage("No se ingresó ningun código, por favor ingrese un código de producto.");
                cleanData();
                txtCodigo.Focus();

            }
            else if (MovimientoBusiness.CheckProducto(Int32.Parse(txtCodigo.Text)))
            {
                var data = MovimientoBusiness.GetDescProductos(Int32.Parse(txtCodigo.Text));
                txtDescripcion.Text = data.descripcion;
                txtMarca.Text = data.nom_marca;
                txtProveedor.Text = data.nom_proveedor;
                txtPartePlano.Text = data.parte_plano;
                txtObsProducto.Text = data.obs;
                txtIdProd.Text = data.id_producto.ToString();
                pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/imgProductos/" + data.image);
            }
            else
            {
                AlertMessage("Error, el código de producto ingresado no se encuentra en el sistema.");
                cleanData();
                txtCodigo.Focus();
            }
        }

        private void AlertMessage(string message)
        {
            string caption = "Error Detectado en el Código de Producto";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            //Muestra el MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }

        private void nextFocus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //no ding
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cleanData()
        {
            txtCodigo.Clear();
            txtCant.Text = "1";
            txtObsSalida.Clear();

            txtIdProd.Clear();
            txtDescripcion.Clear();
            txtProveedor.Clear();
            txtMarca.Clear();
            txtPartePlano.Clear();
            txtObsProducto.Clear();
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
            {
                if (row.Cells["id_producto"].Value != null)
                {
                    if (row.Cells["id_producto"].Value.ToString().Equals(txtIdProd.Text))
                    {
                        row.Cells["cantidad"].Value = Double.Parse(txtCant.Text) + Double.Parse(row.Cells["cantidad"].Value.ToString());
                        row.Cells["fecha_mov"].Value = DateTime.Now;
                        if (!string.IsNullOrWhiteSpace(txtObsSalida.Text))
                        {
                            Console.WriteLine("Cell" + row.Cells["obs_mov"].Value.ToString());
                            row.Cells["obs_mov"].Value = txtObsSalida.Text;
                        }
                        cleanData();
                        txtCodigo.Focus();
                        break;
                    }
                } else
                {
                    dataGridViewProdSalientes.Rows.Add(txtIdProd.Text, txtCodigo.Text, txtDescripcion.Text, txtCant.Text, DateTime.Now, txtOt.Text, txtObsSalida.Text);
                    cleanData();
                    txtCodigo.Focus();
                    break;
                }
            }
            
        }
    }
}
