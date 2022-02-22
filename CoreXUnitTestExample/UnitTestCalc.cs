using System;
using Xunit;

namespace CoreXUnitTestExample
{
    public class UnitTestCalc
    {
        private readonly Calculator _sut;

        public UnitTestCalc()
        {
            _sut = new Calculator();
        }

        [Fact(Skip = "This test is broken")]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13, _sut.Value);
        }

        [Theory]
        [InlineData(13, 5, 8)]
        [InlineData(0, -3, 3)]
        [InlineData(0, 0, 0)]
        public void AddTwoNumbersShouldEqualTheirEqualTheory(
            decimal expected, decimal firstToAdd, decimal secondToAdd)
        {
            _sut.Add(firstToAdd);
            _sut.Add(secondToAdd);
            Assert.Equal(expected, _sut.Value);
        }
    }
}
