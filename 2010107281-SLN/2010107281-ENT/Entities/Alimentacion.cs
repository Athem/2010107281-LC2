using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class Alimentacion : ServicioTuristico
    {
        //public int AlimentacionId { get; set; }
        //public string NombreAlimentacion { get; set; }

        //public List<CategoriaAlimentacion> CategoriasAlimentaciones { get; set; }

        //public Alimentacion():base()
        //{
        //    CategoriasAlimentaciones = new List<CategoriaAlimentacion>();
        //}
        public int AlimentacionId { get; set; }


        public Alimentacion(string fecha, DateTime hora, string direccion) : base(fecha, hora, direccion)
        {

        }
        public List<CategoriaAlimentacion> CategoriasAlimentacion { get; set; }

        public Alimentacion() : base()
        {
            CategoriasAlimentacion = new List<CategoriaAlimentacion>();
        }

    }
}
