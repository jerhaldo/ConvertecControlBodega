
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblOt = new System.Windows.Forms.Label();
            this.tplHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblFolioValue = new System.Windows.Forms.Label();
            this.lblOtValue = new System.Windows.Forms.Label();
            this.lblNombreValue = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewProdSalientes = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelParametrosSalida = new System.Windows.Forms.Panel();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.btnConfimar = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtObsSalida = new System.Windows.Forms.RichTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panelDescProducto = new System.Windows.Forms.Panel();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.panelDescProdR = new System.Windows.Forms.Panel();
            this.lblPartePlano = new System.Windows.Forms.Label();
            this.lblPar = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelDescProdL = new System.Windows.Forms.Panel();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tplHeader.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).BeginInit();
            this.panelParametrosSalida.SuspendLayout();
            this.groupBoxParametros.SuspendLayout();
            this.panelDescProducto.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            this.panelDescProdR.SuspendLayout();
            this.panelDescProdL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(282, 20);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(52, 21);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(86, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(15, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblOt
            // 
            this.lblOt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(207, 20);
            this.lblOt.Margin = new System.Windows.Forms.Padding(10);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(35, 21);
            this.lblOt.TabIndex = 0;
            this.lblOt.Text = "OT:";
            // 
            // tplHeader
            // 
            this.tplHeader.AutoSize = true;
            this.tplHeader.BackColor = System.Drawing.Color.White;
            this.tplHeader.ColumnCount = 9;
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1555F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplHeader.Controls.Add(this.lblIdValue, 1, 0);
            this.tplHeader.Controls.Add(this.lblFolioValue, 7, 0);
            this.tplHeader.Controls.Add(this.lblId, 0, 0);
            this.tplHeader.Controls.Add(this.lblFolio, 6, 0);
            this.tplHeader.Controls.Add(this.lblNombre, 2, 0);
            this.tplHeader.Controls.Add(this.lblOtValue, 5, 0);
            this.tplHeader.Controls.Add(this.lblNombreValue, 3, 0);
            this.tplHeader.Controls.Add(this.lblOt, 4, 0);
            this.tplHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplHeader.Location = new System.Drawing.Point(5, 5);
            this.tplHeader.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tplHeader.Name = "tplHeader";
            this.tplHeader.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tplHeader.RowCount = 1;
            this.tplHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplHeader.Size = new System.Drawing.Size(1563, 61);
            this.tplHeader.TabIndex = 9;
            // 
            // lblIdValue
            // 
            this.lblIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(66, 20);
            this.lblIdValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(1, 21);
            this.lblIdValue.TabIndex = 10;
            // 
            // lblFolioValue
            // 
            this.lblFolioValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolioValue.AutoSize = true;
            this.lblFolioValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioValue.Location = new System.Drawing.Point(355, 20);
            this.lblFolioValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblFolioValue.Name = "lblFolioValue";
            this.lblFolioValue.Size = new System.Drawing.Size(0, 21);
            this.lblFolioValue.TabIndex = 0;
            // 
            // lblOtValue
            // 
            this.lblOtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtValue.AutoSize = true;
            this.lblOtValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtValue.Location = new System.Drawing.Point(262, 20);
            this.lblOtValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblOtValue.Name = "lblOtValue";
            this.lblOtValue.Size = new System.Drawing.Size(1, 21);
            this.lblOtValue.TabIndex = 0;
            // 
            // lblNombreValue
            // 
            this.lblNombreValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreValue.AutoSize = true;
            this.lblNombreValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValue.Location = new System.Drawing.Point(187, 20);
            this.lblNombreValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombreValue.Name = "lblNombreValue";
            this.lblNombreValue.Size = new System.Drawing.Size(1, 21);
            this.lblNombreValue.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.tplHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(5);
            this.panelHeader.Size = new System.Drawing.Size(1573, 71);
            this.panelHeader.TabIndex = 5;
            // 
            // panelTabla
            // 
            this.panelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabla.Controls.Add(this.dataGridViewProdSalientes);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTabla.Location = new System.Drawing.Point(5, 415);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Padding = new System.Windows.Forms.Padding(2);
            this.panelTabla.Size = new System.Drawing.Size(1563, 564);
            this.panelTabla.TabIndex = 19;
            // 
            // dataGridViewProdSalientes
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewProdSalientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProdSalientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProdSalientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdSalientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProdSalientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdSalientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cod_bodega,
            this.nombre_prod,
            this.cantidad,
            this.fecha_mov,
            this.obs_mov});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdSalientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProdSalientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdSalientes.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewProdSalientes.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewProdSalientes.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridViewProdSalientes.Name = "dataGridViewProdSalientes";
            this.dataGridViewProdSalientes.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdSalientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProdSalientes.RowHeadersVisible = false;
            this.dataGridViewProdSalientes.RowHeadersWidth = 51;
            this.dataGridViewProdSalientes.RowTemplate.Height = 40;
            this.dataGridViewProdSalientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdSalientes.Size = new System.Drawing.Size(1557, 558);
            this.dataGridViewProdSalientes.TabIndex = 16;
            this.dataGridViewProdSalientes.TabStop = false;
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 125;
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
            this.nombre_prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_prod.HeaderText = "Descripción";
            this.nombre_prod.MinimumWidth = 6;
            this.nombre_prod.Name = "nombre_prod";
            this.nombre_prod.ReadOnly = true;
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
            // obs_mov
            // 
            this.obs_mov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obs_mov.HeaderText = "Obs";
            this.obs_mov.MinimumWidth = 6;
            this.obs_mov.Name = "obs_mov";
            this.obs_mov.ReadOnly = true;
            // 
            // panelParametrosSalida
            // 
            this.panelParametrosSalida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelParametrosSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParametrosSalida.Controls.Add(this.groupBoxParametros);
            this.panelParametrosSalida.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelParametrosSalida.Location = new System.Drawing.Point(5, 5);
            this.panelParametrosSalida.Margin = new System.Windows.Forms.Padding(0);
            this.panelParametrosSalida.Name = "panelParametrosSalida";
            this.panelParametrosSalida.Size = new System.Drawing.Size(368, 410);
            this.panelParametrosSalida.TabIndex = 1;
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.groupBoxParametros.Controls.Add(this.btnAgregar);
            this.groupBoxParametros.Controls.Add(this.lblUnidad);
            this.groupBoxParametros.Controls.Add(this.btnConfimar);
            this.groupBoxParametros.Controls.Add(this.lblObs);
            this.groupBoxParametros.Controls.Add(this.txtCant);
            this.groupBoxParametros.Controls.Add(this.lblCant);
            this.groupBoxParametros.Controls.Add(this.txtObsSalida);
            this.groupBoxParametros.Controls.Add(this.txtCodigo);
            this.groupBoxParametros.Controls.Add(this.lblCodigo);
            this.groupBoxParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxParametros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParametros.Location = new System.Drawing.Point(0, 0);
            this.groupBoxParametros.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxParametros.Size = new System.Drawing.Size(366, 408);
            this.groupBoxParametros.TabIndex = 0;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parametros de Salida";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(212)))), ((int)(((byte)(22)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(15, 295);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 45);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.btnAgregar.Enter += new System.EventHandler(this.CargarDescripcion);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(259, 88);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(5);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 19);
            this.lblUnidad.TabIndex = 18;
            // 
            // btnConfimar
            // 
            this.btnConfimar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfimar.Location = new System.Drawing.Point(199, 1349);
            this.btnConfimar.Name = "btnConfimar";
            this.btnConfimar.Size = new System.Drawing.Size(122, 31);
            this.btnConfimar.TabIndex = 4;
            this.btnConfimar.Text = "Confirmar";
            this.btnConfimar.UseVisualStyleBackColor = true;
            this.btnConfimar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(15, 132);
            this.lblObs.Margin = new System.Windows.Forms.Padding(10);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(139, 19);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Observaciones:";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(150, 82);
            this.txtCant.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtCant.MaxLength = 10;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(97, 28);
            this.txtCant.TabIndex = 1;
            this.txtCant.Text = "1";
            this.txtCant.Enter += new System.EventHandler(this.CargarDescripcion);
            this.txtCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocus);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckUnidad);
            this.txtCant.Leave += new System.EventHandler(this.CheckDecimalCantidad);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(15, 91);
            this.lblCant.Margin = new System.Windows.Forms.Padding(10);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(89, 19);
            this.lblCant.TabIndex = 1;
            this.lblCant.Text = "Cantidad:";
            // 
            // txtObsSalida
            // 
            this.txtObsSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsSalida.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsSalida.Location = new System.Drawing.Point(15, 173);
            this.txtObsSalida.Margin = new System.Windows.Forms.Padding(10);
            this.txtObsSalida.MaxLength = 256;
            this.txtObsSalida.Name = "txtObsSalida";
            this.txtObsSalida.Size = new System.Drawing.Size(329, 109);
            this.txtObsSalida.TabIndex = 2;
            this.txtObsSalida.Text = "";
            this.txtObsSalida.Enter += new System.EventHandler(this.CargarDescripcion);
            this.txtObsSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocus);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(150, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 28);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocus);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 50);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // panelDescProducto
            // 
            this.panelDescProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDescProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescProducto.Controls.Add(this.groupBoxProducto);
            this.panelDescProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescProducto.Location = new System.Drawing.Point(373, 5);
            this.panelDescProducto.Margin = new System.Windows.Forms.Padding(0);
            this.panelDescProducto.Name = "panelDescProducto";
            this.panelDescProducto.Size = new System.Drawing.Size(1195, 410);
            this.panelDescProducto.TabIndex = 2;
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.groupBoxProducto.Controls.Add(this.panelDescProdR);
            this.groupBoxProducto.Controls.Add(this.panelDescProdL);
            this.groupBoxProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProducto.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(1193, 408);
            this.groupBoxProducto.TabIndex = 4;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Descripción Producto";
            // 
            // panelDescProdR
            // 
            this.panelDescProdR.Controls.Add(this.lblPartePlano);
            this.panelDescProdR.Controls.Add(this.lblPar);
            this.panelDescProdR.Controls.Add(this.lblStock);
            this.panelDescProdR.Controls.Add(this.label1);
            this.panelDescProdR.Controls.Add(this.lblDes);
            this.panelDescProdR.Controls.Add(this.lblDescripcion);
            this.panelDescProdR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescProdR.Location = new System.Drawing.Point(693, 24);
            this.panelDescProdR.Name = "panelDescProdR";
            this.panelDescProdR.Size = new System.Drawing.Size(497, 381);
            this.panelDescProdR.TabIndex = 22;
            // 
            // lblPartePlano
            // 
            this.lblPartePlano.AutoSize = true;
            this.lblPartePlano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartePlano.Location = new System.Drawing.Point(142, 210);
            this.lblPartePlano.Margin = new System.Windows.Forms.Padding(10);
            this.lblPartePlano.Name = "lblPartePlano";
            this.lblPartePlano.Size = new System.Drawing.Size(0, 21);
            this.lblPartePlano.TabIndex = 12;
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.Location = new System.Drawing.Point(10, 211);
            this.lblPar.Margin = new System.Windows.Forms.Padding(10);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(106, 19);
            this.lblPar.TabIndex = 10;
            this.lblPar.Text = "Parte Plano:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(89, 248);
            this.lblStock.Margin = new System.Windows.Forms.Padding(10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 21);
            this.lblStock.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stock:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(10, 149);
            this.lblDes.Margin = new System.Windows.Forms.Padding(10);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(112, 19);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Descripción:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(142, 148);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(10);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(583, 42);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "TRANSDUCTOR DE TENSIÓN AC (tres fases) WB3U414U01 (Input AC 0-500Vac, Output 4-20" +
    "mA, Power +24Vdc)";
            // 
            // panelDescProdL
            // 
            this.panelDescProdL.Controls.Add(this.pictureBoxProducto);
            this.panelDescProdL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDescProdL.Location = new System.Drawing.Point(3, 24);
            this.panelDescProdL.Margin = new System.Windows.Forms.Padding(0);
            this.panelDescProdL.Name = "panelDescProdL";
            this.panelDescProdL.Padding = new System.Windows.Forms.Padding(10);
            this.panelDescProdL.Size = new System.Drawing.Size(690, 381);
            this.panelDescProdL.TabIndex = 21;
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.BackColor = System.Drawing.Color.White;
            this.pictureBoxProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProducto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProducto.Image")));
            this.pictureBoxProducto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProducto.InitialImage")));
            this.pictureBoxProducto.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxProducto.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(670, 361);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducto.TabIndex = 14;
            this.pictureBoxProducto.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelDescProducto);
            this.panelBody.Controls.Add(this.panelParametrosSalida);
            this.panelBody.Controls.Add(this.panelTabla);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 71);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(5);
            this.panelBody.Size = new System.Drawing.Size(1573, 984);
            this.panelBody.TabIndex = 6;
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 1055);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Salida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSalida_FormClosed);
            this.Load += new System.EventHandler(this.FormSalida_Load);
            this.tplHeader.ResumeLayout(false);
            this.tplHeader.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).EndInit();
            this.panelParametrosSalida.ResumeLayout(false);
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxParametros.PerformLayout();
            this.panelDescProducto.ResumeLayout(false);
            this.groupBoxProducto.ResumeLayout(false);
            this.panelDescProdR.ResumeLayout(false);
            this.panelDescProdR.PerformLayout();
            this.panelDescProdL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreValue;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblFolioValue;
        private System.Windows.Forms.TableLayoutPanel tplHeader;
        private System.Windows.Forms.Label lblOtValue;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dataGridViewProdSalientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs_mov;
        private System.Windows.Forms.Panel panelParametrosSalida;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Button btnConfimar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.RichTextBox txtObsSalida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panelDescProducto;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPartePlano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelDescProdR;
        private System.Windows.Forms.Panel panelDescProdL;
    }
}