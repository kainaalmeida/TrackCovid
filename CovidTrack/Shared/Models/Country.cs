namespace CovidTrack.Shared.Models
{
    public class Country
    {
        public long updated { get; set; }
        public string country { get; set; }
        public Countryinfo countryInfo { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public float casesPerOneMillion { get; set; }
        public float deathsPerOneMillion { get; set; }
        public int tests { get; set; }
        public int testsPerOneMillion { get; set; }
        public int population { get; set; }
        public string continent { get; set; }
        public float activePerOneMillion { get; set; }
        public float recoveredPerOneMillion { get; set; }
        public float criticalPerOneMillion { get; set; }
    }
}
