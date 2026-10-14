using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Este es el botón Aceptar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "123")
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.Show();
                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este es el botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra el sistema si cancelan
        }
    }
}