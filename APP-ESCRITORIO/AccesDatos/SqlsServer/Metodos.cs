using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun.Cache;
using System.Windows.Forms;

namespace AccesDatos
{
    public class Metodos:ConexionBD
    {
        private SqlDataReader LeerFilas;
        #region PROCEDIMIENTOS ALMACENADOS: TABLA PRODUCTO
        public DataTable MostrarTabla()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarTablaProductos";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();

                    return Tabla;
                }
            }

        }

        public void InsertarRegistro(CacheProductos productos )
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarProducto";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre",productos.Nombre);
                        command.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
                        command.Parameters.AddWithValue("@id_marca",productos.IdMarca);
                        command.Parameters.AddWithValue("@id_categoria",productos.IdCategoria);
                        command.Parameters.AddWithValue("@stock",productos.Stock);

                        if (productos.Imagen == null)
                        {
                            // .Parameters.Add(New SqlParameter("@imagen", SqlDbType.Image)).Value = DbNull.Value
                            command.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image)).Value = DBNull.Value;
                            //command.Parameters.AddWithValue("@imagen", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@imagen",productos.Imagen);
                        }

                        command.Parameters.AddWithValue("@fecha", productos.Fecha );
                        command.Parameters.AddWithValue("@precio_compra", productos.PrecioCompra);
                        command.Parameters.AddWithValue("@precio_venta",productos.PrecioVenta);
                        command.ExecuteNonQuery();
                        //command.Parameters.Clear(); //limpiar los parametros 
                    }
                }                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto" + ex);
            } 

        }
       
        public void EditarProducto(CacheProductos productos)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "EditarProducto";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", productos.Nombre);
                        command.Parameters.AddWithValue("@Descripcion",productos.Descripcion);
                        command.Parameters.AddWithValue("@id_marca", productos.IdMarca);
                        command.Parameters.AddWithValue("@id_categoria", productos.IdCategoria);
                        command.Parameters.AddWithValue("@stock", productos.Stock);

                        if (productos.Imagen == null)
                        {
                            command.Parameters.AddWithValue("@imagen", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@imagen", productos.Imagen);
                        }
                        command.Parameters.AddWithValue("@fecha", productos.Fecha);
                        command.Parameters.AddWithValue("@precio_compra", productos.PrecioCompra);
                        command.Parameters.AddWithValue("@precio_venta", productos.PrecioVenta);
                        command.Parameters.AddWithValue("@id", productos.IdP);
                        command.ExecuteNonQuery();
                        //command.Parameters.Clear(); //limpiar los parametros 
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR"+ex);
            }
        }
        public void EliminarProducto(CacheProductos productos )
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EliminarProducto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idP", productos.IdP);
                    command.ExecuteNonQuery();
                }
            }

        }

        public void BuscarProducto(DataGridView dgv, string buscar)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_BuscarProducto";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Buscar", buscar);
                        command.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region PROCEDIMIENTOS ALMACENADO : TABLA MARCA
        public DataTable ListarMarca()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarMarca";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    return Tabla;
                }
            }
        }
        public DataTable ListarTablaMarca()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTablaMarca";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();

                    return Tabla;
                }
            }
        }
        public void BuscarMarca(DataGridView dgv, string buscar)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_BuscarMarca";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Buscar", buscar);
                        command.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InsertarMarca(CacheCategoriaMarca marca)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarMarca";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", marca.NombreMarca_);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar marca");
            }
        }
        public void EditarMarca(CacheCategoriaMarca marca)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "EditarMarca";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", marca.NombreMarca_);
                        cmd.Parameters.AddWithValue("@idM", marca.IdM);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar marca");
            }
        }
        public void EliminarMarca(CacheCategoriaMarca marca)
        {
            using (var connecion = GetSqlConnection())
            {
                connecion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connecion;
                    cmd.CommandText = "EliminarMarca";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idM",marca.IdM);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion


        #region PROCEDIMIENTOS ALMACENADO : TABLA CATEGORIA
        public DataTable ListarCateroria()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarCategoria";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    return Tabla;
                }
            }
        }
        public DataTable ListarTablaCategoria()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTablaCategoria";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();

                    return Tabla;
                }
            }
        }
        public void BuscarCategoria(DataGridView dgv, string buscar)
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_BuscarCategoria";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Buscar", buscar);
                        command.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InsertarCategoria(CacheCategoriaMarca categoria) 
        {
            try
            {
                using (var connection = GetSqlConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarCategoria";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", categoria.NombreCategoria_);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        public void EditarCategoria(CacheCategoriaMarca categoria) 
        {
            try
            {
                using (var connection= GetSqlConnection())
                {
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "EditarCategoria";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", categoria.NombreCategoria_);
                        cmd.Parameters.AddWithValue("@idC", categoria.IdC);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al editar categoria");
            }
        }

        public void Eliminar(CacheCategoriaMarca categoria)
        {
            using (var connecion= GetSqlConnection())
            {
                connecion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connecion;
                    cmd.CommandText = "EliminarCategoria";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idC",categoria.IdC);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
