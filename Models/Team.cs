﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BowlingLeague.Models
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; }

        public int CaptainID { get; set; }
    }
}
