using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class CategoriaHospedaje
    {
        public int CategoriaHospedajeId { get; set; }

        public int Hospedaje { get; set; }

        public Hospedaje Hospedajes { get; set; }


    }
}
