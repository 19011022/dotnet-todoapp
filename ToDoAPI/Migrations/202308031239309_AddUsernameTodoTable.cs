namespace ToDoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsernameTodoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Username");
        }
    }
}
