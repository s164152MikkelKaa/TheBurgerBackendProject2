namespace TheBurgerBackendProject2.Server.Models
{
    public class BurgerSpots
    {
        public int Id { get; set; }
        public string SpotName { get; set; }
        public string SpotAddress { get; set; }
        public double CoordinateLat { get; set; }
        public double CoordinateLon { get; set; }
        public string? OpenTimes { get; set; }
        public double? SpotScore { get; set; }
        public DateTime LastEditAt { get; set; }
        public string? LastEditBy { get; set; }
    }
}
