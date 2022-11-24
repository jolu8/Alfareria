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
                c.idModelo = int.Parse(txtIdModelo.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                logModelo.Instancia.InsertarModelo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        public void listarModelo()
        {
            dgvModelo.DataSource = logModelo.Instancia.ListarModelo();
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
                c.idModelo = int.Parse(txtIdModelo.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                logModelo.Instancia.ActualizarModelo(c);
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
            DataGridViewRow fila = dgvModelo.CurrentRow;
            if (fila != null)
            {
                DniC = int.Parse(fila.Cells[0].Value.ToString());
                entModelo cli = logModelo.Instancia.BuscarModelo(DniC);
                if (cli != null)
                {
                    logModelo.Instancia.EliminarModelo(DniC);
                    listarModelo();
                }
                else
                    MessageBox.Show("El Modelo no existe, verifique.", "Modelo: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Modelo.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarModelo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
