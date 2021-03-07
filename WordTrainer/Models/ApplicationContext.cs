using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WordTrainer.Models
{
    public class ApplicationContext
    {
        public DbSet<Word> EnglishWords { get; set; }
    }
}
