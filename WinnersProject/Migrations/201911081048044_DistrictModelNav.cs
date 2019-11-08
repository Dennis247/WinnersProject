namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DistrictModelNav : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Members", "BranchId");
            AddForeignKey("dbo.Members", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "BranchId", "dbo.Branches");
            DropIndex("dbo.Members", new[] { "BranchId" });
        }
    }
}
