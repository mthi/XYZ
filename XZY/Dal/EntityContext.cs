using System.Data.Entity;
using Dal.Model;

namespace Dal
{
  public class EntityContext : DbContext
  {
    public DbSet<SimpleEntity> SimpleEntities { get; set; }

    public override int SaveChanges()
    {
      var entries = ChangeTracker.Entries();
      return base.SaveChanges();
    }
  }
}
