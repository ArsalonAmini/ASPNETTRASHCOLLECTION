namespace ASPNETWEBAPPLICATION.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkerEmailandPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Workers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Workers", "Password", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Workers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Workers", "Password", c => c.String());
            DropColumn("dbo.Workers", "ConfirmPassword");
            DropColumn("dbo.Workers", "Email");
        }
    }
}
