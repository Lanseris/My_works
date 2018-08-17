namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobsChange13 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Jobs", "UserId");
            AddForeignKey("dbo.Jobs", "UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "UserId", "dbo.Users");
            DropIndex("dbo.Jobs", new[] { "UserId" });
        }
    }
}
