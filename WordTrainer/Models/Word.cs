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
        public string Transcription { get; set; }
        [Required]
        public string Translation { get; set; }
        public string ExamplesEn { get; set; }
        public string ExamplesRu { get; set; }
        public bool? Favourite { get; set; } = false;
        public bool? IsForgoten { get; set; } = false;
        public int? Rank { get; set; }
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
