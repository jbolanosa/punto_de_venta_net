using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Operations;
using Backend.Entity;
using Backend.FileAccess;

namespace ProyectoPIIISeccionA.Forms
{
    public partial class Pedidos : Form
    {
        GenerarOrden generarOrden;
        FacturaFAL factura;
        RegOrdenesFAL regOrdenes;
        DateTime tiempo;
        int segundos;
        StringBuilder prodPedido;
        double total;
        
        public Pedidos()
        {
            InitializeComponent();
            generarOrden = new GenerarOrden();
            factura = new FacturaFAL();
            regOrdenes = new RegOrdenesFAL(@"C:\DATABASE\REGISTRO_ORDENES.txt");
            tiempo = Convert.ToDateTime("00:00:00");
            prodPedido = new StringBuilder();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Orden orden;
            try
            {
                orden = new Orden(int.Parse(txtNumOrden.Text), cboxCamarero.Text, cboxUbicacion.Text, total, "EN PROCESO", null, null, null);
                generarOrden.AgregarOrden(orden);
                factura.Insertar(orden, prodPedido.ToString());

                txtNumOrden.Text = "";
                txtPedido.Text = "";
                txtTotal.Text = "";
                cboxCamarero.SelectedIndex = -1;
                cboxUbicacion.SelectedIndex = -1;
                total = 0;
                prodPedido.Clear();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            

        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            int numeroOrden = generarOrden.Refrescar();
            if (numeroOrden == -1)
                MessageBox.Show("No hay ordenes en cola", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                txtDetalles.Text = factura.LeerTodo(numeroOrden.ToString());
                txtMostrarNumOrden.Text = numeroOrden.ToString("D6");
                btnRefrescar.Enabled = false;
                btnIniciar.Enabled = true;

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            generarOrden.IniciarOrden();
            txtMostrarNumOrden.BackColor = Color.Green;
            timer.Enabled = true;
            btnIniciar.Enabled = false;
            btnCompletar.Enabled = true;
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            regOrdenes.Insertar(generarOrden.CompletarOrden());
            segundos = 0;
            tiempo = Convert.ToDateTime("00:00:00");
            lblCronometro.Text = "";
            txtDetalles.Text = "";
            btnRefrescar.Enabled = true;
            btnCompletar.Enabled = false;
            txtMostrarNumOrden.Text = "";
            txtMostrarNumOrden.BackColor = Color.WhiteSmoke;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblCronometro.Text = tiempo.AddSeconds(segundos).ToString("HH:mm:ss");
            if (segundos == 360)
                txtMostrarNumOrden.BackColor = Color.Yellow;
            else if (segundos == 660)
                txtMostrarNumOrden.BackColor = Color.Red;
        }

        

        private void btnBebida1_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(1);
            txtTotal.Text = total.ToString();
        }
        private void btnBebida2_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(2);
            txtTotal.Text = total.ToString();
        }
        private void btnBebida3_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(3);
            txtTotal.Text = total.ToString();
        }
        private void btnBebida4_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(4);
            txtTotal.Text = total.ToString();
        }
        private void btnComida1_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(5);
            txtTotal.Text = total.ToString();
        }
        private void btnComida2_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(6);
            txtTotal.Text = total.ToString();
        }
        private void btnComida3_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(7);
            txtTotal.Text = total.ToString();
        }
        private void btnComida4_Click(object sender, EventArgs e)
        {
            AgregarAlPedido(8);
            txtTotal.Text = total.ToString();
        }
        public void AgregarAlPedido(int opcion)
        {
            string prod;
            switch (opcion)
            {
                case 1:
                    prod = "COCA-COLA";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}9.50");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 9.50;
                    break;
                case 2:
                    prod = "FANTA";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}7.50");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 7.50;
                    break;
                case 3:
                    prod = "PEPSI";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}7.50");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 7.50;
                    break;
                case 4:
                    prod = "SPRITE";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}9.50");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 9.50;
                    break;
                case 5:
                    prod = "TUETANOS DE RES";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}59.95");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 59.95;
                    break;
                case 6:
                    prod = "CARPACCIO DE LOMITO";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}74.95");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 74.95;
                    break;
                case 7:
                    prod = "TIRADITO DE ROBALO";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}74.95");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 74.95;
                    break;
                case 8:
                    prod = "QUESO FUNDIDO";
                    prodPedido.AppendLine($"1-  {prod.PadRight(25, '.')}69.95");
                    txtPedido.Text = prodPedido.ToString();
                    total = total + 69.95;
                    break;
            }
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
