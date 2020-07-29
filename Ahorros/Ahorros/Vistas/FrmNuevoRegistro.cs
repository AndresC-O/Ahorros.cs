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

namespace Ahorros.Vistas
{
    public partial class FrmNuevoRegistro : Form
    {
        tb_Usuarios usuarios = new tb_Usuarios();

        public FrmNuevoRegistro()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDUI.Text.Equals("") || txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtPassword.Text.Equals("") || txtVerifyPassword.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos para continuar!", "Completar datos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtVerifyPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("¡Las contraseñas no coinciden!", "Verificar.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        using (AhorrosBDEntities bd = new AhorrosBDEntities())
                        {
                            var lista = from tbUsuario in bd.tb_Usuarios
                                        where tbUsuario.DUI == txtDUI.Text
                                        select tbUsuario;

                            if (lista.Count() > 0)
                            {
                                MessageBox.Show("¡El usuario ya existe, intente con otro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                try
                                {
                                    using (AhorrosBDEntities db = new AhorrosBDEntities())
                                    {
                                        usuarios.DUI = txtDUI.Text;
                                        usuarios.nombres = txtNombres.Text;
                                        usuarios.apellidos = txtApellidos.Text;
                                        usuarios.contrasenia = txtPassword.Text;

                                        bd.tb_Usuarios.Add(usuarios);
                                        bd.SaveChanges();
                                    }

                                    MessageBox.Show("¡Registro completado con éxito!", "Completo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FrmMenu menu = new FrmMenu();
                                    menu.lblnumDUI.Text = txtDUI.Text;
                                    menu.Show();
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ha ocurrido un error: \n\n" + ex, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch(Exception exx)
                    {
                        MessageBox.Show("Ha ocurrido un error: \n\n" + exx, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
