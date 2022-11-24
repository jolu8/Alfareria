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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        public void listarProducto()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
        }
        private void LimpiarVariables()
        {
            txtIdProducto.Text = "";
            txtTipo.Text = "";
            txtMaterial.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProducto c = new entProducto();
                c.idProducto = txtIdProducto.Text.Trim();
                c.tipo = txtTipo.Text.Trim();
                c.material = txtMaterial.Text.Trim();
                c.modelo = txtModelo.Text.Trim();
                c.precio = int.Parse(txtPrecio.Text.Trim());
                logProducto.Instancia.InsertaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.idProducto = txtIdProducto.Text.Trim();
                c.tipo = txtTipo.Text.Trim();
                c.material = txtMaterial.Text.Trim();
                c.modelo = txtModelo.Text.Trim();
                c.precio = int.Parse(txtPrecio.Text.Trim());
                logProducto.Instancia.ActualizarProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int DniC;
            DataGridViewRow fila = dgvProducto.CurrentRow;
            if (fila != null)
            {
                DniC = int.Parse(fila.Cells[0].Value.ToString());
                entProducto cli = logProducto.Instancia.BuscarProducto(DniC);
                if (cli != null)
                {
                    logProducto.Instancia.EliminarProducto(DniC);
                    listarProducto();
                }
                else
                    MessageBox.Show("El Producto no existe, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Producto.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarProducto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
