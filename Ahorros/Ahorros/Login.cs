using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ahorros.Modelo;

namespace Ahorros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Métodos PlaceHolders
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                if(chBVerPass.Checked == false)
                {
                    txtPassword.PasswordChar = '•';
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Contraseña";  
            }
        }

        private void txtDUI_Enter(object sender, EventArgs e)
        {
            if (txtDUI.Text == "00000000-0")
            {
                txtDUI.Text = "";
            }
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            if (txtDUI.Text == "")
            {
                txtDUI.Text = "00000000-0";
            }
        }

        private void chBVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "Contraseña")
            {
                if(chBVerPass.Checked == true)
                {
                    if(txtPassword.PasswordChar == '•')
                    {
                        txtPassword.PasswordChar = '\0';
                    }
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                }
            }
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("¿Estás seguro que desear salir?", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(message == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using(AhorrosBDEntities bd = new AhorrosBDEntities())
            {
                var Lista = from usuario in bd.tb_Usuarios
                            where usuario.DUI == txtDUI.Text && usuario.contrasenia == txtPassword.Text
                            select usuario;

                if(Lista.Count() > 0)
                {
                    MessageBox.Show("Siu");
                }
                else
                {
                    MessageBox.Show("Noooooooou");
                }
            }
        }
    }
}
