﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class ServicioTuristico
    {
        public int ServicioTuristicoId { get; set; }

        public List<Paquete> Paquetes { get; set; }

        public ServicioTuristico()
        {
            Paquetes = new List<Paquete>();
        }
    }
}
