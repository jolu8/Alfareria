using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfareria
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new FormCliente();
            formulario.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Form formulario = new FormMaterial();
            formulario.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProducto();
            formulario.Show();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            Form formulario = new FormModelo();
            formulario.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPedido();
            formulario.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmVenta();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
