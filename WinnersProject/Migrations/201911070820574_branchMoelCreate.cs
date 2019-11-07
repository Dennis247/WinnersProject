namespace WinnersProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class branchMoelCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        branchName = c.String(),
                        districtId = c.Int(nullable: false),
                        EntityDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Branches");
        }
    }
}
