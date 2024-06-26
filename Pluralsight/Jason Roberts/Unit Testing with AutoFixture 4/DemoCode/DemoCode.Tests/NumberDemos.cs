﻿namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arrange
            var sut = new IntCalculator();
            var fixture = new Fixture();

            // act
            sut.Substract(fixture.Create<int>());

            // assert
            Assert.True(sut.Value < 0);
        }

        [Fact]
        public void Decimals()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new DecimalCalculator();

            decimal num = fixture.Create<decimal>();

            // act
            sut.Add(num);

            // assert
            Assert.Equal(num, sut.Value);
        }
    }
}
