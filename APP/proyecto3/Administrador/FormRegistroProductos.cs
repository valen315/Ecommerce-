using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.EntitySql;
using System.IO;
using System.Reflection;
using Dominio;
using CapaComun.Cache;
using System.Management;

namespace proyecto3.Administrador
{
    public partial class FormRegistroProductos : Form
    {
        public FormRegistroProductos()
        {
            InitializeComponent();
            
        }
        ModeloDominioProducto producto = new ModeloDominioProducto();
        private void FormRegistroProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
            MostrarBotones();
            ModificacionesTabla();
        }
        private void ModificacionesTabla()
        {
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns["DESCRIPCION"].Width = 130;
            dataGridView1.Columns["PRECIOCOMPRA"].Visible = false;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[7].HeaderText = "PRECIO DE VENTA";
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 25;
            dataGridView1.Columns[10].HeaderText = "";
            dataGridView1.Columns[11].HeaderText = "";
            dataGridView1.Columns[11].Width = 32;
            var columnaImagen = (DataGridViewImageColumn)dataGridView1.Columns["IMAGEN"];
            columnaImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.ClearSelection();

        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto nuevoProducto = new FormNuevoProducto();
            nuevoProducto.Operacion = "Agregar";
            nuevoProducto.ListaCategoria();
            nuevoProducto.ListarMarca();
            nuevoProducto.ShowDialog();
            Actualizar();
        }


        private void btnMarca_Click(object sender, EventArgs e)
        {
            FormMarcas formMarcas = new FormMarcas();
            formMarcas.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria categoria = new FormCategoria();
            categoria.ShowDialog();
        }
     
        public void Actualizar()
        {
         
            producto.MostrarTabla(dataGridView1);

        }
        public void MostrarBotones()
        {
            Botones botones = new Botones();
            botones.Boton(dataGridView1);
        }

        private int n = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormNuevoProducto editarProducto = new FormNuevoProducto();
            n = e.RowIndex;
            try
            {
                if (n != -1)
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "EDITAR")
                    {


                        editarProducto.Operacion = "Editar";
                        editarProducto.ListarMarca();
                        editarProducto.ListaCategoria();
                        editarProducto.idProducto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                        editarProducto.txtNombreProducto.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                        editarProducto.txtDescipcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                        editarProducto.comboMarca.Text = dataGridView1.CurrentRow.Cells["MARCA"].Value.ToString();
                        editarProducto.comboCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                        editarProducto.txtStock.Text = dataGridView1.CurrentRow.Cells["STOCK"].Value.ToString();
                        //obtenes de la fila seleccionada la imagen en byte y guardarla en una array de byte (img) pasar o transformar
                        //ese variable en un dato de tipo Image para visualizarla 
                        if (dataGridView1.CurrentRow.Cells["IMAGEN"].Value != DBNull.Value)
                        {
                            byte[] img = (byte[])dataGridView1.CurrentRow.Cells["IMAGEN"].Value;
                            MemoryStream ms = new MemoryStream(img);
                            editarProducto.imagenPicture.Image = Image.FromStream(ms);
                        }
                        editarProducto.txtPrecioCompra.Text = dataGridView1.CurrentRow.Cells["PRECIOCOMPRA"].Value.ToString();
                        editarProducto.txtPrecioVenta.Text = dataGridView1.CurrentRow.Cells["PRECIOVENTA"].Value.ToString();
                        editarProducto.FechaDate.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString();

                        editarProducto.ShowDialog();
                        Actualizar();

                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].Name == "ELIMINAR")
                    {
                        CacheProductos cacheProductos = new CacheProductos();
                        try
                        {
                            DialogResult resultado = new DialogResult();
                            MensajeEliminar mensaje = new MensajeEliminar("Esta seguro de eliminar el producto?");
                            resultado= mensaje.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                cacheProductos.IdP = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                                producto.EliminarProducto(cacheProductos);
                                Mensaje.Notificacion("ELIMINADO");
                            }
                            Actualizar();
                        }
                        catch (Exception)
                        {
                            MensajeError.TextoMensaje("Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "STOCK")
            {
                if (Convert.ToInt32(e.Value) >=30)
                {
                    e.CellStyle.BackColor = Color.FromArgb(171, 221, 153);

                }
                if (Convert.ToInt32(e.Value) < 30 && Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 255, 176);

                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.BackColor = Color.FromArgb(232, 141, 141);
                }
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            producto.BuscarProducto(dataGridView1, txtBuscar.Text);
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                Actualizar();
            }
        }
    }
}
