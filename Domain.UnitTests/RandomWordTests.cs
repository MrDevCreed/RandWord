using FluentAssertions;
using RandWord;
using RandWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Domain.UnitTests
{
    public class RandomWordTests
    {
        [Fact]
        public void GenarateRandomWord_ShouldReturnShuffledList()
        {
            RandomWord randomWord = new RandomWord();

            string word = randomWord.GenarateRandomWord();

            word.Should().NotBeEmpty();
        }
        [Fact]
        public void GenarateRandomWord_WithExcepts_ShouldReturnShuffledList()
        {
            RandomWord randomWord = new RandomWord();

            string word = randomWord.GenarateRandomWord(new List<string>() {"A","B" });

            word.Should().NotBe("A").And.NotBe("B");
        }
    }
}
