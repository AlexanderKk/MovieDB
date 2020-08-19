namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdDAttachmentsInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "CheckView", c => c.Boolean());
            AddColumn("dbo.Attachments", "NumberOfStars", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "NumberOfStars");
            DropColumn("dbo.Attachments", "CheckView");
        }
    }
}
