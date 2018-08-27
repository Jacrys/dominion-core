using System;
using Xunit;
using dominion_web.Models;
using FluentAssertions;

namespace dominion_test
{
    public class RepositoryTests
    {
        [Fact]
        public void IsCSharpProjectTrue()
        {
            var testee = new Repository
            {
                Files = new[] {
                    "Something.cs",
                    "something.txt"
                }
            };

            testee.IsCSharpProject.Should().BeTrue();
        }
    }
}
