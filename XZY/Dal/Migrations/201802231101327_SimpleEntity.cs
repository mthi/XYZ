namespace Dal.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class SimpleEntity : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.SimpleEntities",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            TimeStamp = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.Id);

    }

    public override void Down()
    {
      DropTable("dbo.SimpleEntities");
    }
  }
}
