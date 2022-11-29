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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            listarPedido();
        }
        public void listarPedido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
        }
        private void FormPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPedidoAgregar();
            formulario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idPedido;
            DataGridViewRow fila = dgvPedido.CurrentRow;
            if (fila != null)
            {
                idPedido = fila.Cells[0].Value.ToString();
                entPedido pe = logPedido.Instancia.BuscarPedido(idPedido);
                if (pe != null)
                {
                    logPedido.Instancia.EliminarPedido(idPedido);
                    listarPedido();
                }
                else
                    MessageBox.Show("El Cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Cliente.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarPedido();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
