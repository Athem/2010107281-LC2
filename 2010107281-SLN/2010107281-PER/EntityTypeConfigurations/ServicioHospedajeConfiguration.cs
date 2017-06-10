using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class ServicioHospedajeConfiguration : EntityTypeConfiguration<ServicioHospedaje>
    {
        public ServicioHospedajeConfiguration()
        {
            //Table Configurations
            ToTable("ServiciosHospedaje");

            HasKey(c => c.ServicioHospedajeId);

        }
    }
}
