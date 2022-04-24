using FizzBuzz.Games;
using FluentAssertions;
using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizbuzzTest
    {private readonly Game _game;
        public FizbuzzTest()
        {
            _game=new Game();
        }
        [Fact]
        public void number_Divisible_3()
        {
            int number = 15;
          var expect=  _game.Divisible3(number);
            expect.Should().Be(true);
        }
    }
}
