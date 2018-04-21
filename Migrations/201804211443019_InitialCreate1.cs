namespace rsiProj1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "TypeId", "dbo.Types");
            DropPrimaryKey("dbo.Events");
            DropPrimaryKey("dbo.Types");
            AlterColumn("dbo.Events", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Types", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Events", "Id");
            AddPrimaryKey("dbo.Types", "Id");
            AddForeignKey("dbo.Events", "TypeId", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "TypeId", "dbo.Types");
            DropPrimaryKey("dbo.Types");
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Types", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Events", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Types", "Id");
            AddPrimaryKey("dbo.Events", "Id");
            AddForeignKey("dbo.Events", "TypeId", "dbo.Types", "Id", cascadeDelete: true);
        }
    }
}
