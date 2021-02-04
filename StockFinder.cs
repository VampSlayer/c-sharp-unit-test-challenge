using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace SnowShop
{
    public abstract class StockFinder : IStockFinder
    {
        private const string BaseUrl = "https://mockend.com/VampSlayer/c-sharp-unit-test-challenge/";

        protected static async Task<List<dynamic>> FindStock(int greaterThan, string path)
        {
            var items = await Get(path);

            var foundItems = items.Where(x => x["stock"] > greaterThan).ToList();
            
            return foundItems;
        }

        protected static async Task<List<dynamic>> Get(string path)
        {
            var restClient = new RestClient();
            
            var restRequestHelper = new RestRequestHelper(restClient);

            return await restRequestHelper.Get(BaseUrl + path);
        }

        public async Task<List<dynamic>> GetSnowboardTypes()
        {
            var items = await Get("snowboards");

            var snowboardNames = items.Select(x => x["type"]).ToList();

            return snowboardNames;
        }
    }
}