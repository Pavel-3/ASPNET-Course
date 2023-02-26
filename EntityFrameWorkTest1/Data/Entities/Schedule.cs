using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkTest1.Data.Entities
{
    public abstract class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime Event { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public List<SchaduleDayOfWeek> schaduleDayOfWeeks { get; set; }
    }
    public class SchaduleDayOfWeek
    {
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int ScaduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
