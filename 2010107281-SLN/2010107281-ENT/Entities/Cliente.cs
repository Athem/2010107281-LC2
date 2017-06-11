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
        public int NumeroCuenta { get; set; }
        
        public List<VentaPaquete> VentaPaquetes { get; set; }

        public Cliente(string Nombres, string Apellidos, string Correo, int Telefono, string Direccion, int Dni) : base(Nombres, Apellidos, Correo, Telefono, Direccion, Dni)
        {

        }
        public Cliente() : base()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}
