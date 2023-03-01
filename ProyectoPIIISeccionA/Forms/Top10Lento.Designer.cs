namespace ProyectoPIIISeccionA
{
    partial class Top10Lento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10Lento));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrarForm = new System.Windows.Forms.PictureBox();
            this.dgvTopLentos = new System.Windows.Forms.DataGridView();
            this.btnRefrescar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAS LENTOS:";
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
            // dgvTopLentos
            // 
            this.dgvTopLentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopLentos.Location = new System.Drawing.Point(30, 43);
            this.dgvTopLentos.Name = "dgvTopLentos";
            this.dgvTopLentos.Size = new System.Drawing.Size(840, 383);
            this.dgvTopLentos.TabIndex = 11;
            this.dgvTopLentos.DoubleClick += new System.EventHandler(this.dgvTopLentos_DoubleClick);
            // 
            // btnRefrescar2
            // 
            this.btnRefrescar2.Location = new System.Drawing.Point(365, 433);
            this.btnRefrescar2.Name = "btnRefrescar2";
            this.btnRefrescar2.Size = new System.Drawing.Size(170, 82);
            this.btnRefrescar2.TabIndex = 12;
            this.btnRefrescar2.Text = "Recargar";
            this.btnRefrescar2.UseVisualStyleBackColor = true;
            this.btnRefrescar2.Click += new System.EventHandler(this.btnRefrescar2_Click);
            // 
            // Top10Lento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.btnRefrescar2);
            this.Controls.Add(this.dgvTopLentos);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Top10Lento";
            this.Text = "Top10Lento";
            this.Load += new System.EventHandler(this.Top10Lento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox BtnCerrarForm;
        private System.Windows.Forms.DataGridView dgvTopLentos;
        private System.Windows.Forms.Button btnRefrescar2;
    }
}