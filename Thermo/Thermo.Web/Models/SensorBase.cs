namespace Thermo.Web.Models
{
    public class SensorBase: EntityBase
    {
        public string DeviceName { get; set; }

        public long ChipId { get; set; }
    }
}