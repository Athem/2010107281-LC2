﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    //public class CalificacionHospedaje
    //{
    //    public int ClasificacionHospedajeId { get; set; }

    //    public int Hospedaje { get; set; }
    //    public Hospedaje Hospedajes { get; set; }
    //}
    public class CalificacionHospedaje
    {
        public int CalificacionHospedajeId { get; set; }

        public int HospedajeId { get; set; }
        public Hospedaje Hospedaje { get; set; }

    }
}
