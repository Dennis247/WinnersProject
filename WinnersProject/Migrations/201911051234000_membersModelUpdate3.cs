namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membersModelUpdate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "EntityDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "districtId", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "EntityDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "EntityDate");
            DropColumn("dbo.Members", "districtId");
            DropColumn("dbo.Districts", "EntityDate");
        }
    }
}
