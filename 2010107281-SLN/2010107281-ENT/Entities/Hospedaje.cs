﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Hospedaje
    {
        public int HospedajeId { get; set; }

        public List<ServicioHospedaje> ServicioHospedajes { get; set; }

        public Hospedaje()
        {
            ServicioHospedajes = new List<ServicioHospedaje>();

        }

        public int TipoHospedaje { get; set; }
        public TipoHospedaje TipoHospedajes { get; set; }

        public int ClasificacionHospedaje { get; set; }
        public ClasificacionHospedaje ClasificacionHospedajes { get; set; }

        public int CategoriaHospedaje { get; set; }
        public CategoriaHospedaje CategoriaHospedajes { get; set; }
    }
}
