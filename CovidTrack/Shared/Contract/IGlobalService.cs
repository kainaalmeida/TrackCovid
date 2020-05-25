using CovidTrack.Shared.Models;
using System.Threading.Tasks;

namespace CovidTrack.Shared.Contract
{
    public interface IGlobalService
    {
        Task<GlobalTrend> All();
    }
}
