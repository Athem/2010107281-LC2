using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class VentaPaquete
    {
        public int VentaPaqueteId { get; set; }

        public int Paquete { get; set; }
        public Paquete Paquetes { get; set; }

        public int ComprobantePago { get; set; }
        public ComprobantePago ComprobantePagos { get; set; }

        public int MedioPago { get; set; }
        public MedioPago MedioPagos { get; set; }

        public int Empleado { get; set; }
        public Empleado Empleados { get; set; }

        public int Cliente { get; set; }
        public Cliente Clientes { get; set; }


    }
}
