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
    public partial class FormModelo : Form
    {
        public FormModelo()
        {
            InitializeComponent();
            listarModelo();
        }

        public List<entModelo> listarModelo()
        {
            List<entModelo> listarModelo = logModelo.Instancia.ListarModelo();
            if (listarModelo.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarModelo;
                dgvModelo.DataSource = datosEnlazados;
            }
            return (listarModelo);
        }

        private void txtModID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entModelo c = new entModelo();
                c.idModelo = txtIdModelo.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                logModelo.Instancia.InsertarModelo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarModelo();
        }

        private void LimpiarVariables()
        {
            txtIdModelo.Text = "";
            txtDescripcion.Text = " ";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                entModelo c = new entModelo();
                c.idModelo = txtIdModelo.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                logModelo.Instancia.ActualizarModelo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarModelo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idModelo;
            DataGridViewRow fila = dgvModelo.CurrentRow;
            if (fila != null)
            {
                idModelo = int.Parse(fila.Cells[0].Value.ToString());
                entModelo mod = logModelo.Instancia.BuscarModelo(idModelo);
                if (mod != null)
                {
                    logModelo.Instancia.EliminarModelo(idModelo);
                    listarModelo();
                }
               else
                    MessageBox.Show("El Modelo no existe, verifique.", "Modelo: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Modelo.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
