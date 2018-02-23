using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
  public class Change
  {
    public Type Type { get; set; }
    public Object Key { get; set; }

    public Change(DbEntityEntry entry)
    {
      Type = entry.Entity.GetType();

    }

    private Object ExtractKeyAttribute(DbEntityEntry dbEntity)
    {
      var keyProp = dbEntity.Entity.GetType().GetProperties()
        .FirstOrDefault(p => p.CustomAttributes.Any(ca => ca.AttributeType == typeof(KeyAttribute)));

      if (keyProp != null)
      {
        return dbEntity.CurrentValues[keyProp.Name];
      }

      throw new KeyAttributeNotFoundException(dbEntity.Entity.GetType());
    }
  }
}
