namespace ToDoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ToDoes", "User_Id", c => c.Int());
            CreateIndex("dbo.ToDoes", "User_Id");
            AddForeignKey("dbo.ToDoes", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoes", "User_Id", "dbo.Users");
            DropIndex("dbo.ToDoes", new[] { "User_Id" });
            DropColumn("dbo.ToDoes", "User_Id");
            DropTable("dbo.Users");
        }
    }
}
