namespace Dapper.Core.Entities
{
    public class Device
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? TelemetryType { get; set; }

        public Device()
        {

        }
        public Device(string name, string telemetryType, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            TelemetryType = telemetryType;
        }
    }
}