using System;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Opción del menú para Pedidos
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.MdiParent = this;
            frm.Show();
        }

        // Opción del menú para Mesas
        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMesas frm = new FrmMesas();
            frm.MdiParent = this;
            frm.Show();
        }

        // Opción del menú para Productos
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        // Opción del menú para Empleados
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        // Opción del menú para Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}