using System.Collections.Generic;

namespace WordTrainer.Models
{
    public interface IWordRepository
    {
        IEnumerable<Word> Words { get; }
        void Add(Word word);
    }
}
