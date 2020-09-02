using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using Dominio;

namespace proyecto3
{
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            DatosUsuarios();
            initializePassEditControl();
        }
        //METODO PARA Cargar datos del usurio tanto para el panel editar como en Form
        private void DatosUsuarios()
        {
            //FROM
            lblNombre.Text = CacheInicioSesionUser.Nombre;
            lblApellido.Text = CacheInicioSesionUser.Apellido;
            lblEmail.Text = CacheInicioSesionUser.Email;
            lblTelefono.Text = CacheInicioSesionUser.Telefono.ToString();
            lblUsuario.Text = CacheInicioSesionUser.Usuario;

            
            //PANEL
            txtNombre.Text = CacheInicioSesionUser.Nombre;
            txtApellido.Text = CacheInicioSesionUser.Apellido;
            txtEmail.Text = CacheInicioSesionUser.Email;
            txtTelefono.Text = CacheInicioSesionUser.Telefono.ToString();
            txtUsuario.Text = CacheInicioSesionUser.Usuario;
            txtContraseña.Text = CacheInicioSesionUser.Pass;
            txtConfirmarContraseña.Text = CacheInicioSesionUser.Pass;
            txtContraseñaActual.Text = "";

        }
        private void initializePassEditControl()
        {
            linkEditarPass.Text = "EDITAR";
            txtContraseña.Enabled = false;
            txtContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.Enabled = false;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            txtContraseñaActual.UseSystemPasswordChar = true;
        }
        //Metodo para reniciar y actualizar datos
        private void Reset()
        {
            DatosUsuarios();
            initializePassEditControl();
        }

        private void linkEditarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditarPass.Text == "EDITAR")
            {
                linkEditarPass.Text = "CANCELAR";
                txtContraseña.Enabled = true;
                txtContraseña.Text = "";
                txtConfirmarContraseña.Enabled = true;
                txtConfirmarContraseña.Text = "";
                txtContraseña.Focus();
            }
            else if (linkEditarPass.Text == "CANCELAR") 
            {
                Reset();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length >= 5)
            {

                if (txtContraseña.Text == txtConfirmarContraseña.Text)
                {
                    if (txtContraseñaActual.Text == CacheInicioSesionUser.Pass)
                    {
                        var userModel = new ModeloDominioUser(
                            id: CacheInicioSesionUser.Id,
                            usuario: txtUsuario.Text,
                            pass: txtContraseña.Text,
                            nombre: txtNombre.Text,
                            apellido: txtApellido.Text,
                            email: txtEmail.Text,
                            telefono: Convert.ToInt32(txtTelefono.Text)
                            
                            );
                        var resultado = userModel.EditarPerfilUsuario();
                        MessageBox.Show(resultado);
                        Reset();
                        panelEditar.Visible = false;
                    }
                    else
                        MessageBox.Show("Por cuestiones de seguridad confirme su contraseña actual");
                }
                else
                    MessageBox.Show("las contraseñas no coinciden ");
            }
            else
                MessageBox.Show("La contraseña tiene que ser minimo de 5 caracteres");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
            Reset();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
            DatosUsuarios();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
