using Newtonsoft.Json;
using RandomPeople.Models;
using RandomPeople.Services.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPeople.Services.RndPeople
{
    public class RndPeopleServices:IRndPeopleServices
    {
        private readonly string uri = "http://api.randomuser.me/0.6/";
        private readonly IRestClient _restClient = new RestClient();

        async public Task<RootObject> GetPerson()
        {
            var responce = await _restClient.GetAsync(uri);
            var aa = JsonConvert.DeserializeObject<RootObject>(responce);
            return JsonConvert.DeserializeObject<RootObject>(responce);
        }
    }
}
