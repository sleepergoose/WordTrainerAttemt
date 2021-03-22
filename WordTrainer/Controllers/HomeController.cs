﻿using Microsoft.AspNetCore.Mvc;
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

        public HomeController(IWordRepository repo) => repository = repo;
        
        public  IActionResult Index() => View(repository.Words);

        [HttpGet]
        public IActionResult TrainEn() => View(repository.Words.ToList());

        [HttpGet]
        public IActionResult TrainRu() => View(repository.Words.ToList());



        // Do not use in this time
        /// <summary>
        /// Reads data from Request's Body
        /// </summary>
        /// <param name="requestBody">Data from Request's Body </param>
        /// <returns>Data in a specific format</returns>
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
