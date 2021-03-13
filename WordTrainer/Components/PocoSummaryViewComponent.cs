﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordTrainer.Models;

namespace WordTrainer.Components
{
    public class PocoSummaryViewComponent
    {
        IWordRepository repository;
        public PocoSummaryViewComponent(IWordRepository repo) => repository = repo;
        
        public string Invoke()
        {
            return $@"{repository.Words.Count()} words";
        }
    }
}
