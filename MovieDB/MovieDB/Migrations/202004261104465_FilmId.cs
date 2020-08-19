namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "FilmsId", "dbo.Films");
            DropIndex("dbo.Attachments", new[] { "FilmsId" });
            AlterColumn("dbo.Attachments", "FilmsId", c => c.Int());
            CreateIndex("dbo.Attachments", "FilmsId");
            AddForeignKey("dbo.Attachments", "FilmsId", "dbo.Films", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attachments", "FilmsId", "dbo.Films");
            DropIndex("dbo.Attachments", new[] { "FilmsId" });
            AlterColumn("dbo.Attachments", "FilmsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Attachments", "FilmsId");
            AddForeignKey("dbo.Attachments", "FilmsId", "dbo.Films", "Id", cascadeDelete: true);
        }
    }
}
