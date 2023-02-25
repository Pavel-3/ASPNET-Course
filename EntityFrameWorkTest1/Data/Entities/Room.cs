namespace EntityFrameWorkTest1.Data.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Device> Devices {get; set; }
    }

}
