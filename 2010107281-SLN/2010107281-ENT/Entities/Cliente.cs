using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Cliente : Persona
    {
        //public int ClienteId { get; set; }

        //public List<VentaPaquete> VentaPaquetes { get; set; }

        //public Cliente(string Nombre, string Apellido, string Correo, int Telefono, string Direccion, int DNI) : base(Nombre, Apellido, Correo, Telefono, Direccion, DNI)
        //{

        //}
        //public Cliente() : base()
        //{
        //    VentaPaquetes = new List<VentaPaquete>();
        //}
        public int ClienteId { get; set; }
        public int NumeroCuenta { get; set; }
        
        public List<VentaPaquete> VentaPaquetes { get; set; }

        public Cliente(string Nombre, string ApellidoPaterno, string Correo, int Telefono, string Direccion, int NumeroDni) : base(Nombre, ApellidoPaterno, Correo, Telefono, Direccion, NumeroDni)
        {

        }
        public Cliente() : base()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}
