using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class CategoriaAlimentacion
    {
        public int CategoriaAlimentacionId { get; set; }

        public List<Alimentacion> Alimentaciones { get; set; }

        public CategoriaAlimentacion()
        {
            Alimentaciones = new List<Alimentacion>();
        }
    }
}
