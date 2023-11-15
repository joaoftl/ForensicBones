using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    public class DescricaoCranio
    {
        [Key]
        [Display(Name = "Id Descrição do Crânio")]
        public int Id { get; set; }

        [ForeignKey("InventarioCranio")]
        [Column(Order = 1)]
        [Display(Name = "Id Inventário do Crânio")]
        public int IdInventarioCranio { get; set; }

        public string Frontal { get; set; }
        public string Ocipital { get; set; }
        public string Esfenoide { get; set; }
        public string Maxilar { get; set; }
        public string Vomer { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public string ParietalEsq { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public string TemporalEsq { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public string ConchaNasalEsq { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public string EtmoideEsq { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public string LacrimalEsq { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public string NasalEsq { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public string ZigomaticoEsq { get; set; }
        [Display(Name = "Parietal Direito")]
        public string ParietalDir { get; set; }
        [Display(Name = "Temporal Direito")]
        public string TemporalDir { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public string ConchaNasalDir { get; set; }
        [Display(Name = "Etmoide Direito")]
        public string EtmoideDir { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public string LacrimalDir { get; set; }
        [Display(Name = "Zigomático Direito")]
        public string ZigomaticoDir { get; set; }
        public string Hioide { get; set; }
        [Display(Name = "Cartilagem Tireóide")]
        public string CartilagemTireoide { get; set; }
        public string Mandibula { get; set; }
    }
}
