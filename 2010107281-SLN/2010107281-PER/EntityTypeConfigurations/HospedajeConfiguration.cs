using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class HospedajeConfiguration : EntityTypeConfiguration<Hospedaje>
    {
        public HospedajeConfiguration()
        {
            //Table Configurations
            ToTable("Hospedajes");

            HasKey(c => c.HospedajeId);

            //Relations Configurations
            HasRequired(c => c.TipoHospedaje)
                .WithRequiredPrincipal(c => c.Hospedaje);

            HasRequired(c => c.CalificacionHospedaje)
              .WithRequiredPrincipal(c => c.Hospedaje);

            HasRequired(c => c.CategoriaHospedaje)
              .WithRequiredPrincipal(c => c.Hospedaje);

            HasMany(c => c.ServiciosHospedaje)
              .WithRequired(c => c.Hospedaje);

        }
    }
}
