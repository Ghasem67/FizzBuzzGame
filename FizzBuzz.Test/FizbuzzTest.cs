using FizzBuzz.Games;
using FluentAssertions;
using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizbuzzTest
    {
        private readonly Game _game;
        public FizbuzzTest()
        {
            _game = new Game();
        }
        [Fact]
        public void number_Divisible_3_Shoud_true()
        {
            int number = 15;
            var expect = _game.Divisible3(number);
            expect.Should().Be(true);
        }
        [Fact]
        public void number_Divisible_5_Shoud_true()
        {
            int number = 15;
            var expect = _game.Divisible3(number);
            expect.Should().Be(true);
        }
        //[Fact]
        //public void number_Divisible_5and3_Shoud_true()
        //{
        //    int number = 15;
        //    var expect = _game.Divisible5and3(number);
        //    expect.Should().Be(true);
        //}

    }
}
