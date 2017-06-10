using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.Entities
{
    public class TipoComprobante
    {
        //public int TipoComprobanteId { get; set; }

        //public List<ComprobantePago> ComprobantePagos { get; set; }

        //public TipoComprobante()
        //{
        //    ComprobantePagos = new List<ComprobantePago>();
        //}
        //public int ComprobantePagoId { get; set; }
        //public ComprobantePago ComprobantePago { get; set; }

        public int TipoComprobanteId { get; set; }

        public int ComprobantePagoId { get; set; }
        public ComprobantePago ComprobantePago { get; set; }


    }

}
