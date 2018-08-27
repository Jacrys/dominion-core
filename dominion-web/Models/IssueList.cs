using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Octokit;

namespace dominion_web.Models
{
    public class IssueList
    {
        public string owner { get;set; }
        public string repoName { get; set; }
        public IReadOnlyList<Issue> issues { get; set; }
    }
}
