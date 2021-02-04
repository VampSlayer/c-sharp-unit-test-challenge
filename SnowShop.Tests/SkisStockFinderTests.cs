using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnowShop.Tests
{
    public class SkiStockFinderTests
    {
        [Fact]
        public async Task FindStock_ShouldReturn1Skis()
        {
            // arrange
            var skiStockFinder = new SkiStockFinder();
            // act
            var skis = await skiStockFinder.FindStock(0);
            // asserts
            skis.Should().HaveCount(1);
        }
        
        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 1)]
        public async Task FindSkisWithPoles_ShouldReturn1Skis_WhenGivenBoolOf(bool withPoles, int expected)
        {
            // arrange
            var skiStockFinder = new SkiStockFinder();
            // act
            var skis = await skiStockFinder.FindSkisWithPoles(withPoles);
            // asserts
            skis.Should().HaveCount(expected);
        }
    }
}