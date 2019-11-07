namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchModelUpdate2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Branches", "DistrictId");
            AddForeignKey("dbo.Branches", "DistrictId", "dbo.Districts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "DistrictId", "dbo.Districts");
            DropIndex("dbo.Branches", new[] { "DistrictId" });
        }
    }
}
