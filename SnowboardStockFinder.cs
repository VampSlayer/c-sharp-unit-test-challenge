using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowShop
{
    public class SnowboardStockFinder : StockFinder
    {
        public new async Task<List<dynamic>> FindStock(int greaterThan, string path)
        {
            var items = await Get("snowboards");

            var foundItems = items.Where(x => x["stock"] > greaterThan).ToList();
            
            return foundItems;
        }
        
        public async Task<List<dynamic>> FindSnowboardsWithLengthGreaterThan(int length)
        {
            var skis = await FindStock(0, "snowboards");

            return skis.Where(x => x["length"] >= length).ToList();
        }
    }
}