using ConvertecControlBodega.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class BuscadorProductos : Form
    {
        public BuscadorProductos()
        {
            InitializeComponent();
        }

        private void BuscadorProductos_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            //var bindingList = new BindingList<Model.ProductoDetalle>(MovimientoBusiness.GetProductosDetalle());
            //advancedDataGridView1.DataSource = MovimientoBusiness.GetProductosDetalle();
            //advancedDataGridView1.DataSource = bindingList;
            advancedDataGridView1.DataSource = MovimientoBusiness.GetProductosDetalle();

        }

    }
}
