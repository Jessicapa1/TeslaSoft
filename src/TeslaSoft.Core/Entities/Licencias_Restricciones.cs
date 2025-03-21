using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaSoft.Entities
{
    public class Licencias_Restricciones : FullAuditedEntity<long>
    {
        [ForeignKey("LicenciaId")]
        public virtual long LicenciaId { get; set; }
        [ForeignKey("RestriccionId")]
        public virtual long RestriccionId { get; set; }

        public virtual Licencias Licencias { get; set; }
        public virtual Restricciones Restricciones { get; set; }

    }
}
