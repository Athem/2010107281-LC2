using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Persona
    {
            
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Dirección { get; set; }
        public int Dni { get; set; }

        public Persona(string nombres, string apellidos, string correo, int telefono, string dirección, int dni)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Correo = correo;
            Telefono = telefono;
            Dirección = dirección;
            Dni = dni;
        }
        public Persona()
        {
        }

    }
}
