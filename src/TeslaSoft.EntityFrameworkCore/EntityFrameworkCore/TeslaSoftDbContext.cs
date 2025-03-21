using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TeslaSoft.Authorization.Roles;
using TeslaSoft.Authorization.Users;
using TeslaSoft.MultiTenancy;
using Abp.Domain.Entities.Auditing;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using System;

namespace TeslaSoft.EntityFrameworkCore
{
    public class TeslaSoftDbContext : AbpZeroDbContext<Tenant, Role, User, TeslaSoftDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public TeslaSoftDbContext(DbContextOptions<TeslaSoftDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspirantes> Aspirantes { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<Licencias_Restricciones> Licencias_Restricciones { get; set; }
        public virtual DbSet<Restricciones> Restricciones { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Licencias_Categoriass> Licencias_Categoriass { get; set; }
    }

    public class Aspirantes : FullAuditedEntity<long>
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public long DocumentNumber { get; set; }

        [ForeignKey("LicenciasId")]
        public virtual long LicenciasId { get; set; }

        public virtual Licencias Licencias {get;set;}
    }

    public class Licencias : FullAuditedEntity<long>
    {
        public DateTime FechaDeExpedicion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual long CategoriaId { get; set; }

        public virtual List<Licencias> Categorias { get; set; }
    }
    public class Licencias_Restricciones : FullAuditedEntity<long>
    {
        [ForeignKey("LicenciaId")]
        public virtual long LicenciaId { get; set; }
        [ForeignKey("RestriccionId")]
        public virtual long RestriccionId { get; set; }

        public virtual Licencias Licencias { get; set; }
        public virtual Restricciones Restricciones { get; set; }

    }
    public class Restricciones : FullAuditedEntity<long>
    {
        public string Descripcion { get; set; }
        [ForeignKey("LicenciaId")]
        public virtual long LicenciaId { get; set; }
        public virtual List<Licencias_Restricciones> Licencias_Restricciones { get; set; }
    }
    public class Categorias : FullAuditedEntity<long>
    {

        public string GrupoCategoria { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Licencias_Categoriass> Licencias_Categoriass { get; set; }

    }
    public class Licencias_Categoriass : FullAuditedEntity<long>
    {
        [ForeignKey("LicenciaId")]
        public virtual long LicenciaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual long CategoriaId { get; set; }

        public virtual Licencias Licencias { get; set; }
        public virtual Categorias Categorias { get; set; }

    }
}
