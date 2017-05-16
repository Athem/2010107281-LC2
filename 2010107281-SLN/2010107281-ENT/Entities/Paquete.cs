﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Paquete
    {
        public int PaqueteId { get; set; }

        public List<VentaPaquete> VentaPaquetes { get; set; }

        public Paquete()
        {
            VentaPaquetes = new List<VentaPaquete>();

        }

        public int ServicioTuristico { get; set; }
        public ServicioTuristico ServicioTuristicos { get; set; }
    }
}
