using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkTest1.Data.Entities
{
    public class NuemericalSensor : Device // temperature sensor, humidity sensor, light sensor ...
    {
        public float Value { get; }
    }

}
