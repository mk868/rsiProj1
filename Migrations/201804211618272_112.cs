namespace rsiProj1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Events", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Events", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Events", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Events", "Id");
        }
    }
}
