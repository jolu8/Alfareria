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
    public partial class FormPedidoAgregar : Form
    {
        public FormPedidoAgregar()
        {
            InitializeComponent();
        }
        private void LimpiarVariables()
        {
            txtIdPedido.Text = "";
            cbxIdCliente.Text = "";
            cbxIdProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtObservaciones.Text = "";
            dtFechaPedido.Text = "";
            dtFechaEntrega.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPedido c = new entPedido();
                c.idPedido = txtIdPedido.Text.Trim();
                c.idCliente = (entCliente)cbxIdCliente.SelectedItem;
                c.idProducto = (entProducto)cbxIdProducto.SelectedItem;
                c.cantidad = int.Parse(txtCantidad.Text.Trim());
                c.precioPedido = int.Parse(txtPrecio.Text.Trim());
                c.observaciones = txtObservaciones.Text.Trim();
                c.fPedido = DateTime.Parse(dtFechaPedido.Text.Trim());
                c.fEntrega = DateTime.Parse(dtFechaEntrega.Text.Trim());
                logPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
