using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class ServicioTuristicoDto
    {
        public int ServicioTuristicoId { get; set; }
        public String Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Direccion { get; set; }
    }
}