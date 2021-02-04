using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnowShop.Tests
{
    public class SnowboardStockFinderTests
    {
        [Fact]
        public async Task FindStock_ShouldReturn1Snowboards()
        {
            // arrange
            var snowboardStockFinder = new SnowboardStockFinder();
            // act
            var snowboards = await snowboardStockFinder.FindStock(0, "snowboard");
            // asserts
            snowboards.Should().HaveCount(1);
        }
        
        [Fact]
        public async Task GetSnowboardTypes_ShouldReturn50Types()
        {
            // arrange
            var snowboardStockFinder = new SnowboardStockFinder();
            // act
            var snowboards = await snowboardStockFinder.GetSnowboardTypes();
            // assert
            snowboards.Should().HaveCount(50);
        }
        
        [Theory]
        [InlineData(1, 10)]
        [InlineData(50, 10)]
        [InlineData(100, 10)]
        public async Task FindSnowboardsWithLengthGreaterThan_ShouldReturnExpectedNumberOfSnowboards_WhenGivenLengthOf(int length, int expected)
        {
            // arrange
            var snowboardStockFinder = new SnowboardStockFinder();
            // act
            var snowboards = await snowboardStockFinder.FindSnowboardsWithLengthGreaterThan(length);
            // assert
            snowboards.Should().HaveCount(expected);
        }
    }
}