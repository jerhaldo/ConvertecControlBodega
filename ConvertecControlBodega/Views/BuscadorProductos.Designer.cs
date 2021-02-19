
namespace ConvertecControlBodega.Views
{
    partial class BuscadorProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.productoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codbodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultfechacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.codbodegaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.nomproveedorDataGridViewTextBoxColumn,
            this.nommarcaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.ultfechacompraDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.productoDetalleBindingSource;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 57);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1122, 546);
            this.advancedDataGridView1.TabIndex = 2;
            // 
            // productoDetalleBindingSource
            // 
            this.productoDetalleBindingSource.DataSource = typeof(ConvertecControlBodega.Model.ProductoDetalle);
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codbodegaDataGridViewTextBoxColumn
            // 
            this.codbodegaDataGridViewTextBoxColumn.DataPropertyName = "cod_bodega";
            this.codbodegaDataGridViewTextBoxColumn.HeaderText = "cod_bodega";
            this.codbodegaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codbodegaDataGridViewTextBoxColumn.Name = "codbodegaDataGridViewTextBoxColumn";
            this.codbodegaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.codbodegaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomproveedorDataGridViewTextBoxColumn
            // 
            this.nomproveedorDataGridViewTextBoxColumn.DataPropertyName = "nom_proveedor";
            this.nomproveedorDataGridViewTextBoxColumn.HeaderText = "nom_proveedor";
            this.nomproveedorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomproveedorDataGridViewTextBoxColumn.Name = "nomproveedorDataGridViewTextBoxColumn";
            this.nomproveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nomproveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nommarcaDataGridViewTextBoxColumn
            // 
            this.nommarcaDataGridViewTextBoxColumn.DataPropertyName = "nom_marca";
            this.nommarcaDataGridViewTextBoxColumn.HeaderText = "nom_marca";
            this.nommarcaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nommarcaDataGridViewTextBoxColumn.Name = "nommarcaDataGridViewTextBoxColumn";
            this.nommarcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nommarcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.valorDataGridViewTextBoxColumn.Width = 125;
            // 
            // ultfechacompraDataGridViewTextBoxColumn
            // 
            this.ultfechacompraDataGridViewTextBoxColumn.DataPropertyName = "ult_fecha_compra";
            this.ultfechacompraDataGridViewTextBoxColumn.HeaderText = "ult_fecha_compra";
            this.ultfechacompraDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ultfechacompraDataGridViewTextBoxColumn.Name = "ultfechacompraDataGridViewTextBoxColumn";
            this.ultfechacompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ultfechacompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // BuscadorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 615);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BuscadorProductos";
            this.Text = "BuscadorProductos";
            this.Load += new System.EventHandler(this.BuscadorProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultfechacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoDetalleBindingSource;
    }
}