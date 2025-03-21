using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaSoft.Entities
{
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
