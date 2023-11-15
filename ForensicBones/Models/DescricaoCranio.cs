using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones.Models
{
    public class DescricaoCranio
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InventarioCranio")]
        [Column(Order = 1)]
        public int IdInventarioCranio { get; set; }

        public string Frontal { get; set; }
        public string Ocipital { get; set; }
        public string Esfenoide { get; set; }
        public string Maxilar { get; set; }
        public string Vomer { get; set; }
        public string ParietalEsq { get; set; }
        public string TemporalEsq { get; set; }
        public string ConchaNasalEsq { get; set; }
        public string EtmoideEsq { get; set; }
        public string LacrimalEsq { get; set; }
        public string NasalEsq { get; set; }
        public string ZigomaticoEsq { get; set; }
        public string ParietalDir { get; set; }
        public string TemporalDir { get; set; }
        public string ConchaNasalDir { get; set; }
        public string EtmoideDir { get; set; }
        public string LacrimalDir { get; set; }
        public string ZigomaticoDir { get; set; }
        public string Hioide { get; set; }
        public string CartilagemTireoide { get; set; }
        public string Mandibula { get; set; }
    }
}
