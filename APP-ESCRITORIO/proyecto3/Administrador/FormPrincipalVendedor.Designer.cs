namespace proyecto3
{
    partial class FormPrincipalVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalVendedor));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubProductos = new System.Windows.Forms.Panel();
            this.btnRegistroProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.icoClose = new FontAwesome.Sharp.IconButton();
            this.IcoMin = new FontAwesome.Sharp.IconButton();
            this.panelReporteSalir = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubProductos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelReporteSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Controls.Add(this.panelMenuLateral);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1106, 527);
            this.panelContenedor.TabIndex = 8;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.panelMenuLateral.Controls.Add(this.panelSubProductos);
            this.panelMenuLateral.Controls.Add(this.panelReporteSalir);
            this.panelMenuLateral.Controls.Add(this.btnProductos);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Controls.Add(this.btnConfiguracion);
            this.panelMenuLateral.Controls.Add(this.btnClientes);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(195, 527);
            this.panelMenuLateral.TabIndex = 6;
            this.panelMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuLateral_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 50);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrarSesion.Rotation = 0D;
            this.btnCerrarSesion.Size = new System.Drawing.Size(195, 50);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Text = "   Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseMnemonic = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconSize = 30;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Rotation = 0D;
            this.btnReportes.Size = new System.Drawing.Size(195, 50);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.TabStop = false;
            this.btnReportes.Text = "   Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseMnemonic = false;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubProductos
            // 
            this.panelSubProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.panelSubProductos.Controls.Add(this.btnRegistroProductos);
            this.panelSubProductos.Controls.Add(this.btnInventario);
            this.panelSubProductos.Location = new System.Drawing.Point(1, 254);
            this.panelSubProductos.Name = "panelSubProductos";
            this.panelSubProductos.Size = new System.Drawing.Size(195, 100);
            this.panelSubProductos.TabIndex = 13;
            // 
            // btnRegistroProductos
            // 
            this.btnRegistroProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnRegistroProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroProductos.FlatAppearance.BorderSize = 0;
            this.btnRegistroProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistroProductos.Location = new System.Drawing.Point(0, 50);
            this.btnRegistroProductos.Name = "btnRegistroProductos";
            this.btnRegistroProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistroProductos.Size = new System.Drawing.Size(195, 50);
            this.btnRegistroProductos.TabIndex = 2;
            this.btnRegistroProductos.TabStop = false;
            this.btnRegistroProductos.Text = "Administración \r\n Productos ";
            this.btnRegistroProductos.UseMnemonic = false;
            this.btnRegistroProductos.UseVisualStyleBackColor = false;
            this.btnRegistroProductos.Click += new System.EventHandler(this.btnRegistroProductos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(195, 50);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.TabStop = false;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseMnemonic = false;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconSize = 30;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(1, 199);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductos.Rotation = 0D;
            this.btnProductos.Size = new System.Drawing.Size(195, 50);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.TabStop = false;
            this.btnProductos.Text = "   Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseMnemonic = false;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconSize = 30;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(1, 143);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(195, 50);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = "   Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseMnemonic = false;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Black;
            this.btnConfiguracion.IconSize = 30;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(1, 87);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfiguracion.Rotation = 0D;
            this.btnConfiguracion.Size = new System.Drawing.Size(195, 50);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.TabStop = false;
            this.btnConfiguracion.Text = "   Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseMnemonic = false;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(195, 84);
            this.panelLogo.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(67, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(90, 70);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 1;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelFormularios.Location = new System.Drawing.Point(195, 44);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(911, 483);
            this.panelFormularios.TabIndex = 7;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTitulo.Controls.Add(this.icoClose);
            this.panelTitulo.Controls.Add(this.btnMenu);
            this.panelTitulo.Controls.Add(this.btnMax);
            this.panelTitulo.Controls.Add(this.btnMin);
            this.panelTitulo.Controls.Add(this.IcoMin);
            this.panelTitulo.Controls.Add(this.pictureBox4);
            this.panelTitulo.Controls.Add(this.btnRestaurar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(195, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(911, 44);
            this.panelTitulo.TabIndex = 10;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMenu.IconSize = 33;
            this.btnMenu.Location = new System.Drawing.Point(5, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(46, 42);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = global::proyecto3.Properties.Resources.browser_10_icon_icons_com_63862;
            this.btnMax.Location = new System.Drawing.Point(592, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 20);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 13;
            this.btnMax.TabStop = false;
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(648, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 10;
            this.btnMin.TabStop = false;
            this.btnMin.Visible = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(676, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::proyecto3.Properties.Resources.browser_24_icon_icons_com_63876;
            this.btnRestaurar.Location = new System.Drawing.Point(620, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // icoClose
            // 
            this.icoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoClose.FlatAppearance.BorderSize = 0;
            this.icoClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.icoClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icoClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.icoClose.IconSize = 22;
            this.icoClose.Location = new System.Drawing.Point(871, 7);
            this.icoClose.Name = "icoClose";
            this.icoClose.Rotation = 0D;
            this.icoClose.Size = new System.Drawing.Size(25, 28);
            this.icoClose.TabIndex = 18;
            this.icoClose.TabStop = false;
            this.icoClose.UseVisualStyleBackColor = true;
            this.icoClose.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // IcoMin
            // 
            this.IcoMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IcoMin.FlatAppearance.BorderSize = 0;
            this.IcoMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcoMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IcoMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.IcoMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IcoMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.IcoMin.IconSize = 20;
            this.IcoMin.Location = new System.Drawing.Point(844, 8);
            this.IcoMin.Name = "IcoMin";
            this.IcoMin.Rotation = 0D;
            this.IcoMin.Size = new System.Drawing.Size(24, 28);
            this.IcoMin.TabIndex = 15;
            this.IcoMin.TabStop = false;
            this.IcoMin.UseVisualStyleBackColor = true;
            this.IcoMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelReporteSalir
            // 
            this.panelReporteSalir.Controls.Add(this.btnReportes);
            this.panelReporteSalir.Controls.Add(this.btnCerrarSesion);
            this.panelReporteSalir.Location = new System.Drawing.Point(1, 359);
            this.panelReporteSalir.Name = "panelReporteSalir";
            this.panelReporteSalir.Size = new System.Drawing.Size(195, 100);
            this.panelReporteSalir.TabIndex = 14;
            // 
            // FormPrincipalVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 527);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1106, 400);
            this.Name = "FormPrincipalVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuDesplegable";
            this.Load += new System.EventHandler(this.FormPrincipalVendedor_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubProductos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelReporteSalir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnInicio;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelSubProductos;
        private System.Windows.Forms.Button btnRegistroProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton icoClose;
        private FontAwesome.Sharp.IconButton IcoMin;
        private System.Windows.Forms.Panel panelReporteSalir;
    }
}