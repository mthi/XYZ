using Dal;
using Dal.Model;
using System;
using System.Linq;

namespace XZY
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new EntityContext())
      {
        context.SimpleEntities.Add(new SimpleEntity {Name = "Test", TimeStamp = DateTime.UtcNow});
        context.SaveChanges();

        var entry = context.SimpleEntities.FirstOrDefault();
        entry.Name = "HORST";

        context.SaveChanges();
      }
    }
  }
}
