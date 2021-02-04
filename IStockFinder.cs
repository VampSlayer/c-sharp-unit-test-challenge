using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnowShop
{
    public interface IStockFinder
    {
        Task<List<dynamic>> GetSnowboardTypes();
    }
}