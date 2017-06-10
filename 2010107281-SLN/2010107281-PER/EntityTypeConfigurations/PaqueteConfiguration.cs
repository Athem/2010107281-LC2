using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class PaqueteConfiguration : EntityTypeConfiguration<Paquete>
    {
        public PaqueteConfiguration()
        {
            //Table Configurations
            ToTable("Paquetes");

            HasKey(c => c.PaqueteId);
            //Relations Configurations 
            HasMany(c => c.ServiciosTurisctico)
                .WithMany(c => c.Paquetes)
            .Map(m =>
            {
                m.ToTable("PaquetesServiciosTuristicos");
                m.MapLeftKey("PaquetesId");
                m.MapRightKey("ServicioTuristicoId");
            });

        }
    }
}
