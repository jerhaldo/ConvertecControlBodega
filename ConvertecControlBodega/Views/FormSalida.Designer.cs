
namespace ConvertecControlBodega.Views
{
    partial class FormSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.groupBoxProd = new System.Windows.Forms.GroupBox();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.txtObsProducto = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartePlano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.groupBoxMovimiento = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtOt = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblOt = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtObsSalida = new System.Windows.Forms.RichTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.dataGridViewProdSalientes = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.groupBoxMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 64);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(13, 145);
            this.lblCant.Margin = new System.Windows.Forms.Padding(10, 50, 10, 50);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(97, 21);
            this.lblCant.TabIndex = 1;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(13, 226);
            this.lblObs.Margin = new System.Windows.Forms.Padding(10);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(141, 21);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Observaciones:";
            // 
            // groupBoxProd
            // 
            this.groupBoxProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProd.Controls.Add(this.txtIdProd);
            this.groupBoxProd.Controls.Add(this.btn_agregar);
            this.groupBoxProd.Controls.Add(this.dataGridViewProdSalientes);
            this.groupBoxProd.Controls.Add(this.pictureBoxProducto);
            this.groupBoxProd.Controls.Add(this.txtObsProducto);
            this.groupBoxProd.Controls.Add(this.label2);
            this.groupBoxProd.Controls.Add(this.txtPartePlano);
            this.groupBoxProd.Controls.Add(this.label1);
            this.groupBoxProd.Controls.Add(this.txtProveedor);
            this.groupBoxProd.Controls.Add(this.lblProveedor);
            this.groupBoxProd.Controls.Add(this.txtMarca);
            this.groupBoxProd.Controls.Add(this.lblMarca);
            this.groupBoxProd.Controls.Add(this.groupBoxMovimiento);
            this.groupBoxProd.Controls.Add(this.txtDescripcion);
            this.groupBoxProd.Controls.Add(this.lblDescripcion);
            this.groupBoxProd.Controls.Add(this.txtObsSalida);
            this.groupBoxProd.Controls.Add(this.txtCodigo);
            this.groupBoxProd.Controls.Add(this.txtCant);
            this.groupBoxProd.Controls.Add(this.lblCodigo);
            this.groupBoxProd.Controls.Add(this.lblCant);
            this.groupBoxProd.Controls.Add(this.lblObs);
            this.groupBoxProd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProd.Location = new System.Drawing.Point(19, 19);
            this.groupBoxProd.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxProd.Name = "groupBoxProd";
            this.groupBoxProd.Size = new System.Drawing.Size(1336, 995);
            this.groupBoxProd.TabIndex = 3;
            this.groupBoxProd.TabStop = false;
            this.groupBoxProd.Text = "Producto";
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProducto.InitialImage")));
            this.pictureBoxProducto.Location = new System.Drawing.Point(464, 145);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(277, 264);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProducto.TabIndex = 14;
            this.pictureBoxProducto.TabStop = false;
            // 
            // txtObsProducto
            // 
            this.txtObsProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsProducto.Location = new System.Drawing.Point(624, 619);
            this.txtObsProducto.Margin = new System.Windows.Forms.Padding(10);
            this.txtObsProducto.MaxLength = 256;
            this.txtObsProducto.Name = "txtObsProducto";
            this.txtObsProducto.ReadOnly = true;
            this.txtObsProducto.Size = new System.Drawing.Size(317, 55);
            this.txtObsProducto.TabIndex = 13;
            this.txtObsProducto.TabStop = false;
            this.txtObsProducto.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 623);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Obs:";
            // 
            // txtPartePlano
            // 
            this.txtPartePlano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartePlano.Location = new System.Drawing.Point(217, 616);
            this.txtPartePlano.Name = "txtPartePlano";
            this.txtPartePlano.ReadOnly = true;
            this.txtPartePlano.Size = new System.Drawing.Size(258, 28);
            this.txtPartePlano.TabIndex = 11;
            this.txtPartePlano.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 619);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parte Plano:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(217, 562);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(258, 28);
            this.txtProveedor.TabIndex = 9;
            this.txtProveedor.TabStop = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(56, 565);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(102, 21);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(624, 562);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(317, 28);
            this.txtMarca.TabIndex = 7;
            this.txtMarca.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(522, 565);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 21);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // groupBoxMovimiento
            // 
            this.groupBoxMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMovimiento.Controls.Add(this.txtNombre);
            this.groupBoxMovimiento.Controls.Add(this.lblNombre);
            this.groupBoxMovimiento.Controls.Add(this.txtFolio);
            this.groupBoxMovimiento.Controls.Add(this.txtId);
            this.groupBoxMovimiento.Controls.Add(this.txtOt);
            this.groupBoxMovimiento.Controls.Add(this.lblId);
            this.groupBoxMovimiento.Controls.Add(this.lblOt);
            this.groupBoxMovimiento.Controls.Add(this.lblFolio);
            this.groupBoxMovimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMovimiento.Location = new System.Drawing.Point(754, 30);
            this.groupBoxMovimiento.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxMovimiento.Name = "groupBoxMovimiento";
            this.groupBoxMovimiento.Size = new System.Drawing.Size(475, 359);
            this.groupBoxMovimiento.TabIndex = 4;
            this.groupBoxMovimiento.TabStop = false;
            this.groupBoxMovimiento.Text = "Movimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(115, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(317, 28);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 87);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 21);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(115, 183);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(10);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(317, 28);
            this.txtFolio.TabIndex = 3;
            this.txtFolio.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(115, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(317, 28);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // txtOt
            // 
            this.txtOt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOt.Location = new System.Drawing.Point(115, 135);
            this.txtOt.Margin = new System.Windows.Forms.Padding(10);
            this.txtOt.Name = "txtOt";
            this.txtOt.ReadOnly = true;
            this.txtOt.Size = new System.Drawing.Size(317, 28);
            this.txtOt.TabIndex = 2;
            this.txtOt.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(13, 39);
            this.lblId.Margin = new System.Windows.Forms.Padding(10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(13, 135);
            this.lblOt.Margin = new System.Windows.Forms.Padding(10);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(38, 21);
            this.lblOt.TabIndex = 1;
            this.lblOt.Text = "OT:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(13, 183);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(51, 21);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(217, 513);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(724, 28);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(56, 516);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(10, 40, 10, 50);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(112, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtObsSalida
            // 
            this.txtObsSalida.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsSalida.Location = new System.Drawing.Point(174, 226);
            this.txtObsSalida.Margin = new System.Windows.Forms.Padding(10);
            this.txtObsSalida.MaxLength = 256;
            this.txtObsSalida.Name = "txtObsSalida";
            this.txtObsSalida.Size = new System.Drawing.Size(258, 163);
            this.txtObsSalida.TabIndex = 3;
            this.txtObsSalida.Text = "";
            this.txtObsSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(174, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(258, 28);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus);
            this.txtCodigo.Leave += new System.EventHandler(this.cargarDescripcion);
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(174, 145);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(258, 28);
            this.txtCant.TabIndex = 2;
            this.txtCant.Text = "1";
            this.txtCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus);
            // 
            // dataGridViewProdSalientes
            // 
            this.dataGridViewProdSalientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdSalientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdSalientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cod_bodega,
            this.nombre_prod,
            this.cantidad,
            this.fecha_mov,
            this.ot,
            this.obs_mov});
            this.dataGridViewProdSalientes.Location = new System.Drawing.Point(17, 693);
            this.dataGridViewProdSalientes.Name = "dataGridViewProdSalientes";
            this.dataGridViewProdSalientes.ReadOnly = true;
            this.dataGridViewProdSalientes.RowHeadersWidth = 51;
            this.dataGridViewProdSalientes.RowTemplate.Height = 24;
            this.dataGridViewProdSalientes.Size = new System.Drawing.Size(1313, 296);
            this.dataGridViewProdSalientes.TabIndex = 15;
            this.dataGridViewProdSalientes.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(174, 428);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 33);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(483, 64);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 28);
            this.txtIdProd.TabIndex = 17;
            this.txtIdProd.Visible = false;
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 55;
            // 
            // cod_bodega
            // 
            this.cod_bodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_bodega.HeaderText = "Código";
            this.cod_bodega.MinimumWidth = 6;
            this.cod_bodega.Name = "cod_bodega";
            this.cod_bodega.ReadOnly = true;
            this.cod_bodega.Width = 99;
            // 
            // nombre_prod
            // 
            this.nombre_prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_prod.HeaderText = "Descripción";
            this.nombre_prod.MinimumWidth = 6;
            this.nombre_prod.Name = "nombre_prod";
            this.nombre_prod.ReadOnly = true;
            this.nombre_prod.Width = 136;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 113;
            // 
            // fecha_mov
            // 
            this.fecha_mov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_mov.HeaderText = "Fecha";
            this.fecha_mov.MinimumWidth = 6;
            this.fecha_mov.Name = "fecha_mov";
            this.fecha_mov.ReadOnly = true;
            this.fecha_mov.Width = 89;
            // 
            // ot
            // 
            this.ot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ot.HeaderText = "OT";
            this.ot.MinimumWidth = 6;
            this.ot.Name = "ot";
            this.ot.ReadOnly = true;
            this.ot.Width = 59;
            // 
            // obs_mov
            // 
            this.obs_mov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.obs_mov.HeaderText = "Obs";
            this.obs_mov.MinimumWidth = 6;
            this.obs_mov.Name = "obs_mov";
            this.obs_mov.ReadOnly = true;
            this.obs_mov.Width = 71;
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 1033);
            this.Controls.Add(this.groupBoxProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Salida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSalida_Load);
            this.groupBoxProd.ResumeLayout(false);
            this.groupBoxProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.groupBoxMovimiento.ResumeLayout(false);
            this.groupBoxMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.GroupBox groupBoxProd;
        private System.Windows.Forms.RichTextBox txtObsSalida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.GroupBox groupBoxMovimiento;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtOt;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RichTextBox txtObsProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartePlano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.DataGridView dataGridViewProdSalientes;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs_mov;
    }
}