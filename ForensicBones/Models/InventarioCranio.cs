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
        public int IdInventarioEsqueleto { get; set; }

        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Vomer { get; set; }
        public int ParietalEsq { get; set; }
        public int TemporalEsq { get; set; }
        public int ConchaNasalEsq { get; set; }
        public int EtmoideEsq { get; set; }
        public int LacrimalEsq { get; set; }
        public int NasalEsq { get; set; }
        public int ZigomaticoEsq { get; set; }
        public int ParietalDir { get; set; }
        public int TemporalDir { get; set; }
        public int ConchaNasalDir { get; set; }
        public int EtmoideDir { get; set; }
        public int LacrimalDir { get; set; }
        public int ZigomaticoDir { get; set; }
        public int Hioide { get; set; }
        public int CartilagemTireoide { get; set; }
        public int Mandibula { get; set; }
        public string Observacoes { get; set; }

    }
}
