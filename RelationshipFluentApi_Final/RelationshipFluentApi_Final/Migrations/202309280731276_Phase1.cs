namespace RelationshipFluentApi_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phase1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProfileName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "Id", "dbo.Users");
            DropIndex("dbo.Profiles", new[] { "Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Profiles");
        }
    }
}
