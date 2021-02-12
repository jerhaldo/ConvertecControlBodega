using ConvertecControlBodega.Business;
using ConvertecControlBodega.Views;
using System;
using System.Windows.Forms;

namespace ConvertecControlBodega
{
    public partial class Principal : System.Windows.Forms.Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateData();
            timer1.Start();
        }

        public void PopulateData()
        {
            dataGridViewSalidas.DataSource = MovimientoBusiness.GetMovimientos();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("G");
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            IngresoTrabajador ingTrabajador = new IngresoTrabajador();
            ingTrabajador.ShowDialog();
        }

        private void RefreshData(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                PopulateData();
            }
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            FormDisplayProducto mostrar = new FormDisplayProducto();
            mostrar.ShowDialog();
        }
    }
}
