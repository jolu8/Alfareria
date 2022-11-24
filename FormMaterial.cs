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
    public partial class FormMaterial : Form
    {
        public FormMaterial()
        {
            InitializeComponent();
            ListarMaterial();
        }

        public List<entMaterial> ListarMaterial()
        {
            List<entMaterial> listarMaterial = logMaterial.Instancia.ListarMaterial();
            if (listarMaterial.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarMaterial;
                dgvMaterial.DataSource = datosEnlazados;
            }
            return (listarMaterial);
        }

        public void listarMaterial()
        {
            dgvMaterial.DataSource = logMaterial.Instancia.ListarMaterial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entMaterial Mat = new entMaterial();
                Mat.idMaterial = int.Parse(txtIdMaterial.Text.Trim());
                Mat.descripcion = txtDescripcion.Text.Trim();
                logMaterial.Instancia.InsertarMaterial(Mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void LimpiarVariables()
        {
            txtIdMaterial.Text = "";
            txtDescripcion.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMaterial c = new entMaterial();
                c.idMaterial = int.Parse(txtIdMaterial.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                logMaterial.Instancia.ActualizarMaterial(c);
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
            DataGridViewRow fila = dgvMaterial.CurrentRow;
            if (fila != null)
            {
                DniC = int.Parse(fila.Cells[0].Value.ToString());
                entMaterial cli = logMaterial.Instancia.BuscarMaterial(DniC);
                if (cli != null)
                {
                    logMaterial.Instancia.EliminarMaterial(DniC);
                    listarMaterial();
                }
                else
                    MessageBox.Show("El Material no existe, verifique.", "Material: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Material.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarMaterial();
        }
    }
}
