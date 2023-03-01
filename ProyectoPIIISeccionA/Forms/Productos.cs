using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoPIIISeccionA.Forms
{

    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\DATABASE\REGISTRO_PRODUCTOS.txt", true);
            try
            {
                escribir.WriteLine("PRECIO: " + textBox1.Text);
                escribir.WriteLine("NOMBRE: " + textBox2.Text);
                escribir.WriteLine("CODIGO DE PRODUCTO: " + textBox3.Text);
                escribir.WriteLine("FECHA DE VENCIMIENTO: " + textBox4.Text);
                escribir.WriteLine("\n");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch
            {

                MessageBox.Show("Error");
            }
            escribir.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\DATABASE\REGISTRO_PRODUCTOS.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
