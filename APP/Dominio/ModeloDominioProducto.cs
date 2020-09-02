using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesDatos;
using CapaComun;
using CapaComun.Cache;

namespace Dominio
{
    public class ModeloDominioProducto
    {
        Metodos metodos = new Metodos();

        //public List<CacheProductos> BuscarProducto(string buscar)
        //{
        //    return metodos.ListaProductos(buscar);
        //}
        #region Metodo Tabla PRODUCTOS
        public void MostrarTabla(DataGridView dgv)
        {
           
            dgv.DataSource = metodos.MostrarTabla();
        }

        public void  InsertarProducto(CacheProductos productos)
        {
                metodos.InsertarRegistro(productos);
        }
        public void  EditarProducto(CacheProductos productos)
        {
             metodos.EditarProducto(productos);
             
        }
        public void EliminarProducto(CacheProductos productos)
        {
           metodos.EliminarProducto(productos);
        }
        public void BuscarProducto(DataGridView dgv , string buscar)
        {
            metodos.BuscarProducto(dgv,buscar);
        }
        #endregion

        #region Metodo Tabla MARCA
        public void ListarMarca(ComboBox cmb)
        {
            cmb.DataSource = metodos.ListarMarca();
            cmb.DisplayMember = "nombreM";
            cmb.ValueMember = "id";
        }
        public void ListarTablaMarca( DataGridView dgv)
        {
            dgv.DataSource = metodos.ListarTablaMarca();
        }
        public void InsertarMarca(CacheCategoriaMarca marca)
        {
            metodos.InsertarMarca(marca);
        }
        public void EditarMarca(CacheCategoriaMarca marca)
        {
            metodos.EditarMarca(marca);
        }
        public void EliminarMarca(CacheCategoriaMarca marca)
        {
            metodos.EliminarMarca(marca);
        }
        public void BucarMarca(DataGridView dgv,string buscar)
        {
            metodos.BuscarMarca(dgv, buscar);
        }
        #endregion

        #region Metodo Tabla CATEGORIA
        public void ListaCategoria(ComboBox cmb)
        {
            cmb.DataSource = metodos.ListarCateroria();
            cmb.DisplayMember = "nombreC";
            cmb.ValueMember = "id";
        }
        public void ListarTablaCategoria(DataGridView dgv)
        {
            dgv.DataSource = metodos.ListarTablaCategoria();
        }
        public void InsertarCategoria(CacheCategoriaMarca categoria)
        {
            metodos.InsertarCategoria(categoria);
        }
        public void EditarCategoria(CacheCategoriaMarca categoria)
        {
            metodos.EditarCategoria(categoria);
        }
        public void EliminarCategoria(CacheCategoriaMarca categoria)
        {
            metodos.Eliminar(categoria);
        }
        public void BuscarCategoria(DataGridView dgv, string buscar)
        {
            metodos.BuscarCategoria(dgv, buscar);
        }
        #endregion
    }
}
