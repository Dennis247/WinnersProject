namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateRegisteredRemoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "dateRegistered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "dateRegistered", c => c.DateTime(nullable: false));
        }
    }
}
