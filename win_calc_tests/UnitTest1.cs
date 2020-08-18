using System;
using win_calc;
using Xunit;

namespace win_calc_tests
{
    public class UnitTest1
    {
        [Fact]
        public void DivisionByZeroTest()
        {
            //Arrange
            double value = 12;
            double value2 = 0;
            Operations sut = new Operations();

            //act
            //var expected = sut.Divide(value, value2);


            //Assert
            Assert.Throws<DivideByZeroException>(
                ()=> sut.Divide(value, value2)
                );

        }
        [Fact]
        public void AddTest()
        {
            //Arrange
            double value = 12;
            double value2 = 10;
            Operations sut = new Operations();

            //act
            var expected = sut.Add(value, value2);
            var actual = 22;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTest()
        {
            //Arrange
            double value = 12;
            double value2 = 10;
            Operations sut = new Operations();

            //act
            var expected = sut.Subtract(value, value2);
            var actual = 2;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTest()
        {
            //Arrange
            double value = 12;
            double value2 = 2;
            Operations sut = new Operations();

            //act
            var expected = sut.Divide(value, value2);
            var actual = 6;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplicationTest()
        {
            //Arrange
            double value = 12;
            double value2 = 10;
            Operations sut = new Operations();

            //act
            var expected = sut.Times(value, value2);
            var actual = 120;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
