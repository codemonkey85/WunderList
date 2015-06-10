namespace WunderListSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Create_Begin", c => c.DateTime());
            AlterColumn("dbo.Books", "Create_End", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Create_End", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Books", "Create_Begin", c => c.DateTime(nullable: false));
        }
    }
}
