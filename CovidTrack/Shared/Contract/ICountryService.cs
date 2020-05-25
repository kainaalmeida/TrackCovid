using CovidTrack.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidTrack.Shared.Contract
{
    public interface ICountryService
    {
        Task<IList<Country>> GetAll();
    }
}
