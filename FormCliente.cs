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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            listarCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }
        //public List<entCliente> listarCliente()
        //{
        //    List<entCliente> listarCliente = logCliente.Instancia.ListarCliente();
        //    //if (listarCliente.Count > 0)
        //    //{
        //        BindingSource datosEnlazados = new BindingSource();
        //        datosEnlazados.DataSource = listarCliente;
        //        dgvCliente.DataSource = datosEnlazados;
        //    //}
        //    return (listarCliente);
        //}

        private void button_Click(object sender, EventArgs e)
        {
            Form formulario = new FormClienteAgregar();
            formulario.Show();
            //Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormClienteModificar();
            formulario.Show();
            listarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dni;
            DataGridViewRow fila = dgvCliente.CurrentRow;
            if (fila != null)
            {
                dni = int.Parse(fila.Cells[0].Value.ToString());
                entCliente cli = logCliente.Instancia.BuscarCliente(dni);
                if (cli != null)
                {
                    logCliente.Instancia.EliminarCliente(dni);
                    listarCliente();
                }
                else
                    MessageBox.Show("El Cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Cliente.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarCliente();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listarCliente();
        }
    }
}
