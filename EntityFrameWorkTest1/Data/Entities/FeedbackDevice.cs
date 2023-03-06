namespace EntityFrameWorkTest1.Data.Entities
{
    public class FeedbackDevice : Device // curtains, heating, laps, socets, electric kettle ...
    {
        public bool Value { get; set; }
        public List<DeviceSchedule> Schedules { get; set; }
    }

}
