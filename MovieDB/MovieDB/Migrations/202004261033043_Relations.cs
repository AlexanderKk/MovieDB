namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.Attachments", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Films_Id", "dbo.Films");
            DropIndex("dbo.Attachments", new[] { "Films_Id" });
            DropIndex("dbo.Attachments", new[] { "Users_Id" });
            DropIndex("dbo.Users", new[] { "Films_Id" });
            DropColumn("dbo.Attachments", "Films_Id");
            DropColumn("dbo.Attachments", "Users_Id");
            DropColumn("dbo.Users", "Films_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Films_Id", c => c.Int());
            AddColumn("dbo.Attachments", "Users_Id", c => c.Int());
            AddColumn("dbo.Attachments", "Films_Id", c => c.Int());
            CreateIndex("dbo.Users", "Films_Id");
            CreateIndex("dbo.Attachments", "Users_Id");
            CreateIndex("dbo.Attachments", "Films_Id");
            AddForeignKey("dbo.Users", "Films_Id", "dbo.Films", "Id");
            AddForeignKey("dbo.Attachments", "Users_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Attachments", "Films_Id", "dbo.Films", "Id");
        }
    }
}
