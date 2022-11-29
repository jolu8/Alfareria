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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            LimpiarVariables();
            listarProductos();
            llenarcbxTipo();
            llenarcbxMaterial();
            llenarcbxModelo();
        }

        private void llenarcbxTipo()
        {
            cbxTipo.DataSource = logTipo.Instancia.ListarTipo();
            cbxTipo.DisplayMember = "idTipo";
            cbxTipo.ValueMember = "idTipo";
        }

        private void llenarcbxMaterial()
        {
            cbxMaterial.DataSource = logMaterial.Instancia.ListarMaterial();
            cbxMaterial.DisplayMember = "descripcion";
            cbxMaterial.ValueMember = "idMaterial";
        }

        private void llenarcbxModelo()
        {
            cbxModelo.DataSource = logModelo.Instancia.ListarModelo();
            cbxModelo.DisplayMember = "descripcion";
            cbxModelo.ValueMember = "idModelo";
        }

        private void LimpiarVariables()
        {
            txtIdProducto.Text = "";
            cbxTipo.Text = "";
            cbxMaterial.Text = "";
            cbxModelo.Text = "";
            txtPrecio.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entProducto p = new entProducto();
                p.idProducto = txtIdProducto.Text.Trim();
                p.tipo = cbxTipo.SelectedValue.ToString();
                p.idMaterial = cbxMaterial.SelectedValue.ToString();
                p.idModelo = cbxModelo.SelectedValue.ToString();
                p.precio = int.Parse(txtPrecio.Text.Trim());
                logProducto.Instancia.InsertarProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarProductos();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.idProducto = txtIdProducto.Text.Trim();
                c.tipo = cbxTipo.SelectedValue.ToString();
                c.idMaterial = cbxMaterial.SelectedValue.ToString();
                c.idModelo = cbxModelo.SelectedValue.ToString();
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
            string idProducto;
            DataGridViewRow fila = dgvProducto.CurrentRow;
            if (fila != null)
            {
                idProducto = fila.Cells[0].Value.ToString();
                entProducto cli = logProducto.Instancia.BuscarProducto(idProducto);
                if (cli != null)
                {
                    logProducto.Instancia.EliminarProducto(idProducto);
                    listarProductos();
                }
                else
                    MessageBox.Show("El Producto no existe, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Producto.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listarProductos()
        {
            dgvProducto.DataSource = logProducto.Instancia.listarProducto();
        }
    }
}
