using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace TeslaSoft.Entities
{
    public class Categorias : FullAuditedEntity<long>
    {

        public string GrupoCategoria { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Licencias_Categoriass> Licencias_Categoriass { get; set; }

    }
}
