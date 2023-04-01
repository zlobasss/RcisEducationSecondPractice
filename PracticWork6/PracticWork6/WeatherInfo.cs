namespace PracticWork6
{
    public class WeatherInfo
    {
        public MainInfo Main { get; set; }
        public WeatherData[] Weather { get; set; }
        public WindInfo Wind { get; set; }
        public string Dt_txt { get; set; }
    }
}