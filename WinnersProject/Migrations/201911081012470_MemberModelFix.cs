namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberModelFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "asFirstTimer", c => c.String());
            AlterColumn("dbo.Members", "asBornAgain", c => c.String());
            AlterColumn("dbo.Members", "asBothFirstBornAgain", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "asBothFirstBornAgain", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Members", "asBornAgain", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Members", "asFirstTimer", c => c.Boolean(nullable: false));
        }
    }
}
