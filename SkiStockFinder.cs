using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowShop
{
    public class SkiStockFinder : StockFinder
    {
        public async Task<List<dynamic>> FindStock(int greaterThan)
        {
            return await FindStock(greaterThan, "skis");
        }
        
        public async Task<List<dynamic>> FindSkisWithPoles(bool withOrWithoutPoles)
        {
            var skis = await FindStock(0, "skis");

            return skis.Where(x => x["poles"] == withOrWithoutPoles).ToList();
        }
    }
}