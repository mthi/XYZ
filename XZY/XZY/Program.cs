using Dal;
using Dal.Model;
using System;

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
      }
    }
  }
}
