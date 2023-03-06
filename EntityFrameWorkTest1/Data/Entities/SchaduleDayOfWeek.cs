namespace EntityFrameWorkTest1.Data.Entities
{
    public class SchaduleDayOfWeek
    {
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int? DeviceScheduleId { get; set; }
        public int? NumericalDeviceScheduleId { get; set; }
        public DeviceSchedule? DeviceSchedule { get; set; }
        public NumericalDeviceSchedule? NumericalDeviceSchedule { get; set; }
    }
}
