namespace WunderListSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WunderListItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WunderListId = c.String(),
                        Title = c.String(),
                        ListType = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WunderListSubTasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TaskId = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WunderTasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreateAt = c.DateTime(nullable: false),
                        ListId = c.String(),
                        TaskId = c.String(),
                        Title = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WunderTasks");
            DropTable("dbo.WunderListSubTasks");
            DropTable("dbo.WunderListItems");
        }
    }
}
