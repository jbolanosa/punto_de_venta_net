namespace ProyectoPIIISeccionA.Forms
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrarForm = new System.Windows.Forms.PictureBox();
            this.tbpAdministrarOrden = new System.Windows.Forms.TabControl();
            this.tbpGenerarOrden = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxUbicacion = new System.Windows.Forms.ComboBox();
            this.cboxCamarero = new System.Windows.Forms.ComboBox();
            this.txtNumOrden = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpBebidas = new System.Windows.Forms.TabPage();
            this.btnBebida4 = new System.Windows.Forms.Button();
            this.btnBebida3 = new System.Windows.Forms.Button();
            this.btnBebida2 = new System.Windows.Forms.Button();
            this.btnBebida1 = new System.Windows.Forms.Button();
            this.tbpComidas = new System.Windows.Forms.TabPage();
            this.btnComida4 = new System.Windows.Forms.Button();
            this.btnComida3 = new System.Windows.Forms.Button();
            this.btnComida2 = new System.Windows.Forms.Button();
            this.btnComida1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbpCompletarOrden = new System.Windows.Forms.TabPage();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.txtMostrarNumOrden = new System.Windows.Forms.TextBox();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).BeginInit();
            this.tbpAdministrarOrden.SuspendLayout();
            this.tbpGenerarOrden.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpBebidas.SuspendLayout();
            this.tbpComidas.SuspendLayout();
            this.tbpCompletarOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDOS:";
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarForm.Image")));
            this.BtnCerrarForm.Location = new System.Drawing.Point(873, 11);
            this.BtnCerrarForm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCerrarForm.TabIndex = 8;
            this.BtnCerrarForm.TabStop = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // tbpAdministrarOrden
            // 
            this.tbpAdministrarOrden.Controls.Add(this.tbpGenerarOrden);
            this.tbpAdministrarOrden.Controls.Add(this.tbpCompletarOrden);
            this.tbpAdministrarOrden.Location = new System.Drawing.Point(13, 43);
            this.tbpAdministrarOrden.Name = "tbpAdministrarOrden";
            this.tbpAdministrarOrden.SelectedIndex = 0;
            this.tbpAdministrarOrden.Size = new System.Drawing.Size(875, 500);
            this.tbpAdministrarOrden.TabIndex = 9;
            // 
            // tbpGenerarOrden
            // 
            this.tbpGenerarOrden.Controls.Add(this.label3);
            this.tbpGenerarOrden.Controls.Add(this.cboxUbicacion);
            this.tbpGenerarOrden.Controls.Add(this.cboxCamarero);
            this.tbpGenerarOrden.Controls.Add(this.txtNumOrden);
            this.tbpGenerarOrden.Controls.Add(this.lblTotal);
            this.tbpGenerarOrden.Controls.Add(this.txtTotal);
            this.tbpGenerarOrden.Controls.Add(this.txtPedido);
            this.tbpGenerarOrden.Controls.Add(this.tabControl1);
            this.tbpGenerarOrden.Controls.Add(this.btnAgregar);
            this.tbpGenerarOrden.Location = new System.Drawing.Point(4, 22);
            this.tbpGenerarOrden.Name = "tbpGenerarOrden";
            this.tbpGenerarOrden.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenerarOrden.Size = new System.Drawing.Size(867, 474);
            this.tbpGenerarOrden.TabIndex = 0;
            this.tbpGenerarOrden.Text = "Generar Orden";
            this.tbpGenerarOrden.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero de orden";
            // 
            // cboxUbicacion
            // 
            this.cboxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUbicacion.FormattingEnabled = true;
            this.cboxUbicacion.Items.AddRange(new object[] {
            "Autoservicio",
            "Mesa A1",
            "Mesa A2",
            "Mesa A3",
            "Mesa A4",
            "Mesa A5"});
            this.cboxUbicacion.Location = new System.Drawing.Point(17, 103);
            this.cboxUbicacion.Name = "cboxUbicacion";
            this.cboxUbicacion.Size = new System.Drawing.Size(139, 21);
            this.cboxUbicacion.TabIndex = 8;
            // 
            // cboxCamarero
            // 
            this.cboxCamarero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCamarero.FormattingEnabled = true;
            this.cboxCamarero.Items.AddRange(new object[] {
            "Pedro Antonio",
            "Marelyn Guzman",
            "Bernardo Torres",
            "Pablo Andres"});
            this.cboxCamarero.Location = new System.Drawing.Point(17, 70);
            this.cboxCamarero.Name = "cboxCamarero";
            this.cboxCamarero.Size = new System.Drawing.Size(139, 21);
            this.cboxCamarero.TabIndex = 7;
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Location = new System.Drawing.Point(17, 44);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(139, 20);
            this.txtNumOrden.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(57, 429);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(139, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtPedido
            // 
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(17, 130);
            this.txtPedido.Multiline = true;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(263, 293);
            this.txtPedido.TabIndex = 3;
            this.txtPedido.TextChanged += new System.EventHandler(this.txtPedido_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpBebidas);
            this.tabControl1.Controls.Add(this.tbpComidas);
            this.tabControl1.Location = new System.Drawing.Point(344, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 133);
            this.tabControl1.TabIndex = 2;
            // 
            // tbpBebidas
            // 
            this.tbpBebidas.Controls.Add(this.btnBebida4);
            this.tbpBebidas.Controls.Add(this.btnBebida3);
            this.tbpBebidas.Controls.Add(this.btnBebida2);
            this.tbpBebidas.Controls.Add(this.btnBebida1);
            this.tbpBebidas.Location = new System.Drawing.Point(4, 22);
            this.tbpBebidas.Name = "tbpBebidas";
            this.tbpBebidas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBebidas.Size = new System.Drawing.Size(471, 107);
            this.tbpBebidas.TabIndex = 0;
            this.tbpBebidas.Text = "Bebidas";
            this.tbpBebidas.UseVisualStyleBackColor = true;
            // 
            // btnBebida4
            // 
            this.btnBebida4.Location = new System.Drawing.Point(352, 6);
            this.btnBebida4.Name = "btnBebida4";
            this.btnBebida4.Size = new System.Drawing.Size(110, 90);
            this.btnBebida4.TabIndex = 7;
            this.btnBebida4.Text = "SPRITE";
            this.btnBebida4.UseVisualStyleBackColor = true;
            this.btnBebida4.Click += new System.EventHandler(this.btnBebida4_Click);
            // 
            // btnBebida3
            // 
            this.btnBebida3.Location = new System.Drawing.Point(236, 6);
            this.btnBebida3.Name = "btnBebida3";
            this.btnBebida3.Size = new System.Drawing.Size(110, 90);
            this.btnBebida3.TabIndex = 6;
            this.btnBebida3.Text = "PEPSI";
            this.btnBebida3.UseVisualStyleBackColor = true;
            this.btnBebida3.Click += new System.EventHandler(this.btnBebida3_Click);
            // 
            // btnBebida2
            // 
            this.btnBebida2.Location = new System.Drawing.Point(120, 6);
            this.btnBebida2.Name = "btnBebida2";
            this.btnBebida2.Size = new System.Drawing.Size(110, 90);
            this.btnBebida2.TabIndex = 5;
            this.btnBebida2.Text = "FANTA";
            this.btnBebida2.UseVisualStyleBackColor = true;
            this.btnBebida2.Click += new System.EventHandler(this.btnBebida2_Click);
            // 
            // btnBebida1
            // 
            this.btnBebida1.Location = new System.Drawing.Point(3, 6);
            this.btnBebida1.Name = "btnBebida1";
            this.btnBebida1.Size = new System.Drawing.Size(110, 90);
            this.btnBebida1.TabIndex = 4;
            this.btnBebida1.Text = "COCA-COLA";
            this.btnBebida1.UseVisualStyleBackColor = true;
            this.btnBebida1.Click += new System.EventHandler(this.btnBebida1_Click);
            // 
            // tbpComidas
            // 
            this.tbpComidas.Controls.Add(this.btnComida4);
            this.tbpComidas.Controls.Add(this.btnComida3);
            this.tbpComidas.Controls.Add(this.btnComida2);
            this.tbpComidas.Controls.Add(this.btnComida1);
            this.tbpComidas.Location = new System.Drawing.Point(4, 22);
            this.tbpComidas.Name = "tbpComidas";
            this.tbpComidas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComidas.Size = new System.Drawing.Size(471, 107);
            this.tbpComidas.TabIndex = 1;
            this.tbpComidas.Text = "Comidas";
            this.tbpComidas.UseVisualStyleBackColor = true;
            // 
            // btnComida4
            // 
            this.btnComida4.Location = new System.Drawing.Point(352, 6);
            this.btnComida4.Name = "btnComida4";
            this.btnComida4.Size = new System.Drawing.Size(110, 90);
            this.btnComida4.TabIndex = 3;
            this.btnComida4.Text = "QUESO FUNDIDO";
            this.btnComida4.UseVisualStyleBackColor = true;
            this.btnComida4.Click += new System.EventHandler(this.btnComida4_Click);
            // 
            // btnComida3
            // 
            this.btnComida3.Location = new System.Drawing.Point(236, 6);
            this.btnComida3.Name = "btnComida3";
            this.btnComida3.Size = new System.Drawing.Size(110, 90);
            this.btnComida3.TabIndex = 2;
            this.btnComida3.Text = "TIRADITO DE ROBALO";
            this.btnComida3.UseVisualStyleBackColor = true;
            this.btnComida3.Click += new System.EventHandler(this.btnComida3_Click);
            // 
            // btnComida2
            // 
            this.btnComida2.Location = new System.Drawing.Point(120, 6);
            this.btnComida2.Name = "btnComida2";
            this.btnComida2.Size = new System.Drawing.Size(110, 90);
            this.btnComida2.TabIndex = 1;
            this.btnComida2.Text = "CARPACCIO DE LOMITO";
            this.btnComida2.UseVisualStyleBackColor = true;
            this.btnComida2.Click += new System.EventHandler(this.btnComida2_Click);
            // 
            // btnComida1
            // 
            this.btnComida1.Location = new System.Drawing.Point(3, 6);
            this.btnComida1.Name = "btnComida1";
            this.btnComida1.Size = new System.Drawing.Size(110, 90);
            this.btnComida1.TabIndex = 0;
            this.btnComida1.Text = "TUETANOS DE RES";
            this.btnComida1.UseVisualStyleBackColor = true;
            this.btnComida1.Click += new System.EventHandler(this.btnComida1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(526, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(293, 59);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Orden";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbpCompletarOrden
            // 
            this.tbpCompletarOrden.Controls.Add(this.txtDetalles);
            this.tbpCompletarOrden.Controls.Add(this.label2);
            this.tbpCompletarOrden.Controls.Add(this.lblCronometro);
            this.tbpCompletarOrden.Controls.Add(this.txtMostrarNumOrden);
            this.tbpCompletarOrden.Controls.Add(this.btnCompletar);
            this.tbpCompletarOrden.Controls.Add(this.btnIniciar);
            this.tbpCompletarOrden.Controls.Add(this.btnRefrescar);
            this.tbpCompletarOrden.Location = new System.Drawing.Point(4, 22);
            this.tbpCompletarOrden.Name = "tbpCompletarOrden";
            this.tbpCompletarOrden.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCompletarOrden.Size = new System.Drawing.Size(867, 474);
            this.tbpCompletarOrden.TabIndex = 1;
            this.tbpCompletarOrden.Text = "Completar Orden";
            this.tbpCompletarOrden.UseVisualStyleBackColor = true;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(347, 31);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalles.Size = new System.Drawing.Size(499, 298);
            this.txtDetalles.TabIndex = 0;
            this.txtDetalles.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero de orden";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Location = new System.Drawing.Point(292, 117);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro.TabIndex = 8;
            this.lblCronometro.Text = "00:00:00";
            // 
            // txtMostrarNumOrden
            // 
            this.txtMostrarNumOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMostrarNumOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.txtMostrarNumOrden.Location = new System.Drawing.Point(9, 31);
            this.txtMostrarNumOrden.Name = "txtMostrarNumOrden";
            this.txtMostrarNumOrden.ReadOnly = true;
            this.txtMostrarNumOrden.Size = new System.Drawing.Size(332, 83);
            this.txtMostrarNumOrden.TabIndex = 4;
            this.txtMostrarNumOrden.TabStop = false;
            this.txtMostrarNumOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Enabled = false;
            this.btnCompletar.Location = new System.Drawing.Point(483, 369);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(134, 99);
            this.btnCompletar.TabIndex = 7;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(343, 369);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(134, 99);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(203, 369);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(134, 99);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.tbpAdministrarOrden);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).EndInit();
            this.tbpAdministrarOrden.ResumeLayout(false);
            this.tbpGenerarOrden.ResumeLayout(false);
            this.tbpGenerarOrden.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpBebidas.ResumeLayout(false);
            this.tbpComidas.ResumeLayout(false);
            this.tbpCompletarOrden.ResumeLayout(false);
            this.tbpCompletarOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox BtnCerrarForm;
        private System.Windows.Forms.TabControl tbpAdministrarOrden;
        private System.Windows.Forms.TabPage tbpGenerarOrden;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tbpCompletarOrden;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.TextBox txtMostrarNumOrden;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpBebidas;
        private System.Windows.Forms.Button btnBebida4;
        private System.Windows.Forms.Button btnBebida3;
        private System.Windows.Forms.Button btnBebida2;
        private System.Windows.Forms.Button btnBebida1;
        private System.Windows.Forms.TabPage tbpComidas;
        private System.Windows.Forms.Button btnComida4;
        private System.Windows.Forms.Button btnComida3;
        private System.Windows.Forms.Button btnComida2;
        private System.Windows.Forms.Button btnComida1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumOrden;
        private System.Windows.Forms.ComboBox cboxCamarero;
        private System.Windows.Forms.ComboBox cboxUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalles;
    }
}