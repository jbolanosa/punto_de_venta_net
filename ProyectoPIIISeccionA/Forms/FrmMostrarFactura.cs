using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Entity;
using Backend.FileAccess;

namespace ProyectoPIIISeccionA
{
    public partial class FrmMostrarFactura : Form
    {
        int numeroOrden;
        FacturaFAL factura;
        public FrmMostrarFactura(int numeroOrden)
        {
            InitializeComponent();
            this.numeroOrden = numeroOrden;
            factura = new FacturaFAL();
        }

        private void FrmMostrarFactura_Load(object sender, EventArgs e)
        {
            txtMostrarFactura.Text = factura.LeerTodo(numeroOrden.ToString());
        }
    }
}
