using System;

namespace Thermo.Web.Models
{
    public class TemperatureSensor : SensorBase
    {
        public double Temperature { get; set; }

        public DateTime Date { get; set; }
    }
}