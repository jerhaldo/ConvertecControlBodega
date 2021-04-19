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
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            txtDirectorio.Text = Properties.Settings.Default.ImagePath;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ImagePath = folderBrowserDialogImagePath.SelectedPath;
            Properties.Settings.Default.Save();
            MessageBox.Show("Directorio Actualizado con éxito.", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowserImagePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogImagePath.Description = "Seleccione una carpeta para almacenar las imagenes.";
            folderBrowserDialogImagePath.ShowNewFolderButton = true;

            if (folderBrowserDialogImagePath.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = folderBrowserDialogImagePath.SelectedPath;
            }
        }
    }
}
