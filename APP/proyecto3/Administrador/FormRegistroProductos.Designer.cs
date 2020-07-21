namespace proyecto3.Administrador
{
    partial class FormRegistroProductos
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
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.iconRojo = new FontAwesome.Sharp.IconPictureBox();
            this.iconVerde = new FontAwesome.Sharp.IconPictureBox();
            this.iconAmarrillo = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAmarrillo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.iconCerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconCerrar.IconColor = System.Drawing.Color.DarkRed;
            this.iconCerrar.Location = new System.Drawing.Point(27, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(32, 32);
            this.iconCerrar.TabIndex = 20;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 370);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(107, 36);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(186, 47);
            this.btnNuevoProducto.TabIndex = 22;
            this.btnNuevoProducto.Text = "NUEVO PRODUCTO";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(554, 81);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(126, 29);
            this.btnCategoria.TabIndex = 23;
            this.btnCategoria.Text = "CATEGORIAS";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnMarca
            // 
            this.btnMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Location = new System.Drawing.Point(554, 30);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(126, 29);
            this.btnMarca.TabIndex = 24;
            this.btnMarca.Text = "MARCAS";
            this.btnMarca.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(49, 99);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.Size = new System.Drawing.Size(376, 22);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconRojo
            // 
            this.iconRojo.BackColor = System.Drawing.SystemColors.Control;
            this.iconRojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.iconRojo.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconRojo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.iconRojo.IconSize = 26;
            this.iconRojo.Location = new System.Drawing.Point(133, 62);
            this.iconRojo.Name = "iconRojo";
            this.iconRojo.Size = new System.Drawing.Size(26, 26);
            this.iconRojo.TabIndex = 27;
            this.iconRojo.TabStop = false;
            // 
            // iconVerde
            // 
            this.iconVerde.BackColor = System.Drawing.SystemColors.Control;
            this.iconVerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(251)))), ((int)(((byte)(174)))));
            this.iconVerde.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconVerde.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(251)))), ((int)(((byte)(174)))));
            this.iconVerde.IconSize = 26;
            this.iconVerde.Location = new System.Drawing.Point(133, 11);
            this.iconVerde.Name = "iconVerde";
            this.iconVerde.Size = new System.Drawing.Size(26, 26);
            this.iconVerde.TabIndex = 28;
            this.iconVerde.TabStop = false;
            // 
            // iconAmarrillo
            // 
            this.iconAmarrillo.BackColor = System.Drawing.SystemColors.Control;
            this.iconAmarrillo.ForeColor = System.Drawing.Color.Yellow;
            this.iconAmarrillo.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconAmarrillo.IconColor = System.Drawing.Color.Yellow;
            this.iconAmarrillo.IconSize = 26;
            this.iconAmarrillo.Location = new System.Drawing.Point(133, 36);
            this.iconAmarrillo.Name = "iconAmarrillo";
            this.iconAmarrillo.Size = new System.Drawing.Size(26, 26);
            this.iconAmarrillo.TabIndex = 29;
            this.iconAmarrillo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stock mayor a 30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Stock promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Stock menor a 10";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(27, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 370);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.iconRojo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconVerde);
            this.panel2.Controls.Add(this.iconAmarrillo);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(701, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 100);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.iconCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroProductos";
            this.Text = "FormRegistroProductos";
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAmarrillo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconPictureBox iconRojo;
        private FontAwesome.Sharp.IconPictureBox iconVerde;
        private FontAwesome.Sharp.IconPictureBox iconAmarrillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}