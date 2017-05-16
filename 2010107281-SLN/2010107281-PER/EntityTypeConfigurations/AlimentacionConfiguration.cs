using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class AlimentacionConfiguration : EntityTypeConfiguration<Alimentacion>
    {
        public AlimentacionConfiguration()
        {
            ToTable("Alimentacion");
            Property(v => v.AlimentacionId)
            .IsRequired();

            HasRequired(v => v.CategoriasAlimentaciones)
                .WithMany(g => g.Alimentaciones)
                .HasForeignKey(v => v.CategoriaAlimentacionId);

        }
    }
}
