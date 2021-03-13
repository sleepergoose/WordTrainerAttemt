using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WordTrainer.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }


}
