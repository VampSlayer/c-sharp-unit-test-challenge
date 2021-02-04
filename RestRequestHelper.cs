using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using SnowShop.Models;

namespace SnowShop
{
    public class RestRequestHelper
    {
        private readonly RestClient _restClient;

        public RestRequestHelper(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<dynamic> Get(string url)
        {
            var request = new RestRequest(url, DataFormat.Json);

            return await _restClient.GetAsync<dynamic>(request);
        }
        
        public async Task<List<Snowboard>> GetSnowboards()
        {
            var request = new RestRequest("https://mockend.com/VampSlayer/c-sharp-unit-test-challenge/snowboards", DataFormat.Json);

            return await _restClient.GetAsync<List<Snowboard>>(request);
        }
    }
}