using CovidTrack.Shared.Contract;
using CovidTrack.Shared.Helper;
using CovidTrack.Shared.Models;
using Flurl;
using Flurl.Http;
using MonkeyCache.LiteDB;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CovidTrack.Shared.Implementation
{
    public class GlobalService : IGlobalService
    {
        public async Task<GlobalTrend> All()
        {
            var key = "all";
            try
            {
                if (!Barrel.Current.IsExpired(key))
                {
                    return Barrel.Current.Get<GlobalTrend>(key);
                }

                var response = await Constants.BASE_URL
                .AppendPathSegment("/all")
                .WithTimeout(30)
                .GetAsync();

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var all = JsonConvert.DeserializeObject<GlobalTrend>(content);

                    if (all != null)
                        Barrel.Current.Add(key: key, data: all, expireIn: TimeSpan.FromHours(1));

                    return all;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
    }
}
