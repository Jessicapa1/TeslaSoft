using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaSoft.Entities
{
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

        public virtual Licencias Licencias { get; set; }
    }
}
