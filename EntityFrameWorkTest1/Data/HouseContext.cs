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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Device>().UseTpcMappingStrategy();
            modelBuilder.Entity<Schedule>().UseTpcMappingStrategy();

            modelBuilder.Entity<NuemericalFeedbackDevice>()
                .ToTable("NuemericalFeedbackDevice", tb => tb.Property(e => e.Id).UseIdentityColumn(1, 7));
            modelBuilder.Entity<Sensor>()
                .ToTable("Sensor", tb => tb.Property(e => e.Id).UseIdentityColumn(2, 7));
            modelBuilder.Entity<FeedbackDevice>()
                .ToTable("FeedbackDevice", tb => tb.Property(e => e.Id).UseIdentityColumn(3, 7));
            modelBuilder.Entity<NuemericalSensor>()
                .ToTable("NuemericalSensor", tb => tb.Property(e => e.Id).UseIdentityColumn(4, 7));
            modelBuilder.Entity<DeviceSchedule>()
                .ToTable("DeviceSchedule", tb => tb.Property(e => e.Id).UseIdentityColumn(1, 3));
            modelBuilder.Entity<NumericalDeviceSchedule>()
                .ToTable("NumericalDeviceSchedule", tb => tb.Property(e => e.Id).UseIdentityColumn(2, 3));

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=DESKTOP-D87V24D;Database=houseDb;Trusted_Connection=True;encrypt=false");
        }
    }
}
