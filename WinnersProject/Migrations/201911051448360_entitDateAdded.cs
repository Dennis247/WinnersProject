namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entitDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "EntityDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "EntityDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "EntityDate");
            DropColumn("dbo.Districts", "EntityDate");
        }
    }
}
