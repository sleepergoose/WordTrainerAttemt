using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordTrainer.Models
{
    public class EFWordRepository : IWordRepository
    {
        private ApplicationContext context;

        public EFWordRepository(ApplicationContext _context) 
            => this.context = _context;
        public IEnumerable<Word> Words => context.Words;

        public void Add(Word word)
        {
            if(word != null)
            {
                context.Words.Add(word);
                context.SaveChanges();
            }
        }
    }
}
