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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMaterial c = new entMaterial();
                c.idMaterial = int.Parse(txtIdMaterial.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                logMaterial.Instancia.InsertaMaterial(c);
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
    }
}
