using System.Data.Entity;

namespace CarPark.Models {
  public class CarParkDb : DbContext {

    public DbSet<Ticket> Tickets { get; set; }

  }
}