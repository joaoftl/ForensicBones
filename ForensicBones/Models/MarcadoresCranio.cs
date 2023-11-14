using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    public class MarcadoresCranio
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InventarioCranio")]
        [Column(Order = 1)]
        public int IdInventarioCranio { get; set; }

        public char CristaNucal { get; set; }
        public char ProcessoMastoide { get; set; }
        public char EminenciaMentoniana { get; set; }
        public char SupraOrbital { get; set; }
        public char AreaGlabela { get; set; }
        public char ResultadoSexo { get; set; }
        public string Observacoes { get; set; }

        public char EstimativaSexo()
        {
            string marcadores = $"{CristaNucal}{ProcessoMastoide}{EminenciaMentoniana}{SupraOrbital}{AreaGlabela}";

            var contagemMarcadores = marcadores
                .ToLower()  // Convertendo para minúsculas
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            // Encontrar o caracter com a maior contagem
            char sexoEstimado = contagemMarcadores.OrderByDescending(kv => kv.Value).FirstOrDefault().Key;

            ResultadoSexo = sexoEstimado;

            return sexoEstimado;
        }

    }    
}
