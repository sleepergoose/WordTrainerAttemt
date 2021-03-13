using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WordTrainer.Models
{
    public class Word
    {
        [Key, Required]
        public int WordID { get; set; }
        [Required]
        public string Text { get; set; }
        public string Translation { get; set; }
        public string Examples { get; set; }
        public bool? Favourite { get; set; } = false;
        public bool? IsForgoten { get; set; } = false;
        public Rank? Rank { get; set; }
    }

    public enum Rank
    {
        Unknown,
        Known,
        Used,
        Familiar,
        Strong
    }
}
