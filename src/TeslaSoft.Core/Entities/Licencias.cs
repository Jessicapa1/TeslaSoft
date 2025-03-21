using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaSoft.Entities
{
    public class Licencias : FullAuditedEntity<long>
    {
        public DateTime FechaDeExpedicion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual long CategoriaId { get; set; }

        public virtual List<Licencias> Categorias { get; set; }
    }
}
