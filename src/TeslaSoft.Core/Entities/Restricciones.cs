using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaSoft.Entities
{
    public class Restricciones : FullAuditedEntity<long>
    {
        public string Descripcion { get; set; }
        [ForeignKey("LicenciaId")]
        public virtual long LicenciaId { get; set; }
        public virtual List<Licencias_Restricciones> Licencias_Restricciones { get; set; }
    }
}
