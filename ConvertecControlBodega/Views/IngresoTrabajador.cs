using ConvertecControlBodega.Business;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class IngresoTrabajador : System.Windows.Forms.Form
    {
        public IngresoTrabajador()
        {
            InitializeComponent();
            this.CancelButton = btnCancelar;
            this.txtId.Select();
            this.CheckDBConnection(false, true);
        }

        private void IngresoTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //Validates empty ID
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                AlertMessage("No se ingresó ninguna ID, por favor ingrese su ID.");
                txtId.Focus();
            }
            else if (MovimientoBusiness.CheckDBConnection(false, true)) //Validates existent ID
            {
                switch (MovimientoBusiness.CheckId(Int32.Parse(txtId.Text)))
                {
                    case 1:
                        //Validates empty OT
                        if (string.IsNullOrWhiteSpace(txtOt.Text))
                        {
                            AlertMessage("No se ingresó ninguna OT, por favor ingrese un identificador.");
                            txtOt.Focus();
                        }
                        else
                        {
                            //Opens Form
                            Form formSalida = new FormSalida(this.txtId.Text, this.txtOt.Text);
                            formSalida.Show();
                            this.Hide();
                        }
                        break;

                    case 0:
                        AlertMessage("Error, el ID ingresado no se encuentra en el sistema.");
                        txtId.Focus();
                        break;
                }
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

        private void IngresoTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckDBConnection(bool showSuccess, bool showError)
        {
            if (MovimientoBusiness.CheckDBConnection(showSuccess, showError))
            {
                AutoCompleteTextID();
                AutoCompleteTextOT();
                btnDataBase.IconColor = Color.FromArgb(138, 183, 30);
                btnConfirmar.Enabled = true;
            }
            else
            {
                //MessageBox.Show("Error, No se ha podido establecer una conexión con la base de datos.", "Error de conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDataBase.IconColor = Color.FromArgb(255, 56, 0);
                this.btnConfirmar.Enabled = false;
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Views.Configuraciones frmConfig = new Views.Configuraciones();
            frmConfig.ShowDialog();
            frmConfig.Dispose();
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            this.CheckDBConnection(true, true);
        }
    }

}
