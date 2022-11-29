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
    public partial class FormMaterial : Form
    {
        public FormMaterial()
        {
            InitializeComponent();
            listarMaterial();
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
                Mat.idMaterial = txtIdMaterial.Text.Trim();
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
                c.idMaterial = txtIdMaterial.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                logMaterial.Instancia.ActualizarMaterial(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMaterial();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string datoaBuscar = txtIdMaterial.Text;
            entMaterial ped = logMaterial.Instancia.BuscarMaterial(datoaBuscar);
            if (ped != null)
            {
                txtIdMaterial.Text = Convert.ToString(ped.idMaterial);
                txtDescripcion.Text = Convert.ToString(ped.descripcion);
            }
            else
            {
                MessageBox.Show("El Pedido no existe");
            }
        }
    }
}
