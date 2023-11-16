using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    public class InventarioCranio
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InventarioEsqueleto")]
        [Column(Order = 1)]
        [Display(Name = "Id Inventário do Esqueleto")]
        public int IdInventarioEsqueleto { get; set; }

        [ForeignKey("MarcadoresCranio")]
        [Column(Order = 2)]
        [Display(Name = "Id Marcadores do Crânio")]
        public int IdMarcadoresCranio { get; set; }

        [ForeignKey("DescricaoCranio")]
        [Column(Order = 3)]
        [Display(Name = "Id Descrição do Crânio")]
        public int IdDescricaoCranio { get; set; }

        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Vomer { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public int ParietalEsq { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public int TemporalEsq { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public int ConchaNasalEsq { get; set; }
        [Display(Name = "Etmóide Esquerdo")]
        public int EtmoideEsq { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public int LacrimalEsq { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public int NasalEsq { get; set; }
        [Display(Name = "Zigomático Esquerdo")]
        public int ZigomaticoEsq { get; set; }
        [Display(Name = "Parietal Direito")]
        public int ParietalDir { get; set; }
        [Display(Name = "Temporal Direito")]
        public int TemporalDir { get; set; }
        [Display(Name = "Concha Nasal Direita")]
        public int ConchaNasalDir { get; set; }
        [Display(Name = "Etmóide Direito")]
        public int EtmoideDir { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public int LacrimalDir { get; set; }
        [Display(Name = "Zigomático Direito")]
        public int ZigomaticoDir { get; set; }
        [Display(Name = "Hióide")]
        public int Hioide { get; set; }
        [Display(Name = "Cartilagem Tireóide")]
        public int CartilagemTireoide { get; set; }
        [Display(Name = "Mandíbula")]
        public int Mandibula { get; set; }
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

    }
}
