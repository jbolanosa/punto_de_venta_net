using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.FileAccess;
using Backend.Entity;

namespace ProyectoPIIISeccionA
{
    public partial class Top10Lento : Form
    {
        RegOrdenesFAL registroOrdenes;
        List<Orden> ordenAux;
        public Top10Lento()
        {
            InitializeComponent();
            registroOrdenes = new RegOrdenesFAL(@"C:\DATABASE\REGISTRO_ORDENES.txt");
            ordenAux = new List<Orden>();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Top10Lento_Load(object sender, EventArgs e)
        {
            try
            {
                ordenAux = registroOrdenes.OrdenesDescendente();
                dgvTopLentos.DataSource = ordenAux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvTopLentos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selected = dgvTopLentos.SelectedRows[0];
                int posicion = dgvTopLentos.Rows.IndexOf(selected);

                FrmMostrarFactura frmMF = new FrmMostrarFactura(ordenAux[posicion].numero);
                frmMF.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnRefrescar2_Click(object sender, EventArgs e)
        {
            try
            {
                ordenAux = registroOrdenes.OrdenesDescendente();
                dgvTopLentos.DataSource = ordenAux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
