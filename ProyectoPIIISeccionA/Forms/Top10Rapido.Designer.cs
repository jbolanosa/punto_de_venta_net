namespace ProyectoPIIISeccionA
{
    partial class Top10Rapido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10Rapido));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrarForm = new System.Windows.Forms.PictureBox();
            this.dgvTopRapidos = new System.Windows.Forms.DataGridView();
            this.btnRefrescar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRapidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAS RAPIDOS:";
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarForm.Image")));
            this.BtnCerrarForm.Location = new System.Drawing.Point(873, 11);
            this.BtnCerrarForm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCerrarForm.TabIndex = 9;
            this.BtnCerrarForm.TabStop = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // dgvTopRapidos
            // 
            this.dgvTopRapidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopRapidos.Location = new System.Drawing.Point(31, 43);
            this.dgvTopRapidos.Name = "dgvTopRapidos";
            this.dgvTopRapidos.Size = new System.Drawing.Size(840, 383);
            this.dgvTopRapidos.TabIndex = 10;
            this.dgvTopRapidos.DoubleClick += new System.EventHandler(this.dgvTopRapidos_DoubleClick);
            // 
            // btnRefrescar1
            // 
            this.btnRefrescar1.Location = new System.Drawing.Point(364, 435);
            this.btnRefrescar1.Name = "btnRefrescar1";
            this.btnRefrescar1.Size = new System.Drawing.Size(170, 82);
            this.btnRefrescar1.TabIndex = 11;
            this.btnRefrescar1.Text = "Recargar";
            this.btnRefrescar1.UseVisualStyleBackColor = true;
            this.btnRefrescar1.Click += new System.EventHandler(this.btnRefrescar1_Click);
            // 
            // Top10Rapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.btnRefrescar1);
            this.Controls.Add(this.dgvTopRapidos);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Top10Rapido";
            this.Text = "Top10";
            this.Load += new System.EventHandler(this.Top10Rapido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRapidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox BtnCerrarForm;
        private System.Windows.Forms.DataGridView dgvTopRapidos;
        private System.Windows.Forms.Button btnRefrescar1;
    }
}