namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobsChange11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Descr", c => c.String(nullable: false));
            AddColumn("dbo.Jobs", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Status");
            DropColumn("dbo.Jobs", "Descr");
        }
    }
}
