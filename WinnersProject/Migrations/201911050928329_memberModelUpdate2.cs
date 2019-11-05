namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberModelUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "asFirstTimer", c => c.String());
            AddColumn("dbo.Members", "asBornAgain", c => c.String());
            AddColumn("dbo.Members", "asBothFirstBornAgain", c => c.String());
            DropColumn("dbo.Members", "IsFirstTimer");
            DropColumn("dbo.Members", "IsNewMember");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "IsNewMember", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsFirstTimer", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "asBothFirstBornAgain");
            DropColumn("dbo.Members", "asBornAgain");
            DropColumn("dbo.Members", "asFirstTimer");
        }
    }
}
