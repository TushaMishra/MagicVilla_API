using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.dto
{
    public class VillaNumberCreateDTO
    {
        public int VillNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
    }
}
