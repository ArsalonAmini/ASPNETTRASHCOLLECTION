namespace ASPNETWEBAPPLICATION.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "Password", c => c.String());
            AlterColumn("dbo.Workers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "Name", c => c.String());
            DropColumn("dbo.Workers", "Password");
        }
    }
}
