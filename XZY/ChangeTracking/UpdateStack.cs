using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
  public class UpdateStack
  {
    private readonly Stack<ChangeSet> _changes = new Stack<ChangeSet>();
    public void PushUpdate(IEnumerable<DbEntityEntry> changedEntities)
    {
      _changes.Push(new ChangeSet(changedEntities));
    }

    public void PopAll()
    {
      while (_changes.Count > 0)
      {
        var change = _changes.Pop();
        Revert(change);
      }
    }

    private void Revert(ChangeSet changeSet)
    {

    }
  }
}
