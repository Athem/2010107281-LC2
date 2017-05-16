using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }

        public List<VentaPaquete> VentaPaquetes { get; set; }

        public Cliente()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}
