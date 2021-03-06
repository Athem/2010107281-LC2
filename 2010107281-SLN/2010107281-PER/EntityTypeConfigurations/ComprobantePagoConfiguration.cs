﻿using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            //Table Configurations
            ToTable("ComprobantesPago");

            HasKey(c => c.ComprobantePagoId);

            //Relations Configurations 
            HasMany(c => c.TiposComprobante)
                .WithRequired(c => c.ComprobantePago);
        }
    }
}
