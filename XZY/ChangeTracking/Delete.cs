using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
  public class Delete : Change
  {
    public Delete(DbEntityEntry entry) : base(entry)
    {
    }
  }
}
