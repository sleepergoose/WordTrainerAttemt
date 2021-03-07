using System.Collections.Generic;

namespace WordTrainer.Models
{
    public interface IWordRepository
    {
        public IEnumerable<Word> Words { get; }
    }
}
