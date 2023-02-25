using EntityFrameWorkTest1.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameWorkTest1.Data
{
    public class HouseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<NuemericalSensor> NuemericalSensors { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<FeedbackDevice> FeedbackDevices { get; set; }
        public DbSet<NuemericalFeedbackDevice> NuemericalFeedbackDevices{ get; set; }
        public DbSet<DeviceSchedule> DeviceSchedules { get; set; }
        public DbSet<NumericalDeviceSchedule> NumericalDevices { get; set; }
        public DbSet<SchaduleDayOfWeek> SchaduleDayOfWeeks { get; set; }
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>()
                .HaveColumnType("Time");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=DESKTOP-D87V24D;Database=house;Trusted_Connection=True;encrypt=false");
        }
    }
    public class TimeOnlyConverter : ValueConverter<TimeOnly, DateTime>
    {
        public TimeOnlyConverter() : base(
                d => DateTime.MinValue + d.ToTimeSpan(),
                d => TimeOnly.FromDateTime(d)) { }
    }
}
