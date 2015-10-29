using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPeople.Services.Net
{

    public interface IRestClient
    {
        Task<string> GetAsync(string uri);
    }
}
