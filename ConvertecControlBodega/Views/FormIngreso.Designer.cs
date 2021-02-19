
namespace ConvertecControlBodega.Views
{
    partial class FormIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtObsSalida = new System.Windows.Forms.RichTextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblPar = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblOt = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tplHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblFolioValue = new System.Windows.Forms.Label();
            this.lblNombreValue = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tblFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.btnConfimar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPartePlano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.tplDescripcion = new System.Windows.Forms.TableLayoutPanel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dataGridViewProdSalientes = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtOt = new System.Windows.Forms.TextBox();
            this.groupBoxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tplHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblFormulario.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tplDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 48);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(13, 89);
            this.lblCant.Margin = new System.Windows.Forms.Padding(10);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(89, 19);
            this.lblCant.TabIndex = 1;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(13, 130);
            this.lblObs.Margin = new System.Windows.Forms.Padding(10);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(139, 19);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Observaciones:";
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxParametros.Controls.Add(this.lblIdValue);
            this.groupBoxParametros.Controls.Add(this.btn_agregar);
            this.groupBoxParametros.Controls.Add(this.lblObs);
            this.groupBoxParametros.Controls.Add(this.txtCant);
            this.groupBoxParametros.Controls.Add(this.lblCant);
            this.groupBoxParametros.Controls.Add(this.txtObsSalida);
            this.groupBoxParametros.Controls.Add(this.txtIdProd);
            this.groupBoxParametros.Controls.Add(this.txtCodigo);
            this.groupBoxParametros.Controls.Add(this.lblCodigo);
            this.groupBoxParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxParametros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParametros.Location = new System.Drawing.Point(8, 8);
            this.groupBoxParametros.Margin = new System.Windows.Forms.Padding(8);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(332, 352);
            this.groupBoxParametros.TabIndex = 0;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parametros de Salida";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Location = new System.Drawing.Point(223, 300);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(10);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(96, 32);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(150, 82);
            this.txtCant.Margin = new System.Windows.Forms.Padding(10);
            this.txtCant.MaxLength = 10;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(169, 28);
            this.txtCant.TabIndex = 2;
            this.txtCant.Text = "1";
            // 
            // txtObsSalida
            // 
            this.txtObsSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsSalida.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsSalida.Location = new System.Drawing.Point(13, 171);
            this.txtObsSalida.Margin = new System.Windows.Forms.Padding(10);
            this.txtObsSalida.MaxLength = 256;
            this.txtObsSalida.Name = "txtObsSalida";
            this.txtObsSalida.Size = new System.Drawing.Size(306, 109);
            this.txtObsSalida.TabIndex = 3;
            this.txtObsSalida.Text = "";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(329, 41);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(10);
            this.txtIdProd.MaxLength = 10;
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(15, 28);
            this.txtIdProd.TabIndex = 17;
            this.txtIdProd.TabStop = false;
            this.txtIdProd.Visible = false;
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
            this.txtCodigo.Size = new System.Drawing.Size(169, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProducto.Image")));
            this.pictureBoxProducto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProducto.InitialImage")));
            this.pictureBoxProducto.Location = new System.Drawing.Point(13, 32);
            this.pictureBoxProducto.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxProducto.MaximumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxProducto.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducto.TabIndex = 14;
            this.pictureBoxProducto.TabStop = false;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(23, 3);
            this.lblDes.Margin = new System.Windows.Forms.Padding(3);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(112, 19);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Descripción:";
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.Location = new System.Drawing.Point(23, 50);
            this.lblPar.Margin = new System.Windows.Forms.Padding(3);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(106, 19);
            this.lblPar.TabIndex = 10;
            this.lblPar.Text = "Parte Plano:";
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(1296, 10);
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
            this.lblNombre.Location = new System.Drawing.Point(786, 10);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblOt
            // 
            this.lblOt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(10, 10);
            this.lblOt.Margin = new System.Windows.Forms.Padding(10);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(174, 21);
            this.lblOt.TabIndex = 0;
            this.lblOt.Text = "OT:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.tplHeader);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(25);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1307, 1055);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // tplHeader
            // 
            this.tplHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tplHeader.AutoSize = true;
            this.tplHeader.ColumnCount = 9;
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tplHeader.Controls.Add(this.lblFolioValue, 7, 0);
            this.tplHeader.Controls.Add(this.lblId, 2, 0);
            this.tplHeader.Controls.Add(this.lblFolio, 6, 0);
            this.tplHeader.Controls.Add(this.lblOt, 0, 0);
            this.tplHeader.Controls.Add(this.lblNombreValue, 5, 0);
            this.tplHeader.Controls.Add(this.lblNombre, 4, 0);
            this.tplHeader.Controls.Add(this.txtOt, 1, 0);
            this.tplHeader.Location = new System.Drawing.Point(18, 13);
            this.tplHeader.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tplHeader.Name = "tplHeader";
            this.tplHeader.RowCount = 1;
            this.tplHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplHeader.Size = new System.Drawing.Size(1754, 41);
            this.tplHeader.TabIndex = 9;
            // 
            // lblFolioValue
            // 
            this.lblFolioValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolioValue.AutoSize = true;
            this.lblFolioValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioValue.Location = new System.Drawing.Point(1542, 10);
            this.lblFolioValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblFolioValue.Name = "lblFolioValue";
            this.lblFolioValue.Size = new System.Drawing.Size(0, 21);
            this.lblFolioValue.TabIndex = 0;
            // 
            // lblNombreValue
            // 
            this.lblNombreValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreValue.AutoSize = true;
            this.lblNombreValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValue.Location = new System.Drawing.Point(980, 10);
            this.lblNombreValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombreValue.Name = "lblNombreValue";
            this.lblNombreValue.Size = new System.Drawing.Size(174, 21);
            this.lblNombreValue.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tblFormulario);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewProdSalientes);
            this.splitContainer2.Size = new System.Drawing.Size(1305, 978);
            this.splitContainer2.SplitterDistance = 368;
            this.splitContainer2.TabIndex = 17;
            this.splitContainer2.TabStop = false;
            // 
            // tblFormulario
            // 
            this.tblFormulario.ColumnCount = 2;
            this.tblFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tblFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormulario.Controls.Add(this.groupBoxParametros, 0, 0);
            this.tblFormulario.Controls.Add(this.groupBoxProducto, 1, 0);
            this.tblFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormulario.Location = new System.Drawing.Point(0, 0);
            this.tblFormulario.Name = "tblFormulario";
            this.tblFormulario.RowCount = 1;
            this.tblFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormulario.Size = new System.Drawing.Size(1305, 368);
            this.tblFormulario.TabIndex = 0;
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxProducto.Controls.Add(this.btnConfimar);
            this.groupBoxProducto.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxProducto.Controls.Add(this.tplDescripcion);
            this.groupBoxProducto.Controls.Add(this.pictureBoxProducto);
            this.groupBoxProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProducto.Location = new System.Drawing.Point(356, 8);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(8);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(941, 352);
            this.groupBoxProducto.TabIndex = 4;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Descripción Producto";
            // 
            // btnConfimar
            // 
            this.btnConfimar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfimar.Location = new System.Drawing.Point(333, 301);
            this.btnConfimar.Name = "btnConfimar";
            this.btnConfimar.Size = new System.Drawing.Size(101, 31);
            this.btnConfimar.TabIndex = 5;
            this.btnConfimar.Text = "Confirmar";
            this.btnConfimar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblDes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPartePlano, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStock, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(333, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 141);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(141, 3);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 21);
            this.lblDescripcion.TabIndex = 11;
            // 
            // lblPartePlano
            // 
            this.lblPartePlano.AutoSize = true;
            this.lblPartePlano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartePlano.Location = new System.Drawing.Point(141, 50);
            this.lblPartePlano.Margin = new System.Windows.Forms.Padding(3);
            this.lblPartePlano.Name = "lblPartePlano";
            this.lblPartePlano.Size = new System.Drawing.Size(0, 21);
            this.lblPartePlano.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stock:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(141, 97);
            this.lblStock.Margin = new System.Windows.Forms.Padding(3);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 21);
            this.lblStock.TabIndex = 14;
            // 
            // tplDescripcion
            // 
            this.tplDescripcion.ColumnCount = 6;
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tplDescripcion.Controls.Add(this.lblProveedor, 2, 0);
            this.tplDescripcion.Controls.Add(this.lblMar, 3, 0);
            this.tplDescripcion.Controls.Add(this.lblPro, 1, 0);
            this.tplDescripcion.Controls.Add(this.lblMarca, 4, 0);
            this.tplDescripcion.Location = new System.Drawing.Point(333, 202);
            this.tplDescripcion.Margin = new System.Windows.Forms.Padding(10);
            this.tplDescripcion.Name = "tplDescripcion";
            this.tplDescripcion.RowCount = 1;
            this.tplDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplDescripcion.Size = new System.Drawing.Size(595, 62);
            this.tplDescripcion.TabIndex = 19;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(140, 3);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(3);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(0, 21);
            this.lblProveedor.TabIndex = 13;
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMar.Location = new System.Drawing.Point(146, 3);
            this.lblMar.Margin = new System.Windows.Forms.Padding(3);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(67, 19);
            this.lblMar.TabIndex = 6;
            this.lblMar.Text = "Marca:";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.Location = new System.Drawing.Point(23, 3);
            this.lblPro.Margin = new System.Windows.Forms.Padding(3);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(99, 19);
            this.lblPro.TabIndex = 8;
            this.lblPro.Text = "Proveedor:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(219, 3);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(3);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 21);
            this.lblMarca.TabIndex = 14;
            // 
            // dataGridViewProdSalientes
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewProdSalientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdSalientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProdSalientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdSalientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProdSalientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdSalientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cod_bodega,
            this.nombre_prod,
            this.cantidad,
            this.fecha_mov,
            this.obs_mov});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdSalientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProdSalientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdSalientes.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewProdSalientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProdSalientes.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridViewProdSalientes.Name = "dataGridViewProdSalientes";
            this.dataGridViewProdSalientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdSalientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProdSalientes.RowHeadersVisible = false;
            this.dataGridViewProdSalientes.RowHeadersWidth = 51;
            this.dataGridViewProdSalientes.RowTemplate.Height = 40;
            this.dataGridViewProdSalientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdSalientes.Size = new System.Drawing.Size(1305, 606);
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
            // lblIdValue
            // 
            this.lblIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(286, 132);
            this.lblIdValue.Margin = new System.Windows.Forms.Padding(10);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(0, 21);
            this.lblIdValue.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(398, 10);
            this.lblId.Margin = new System.Windows.Forms.Padding(10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(174, 21);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID:";
            // 
            // txtOt
            // 
            this.txtOt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOt.Location = new System.Drawing.Point(197, 3);
            this.txtOt.Name = "txtOt";
            this.txtOt.Size = new System.Drawing.Size(188, 22);
            this.txtOt.TabIndex = 0;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Ingreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tplHeader.ResumeLayout(false);
            this.tplHeader.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblFormulario.ResumeLayout(false);
            this.groupBoxProducto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tplDescripcion.ResumeLayout(false);
            this.tplDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSalientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.RichTextBox txtObsSalida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblNombreValue;
        private System.Windows.Forms.Label lblFolioValue;
        private System.Windows.Forms.TableLayoutPanel tplHeader;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.TableLayoutPanel tplDescripcion;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewProdSalientes;
        private System.Windows.Forms.TableLayoutPanel tblFormulario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPartePlano;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnConfimar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs_mov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtOt;
    }
}