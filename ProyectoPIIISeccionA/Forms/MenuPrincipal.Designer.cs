namespace ProyectoPIIISeccionA
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pb_Min = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_TopLentos = new System.Windows.Forms.Button();
            this.btn_top10rapidos = new System.Windows.Forms.Button();
            this.pb_Top10 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_Clientes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Productos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Pedidos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPMostrar = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Top10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panelSuperior.Controls.Add(this.pb_Min);
            this.panelSuperior.Controls.Add(this.pb_Close);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(900, 24);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarra_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pb_Min
            // 
            this.pb_Min.Image = global::ProyectoPIIISeccionA.Properties.Resources.minimize_1_;
            this.pb_Min.Location = new System.Drawing.Point(853, 4);
            this.pb_Min.Name = "pb_Min";
            this.pb_Min.Size = new System.Drawing.Size(15, 15);
            this.pb_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Min.TabIndex = 12;
            this.pb_Min.TabStop = false;
            this.pb_Min.Click += new System.EventHandler(this.pb_Min_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Image = global::ProyectoPIIISeccionA.Properties.Resources.close_button_1_;
            this.pb_Close.Location = new System.Drawing.Point(872, 4);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(15, 15);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 11;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelMenu.Controls.Add(this.btn_TopLentos);
            this.panelMenu.Controls.Add(this.btn_top10rapidos);
            this.panelMenu.Controls.Add(this.pb_Top10);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.pb_Clientes);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.pb_Productos);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pb_Pedidos);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 71);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_TopLentos
            // 
            this.btn_TopLentos.FlatAppearance.BorderSize = 0;
            this.btn_TopLentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopLentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_TopLentos.Location = new System.Drawing.Point(732, 33);
            this.btn_TopLentos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TopLentos.Name = "btn_TopLentos";
            this.btn_TopLentos.Size = new System.Drawing.Size(136, 23);
            this.btn_TopLentos.TabIndex = 13;
            this.btn_TopLentos.Text = "TOP 10 MAS LENTOS";
            this.btn_TopLentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TopLentos.UseVisualStyleBackColor = true;
            this.btn_TopLentos.Click += new System.EventHandler(this.btn_TopLentos_Click);
            // 
            // btn_top10rapidos
            // 
            this.btn_top10rapidos.FlatAppearance.BorderSize = 0;
            this.btn_top10rapidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_top10rapidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_top10rapidos.Location = new System.Drawing.Point(732, 10);
            this.btn_top10rapidos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_top10rapidos.Name = "btn_top10rapidos";
            this.btn_top10rapidos.Size = new System.Drawing.Size(136, 23);
            this.btn_top10rapidos.TabIndex = 12;
            this.btn_top10rapidos.Text = "TOP 10 MAS RAPIDOS";
            this.btn_top10rapidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_top10rapidos.UseVisualStyleBackColor = true;
            this.btn_top10rapidos.Click += new System.EventHandler(this.btn_top10rapidos_Click);
            // 
            // pb_Top10
            // 
            this.pb_Top10.BackColor = System.Drawing.Color.Transparent;
            this.pb_Top10.Image = global::ProyectoPIIISeccionA.Properties.Resources.top10;
            this.pb_Top10.Location = new System.Drawing.Point(663, 0);
            this.pb_Top10.Name = "pb_Top10";
            this.pb_Top10.Size = new System.Drawing.Size(79, 64);
            this.pb_Top10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Top10.TabIndex = 9;
            this.pb_Top10.TabStop = false;
            this.pb_Top10.Click += new System.EventHandler(this.pb_Top10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(336, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CLIENTES";
            // 
            // pb_Clientes
            // 
            this.pb_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.pb_Clientes.Image = global::ProyectoPIIISeccionA.Properties.Resources.Clientes;
            this.pb_Clientes.Location = new System.Drawing.Point(334, 6);
            this.pb_Clientes.Name = "pb_Clientes";
            this.pb_Clientes.Size = new System.Drawing.Size(59, 46);
            this.pb_Clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Clientes.TabIndex = 7;
            this.pb_Clientes.TabStop = false;
            this.pb_Clientes.Click += new System.EventHandler(this.pb_Clientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(513, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRODUCTOS";
            // 
            // pb_Productos
            // 
            this.pb_Productos.BackColor = System.Drawing.Color.Transparent;
            this.pb_Productos.Image = global::ProyectoPIIISeccionA.Properties.Resources.Productos;
            this.pb_Productos.Location = new System.Drawing.Point(519, 6);
            this.pb_Productos.Name = "pb_Productos";
            this.pb_Productos.Size = new System.Drawing.Size(59, 46);
            this.pb_Productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Productos.TabIndex = 3;
            this.pb_Productos.TabStop = false;
            this.pb_Productos.Click += new System.EventHandler(this.pb_Productos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(174, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDOS";
            // 
            // pb_Pedidos
            // 
            this.pb_Pedidos.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pedidos.Image = global::ProyectoPIIISeccionA.Properties.Resources.Pedidos;
            this.pb_Pedidos.Location = new System.Drawing.Point(172, 6);
            this.pb_Pedidos.Name = "pb_Pedidos";
            this.pb_Pedidos.Size = new System.Drawing.Size(59, 46);
            this.pb_Pedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Pedidos.TabIndex = 1;
            this.pb_Pedidos.TabStop = false;
            this.pb_Pedidos.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPIIISeccionA.Properties.Resources.LogoBG;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPMostrar
            // 
            this.panelPMostrar.AutoScroll = true;
            this.panelPMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelPMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPMostrar.Location = new System.Drawing.Point(0, 95);
            this.panelPMostrar.Name = "panelPMostrar";
            this.panelPMostrar.Size = new System.Drawing.Size(900, 555);
            this.panelPMostrar.TabIndex = 2;
            this.panelPMostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPMostrar_Paint);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelPMostrar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Top10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pb_Min;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Pedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_Clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Productos;
        private System.Windows.Forms.PictureBox pb_Top10;
        public System.Windows.Forms.Panel panelPMostrar;
        public System.Windows.Forms.Button btn_TopLentos;
        public System.Windows.Forms.Button btn_top10rapidos;
    }
}

