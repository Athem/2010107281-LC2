﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class TipoComprobanteDto
    {
        public int TipoComprobanteId { get; set; }
        public int ComprobantePagoId { get; set; }
        public ComprobantePagoDto ComprobantePago { get; set; }
    }
}