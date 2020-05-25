namespace CovidTrack.Shared.Models
{
    public class Countryinfo
    {
        public int _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public float lat { get; set; }
        public float _long { get; set; }
        public string flag { get; set; }
    }
}
