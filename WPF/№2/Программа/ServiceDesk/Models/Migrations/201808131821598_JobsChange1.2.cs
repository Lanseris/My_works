namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobsChange12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "UserId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "UserId", c => c.Int(nullable: false));
        }
    }
}
