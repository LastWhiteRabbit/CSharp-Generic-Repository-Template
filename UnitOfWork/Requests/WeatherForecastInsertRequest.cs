namespace UnitOfWork.Requests
{
    public class WeatherForecastInsertRequest
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
