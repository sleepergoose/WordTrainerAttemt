using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WordTrainer.Models;

namespace WordTrainer.Controllers
{
    public class WordsController : Controller
    {
        IWordRepository repository;

        public WordsController(IWordRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IActionResult List() => View(repository.Words);
        
        // Add word section
        [HttpGet]
        public IActionResult AddWord() => View();

        [HttpPost]
        public IActionResult AddWord(Word word)
        {
            if(ModelState.IsValid)
            {
                //if (repository.Words.Where(p => p.Text.Trim() == word.Text.Trim()).Count() == 0) 
                    repository.Add(word);
            }
            return RedirectToAction("List");
        }

        // Search word section
        [HttpGet]
        public IActionResult Search() => View();


        [HttpPost]
        public bool Add(Word name)
        {
            repository.Add(name);
            return true;
        }
    }
}
