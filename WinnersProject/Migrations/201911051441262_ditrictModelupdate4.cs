namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ditrictModelupdate4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Districts", "EntityDate");
            DropColumn("dbo.Members", "EntityDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "EntityDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Districts", "EntityDate", c => c.DateTime(nullable: false));
        }
    }
}
