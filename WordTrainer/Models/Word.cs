using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WordTrainer.Models
{
    [Serializable]
    public class Word
    {
        [Key, Required]
        public int WordID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [MaxLength(100)]
        public string Transcription { get; set; }
        [MaxLength(300)]
        public string Translation { get; set; }
        [MaxLength(1000)]
        public string Examples { get; set; }
        public bool? Favourite { get; set; } = false;
        public bool? IsForgoten { get; set; } = false;
        [Range(0, 10)]
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
