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
    public partial class FormClienteAgregar : Form
    {
        public FormClienteAgregar()
        {
            InitializeComponent();
            txtDni.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insertar
            try
            {
                entCliente c = new entCliente();
                c.dni = int.Parse(txtDni.Text.Trim());
                c.nombre = txtNombre.Text.Trim();
                c.apellido = txtApellido.Text.Trim();
                c.direccion = txtDireccion.Text.Trim();
                c.telefono = int.Parse(txtTelefono.Text.Trim());
                logCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }

        private void LimpiarVariables()
        {
            txtDni.Text = "";
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtDireccion.Text = " ";
            txtTelefono.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
