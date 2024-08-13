﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.dto
{
    public class VillaNumberDTO
    {
        public int VillNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
    }
}
