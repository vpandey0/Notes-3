namespace PracticeMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phase12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String());
            DropColumn("dbo.Students", "StudentGender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentGender", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Gender");
        }
    }
}
