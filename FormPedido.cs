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
            listarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPedido;
            DataGridViewRow fila = dgvPedido.CurrentRow;
            if (fila != null)
            {
                idPedido = int.Parse(fila.Cells[0].Value.ToString());
                entPedido cli = logPedido.Instancia.BuscarPedido(idPedido);
                if (cli != null)
                {
                    logPedido.Instancia.EliminarPedido(idPedido);
                    listarPedido();
                }
                else
                    MessageBox.Show("El Pedido no existe, verifique.", "Pedido: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione el codigo del Pedido.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listarPedido();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
