using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class HospedajeDto
    {
        public int HospedajeId { get; set; }
        public string Descripcion { get; set; }
        public int TipoHospedajeId { get; set; }
        public TipoHospedajeDto TipoHospedaje { get; set; }
    }
}