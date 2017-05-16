using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class ClasificacionHospedaje
    {
        public int ClasificacionHospedajeId { get; set; }

        public int Hospedaje { get; set; }
        public Hospedaje Hospedajes { get; set; }
    }
}
