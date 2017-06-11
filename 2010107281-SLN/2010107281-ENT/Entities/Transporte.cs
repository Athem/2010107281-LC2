using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Transporte : ServicioTuristico
    {
        public int TransporteId { get; set; }
        public string DescripcionTransporte { get; set; }
        public Transporte(string fecha, DateTime hora, string direccion) : base(fecha, hora, direccion)
        {
        }
        public List<TipoTransporte> TiposTransporte { get; set; }
        public List<CategoriaTransporte> CategoriasTransporte { get; set; }
        public Transporte() : base()
        {
            TiposTransporte = new List<TipoTransporte>();
            CategoriasTransporte = new List<CategoriaTransporte>();
        }
    }
}
