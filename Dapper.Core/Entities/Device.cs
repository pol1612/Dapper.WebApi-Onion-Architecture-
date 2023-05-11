namespace Dapper.Core
{
    public class Device
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? TelemetryType { get; set; }

        public Device(Guid id, string name, string telemetryType)
        {
            Id = id;
            Name = name;
            TelemetryType = telemetryType;
        }
    }
}