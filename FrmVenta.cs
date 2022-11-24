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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        public void listarVenta()
        {
            dgvVenta.DataSource = logVenta.Instancia.ListarVenta();
        }
        private void LimpiarVariables()
        {
            txtIdVenta.Text = "";
            cbxIdPedido.Text = "";
            txtTotal.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entVenta c = new entVenta();
                c.idVenta = txtIdVenta.Text.Trim();
                c.idPedido = (entPedido)cbxIdPedido.SelectedItem;
                c.total = Convert.ToInt32(txtTotal.Text.Trim());
                logVenta.Instancia.InsertarVenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(568, 425);
            int datoaBuscar = Convert.ToInt32(txtIdVenta.Text);
            entVenta ped = logVenta.Instancia.BuscarVenta(datoaBuscar);
            if (ped != null)
            {
                txtIdVenta.Text = Convert.ToString(ped.idVenta);
                cbxIdPedido.Text = Convert.ToString(ped.idPedido);
                txtTotal.Text = Convert.ToString(ped.total);
            }
            else
            {
                MessageBox.Show("El Venta no existe");
            }
        }
    }
}
