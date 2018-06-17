using System;
using Xunit;

namespace api.Unittest
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void Input_2_Should_Be_2()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(2);
            //Assert
            Assert.Equal("2", actual);
        }

        [Fact]
        public void Input_3_Should_Be_Fizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(3);
            //Assert
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void Input_4_Should_Be_4()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(4);
            //Assert
            Assert.Equal("4", actual);
        }

        [Fact]
        public void Input_5_Should_Be_Buzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(5);
            //Assert
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Input_6_Should_Be_Fizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(6);
            //Assert
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void Input_7_Should_Be_7()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(7);
            //Assert
            Assert.Equal("7", actual);
        }

        [Fact]
        public void Input_10_Should_Be_Buzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(10);
            //Assert
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Input_15_Should_Be_FizzBuzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(15);
            //Assert
            Assert.Equal("FizzBuzz", actual);
        }

        [Fact]
        public void Input_30_Should_Be_FizzBuzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Action
            string actual = fizzBuzz.say(30);
            //Assert
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
