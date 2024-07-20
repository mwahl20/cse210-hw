public class Outdoors : Event
{
    private List<string> Forecast = new List<string>
    {
        "Sunny", "Windy", "Cloudy", "Rainy", "Snowy", 
    };
    protected string _weather;
    public Outdoors(string title, string desc, DateTime date,string time, string address): base(title, desc, date, time, address)
    {
        Random random = new Random();
        _weather = Forecast[random.Next(Forecast.Count)];
    }
    public override string FullDetails()
    {
        return $"Event: \n   {StandardDetails()}\n   Weather Forecast: {_weather}";
    }
}