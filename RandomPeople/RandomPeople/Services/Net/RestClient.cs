using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RandomPeople.Services.Net
{
    public class RestClient : IRestClient
    {
        async public Task<string> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            return content;


        }
    }
}
