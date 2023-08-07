namespace ToDoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTimeCtoraTasindi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Pri", c => c.Int(nullable: false));
            DropColumn("dbo.ToDoes", "Priority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoes", "Priority", c => c.Int(nullable: false));
            DropColumn("dbo.ToDoes", "Pri");
        }
    }
}
