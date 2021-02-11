﻿using ConvertecControlBodega.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertecControlBodega.Views
{
    public partial class FormSalida : Form
    {
        public FormSalida(String id, String ot)
        {
            InitializeComponent();
            AutoCompleteTextID();
            lblIdValue.Text = id;
            lblOtValue.Text = ot;
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            //Genera folio a partir de la fecha 20/01/2021 => 20012021
            lblFolioValue.Text = DateTime.Now.ToString("d").Replace("/", "");
            var idTrabajador = Int32.Parse(lblIdValue.Text);
            lblNombreValue.Text = $"{MovimientoBusiness.GetNombre(idTrabajador).nombre} {MovimientoBusiness.GetNombre(idTrabajador).apellidos}";
        }

        private void AutoCompleteTextID()
        {
            AutoCompleteStringCollection collId = new AutoCompleteStringCollection();
            foreach (Model.CodBodegaProducto cod in MovimientoBusiness.GetCodBodegaProductos())
            {
                collId.Add(cod.cod_bodega.ToString());
            }

            txtCodigo.AutoCompleteCustomSource = collId;

        }

        private void CargarDescripcion(object sender, EventArgs e)
        {
            CheckProducto();
        }

        private void CheckProducto()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                AlertMessage("Por favor ingrese un código de producto.", MessageBoxIcon.Error);
                CleanData();
                txtCodigo.Focus();

            }
            else if (MovimientoBusiness.CheckProducto(Int32.Parse(txtCodigo.Text)))
            {
                var data = MovimientoBusiness.GetDescProductos(Int32.Parse(txtCodigo.Text));
                lblDescripcion.Text = data.descripcion;
                lblMarca.Text = data.nom_marca;
                lblProveedor.Text = data.nom_proveedor;
                lblPartePlano.Text = data.parte_plano;
                txtIdProd.Text = data.id_producto.ToString();
                pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/imgProductos/" + data.image);
            }
            else
            {
                AlertMessage("Error, el código de producto ingresado no se encuentra en el sistema.", MessageBoxIcon.Error);
                CleanData();
                txtCodigo.Focus();
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
                SendKeys.Send("{TAB}");
            }
        }

        private void CleanData()
        {
            txtCodigo.Clear();
            txtCant.Text = "1";
            txtObsSalida.Clear();

            txtIdProd.Clear();
            lblDescripcion.Text = "";
            lblProveedor.Text = "";
            lblMarca.Text = "";
            lblPartePlano.Text = "";
            pictureBoxProducto.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Assets/logos/image-unavailable.png");
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
            {
                if (row.Cells["id_producto"].Value != null)
                {
                    if (row.Cells["id_producto"].Value.ToString().Equals(txtIdProd.Text))
                    {
                        row.Cells["cantidad"].Value = Double.Parse(txtCant.Text) + Double.Parse(row.Cells["cantidad"].Value.ToString());
                        row.Cells["fecha_mov"].Value = DateTime.Now;
                        if (!string.IsNullOrWhiteSpace(txtObsSalida.Text))
                        {
                            row.Cells["obs_mov"].Value = txtObsSalida.Text;
                        }
                        CleanData();
                        txtCodigo.Focus();
                        break;
                    }
                } else
                {
                    dataGridViewProdSalientes.Rows.Add(txtIdProd.Text, txtCodigo.Text, lblDescripcion.Text, txtCant.Text, DateTime.Now, txtObsSalida.Text);
                    CleanData();
                    txtCodigo.Focus();
                    break;
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdSalientes.Rows != null && dataGridViewProdSalientes.Rows.Count > 1)
            {
                List<Model.ProdSalida> prodSalList = new List<Model.ProdSalida>();

                foreach (DataGridViewRow row in dataGridViewProdSalientes.Rows)
                {
                    if (row.Cells["id_producto"].Value != null)
                    {
                        Model.ProdSalida prodSalida = new Model.ProdSalida
                        {
                            id_producto = Int32.Parse(row.Cells["id_producto"].Value.ToString()),
                            fecha_mov = DateTime.Parse(row.Cells["fecha_mov"].Value.ToString()),
                            ot = lblOtValue.Text,
                            cantidad = Double.Parse(row.Cells["cantidad"].Value.ToString()),
                            obs_mov = row.Cells["obs_mov"].Value.ToString(),
                            id_trabajador = Int32.Parse(lblIdValue.Text),
                            folio = Int32.Parse(lblFolioValue.Text)
                        };

                        prodSalList.Add(prodSalida);
                    }
                }

                MovimientoBusiness.InsertSalida(prodSalList);
                AlertMessage("Registro guardado con exito.", MessageBoxIcon.Information);
                this.Close();
            } else
            {
                AlertMessage("La lista de elementos se encuentra vacía, por favor ingrese elementos a la lista.", MessageBoxIcon.Error);
            }
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CheckDecimalCantidad(object sender, EventArgs e)
        {
            //
            if (!decimal.TryParse(txtCant.Text.ToString().Replace(",", "."), out decimal cantidad))
            {
                AlertMessage("Por favor ingrese un número válido.", MessageBoxIcon.Error);
                txtCant.Clear();
                txtCant.Focus();
            }
            else
            {
                if (!(cantidad > 0))
                {
                    AlertMessage("Por favor ingrese un número mayor a 0.", MessageBoxIcon.Error);
                    txtCant.Clear();
                    txtCant.Focus();
                } else
                {
                    txtCant.Text = cantidad.ToString();
                }
                
            }
        }
    }
}
