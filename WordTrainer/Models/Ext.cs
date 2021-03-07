using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordTrainer.Models
{
    public static class Ext
    {
        public static string Print(this IEnumerable<string> list) =>
            string.Join(", ", list);
    }
}
