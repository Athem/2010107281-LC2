using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Empleado : Persona
    {
        //public int EmpleadoId { get; set; }

        //public List<VentaPaquete> VentaPaquetes { get; set; }

        //public Empleado(string NombreEmpleado, string Apellido, string Correo, int Telefono, string Direccion, int DNI) : base(NombreEmpleado, Apellido, Correo, Telefono, Direccion, DNI)
        //{

        //}
        //public Empleado() : base()
        //{
        //    VentaPaquetes = new List<VentaPaquete>();
        //}
        public int EmpleadoId { get; set; }
        public int EmpleadoSueldo { get; set; }

        public int VentaId { get; set; }


        public Empleado(string NombreEmpleado, string ApellidoPaterno, string Correo, int Telefono, string Direccion, int NumeroDni) : base(NombreEmpleado, ApellidoPaterno, Correo, Telefono, Direccion, NumeroDni)
        {

        }
        public List<VentaPaquete> VentaPaquetes { get; set; }
        public Empleado() : base()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}
