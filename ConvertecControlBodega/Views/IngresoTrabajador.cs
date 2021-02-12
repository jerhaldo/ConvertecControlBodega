using ConvertecControlBodega.Business;
using System;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class IngresoTrabajador : System.Windows.Forms.Form
    {
        public IngresoTrabajador()
        {
            InitializeComponent();
            AutoCompleteTextID();
            AutoCompleteTextOT();
            this.CancelButton = btnCancelar;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {   
            //Validates empty ID
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                AlertMessage("No se ingresó ninguna ID, por favor ingrese su ID.");
                txtId.Focus();
            }
            else if (MovimientoBusiness.CheckId(Int32.Parse(txtId.Text)))   //Validates existent ID
            {
                //Validates empty OT
                if (string.IsNullOrWhiteSpace(txtOt.Text))
                {
                    AlertMessage("No se ingresó ninguna OT, por favor ingrese un identificador.");
                    txtOt.Focus();
                } else
                {   
                    //Opens Form
                    Form formSalida = new FormSalida(this.txtId.Text, this.txtOt.Text);
                    formSalida.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                AlertMessage("Error, el ID ingresado no se encuentra en el sistema.");
                txtId.Focus();
            }
        }

        private void AutoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.IdTrabajdor id in MovimientoBusiness.GetIDs())
            {
                collId.Add(id.id_trabajador.ToString());
            }

            txtId.AutoCompleteCustomSource = collId;

        }

        private void AutoCompleteTextOT()
        {
            AutoCompleteStringCollection collOt = new AutoCompleteStringCollection();
            foreach (Model.NumeroOt ot in MovimientoBusiness.GetOt())
            {
                if (ot.ot != null)
                {
                    collOt.Add(ot.ot.ToString());
                }
            }

            txtOt.AutoCompleteCustomSource = collOt;
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

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AlertMessage(string message)
        {
            string caption = "Error Detectado en el Ingreso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            
            //Muestra el MessageBox.
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
    }

}
