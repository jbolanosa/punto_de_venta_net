using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

 namespace ProyectoPIIISeccionA
{

    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        #region MinimizarYCerrarForm
        private void pb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pb_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region RedirigirSubmenus
        private void AbrirFormulario<Seleccionado>() where Seleccionado : Form, new()
        {
            Form formulario = panelPMostrar.Controls.OfType<Seleccionado>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new Seleccionado();
            formulario.TopLevel = false;
            panelPMostrar.Controls.Add(formulario);
            panelPMostrar.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Forms.Pedidos>();
        }
        private void pb_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Forms.Clientes>();
        }
        private void pb_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Forms.Productos>();
        }
        private void btn_top10rapidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Top10Rapido>();
        }
        private void btn_TopLentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Top10Lento>();
        }
        #endregion


        #region CreadoPorError
            private void panelBarra_Paint(object sender, PaintEventArgs e) { }
            private void panelPMostrar_Paint(object sender, PaintEventArgs e) { }
            private void pb_Top10_Click(object sender, EventArgs e) {  }
        #endregion

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string directorio = @"C:\DATABASE";
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }
    }
}
