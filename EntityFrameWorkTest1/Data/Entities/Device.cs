namespace EntityFrameWorkTest1.Data.Entities
{
    public abstract class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public List<Schedule> Schedules { get; set; }
    }

}
