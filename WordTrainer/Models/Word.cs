using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordTrainer.Models
{
    public class Word
    {
        [Required]
        public int WordID { get; set; }
        public string Text { get; set; }
        public IEnumerable<string> Translation { get; set; }
        public IEnumerable<string> Examples { get; set; }
        public bool Favourite { get; set; } = false;
        public bool IsForgoten { get; set; } = false;
        public Rank Rank { get; set; }
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
