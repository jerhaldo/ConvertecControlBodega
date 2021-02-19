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

        private void Principal_Load(object sender, EventArgs e)
        {
            PopulateData();
            timer1.Start();
        }

        public void PopulateData()
        {
            dataGridViewSalidas.DataSource = MovimientoBusiness.GetMovimientosSalidas();
            dataGridViewIngresos.DataSource = MovimientoBusiness.GetMovimientosIngresos();
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

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscadorProductos buscador = new BuscadorProductos();
            buscador.ShowDialog();
        }

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngreso ingreso = new FormIngreso();
            ingreso.ShowDialog();
        }
    }
}
