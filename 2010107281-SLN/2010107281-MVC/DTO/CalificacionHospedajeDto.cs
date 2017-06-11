using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class CalificacionHospedajeDto
    {
        public int CalificacionHospedajeId { get; set; }
        public int HospedajeId { get; set; }
        public HospedajeDto Hospedaje { get; set; }
    }
}