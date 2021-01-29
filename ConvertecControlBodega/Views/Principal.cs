using ConvertecControlBodega.Business;
using ConvertecControlBodega.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertecControlBodega
{
    public partial class Principal : Form
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

        void PopulateData()
        {   

            dataGridViewSalidas.DataSource = MovimientoBusiness.GetMovimientos();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("G");
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            ConfirmacionSalida formSalida = new ConfirmacionSalida();
            formSalida.ShowDialog();
        }
    }
}
