namespace _2010107281_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turismo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServicioTuristicos",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false, identity: true),
                        Fecha = c.String(),
                        Hora = c.DateTime(nullable: false),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId);
            
            CreateTable(
                "dbo.CategoriasAlimentacion",
                c => new
                    {
                        CategoriaAlimentacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaAlimentacionId);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        PaqueteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PaqueteId);
            
            CreateTable(
                "dbo.CalificacionHospedaje",
                c => new
                    {
                        CalificacionHospedajeId = c.Int(nullable: false),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalificacionHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.CalificacionHospedajeId)
                .Index(t => t.CalificacionHospedajeId);
            
            CreateTable(
                "dbo.CategoriasHospedaje",
                c => new
                    {
                        CategoriaHospedajeId = c.Int(nullable: false),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.CategoriaHospedajeId)
                .Index(t => t.CategoriaHospedajeId);
            
            CreateTable(
                "dbo.ServiciosHospedaje",
                c => new
                    {
                        ServicioHospedajeId = c.Int(nullable: false, identity: true),
                        HospedajeId = c.Int(nullable: false),
                        Hospedaje_ServicioTuristicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.Hospedaje_ServicioTuristicoId)
                .Index(t => t.Hospedaje_ServicioTuristicoId);
            
            CreateTable(
                "dbo.TiposHospedaje",
                c => new
                    {
                        TipoHospedajeId = c.Int(nullable: false),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.TipoHospedajeId)
                .Index(t => t.TipoHospedajeId);
            
            CreateTable(
                "dbo.CategoriasTransporte",
                c => new
                    {
                        CategoriaTransporteId = c.Int(nullable: false, identity: true),
                        TransporteId = c.Int(nullable: false),
                        Transporte_ServicioTuristicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaTransporteId)
                .ForeignKey("dbo.Transportes", t => t.Transporte_ServicioTuristicoId)
                .Index(t => t.Transporte_ServicioTuristicoId);
            
            CreateTable(
                "dbo.TiposTransporte",
                c => new
                    {
                        TipoTransporteId = c.Int(nullable: false, identity: true),
                        TransporteId = c.Int(nullable: false),
                        Transporte_ServicioTuristicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTransporteId)
                .ForeignKey("dbo.Transportes", t => t.Transporte_ServicioTuristicoId)
                .Index(t => t.Transporte_ServicioTuristicoId);
            
            CreateTable(
                "dbo.VentaPaquetes",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false, identity: true),
                        ComprobantePagoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaPaqueteId)
                .ForeignKey("dbo.ComprobantesPago", t => t.ComprobantePagoId, cascadeDelete: true)
                .Index(t => t.ComprobantePagoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        NumeroCuenta = c.Int(nullable: false),
                        PersonaId = c.Int(nullable: false),
                        Nombres = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Correo = c.String(),
                        Telefono = c.Int(nullable: false),
                        Dirección = c.String(),
                        NumeroDni = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.ComprobantesPago",
                c => new
                    {
                        ComprobantePagoId = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComprobantePagoId);
            
            CreateTable(
                "dbo.TiposComprobante",
                c => new
                    {
                        TipoComprobanteId = c.Int(nullable: false, identity: true),
                        ComprobantePagoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoComprobanteId)
                .ForeignKey("dbo.ComprobantesPago", t => t.ComprobantePagoId, cascadeDelete: true)
                .Index(t => t.ComprobantePagoId);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        EmpleadoSueldo = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                        PersonaId = c.Int(nullable: false),
                        Nombres = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Correo = c.String(),
                        Telefono = c.Int(nullable: false),
                        Dirección = c.String(),
                        NumeroDni = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.MediosPago",
                c => new
                    {
                        MedioPagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MedioPagoId);
            
            CreateTable(
                "dbo.AlimentacionCategoriasAlimento",
                c => new
                    {
                        AlimentacionId = c.Int(nullable: false),
                        AlimentaionCategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AlimentacionId, t.AlimentaionCategoriaId })
                .ForeignKey("dbo.Alimentacion", t => t.AlimentacionId, cascadeDelete: true)
                .ForeignKey("dbo.CategoriasAlimentacion", t => t.AlimentaionCategoriaId, cascadeDelete: true)
                .Index(t => t.AlimentacionId)
                .Index(t => t.AlimentaionCategoriaId);
            
            CreateTable(
                "dbo.PaquetesServiciosTuristicos",
                c => new
                    {
                        PaquetesId = c.Int(nullable: false),
                        ServicioTuristicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PaquetesId, t.ServicioTuristicoId })
                .ForeignKey("dbo.Paquetes", t => t.PaquetesId, cascadeDelete: true)
                .ForeignKey("dbo.ServicioTuristicos", t => t.ServicioTuristicoId, cascadeDelete: true)
                .Index(t => t.PaquetesId)
                .Index(t => t.ServicioTuristicoId);
            
            CreateTable(
                "dbo.VentaPaquetesClientes",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VentaPaqueteId, t.ClienteId })
                .ForeignKey("dbo.VentaPaquetes", t => t.VentaPaqueteId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.VentaPaqueteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.VentaPaquetesEmpleados",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VentaPaqueteId, t.EmpleadoId })
                .ForeignKey("dbo.VentaPaquetes", t => t.VentaPaqueteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleados", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.VentaPaqueteId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.VentaPaquetesMediosPago",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false),
                        MedioPagoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VentaPaqueteId, t.MedioPagoId })
                .ForeignKey("dbo.VentaPaquetes", t => t.VentaPaqueteId, cascadeDelete: true)
                .ForeignKey("dbo.MediosPago", t => t.MedioPagoId, cascadeDelete: true)
                .Index(t => t.VentaPaqueteId)
                .Index(t => t.MedioPagoId);
            
            CreateTable(
                "dbo.VentaPaquetesPaquetes",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false),
                        PaqueteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VentaPaqueteId, t.PaqueteId })
                .ForeignKey("dbo.VentaPaquetes", t => t.VentaPaqueteId, cascadeDelete: true)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteId, cascadeDelete: true)
                .Index(t => t.VentaPaqueteId)
                .Index(t => t.PaqueteId);
            
            CreateTable(
                "dbo.Alimentacion",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false),
                        AlimentacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId)
                .ForeignKey("dbo.ServicioTuristicos", t => t.ServicioTuristicoId)
                .Index(t => t.ServicioTuristicoId);
            
            CreateTable(
                "dbo.Hospedajes",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false),
                        HospedajeId = c.Int(nullable: false),
                        Descripcion = c.String(),
                        TipoHospedajeId = c.Int(nullable: false),
                        CalificacionHospedajeId = c.Int(nullable: false),
                        CategoriaHospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId)
                .ForeignKey("dbo.ServicioTuristicos", t => t.ServicioTuristicoId)
                .Index(t => t.ServicioTuristicoId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        DescripcionTransporte = c.String(),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId)
                .ForeignKey("dbo.ServicioTuristicos", t => t.ServicioTuristicoId)
                .Index(t => t.ServicioTuristicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transportes", "ServicioTuristicoId", "dbo.ServicioTuristicos");
            DropForeignKey("dbo.Hospedajes", "ServicioTuristicoId", "dbo.ServicioTuristicos");
            DropForeignKey("dbo.Alimentacion", "ServicioTuristicoId", "dbo.ServicioTuristicos");
            DropForeignKey("dbo.VentaPaquetesPaquetes", "PaqueteId", "dbo.Paquetes");
            DropForeignKey("dbo.VentaPaquetesPaquetes", "VentaPaqueteId", "dbo.VentaPaquetes");
            DropForeignKey("dbo.VentaPaquetesMediosPago", "MedioPagoId", "dbo.MediosPago");
            DropForeignKey("dbo.VentaPaquetesMediosPago", "VentaPaqueteId", "dbo.VentaPaquetes");
            DropForeignKey("dbo.VentaPaquetesEmpleados", "EmpleadoId", "dbo.Empleados");
            DropForeignKey("dbo.VentaPaquetesEmpleados", "VentaPaqueteId", "dbo.VentaPaquetes");
            DropForeignKey("dbo.VentaPaquetes", "ComprobantePagoId", "dbo.ComprobantesPago");
            DropForeignKey("dbo.TiposComprobante", "ComprobantePagoId", "dbo.ComprobantesPago");
            DropForeignKey("dbo.VentaPaquetesClientes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.VentaPaquetesClientes", "VentaPaqueteId", "dbo.VentaPaquetes");
            DropForeignKey("dbo.PaquetesServiciosTuristicos", "ServicioTuristicoId", "dbo.ServicioTuristicos");
            DropForeignKey("dbo.PaquetesServiciosTuristicos", "PaquetesId", "dbo.Paquetes");
            DropForeignKey("dbo.TiposTransporte", "Transporte_ServicioTuristicoId", "dbo.Transportes");
            DropForeignKey("dbo.CategoriasTransporte", "Transporte_ServicioTuristicoId", "dbo.Transportes");
            DropForeignKey("dbo.TiposHospedaje", "TipoHospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.ServiciosHospedaje", "Hospedaje_ServicioTuristicoId", "dbo.Hospedajes");
            DropForeignKey("dbo.CategoriasHospedaje", "CategoriaHospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.CalificacionHospedaje", "CalificacionHospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.AlimentacionCategoriasAlimento", "AlimentaionCategoriaId", "dbo.CategoriasAlimentacion");
            DropForeignKey("dbo.AlimentacionCategoriasAlimento", "AlimentacionId", "dbo.Alimentacion");
            DropIndex("dbo.Transportes", new[] { "ServicioTuristicoId" });
            DropIndex("dbo.Hospedajes", new[] { "ServicioTuristicoId" });
            DropIndex("dbo.Alimentacion", new[] { "ServicioTuristicoId" });
            DropIndex("dbo.VentaPaquetesPaquetes", new[] { "PaqueteId" });
            DropIndex("dbo.VentaPaquetesPaquetes", new[] { "VentaPaqueteId" });
            DropIndex("dbo.VentaPaquetesMediosPago", new[] { "MedioPagoId" });
            DropIndex("dbo.VentaPaquetesMediosPago", new[] { "VentaPaqueteId" });
            DropIndex("dbo.VentaPaquetesEmpleados", new[] { "EmpleadoId" });
            DropIndex("dbo.VentaPaquetesEmpleados", new[] { "VentaPaqueteId" });
            DropIndex("dbo.VentaPaquetesClientes", new[] { "ClienteId" });
            DropIndex("dbo.VentaPaquetesClientes", new[] { "VentaPaqueteId" });
            DropIndex("dbo.PaquetesServiciosTuristicos", new[] { "ServicioTuristicoId" });
            DropIndex("dbo.PaquetesServiciosTuristicos", new[] { "PaquetesId" });
            DropIndex("dbo.AlimentacionCategoriasAlimento", new[] { "AlimentaionCategoriaId" });
            DropIndex("dbo.AlimentacionCategoriasAlimento", new[] { "AlimentacionId" });
            DropIndex("dbo.TiposComprobante", new[] { "ComprobantePagoId" });
            DropIndex("dbo.VentaPaquetes", new[] { "ComprobantePagoId" });
            DropIndex("dbo.TiposTransporte", new[] { "Transporte_ServicioTuristicoId" });
            DropIndex("dbo.CategoriasTransporte", new[] { "Transporte_ServicioTuristicoId" });
            DropIndex("dbo.TiposHospedaje", new[] { "TipoHospedajeId" });
            DropIndex("dbo.ServiciosHospedaje", new[] { "Hospedaje_ServicioTuristicoId" });
            DropIndex("dbo.CategoriasHospedaje", new[] { "CategoriaHospedajeId" });
            DropIndex("dbo.CalificacionHospedaje", new[] { "CalificacionHospedajeId" });
            DropTable("dbo.Transportes");
            DropTable("dbo.Hospedajes");
            DropTable("dbo.Alimentacion");
            DropTable("dbo.VentaPaquetesPaquetes");
            DropTable("dbo.VentaPaquetesMediosPago");
            DropTable("dbo.VentaPaquetesEmpleados");
            DropTable("dbo.VentaPaquetesClientes");
            DropTable("dbo.PaquetesServiciosTuristicos");
            DropTable("dbo.AlimentacionCategoriasAlimento");
            DropTable("dbo.MediosPago");
            DropTable("dbo.Empleados");
            DropTable("dbo.TiposComprobante");
            DropTable("dbo.ComprobantesPago");
            DropTable("dbo.Clientes");
            DropTable("dbo.VentaPaquetes");
            DropTable("dbo.TiposTransporte");
            DropTable("dbo.CategoriasTransporte");
            DropTable("dbo.TiposHospedaje");
            DropTable("dbo.ServiciosHospedaje");
            DropTable("dbo.CategoriasHospedaje");
            DropTable("dbo.CalificacionHospedaje");
            DropTable("dbo.Paquetes");
            DropTable("dbo.CategoriasAlimentacion");
            DropTable("dbo.ServicioTuristicos");
        }
    }
}
