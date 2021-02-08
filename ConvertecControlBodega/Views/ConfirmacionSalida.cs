using ConvertecControlBodega.Business;
using System;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class ConfirmacionSalida : Form
    {
        public ConfirmacionSalida()
        {
            InitializeComponent();
            autoCompleteTextID();
            autoCompleteTextOT();
            this.CancelButton = btnCancelar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmacionSalida();
        }

        private void confirmacionSalida()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                AlertMessage("No se ingresó ninguna ID, por favor ingrese su ID.");
                txtId.Focus();
            }
            else if (MovimientoBusiness.CheckId(Int32.Parse(txtId.Text)))
            {
                this.Close();
                FormSalida formSalida = new FormSalida(this.txtId.Text, this.txtOt.Text);
                formSalida.ShowDialog();
            }
            else
            {
                AlertMessage("Error, el ID ingresado no se encuentra en el sistema.");
                txtId.Focus();
            }
        }

        private void enterKeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmacionSalida();
            }
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

        private void autoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.IdTrabajdor id in MovimientoBusiness.GetIDs())
            {
                collId.Add(id.id_trabajador.ToString());
            }

            txtId.AutoCompleteCustomSource = collId;

        }

        private void autoCompleteTextOT()
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

        private void checkNumber(object sender, KeyPressEventArgs e)
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
            DialogResult result;

            //Muestra el MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }
    }

}
