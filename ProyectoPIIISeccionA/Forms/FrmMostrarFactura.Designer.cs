
namespace ProyectoPIIISeccionA
{
    partial class FrmMostrarFactura
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
            this.txtMostrarFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMostrarFactura
            // 
            this.txtMostrarFactura.Location = new System.Drawing.Point(12, 12);
            this.txtMostrarFactura.Multiline = true;
            this.txtMostrarFactura.Name = "txtMostrarFactura";
            this.txtMostrarFactura.ReadOnly = true;
            this.txtMostrarFactura.Size = new System.Drawing.Size(445, 371);
            this.txtMostrarFactura.TabIndex = 0;
            this.txtMostrarFactura.TabStop = false;
            // 
            // FrmMostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 395);
            this.Controls.Add(this.txtMostrarFactura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarFactura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmMostrarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrarFactura;
    }
}