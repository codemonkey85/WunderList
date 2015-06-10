namespace WunderListSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Create_Begin", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "Create_End", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Create_End");
            DropColumn("dbo.Books", "Create_Begin");
        }
    }
}
