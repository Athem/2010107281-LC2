﻿using _2010107281_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_PER.EntityTypeConfigurations
{
    public class VentaPaqueteConfiguration : EntityTypeConfiguration<VentaPaquete>
    {
        public VentaPaqueteConfiguration()
        {
            //Table Configurations
            ToTable("VentaPaquetes");

            HasKey(c => c.VentaPaqueteId);

            //Relations Configurations
            HasMany(c => c.Empleados)
                .WithMany(c => c.VentaPaquetes)
                 .Map(m =>
                 {
                     m.ToTable("VentaPaquetesEmpleados");
                     m.MapLeftKey("VentaPaqueteId");
                     m.MapRightKey("EmpleadoId");
                 });
            HasMany(c => c.Clientes)
                .WithMany(c => c.VentaPaquetes)
                 .Map(m =>
                 {
                     m.ToTable("VentaPaquetesClientes");
                     m.MapLeftKey("VentaPaqueteId");
                     m.MapRightKey("ClienteId");
                 });


            HasMany(c => c.MediosPago)
               .WithMany(c => c.VentaPaquetes)
            .Map(m =>
            {
                m.ToTable("VentaPaquetesMediosPago");
                m.MapLeftKey("VentaPaqueteId");
                m.MapRightKey("MedioPagoId");
            });

            HasMany(c => c.Paquetes)
               .WithMany(c => c.VentaPaquetes)
             .Map(m =>
             {
                 m.ToTable("VentaPaquetesPaquetes");
                 m.MapLeftKey("VentaPaqueteId");
                 m.MapRightKey("PaqueteId");
             });

            HasRequired(c => c.ComprobantePago)
              .WithMany(c => c.VentaPaquetes);
        }
    }
}
