namespace FleetManagement.Api
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Plate { get; set; } = string.Empty;
        public string EngineNumber { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}
