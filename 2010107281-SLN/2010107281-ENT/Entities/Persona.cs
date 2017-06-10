using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Persona
    {
        //public int PersonaId { get; set; }
        //public string NombrePersona { get; set; }
        //public string ApellidoPersona { get; set; }
        //public int Dni { get; set; }
        //public string Correo { get; set; }
        //public int Telefono { get; set; }
        //public string Dirección { get; set; }

        //public Persona(string nombres, string apellido, string correo, int telefono, string dirección, int dni)
        //{
        //    NombrePersona = nombres;
        //    ApellidoPersona = apellido;
        //    Dni = dni;
        //    Correo = correo;
        //    Telefono = telefono;
        //    Dirección = dirección;

        //}
        //public Persona()
        //{

        //}
        public int PersonaId { get; set; }

        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Dirección { get; set; }
        public int NumeroDni { get; set; }

        public Persona(string nombres, string apellidopaterno, string correo, int telefono, string dirección, int numerodni)
        {
            Nombres = nombres;
            ApellidoPaterno = apellidopaterno;
            Correo = correo;
            Telefono = telefono;
            Dirección = dirección;
            NumeroDni = numerodni;
        }
        public Persona()
        {

        }

    }
}
