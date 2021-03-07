using Microsoft.AspNetCore.Mvc;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

using WordTrainer.Models;
using System.Diagnostics;

namespace WordTrainer.Controllers
{
    public class HomeController : Controller
    {
        private IWordRepository repository;
        private List<Word> words;
        public HomeController(IWordRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Words);
        }

        [HttpGet]
        public IActionResult Checking() => View(repository.Words.ToList());

        [HttpPost]
        public IActionResult Checking(string text)
        {
            //var buf = new byte[100];
            //var res = await GetListOfStringsFromStream(HttpContext.Request.Body);

            return View();
        }

        private async Task<string> GetListOfStringsFromStream(Stream requestBody)
        {
            StringBuilder builder = new StringBuilder();

            // byte[] buffer = ArrayPool<byte>.Shared.Rent(4096);
            byte[] buffer = new byte[4096];
            while (true)
            {
                var bytesRemaining = await requestBody.ReadAsync(buffer, offset: 0, buffer.Length);
                if (bytesRemaining == 0)
                {
                    break;
                }
                var encodedString = Encoding.UTF8.GetString(buffer, 0, bytesRemaining);
                builder.Append(encodedString);
            }

            // ArrayPool<byte>.Shared.Return(buffer);
            var entireRequestBody = builder.ToString();
            return entireRequestBody;
        }



    }
}
