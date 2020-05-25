using CovidTrack.Shared.Contract;
using CovidTrack.Shared.Helper;
using CovidTrack.Shared.Models;
using Flurl;
using Flurl.Http;
using MonkeyCache.LiteDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidTrack.Shared.Implementation
{
    public class CountryService : ICountryService
    {
        public async Task<IList<Country>> GetAll()
        {
            var key = "all_country";
            try
            {
                if (!Barrel.Current.IsExpired(key))
                {
                    return Barrel.Current.Get<List<Country>>(key);
                }

                var response = await Constants.BASE_URL
                .AppendPathSegment(@"/countries")
                .SetQueryParam("sort", new[] { "country" })
                .WithTimeout(30)
                .GetAsync();

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var setting = new Newtonsoft.Json.JsonSerializerSettings();
                    JsonConvert.DefaultSettings = new Func<JsonSerializerSettings>(() =>
                    {
                        setting.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                        setting.FloatParseHandling = FloatParseHandling.Decimal;
                        return setting;
                    });


                    var all = JsonConvert.DeserializeObject<List<Country>>(content);

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
