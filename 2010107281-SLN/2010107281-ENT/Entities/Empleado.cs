using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Empleado : Persona
    {        
        public int EmpleadoId { get; set; }
        public int EmpleadoSueldo { get; set; }

        public int VentaId { get; set; }


        public Empleado(string Nombres, string Apellidos, string Correo, int Telefono, string Direccion, int Dni) : base(Nombres, Apellidos, Correo, Telefono, Direccion, Dni)
        {

        }
        public List<VentaPaquete> VentaPaquetes { get; set; }
        public Empleado() : base()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}
