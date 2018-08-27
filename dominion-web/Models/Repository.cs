using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Octokit;

namespace dominion_web.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public IEnumerable<string> Files { get; set; }

        public bool IsCSharpProject { get; set; }
    }
}
