using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.IRepositories
{
    public interface IUnityofWork : IDisposable
    {
        ICategoriaHospedajeRepository CategoriaHospedaje { get; }
        ICategoriaTransporteRepository CategoriaTransporte { get; }
        IComprobantePagoRepository ComprobantePago { get; }
        IAlimentacionRepository Alimentacion { get; }
        ICalificacionHospedajeRepository CalificacionHospedaje { get; }
        ICategoriaAlimentacionRepository CategoriaAlimentacion { get; }
        IClienteRepository Cliente { get; }
        IEmpleadoRepository Empleado { get; }
        IHospedajeRepository Hospejade { get; }
        IMedioPagoRepository MedioPago { get; }
        IPaqueteRepository Paquete { get; }
        IServicioHospedajeRepository ServicioHospedaje { get; }
        IServicioTuristicoRepository ServicioTuristico { get; }
        ITipoComprobanteRepository TipoComprobante { get; }
        ITipoHospedajeRepository TipoHospedaje { get; }
        ITipoTransporteRepository TipoTransporte { get; }
        ITransporteRepository Transporte { get; }
        IVentaPaqueteRepository VentaPaquete { get; }
        IPersonaRepository Persona { get; }

        int SaveChange();

        void StateModedified(object entity);
    }
}
