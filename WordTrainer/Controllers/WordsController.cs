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
        /// <summary>
        /// Constructor
        /// </summary>
        public WordsController(IWordRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// List of all the words in the storage
        /// </summary>
        [HttpGet]
        [Route("Words/List/{letter?}")]
        public IActionResult List(string letter = "a")
        {
            return View(repository.Words.Where(w => w.Text[0].ToString().ToLower() == letter.ToLower()));
        }
        
        /// <summary>
        /// Adds new word GET
        /// </summary>
        [HttpGet]
        public IActionResult AddWord() => View();

        /// <summary>
        /// Adds new word GET
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool AddWord(Word name)
        {
            repository.Add(name);
            return true;
        }

        /// <summary>
        /// Searches a word
        /// </summary>
        [HttpGet]
        public IActionResult Search() => View();



    }
}
