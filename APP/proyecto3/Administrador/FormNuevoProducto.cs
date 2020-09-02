using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using CapaComun.Cache;


namespace proyecto3.Administrador
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
            comboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public string Operacion = "";
        public string idProducto;

        //Boton Importar imagen
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Archivos png (*.png)|*.png|Archivos jpg (*.jpg)|*.jpg|Archivos gif (*.gif)|*.gif";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagenPicture.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (System.OutOfMemoryException ) {
                MessageBox.Show( "Error con tamaño de imagen", "Memoria insuficiente");
            }
               
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim().Equals("") || txtStock.Text.Trim().Equals("") ||
               txtPrecioCompra.Text.Trim().Equals("") || txtPrecioVenta.Text.Trim().Equals(""))
             {
                    MessageBox.Show("Los campos son obligatorios");
                    return;
             }
            byte[] imagenByte = null;
            //pasar la imagen que se encuentra en el pictureBox a un array de bytes 
            if (imagenPicture.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                imagenPicture.Image.Save(ms, imagenPicture.Image.RawFormat);
                imagenByte = ms.GetBuffer();
            }
            else
                imagenByte = null;

            CacheProductos productos = new CacheProductos();
            ModeloDominioProducto dominio = new ModeloDominioProducto();
            if (Operacion=="Agregar")
            {
               
                productos.Nombre = txtNombreProducto.Text.Trim();
                productos.Descripcion = txtDescipcion.Text.Trim();
                productos.IdMarca = Convert.ToInt32(comboMarca.SelectedValue);
                productos.IdCategoria = Convert.ToInt32(comboCategoria.SelectedValue);
                productos.Stock = Convert.ToInt32(txtStock.Text.Trim());
                productos.Imagen = imagenByte;
                productos.Fecha = FechaDate.Value;
                productos.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                productos.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
             
                dominio.InsertarProducto(productos);
                Mensaje.Notificacion("Guardado correctamente");
                Reset();
            }
            else if (Operacion=="Editar")
            {
                productos.IdP =Convert.ToInt32(idProducto);
                productos.Nombre = txtNombreProducto.Text.Trim();
                productos.Descripcion = txtDescipcion.Text.Trim();
                productos.IdMarca = Convert.ToInt32(comboMarca.SelectedValue);
                productos.IdCategoria = Convert.ToInt32(comboCategoria.SelectedValue);
                productos.Stock = Convert.ToInt32(txtStock.Text.Trim());
                productos.Imagen = imagenByte;
                productos.Fecha = FechaDate.Value;
                productos.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                productos.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                dominio.EditarProducto(productos);
                Mensaje.Notificacion("Producto actualizado correctamente");
                this.Close();
            }
        }
        public void ListarMarca()
        {
            ModeloDominioProducto producto = new ModeloDominioProducto();
            producto.ListarMarca(comboMarca);
        }
        public void ListaCategoria()
        {
            ModeloDominioProducto producto = new ModeloDominioProducto();
            producto.ListaCategoria(comboCategoria);
            
        }

        //ACTUALIZAR VENTANA
        private void Reset()
        {
            txtNombreProducto.Text = "";
            txtNombreProducto.Focus();
            txtDescipcion.Text = "";
            txtStock.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            ListaCategoria();
            ListarMarca();
            imagenPicture.Dispose();
        }
     

    }
}
