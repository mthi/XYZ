using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
  public class KeyAttributeNotFoundException : Exception
  {
    public KeyAttributeNotFoundException(Type entityType) : base($"Key Attribute not found on Entity of type {entityType}")
    {
    }
  }
}
