using proyecto3.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class FormPrincipalVendedor : Form
    {
        private Form formularioActivo = null;
        public FormPrincipalVendedor()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        #region CAMBIAR TAMAÑO DEL FROMULARIO
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        //private int tolerance = 12;
        //private const int WM_NCHITTEST = 132;
        //private const int HTBOTTOMRIGHT = 17;
        //private Rectangle sizeGripRectangle;
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        ////----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
        //    sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
        //    region.Exclude(sizeGripRectangle);
        //    this.panelContenedor.Region = region;
        //    this.Invalidate();
        //}
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        //}
        #endregion

        #region ICONO MIMINIZAR ,MAXIMIZAR ,RESTAURAR, SALIR
        //Capturar tamaño y posicion inicial
        //int lx, ly;
        //int sw, sh; //ancho y alto
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void btnMax_Click(object sender, EventArgs e)
        //{
        //    lx = this.Location.X;
        //    ly = this.Location.Y;
        //    sw = this.Size.Width;
        //    sh = this.Size.Height;
        //    btnMax.Visible = false;
        //    btnRestaurar.Visible = true;
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        //}

        //private void btnRestaurar_Click(object sender, EventArgs e)
        //{
        //    btnRestaurar.Visible = false;
        //    btnMax.Visible = true;
        //    this.Size = new Size(sw, sh);
        //    this.Location = new Point(lx, ly);
        //}
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //Invocamos metodo para arrastrar
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region METODO PARA MOVER FORMULARIO
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        //NO VISIBLE LOS SUBMENUS
        private void PersonalizarDiseño()
        {
            panelSubProductos.Visible = false;
            panelReporteSalir.Location = new Point(1, 254);
            panelSubProductos.Location = new Point(1, 254);
        }
        private void OcultarSubMenus()
        {
            if (panelSubProductos.Visible == true)
            {
                panelSubProductos.Visible = false;
                panelReporteSalir.Location = new Point(1, 254);
            }
               
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
                subMenu.Location = new Point(1, 254);
                panelReporteSalir.Location = new Point(1,359);
                
            }
            else
            {
                subMenu.Visible = false;
                panelReporteSalir.Location = new Point(1, 254);
            }
                

        }
        private void AbrirFormularioHijo(Form FormularioHijo)
        {
            if (formularioActivo != null)
            {
                //abrir solo formulario
                formularioActivo.Close();
            }
            try
            {
                formularioActivo = FormularioHijo;
                FormularioHijo.TopLevel = false;
                FormularioHijo.FormBorderStyle = FormBorderStyle.None;
                FormularioHijo.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(FormularioHijo);
                panelFormularios.Tag = FormularioHijo;
                FormularioHijo.BringToFront();//traer formulario al frente
                FormularioHijo.Show();//mostrar
            }
            catch (System.ObjectDisposedException)
            {

            }
           
        }
        //LOGO 
        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                formularioActivo.Close();
            }
            catch(System.NullReferenceException)
            {
                //MessageBox.Show("");
            }
            
        }
        private void PantallaCompleta()
        {
            //PANTALLA EN MAXIMO PERO QUE SEA VISIBLE LA BARRA DE TAREA
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void FormPrincipalVendedor_Load(object sender, EventArgs e)
        {
            PantallaCompleta();
        }

        #region MENU OPCIONES
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {  
            OcultarSubMenus();
            AbrirFormularioHijo(new FormConfiguracion());
          
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCliente());
            OcultarSubMenus();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubProductos);
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormInventario());
               OcultarSubMenus();
        }

        private void btnRegistroProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormRegistroProductos());
            OcultarSubMenus();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReportes());
            OcultarSubMenus();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width == 195)
            {
                panelMenuLateral.Width = 60;
            }
            else
            {
                panelMenuLateral.Width = 195;
            }
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
