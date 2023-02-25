namespace EntityFrameWorkTest1.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Room> rooms { get; set; }
        public List<Schedule> schedules { get; set; }
    }
}
