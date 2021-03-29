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
        /// Class Constructor
        /// </summary>
        public WordsController(IWordRepository repo) => repository = repo;

        /// <summary>
        /// Shows list of all words  in the storage
        /// </summary>
        [HttpGet]
        public IActionResult List() => View(repository.Words);

        /// <summary>
        /// Shows Views/Words/AddWord view
        /// </summary>
        [HttpGet]
        public IActionResult AddWord() => View();

        /// <summary>
        /// Adds new word to the storage
        /// </summary>
        [HttpPost]
        public bool AddWord(Word name)
        {
            if (ModelState.IsValid)
            {
                var temp = name.ExamplesEn.Split(new char[] { '\r', '\n' }).Select(p => p.Trim()).Where(m => m != "" && m != " ");
                name.ExamplesEn = string.Join(".", temp.Where((ph, index) => ((index + 1) & 0b1) == 1));
                name.ExamplesRu = string.Join(".", temp.Where((ph, index) => (index & 0b1) == 1));
                repository.Add(name);
            }
            return true;
        }

        /// <summary>
        /// Views/Words/Search view. Works via jQuery (or fetch)
        /// </summary>
        [HttpGet]
        public IActionResult Search() => View();


    }
}
