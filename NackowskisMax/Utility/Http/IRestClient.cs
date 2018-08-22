using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NackowskisMax.Utility.Http
{
    public interface IRestClient
    {
        Task<TResponse> PostAsync<TResponse>(string url, object requestBody);
        Task<TResponse> GetAsync<TResponse>(string url);
        Task<TResponse> SendAsync<TResponse>(HttpMethod method, string url, object requestBody = null);
    }
}