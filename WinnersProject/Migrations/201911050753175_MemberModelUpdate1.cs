namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberModelUpdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "address", c => c.String());
            AddColumn("dbo.Members", "IsFirstTimer", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsNewMember", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Members", "cameOnYourOwn", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "cameOnYourOwn", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "IsNewMember");
            DropColumn("dbo.Members", "IsFirstTimer");
            DropColumn("dbo.Members", "address");
        }
    }
}
