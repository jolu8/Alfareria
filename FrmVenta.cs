using Capa_AccesoDatos;
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
            listarVenta();
            llenarcbxCliente();
        }

        private void llenarcbxCliente()
        {
            cbxIdPedido.DataSource = logPedido.Instancia.ListarPedido();
            cbxIdPedido.DisplayMember = "idPedido";
            cbxIdPedido.ValueMember = "idPedido";
        }

        public List<entVenta> listarVenta()
        {
            List<entVenta> listarVenta = logVenta.Instancia.ListarVenta();
            if (listarVenta.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarVenta;
                dgvVenta.DataSource = datosEnlazados;
            }
            return (listarVenta);
        }
        private void LimpiarVariables()
        {
            txtIdVenta.Text = "";
            cbxIdPedido.Text = "";
            txtTotal.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entVenta c = new entVenta();
                c.idVenta = txtIdVenta.Text.Trim();
                c.idPedido = cbxIdPedido.SelectedValue.ToString();
                c.total = Convert.ToInt32(txtTotal.Text.Trim());
                logVenta.Instancia.InsertarVenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarVenta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(568, 425);
            string datoaBuscar = txtIdVenta.Text;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxIdPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
