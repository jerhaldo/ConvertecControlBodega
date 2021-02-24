using ConvertecControlBodega.Business;
using System;
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
        }

        private void IngresoTrabajador_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.CheckDBConnection(true);
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
            else if (MovimientoBusiness.CheckId(Int32.Parse(txtId.Text)))   //Validates existent ID
            {
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
                    timer1.Stop();
                    this.Hide();
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

        private void IngresoTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckDBConnection(bool showError)
        {
            if (MovimientoBusiness.CheckDBConnection(showError))
            {
                AutoCompleteTextID();
                AutoCompleteTextOT();
                iconPbDataBase.IconColor = Color.FromArgb(138, 183, 30);
                btnConfirmar.Enabled = true;
            }
            else
            {
                //MessageBox.Show("Error, No se ha podido establecer una conexión con la base de datos.", "Error de conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iconPbDataBase.IconColor = Color.FromArgb(255, 56, 0);
                this.btnConfirmar.Enabled = false;
            }
        }

        private void IconPbDataBase_Click(object sender, EventArgs e)
        {
            //Forzar chequeo
            timer1.Stop();
            this.CheckDBConnection(true);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Cada 30 sec
            this.CheckDBConnection(false);
        }
    }

}
