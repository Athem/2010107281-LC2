﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class CategoriaAlimentacion
    {        
        public int CategoriaAlimentacionId { get; set; }

        public List<Alimentacion> Alimentacion { get; set; }
        public CategoriaAlimentacion()
        {
            Alimentacion = new List<Alimentacion>();
        }

    }
}
