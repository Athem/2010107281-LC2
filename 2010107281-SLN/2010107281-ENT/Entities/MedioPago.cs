using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class MedioPago
    {
        //public int MedioPagoId { get; set; }

        //public List<VentaPaquete> VentaPaquetes { get; set; }

        //public MedioPago()
        //{
        //    VentaPaquetes = new List<VentaPaquete>();
        //}
        public int MedioPagoId { get; set; }

        public List<VentaPaquete> VentaPaquetes { get; set; }
        public MedioPago()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }

    }
}
