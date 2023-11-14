using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    [Table("Relatorios")]
    public class Relatorio
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [Required(ErrorMessage = "Código do relatório obrigatório")]
        public string Codigo { get; set; }

        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public int IdUsuario { get; set; }

        public string Data { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");

        public string Observacoes { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Relatorio()
        {
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
        }
    }
 }