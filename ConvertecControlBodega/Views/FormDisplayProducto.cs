using ConvertecControlBodega.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class FormDisplayProducto : System.Windows.Forms.Form
    {
        public FormDisplayProducto()
        {
            InitializeComponent();
            AutoCompleteTextID();
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void AutoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.CodBodegaProducto cod in MovimientoBusiness.GetCodBodegaProductos(false))
            {
                collId.Add(cod.cod_bodega.ToString());
            }

            txtCodigo.AutoCompleteCustomSource = collId;

        }

        private void CargarDescripcion()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (MovimientoBusiness.CheckProducto(Int32.Parse(txtCodigo.Text), false))
                {
                    var data = MovimientoBusiness.GetDescProductosDetalle(Int32.Parse(txtCodigo.Text));
                    lblDescripcion.Text = data.descripcion;
                    lblMarca.Text = data.nom_marca;
                    lblProveedor.Text = data.nom_proveedor;
                    lblPartePlano.Text = data.parte_plano;
                    lblStock.Text = data.stock.ToString();
                    lblFechaReciente.Text = data.ult_fecha_compra.ToString();
                    txtObs.Text = data.obs;
                    lblDisponibilidad.Text = MovimientoBusiness.GetDisponibilidad(data.borrado);
                    
                    //Chequea si el producto posee imagen
                    var img = MovimientoBusiness.GetImages(Int32.Parse(txtCodigo.Text));
                    if (img != null)
                    {
                        pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/imgProductos/" + img.image);
                    } else {
                        pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
                    }
                    
                    txtCodigo.Focus();
                }
                else
                {
                    AlertMessage("Error, el código de producto ingresado no se encuentra en el sistema.", MessageBoxIcon.Error);
                    CleanData();
                }
            } else
            {
                AlertMessage("Por favor ingrese un código de producto.", MessageBoxIcon.Error);
                CleanData();
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
                CargarDescripcion();
            }
        }

        private void CleanData()
        {
            txtCodigo.Clear();
            
            lblDescripcion.Text = "";
            lblProveedor.Text = "";
            lblMarca.Text = "";
            lblPartePlano.Text = "";
            lblStock.Text = "";
            lblFechaReciente.Text = "";
            txtObs.Text = "";
            lblDisponibilidad.Text = "";
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
