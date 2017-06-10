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
            //ToTable("Alimentacion");
            //Property(v => v.AlimentacionId)
            //.IsRequired();

            //HasRequired(v => v.CategoriasAlimentaciones)
            //    .WithMany(g => g.Alimentaciones)
            //    .HasForeignKey(v => v.CategoriaAlimentacionId);
            
            //Table Configurations
            ToTable("Alimentacion");

            HasKey(c => c.AlimentacionId);

            //Relations Configurations
            HasMany(c => c.CategoriasAlimentacion)
                .WithMany(c => c.Alimentacion)
                .Map(m =>
                {
                    m.ToTable("AlimentacionCategoriasAlimento");
                    m.MapLeftKey("AlimentacionId");
                    m.MapRightKey("AlimentaionCategoriaId");
                });
        }
    }
}
