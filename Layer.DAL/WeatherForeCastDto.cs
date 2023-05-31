namespace Layer.DAL
{
    public class WeatherForeCastDto
    {
        public DateOnly Date { get; set; }

        public int Temperature { get; set; }

        public string? Summary { get; set; }
    }
}