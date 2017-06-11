using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class PersonaDto
    {
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Dirección { get; set; }
        public int Dni { get; set; }
    }
}