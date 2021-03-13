using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordTrainer.Models;

namespace WordTrainer.Components
{
    public class WordViewComponent : ViewComponent
    {
        IWordRepository repository;
        public WordViewComponent(IWordRepository repo) => repository = repo;

        public IViewComponentResult Invoke(Word word)
        {
            return View("Word", word);
        }
    }
}
