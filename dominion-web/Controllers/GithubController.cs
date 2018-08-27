using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominion_web.Models;
using Microsoft.AspNetCore.Mvc;
using Octokit;

namespace dominion_web.Controllers
{
    public class GithubController : Controller
    {
        private readonly GitHubCredentials _credentials;
        public GithubController(GitHubCredentials credentials)
        {
            _credentials = credentials;
        }
        public async Task<IActionResult> Issues(IssueList issueList)
        {
            var gh = new GitHubClient(new ProductHeaderValue ("Sample-App_jacrys"));
            gh.Credentials = new Credentials(_credentials.Token);

            var allIssues = new RepositoryIssueRequest
            {
                Filter = IssueFilter.All,
                State = ItemStateFilter.All,
            };

            var issues = await gh.Issue.GetAllForRepository(issueList.owner, issueList.repoName, allIssues);

            issueList.issues = issues;

            return View(issueList);
        }
    }
}