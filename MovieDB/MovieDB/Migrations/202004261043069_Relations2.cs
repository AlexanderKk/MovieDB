namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relations2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "Films_Id", c => c.Int());
            AddColumn("dbo.Attachments", "Users_Id", c => c.Int());
            AddColumn("dbo.Users", "Films_Id", c => c.Int());
            CreateIndex("dbo.Attachments", "Films_Id");
            CreateIndex("dbo.Attachments", "Users_Id");
            CreateIndex("dbo.Users", "Films_Id");
            AddForeignKey("dbo.Attachments", "Films_Id", "dbo.Films", "Id");
            AddForeignKey("dbo.Attachments", "Users_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Films_Id", "dbo.Films", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.Attachments", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Attachments", "Films_Id", "dbo.Films");
            DropIndex("dbo.Users", new[] { "Films_Id" });
            DropIndex("dbo.Attachments", new[] { "Users_Id" });
            DropIndex("dbo.Attachments", new[] { "Films_Id" });
            DropColumn("dbo.Users", "Films_Id");
            DropColumn("dbo.Attachments", "Users_Id");
            DropColumn("dbo.Attachments", "Films_Id");
        }
    }
}
