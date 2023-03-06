namespace EntityFrameWorkTest1.Data.Entities
{
    public class DeviceSchedule : Schedule
    {
        public bool Value { get; set; }
        public int? FeedbackDeviceId { get; set; }
        public FeedbackDevice? FeedbackDevice { get; set; }
    }
}
