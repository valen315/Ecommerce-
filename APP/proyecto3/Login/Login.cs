using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using CapaComun.Cache;

namespace proyecto3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            SeleccionartipoRegistro seleccionartipoRegistro = new SeleccionartipoRegistro();
            this.Hide();
            seleccionartipoRegistro.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "")
            {
                if (txtpass.Text != "")
                {
                    ModeloDominioUser dominioUser = new ModeloDominioUser();
                    var validarLogin=dominioUser.LoginUser(txtuser.Text, txtpass.Text);
                    if (validarLogin == true)
                    {
                        if (CacheInicioSesionUser.Perfil == Convert.ToInt32(CachePerfil.Administrador))
                        {
                            FormPrincipalVendedor vendedor = new FormPrincipalVendedor();
                            vendedor.Show();
                            vendedor.FormClosed += CerrarSesion;
                            this.Hide();
                        }
                        if(CacheInicioSesionUser.Perfil == Convert.ToInt32(CachePerfil.Usuario))
                        {
                            FormPrincipalClientes formClientes = new FormPrincipalClientes();
                            formClientes.Show();
                            formClientes.FormClosed += CerrarSesion;
                            this.Hide();
                        }
                            
                    }
                    else
                    {
                        msjError("Usuario o contraseña incorrecta");
                        txtpass.Clear();
                        txtuser.Clear();
                        txtuser.Focus();
                    }
                }
                else
                    msjError("Ingrese contraseña");
            }
            else
            {
                msjError("Ingrese nombre de usuario");
            }
        }
        private void msjError(string msj)
        {
            lblMensaje.Text =msj;
            lblMensaje.Visible = true;
        }
        private void CerrarSesion(object sender ,FormClosedEventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            lblMensaje.Visible = false;
            this.Show();
            txtuser.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FormRecuperarContraseña();
            recoverPassword.ShowDialog();
        }
    }
}
