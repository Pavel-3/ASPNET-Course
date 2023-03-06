namespace EntityFrameWorkTest1.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
