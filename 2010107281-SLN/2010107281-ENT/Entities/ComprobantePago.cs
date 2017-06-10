using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class ComprobantePago
    {
        //public int ComprobantePagoId { get; set; }
        //public int Descripcion { get; set; }

        ////public int TipoComprobante { get; set; }
        ////public TipoComprobante TipoComprobantes { get; set; }
        //public List<TipoComprobante> TiposComprobante { get; set; }
        //public List<VentaPaquete> VentaPaquetes { get; set; }

        //public ComprobantePago()
        //{
        //    TiposComprobante = new List<TipoComprobante>();
        //    VentaPaquetes = new List<VentaPaquete>();

        //}
        public int ComprobantePagoId { get; set; }
        public int Descripcion { get; set; }

        public List<TipoComprobante> TiposComprobante { get; set; }
        public List<VentaPaquete> VentaPaquetes { get; set; }

        public ComprobantePago()
        {
            TiposComprobante = new List<TipoComprobante>();
            VentaPaquetes = new List<VentaPaquete>();

        }

    }
}
