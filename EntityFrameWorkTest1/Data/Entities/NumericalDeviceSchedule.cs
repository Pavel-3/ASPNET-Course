namespace EntityFrameWorkTest1.Data.Entities
{
    public class NumericalDeviceSchedule : Schedule
    {
        public float Value { get; set; }
        public int? NuemericalFeedbackDeviceId { get; set; }
        public NuemericalFeedbackDevice? NumericalFeedbackDevice { get; set; }
    }
}
