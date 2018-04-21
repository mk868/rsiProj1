namespace rsiProj1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _111 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "TypeId", "dbo.Types");
            DropPrimaryKey("dbo.Types");
            AlterColumn("dbo.Types", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Types", "Id");
            AddForeignKey("dbo.Events", "TypeId", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "TypeId", "dbo.Types");
            DropPrimaryKey("dbo.Types");
            AlterColumn("dbo.Types", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Types", "Id");
            AddForeignKey("dbo.Events", "TypeId", "dbo.Types", "Id", cascadeDelete: true);
        }
    }
}
