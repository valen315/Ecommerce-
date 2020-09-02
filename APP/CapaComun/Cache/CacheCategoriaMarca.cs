using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public class CacheCategoriaMarca
    {
        private int idM;
        private string NombreMarca;
        private int idC;
        private string NombreCategoria;

        public int IdM { get => idM; set => idM = value; }
        public string NombreMarca_ { get => NombreMarca; set => NombreMarca = value; }
        public int IdC { get => idC; set => idC = value; }
        public string NombreCategoria_ { get => NombreCategoria; set => NombreCategoria = value; }
    }
}
