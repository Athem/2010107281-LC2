using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class ServicioHospedajeDto
    {
        public int ServicioHospedajeId { get; set; }
        public int HospedajeId { get; set; }
        public HospedajeDto Hospedaje { get; set; }
    }
}