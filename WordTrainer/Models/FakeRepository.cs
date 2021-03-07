using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordTrainer.Models
{
    public class FakeRepository : IWordRepository
    {
        public IEnumerable<Word> Words => new List<Word> { 
            new Word { WordID = 1, Text = "need", 
                Translation = new List<string> { "необходимость", "потребность", "нужда", "нуждаться", "требоваться"  },
                Rank = Rank.Unknown, Examples = new List<string> { "I need a drink", "I need you", "You will need me", "I need it" } },

            new Word { WordID = 2, Text = "work",
                Translation = new List<string> { "работа", "труд", "произведение", "дело", "дела", "работать", "трудиться", "действовать" },
                Rank = Rank.Unknown, Examples = new List<string> { "I work as engineer", "I work very hard", "My work is interesting", "New work is my hope" } },
        };     
    }
}
