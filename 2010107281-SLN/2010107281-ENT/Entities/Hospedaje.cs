using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Hospedaje : ServicioTuristico
    {
        public int HospedajeId { get; set; }
        public string Descripcion { get; set; }
        public int TipoHospedajeId { get; set; }
        public TipoHospedaje TipoHospedaje { get; set; }

        public int CalificacionHospedajeId { get; set; }
        public CalificacionHospedaje CalificacionHospedaje { get; set; }

        public int CategoriaHospedajeId { get; set; }
        public CategoriaHospedaje CategoriaHospedaje { get; set; }

        public Hospedaje(string fecha, DateTime hora, string direccion) : base(fecha, hora, direccion)
        {

        }
        public List<ServicioHospedaje> ServiciosHospedaje { get; set; }

        public Hospedaje() : base()
        {
            ServiciosHospedaje = new List<ServicioHospedaje>();
        }
    }
}
