namespace ToDoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToDoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ToDoes", "IsCompleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ToDoes", "Detail", c => c.String());
            AddColumn("dbo.ToDoes", "Priority", c => c.Int(nullable: false));
            DropColumn("dbo.ToDoes", "IsChecked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoes", "IsChecked", c => c.Boolean(nullable: false));
            DropColumn("dbo.ToDoes", "Priority");
            DropColumn("dbo.ToDoes", "Detail");
            DropColumn("dbo.ToDoes", "IsCompleted");
            DropColumn("dbo.ToDoes", "CreatedDate");
        }
    }
}
