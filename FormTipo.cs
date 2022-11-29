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
    public partial class FormTipo : Form
    {
        public FormTipo()
        {
            InitializeComponent();
            listarTipo();
        }
        public List<entTipo> listarTipo()
        {
            List<entTipo> listarTipo = logTipo.Instancia.ListarTipo();
            if (listarTipo.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarTipo;
                dgvTipo.DataSource = datosEnlazados;
            }
            return (listarTipo);
        }

        private void limpiarVariables()
        {
            txtIdTipo.Text = "";
            txtNombre.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entTipo Ti = new entTipo();
                Ti.idTipo = txtIdTipo.Text.Trim();
                Ti.descripcion = txtNombre.Text.Trim();
                logTipo.Instancia.InsertarTipo(Ti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarTipo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(568, 425);
            string datoaBuscar = txtIdTipo.Text.Trim();
            entTipo ped = logTipo.Instancia.BuscarTipo(datoaBuscar);
            if (ped != null)
            {
                txtIdTipo.Text = Convert.ToString(ped.idTipo);
                txtNombre.Text = Convert.ToString(ped.descripcion);
            }
            else
            {
                MessageBox.Show("El Tipo no existe");
            }
        }
    }
}
