using _2010107281_ENT.Entities;
using _2010107281_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.Repositories
{
    public class PaqueteRepository : Repository<Paquete>, IPaqueteRepository
    {
        public PaqueteRepository(PaqueteTuristicoContext context) : base(context)
        {

        }
    }
}
