using RandomPeople.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPeople.Services.RndPeople
{
    public interface IRndPeopleServices
    {
       Task<RootObject> GetPerson();
    }
}
