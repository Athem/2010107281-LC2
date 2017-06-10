using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class VentaPaquete
    {
        //public int VentaPaqueteId { get; set; }

        ////public int Paquete { get; set; }
        ////public Paquete Paquetes { get; set; }

        //public int ComprobantePago { get; set; }
        //public ComprobantePago ComprobantePagos { get; set; }

        ////public int MedioPago { get; set; }
        ////public MedioPago MedioPagos { get; set; }

        ////public int Empleado { get; set; }
        ////public Empleado Empleados { get; set; }

        ////public int Cliente { get; set; }
        ////public Cliente Clientes { get; set; }

        //public List<MedioPago> MediosPago { get; set; }
        //public List<Cliente> Clientes { get; set; }
        //public List<Empleado> Empleados { get; set; }
        //public List<Paquete> Paquetes { get; set; }

        //public VentaPaquete()
        //{
        //    Clientes = new List<Cliente>();
        //    Empleados = new List<Empleado>();
        //    MediosPago = new List<MedioPago>();
        //    Paquetes = new List<Paquete>();

        //}

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
