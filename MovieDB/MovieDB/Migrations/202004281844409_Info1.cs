namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Info1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "RatingDate", c => c.DateTime());
            AddColumn("dbo.Attachments", "ViewDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "ViewDate");
            DropColumn("dbo.Attachments", "RatingDate");
        }
    }
}
