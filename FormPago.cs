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
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int datoaBuscar = Convert.ToInt32(txtVenta.Text);
            EntVenta ven = LogVenta.Instancia.BuscarVenta(datoaBuscar);
            if (ven != null)
            {
                txtVentaID.Text = Convert.ToString(ven.VentaID);
                cbPedido.Text = Convert.ToString(ven.PedidoID);
                txtTotal.Text = Convert.ToString(ven.Importe);
            }
            else
            {
                MessageBox.Show("El Pedido no existe");
            }
        }
    }
}
