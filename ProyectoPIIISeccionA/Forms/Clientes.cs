using Backend.Entity;
using Backend.FileAccess;
using Backend.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPIIISeccionA.Forms
{
    public partial class Clientes : Form
    {
        RegistroCliente registroCliente;
        RegClienteFAL regClienteFAL;

        public Clientes()
        {
            InitializeComponent();

            regClienteFAL = new RegClienteFAL(@"C:\DATABASE\REGISTRO_CLIENTE.txt");
            registroCliente = new RegistroCliente();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            try
            {
                cliente = new Cliente(txtNIT.Text, txtNombreCliente.Text, txtDireccionCliente.Text, int.Parse(txtTelefonoCliente.Text), DateTime.Parse(dtpFechaUnion.Text));
                regClienteFAL.InsertarNuevoCliente(cliente);

                MessageBox.Show("Cliente Registrado Existosamente!!!");

                txtNIT.Clear();
                txtNombreCliente.Clear();
                txtDireccionCliente.Clear();
                txtTelefonoCliente.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
