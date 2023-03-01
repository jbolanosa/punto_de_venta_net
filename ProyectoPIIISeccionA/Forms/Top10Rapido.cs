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
    public partial class Top10Rapido : Form
    {
        RegOrdenesFAL registroOrdenes;
        List<Orden> ordenAux;
        public Top10Rapido()
        {
            InitializeComponent();
            registroOrdenes = new RegOrdenesFAL(@"C:\DATABASE\REGISTRO_ORDENES.txt");
            ordenAux = new List<Orden>();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Top10Rapido_Load(object sender, EventArgs e)
        {
            try
            {
                ordenAux = registroOrdenes.OrdenesAscendente();
                dgvTopRapidos.DataSource = ordenAux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvTopRapidos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selected = dgvTopRapidos.SelectedRows[0];
                int posicion = dgvTopRapidos.Rows.IndexOf(selected);

                FrmMostrarFactura frmMF = new FrmMostrarFactura(ordenAux[posicion].numero);
                frmMF.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnRefrescar1_Click(object sender, EventArgs e)
        {
            try
            {
                ordenAux = registroOrdenes.OrdenesAscendente();
                dgvTopRapidos.DataSource = ordenAux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
