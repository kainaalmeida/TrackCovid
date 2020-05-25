namespace CovidTrack.Shared.Models
{
    public class GlobalTrend
    {
        public long updated { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public int casesPerOneMillion { get; set; }
        public float deathsPerOneMillion { get; set; }
        public int tests { get; set; }
        public float testsPerOneMillion { get; set; }
        public long population { get; set; }
        public float activePerOneMillion { get; set; }
        public float recoveredPerOneMillion { get; set; }
        public decimal criticalPerOneMillion { get; set; }
        public int affectedCountries { get; set; }
    }

}
