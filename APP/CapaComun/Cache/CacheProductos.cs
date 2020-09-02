using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public class CacheProductos
    {
        private int _idP;
        private string _Nombre;
        private string _Descripcion;
        private int _idCategoria;
        private int _idMarca;
        private int _Stock;
        private byte[] _imagen;
        private DateTime _fecha;
        private decimal _precioCompra;
        private decimal _precioVenta;
        //private int _idEstado;

        public int IdP { get => _idP; set => _idP = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public int IdMarca { get => _idMarca; set => _idMarca = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public byte[] Imagen { get => _imagen; set => _imagen = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public decimal PrecioCompra { get => _precioCompra; set => _precioCompra = value; }
        public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        //public int IdEstado { get => _idEstado; set => _idEstado = value; }

        

    }
}
