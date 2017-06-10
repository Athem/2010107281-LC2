using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAlimentacionRepository Alimentaciones { get; }
        ICalificacionHospedajeRepository CalificacionHospedajes { get; }
        ICategoriaAlimentacionRepository CategoriaAlimentaciones { get; }       
        ICategoriaHospedajeRepository CategoriaHospedajes { get; }
        ICategoriaTransporteRepository CategoriaTransportes { get; }
        IComprobantePagoRepository ComprobantePagos { get; }
        IHospedajeRepository Hospedajes { get; }
        IMedioPagoRepository MedioPagos { get; }
        IPaqueteRepository Paquetes { get; }
        IPersonaRepository Personas { get; }
        IServicioHospedajeRepository ServicioHospedajes{ get; }
        IServicioTuristicoRepository ServicioTuristicos { get; }
        ITipoComprobanteRepository TipoComprobantes { get; }
        ITipoHospedajeRepository TipoHospedajes { get; }
        ITipoTransporteRepository TipoTransportes { get; }
        ITransporteRepository Transportes { get; }
        IVentaPaqueteRepository VentaPaquetes { get; }        

        int SaveChanges();

        void StateModedified(object entity);
    }
}
