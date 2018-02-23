using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
  public class ChangeSet
  {

    public ChangeSet(IEnumerable<DbEntityEntry> changedEntity)
    {
      foreach (var change in changedEntity)
      {
        if (change.State.HasFlag(EntityState.Deleted))
        {

        }
        else if (change.State.HasFlag(EntityState.Added))
        {
          
        } else if (change.State.HasFlag(EntityState.Modified))
        {

        }
      }
    }
  }
}
