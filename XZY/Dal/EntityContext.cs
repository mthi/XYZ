using System.Data.Entity;
using System.Linq;
using ChangeTracking;
using Dal.Model;

namespace Dal
{
  public class EntityContext : DbContext
  {
    public DbSet<SimpleEntity> SimpleEntities { get; set; }

    private UpdateStack _currentStack;

    public void CreateCheckPoint()
    {
      if (_currentStack == null)
      {
        _currentStack = new UpdateStack();
      }
    }

    public void RestoreToCheckPoint()
    {
      _currentStack?.PopAll();
    }
    public override int SaveChanges()
    {
      var entries = ChangeTracker.Entries();

      //entries.First().

      return base.SaveChanges();
    }
  }
}
