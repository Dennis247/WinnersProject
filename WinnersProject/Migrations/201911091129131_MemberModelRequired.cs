namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberModelRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "name", c => c.String());
        }
    }
}
