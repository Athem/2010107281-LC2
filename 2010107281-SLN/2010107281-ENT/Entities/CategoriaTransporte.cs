using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class CategoriaTransporte
    {
        //public int CategoriaTransporteId { get; set; }

        //public List<Transporte> Transportes { get; set; }

        //public CategoriaTransporte()
        //{
        //    Transportes = new List<Transporte>();
        //}
        public int CategoriaTransporteId { get; set; }
        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}
