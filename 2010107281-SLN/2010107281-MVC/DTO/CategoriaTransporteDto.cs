﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010107281_MVC.DTO
{
    public class CategoriaTransporteDto
    {
        public int CategoriaTransporteId { get; set; }
        public int TransporteId { get; set; }
        public TransporteDto Transporte { get; set; }
    }
}