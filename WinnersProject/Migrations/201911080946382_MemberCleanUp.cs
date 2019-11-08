namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberCleanUp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "branchId", c => c.Int(nullable: false));
            AlterColumn("dbo.Members", "wasInvited", c => c.String());
            AlterColumn("dbo.Members", "asFirstTimer", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Members", "asBornAgain", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Members", "asBothFirstBornAgain", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "districtName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "districtName", c => c.String());
            AlterColumn("dbo.Members", "asBothFirstBornAgain", c => c.String());
            AlterColumn("dbo.Members", "asBornAgain", c => c.String());
            AlterColumn("dbo.Members", "asFirstTimer", c => c.String());
            AlterColumn("dbo.Members", "wasInvited", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "branchId");
        }
    }
}
