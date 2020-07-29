using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorros.Vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void AbrirFormulario(object FormHijo)
        {
            if (this.pnPrincipal.Controls.Count > 0)
            {
                this.pnPrincipal.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnPrincipal.Controls.Add(fh);
            this.pnPrincipal.Tag = fh;
            fh.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                log.Show();
                this.Close();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPresentación());
        }

        private void pbLogoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPresentación());
        }
    }
}
