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
        [UIHint("Text")]
        [Display(Name = "Word")]
        // [DisplayFormat(DataFormatString = "{0:3}", ApplyFormatInEditMode = true)]
        public string Text { get; set; }

        [MaxLength(100)]
        [UIHint("Text")]
        [Display(Name = "Transcription")]
        public string Transcription { get; set; }

        [MaxLength(300)]
        [UIHint("Text")]
        [Display(Name = "Translations")]
        public string Translation { get; set; }

        [MaxLength(1000)]
        [UIHint("Text")]
        [Display(Name = "Examples")]

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
