using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    [Table("InventariosEsqueleto")]
    public class InventarioEsqueleto
    {
        [Key]
        public int Id { get; set; }
        public string Observacoes { get; set; }

        [ForeignKey("Relatorio")]
        [Column(Order = 2)]
        public int idRelatorio { get; set; }
     
        }
    }

   
}
