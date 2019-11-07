namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAttributedAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branches", "branchName", c => c.String(nullable: false));
            AlterColumn("dbo.Districts", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Districts", "name", c => c.String());
            AlterColumn("dbo.Branches", "branchName", c => c.String());
        }
    }
}
