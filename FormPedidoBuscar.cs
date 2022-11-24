using Capa_Entidad;
using Entidad_Logica;
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
    public partial class FormPedidoBuscar : Form
    {
        public FormPedidoBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(568, 425);
            int datoaBuscar = Convert.ToInt32(txtPedido.Text);
            entPedido ped = logPedido.Instancia.BuscarPedido(datoaBuscar);
            if (ped != null)
            {
                txtPedidoID.Text = Convert.ToString(ped.idPedido);
                cbClienteID.Text = Convert.ToString(ped.idCliente);
                cbProductoID.Text = Convert.ToString(ped.idProducto);
                txtCantidad.Text = Convert.ToString(ped.cantidad);
                txtPrecio.Text = Convert.ToString(ped.precioPedido);
                txtObservaciones.Text = Convert.ToString(ped.observaciones);
                dtFechaPedido.Text = Convert.ToString(ped.fPedido);
                dtFechaEntrega.Text = Convert.ToString(ped.fEntrega);               
            }
            else
            {
                MessageBox.Show("El Pedido no existe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
