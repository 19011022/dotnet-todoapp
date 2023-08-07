namespace ToDoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToDoTablosunaAnnotationEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Priority", c => c.Int());
            AlterColumn("dbo.ToDoes", "Title", c => c.String(nullable: false));
            DropColumn("dbo.ToDoes", "Pri");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoes", "Pri", c => c.Int(nullable: false));
            AlterColumn("dbo.ToDoes", "Title", c => c.String());
            DropColumn("dbo.ToDoes", "Priority");
        }
    }
}
