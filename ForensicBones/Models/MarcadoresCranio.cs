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
        [Display(Name = "Id Inventário Crânio")]
        public int IdInventarioCranio { get; set; }
        [Display(Name = "Crista Nucal")]
        public char CristaNucal { get; set; }
        [Display(Name = "Processo Mastóide")]
        public char ProcessoMastoide { get; set; }
        [Display(Name = "Eminência Mentoniana")]
        public char EminenciaMentoniana { get; set; }
        [Display(Name = "Supra Orbital")]
        public char SupraOrbital { get; set; }
        [Display(Name = "Área da Glabela")]
        public char AreaGlabela { get; set; }
        [Display(Name = "Resultado da Estimativa de Sexo")]
        public char ResultadoSexo { get; set; }
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "Cálculo da Estimativa de Sexo")]
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
