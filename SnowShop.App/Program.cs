using System;
using System.Threading.Tasks;

namespace SnowShop.App
{
    class Program
    {
        /// <summary>
        /// Dont rely on this for testing
        /// These methods will hit the API and will never pass the tests
        /// </summary>
        static async Task Main(string[] args)
        {
            var snowboardStockFinder = new SnowboardStockFinder();
            var skiStockFinder = new SkiStockFinder();
            
            // I want to know the stock of my snowboards and skis
            var snowboardStock = await snowboardStockFinder.FindStock(0, "snowboard");
            Console.WriteLine(snowboardStock.Count);
            
            var skiStock = await skiStockFinder.FindStock(0);
            Console.WriteLine(skiStock.Count);
            
            // I want to know the snowboard types
            var types = await snowboardStockFinder.GetSnowboardTypes();
            Console.WriteLine(types.Count);
            
            // I want to find skis with poles
            var skisWithPoles = await skiStockFinder.FindSkisWithPoles(true);
            Console.WriteLine(skisWithPoles.Count);
            
            // I want to find snowboards with length greater than 56cm
            var snowboardsWithLength = await snowboardStockFinder.FindSnowboardsWithLengthGreaterThan(56);
            Console.WriteLine(snowboardsWithLength.Count);
        }
    }
}