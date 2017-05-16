using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Alimentacion : ServicioTuristico
    {
        public int AlimentacionId { get; set; }
        public string NombreAlimentacion { get; set; }

        public List<CategoriaAlimentacion> CategoriasAlimentaciones { get; set; }

        public Alimentacion()
        {
            CategoriasAlimentaciones = new List<CategoriaAlimentacion>();
        }
    }
}
