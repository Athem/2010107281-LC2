using _2010107281_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.Repositories
{
    public class UnityOfWork : IUnityofWork
    {
        private readonly PaqueteTuristicoContext _Context;

        public ICategoriaHospedajeRepository CategoriaHospedaje { get; private set; }

        public ICategoriaTransporteRepository CategoriaTransporte { get; private set; }

        public IComprobantePagoRepository ComprobantePago { get; private set; }

        public IAlimentacionRepository Alimentacion { get; private set; }

        public ICalificacionHospedajeRepository CalificacionHospedaje { get; private set; }

        public ICategoriaAlimentacionRepository CategoriaAlimentacion { get; private set; }

        public IClienteRepository Cliente { get; private set; }

        public IEmpleadoRepository Empleado { get; private set; }

        public IHospedajeRepository Hospejade { get; private set; }

        public IMedioPagoRepository MedioPago { get; private set; }

        public IPaqueteRepository Paquete { get; private set; }

        public IServicioHospedajeRepository ServicioHospedaje { get; private set; }

        public IServicioTuristicoRepository ServicioTuristico { get; private set; }

        public ITipoComprobanteRepository TipoComprobante { get; private set; }

        public ITipoHospedajeRepository TipoHospedaje { get; private set; }

        public ITipoTransporteRepository TipoTransporte { get; private set; }

        public ITransporteRepository Transporte { get; private set; }

        public IVentaPaqueteRepository VentaPaquete { get; private set; }

        public IPersonaRepository Persona { get; private set; }

        public UnityOfWork()
        {

        }
        public UnityOfWork(PaqueteTuristicoContext context)
        {
            _Context = context;

            Alimentacion = new AlimentacionRepository(_Context);
            CategoriaAlimentacion = new CategoriaAlimentacionRepository(_Context);
            CategoriaHospedaje = new CategoriaHospedajeRepository(_Context);
            CategoriaTransporte = new CategoriaTransporteRepository(_Context);
            CalificacionHospedaje = new CalificacionHospedajeRepository(_Context);
            ComprobantePago = new ComprobantePagoRepository(_Context);
            Hospejade = new HospedajeRepository(_Context);
            MedioPago = new MedioPagoRepository(_Context);
            Paquete = new PaqueteRepository(_Context);
            Persona = new PersonaRepository(_Context);
            ServicioHospedaje = new ServicioHospedajeRepository(_Context);
            ServicioTuristico = new ServicioTuristicoRepository(_Context);
            TipoComprobante = new TipoComprobanteRepository(_Context);
            TipoHospedaje = new TipoHospedajeRepository(_Context);
            TipoTransporte = new TipoTransporteRepository(_Context);
            Transporte = new TransporteRepository(_Context);
            VentaPaquete = new VentaPaqueteRepository(_Context);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChange()
        {
            throw new NotImplementedException();
        }

        public void StateModedified(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
