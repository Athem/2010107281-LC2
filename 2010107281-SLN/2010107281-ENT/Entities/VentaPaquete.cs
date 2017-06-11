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
        public int ComprobantePagoId { get; set; }
        public ComprobantePago ComprobantePago { get; set; }
        public List<MedioPago> MediosPago { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Paquete> Paquetes { get; set; }

        public VentaPaquete()
        {
            Clientes = new List<Cliente>();
            Empleados = new List<Empleado>();
            MediosPago = new List<MedioPago>();
            Paquetes = new List<Paquete>();

        }

    }
}
