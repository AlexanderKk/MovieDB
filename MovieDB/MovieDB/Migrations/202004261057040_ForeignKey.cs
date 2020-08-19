namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "Films_Id", "dbo.Films");
            DropIndex("dbo.Attachments", new[] { "Films_Id" });
            RenameColumn(table: "dbo.Attachments", name: "Films_Id", newName: "FilmsId");
            AlterColumn("dbo.Attachments", "FilmsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Attachments", "FilmsId");
            AddForeignKey("dbo.Attachments", "FilmsId", "dbo.Films", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attachments", "FilmsId", "dbo.Films");
            DropIndex("dbo.Attachments", new[] { "FilmsId" });
            AlterColumn("dbo.Attachments", "FilmsId", c => c.Int());
            RenameColumn(table: "dbo.Attachments", name: "FilmsId", newName: "Films_Id");
            CreateIndex("dbo.Attachments", "Films_Id");
            AddForeignKey("dbo.Attachments", "Films_Id", "dbo.Films", "Id");
        }
    }
}
