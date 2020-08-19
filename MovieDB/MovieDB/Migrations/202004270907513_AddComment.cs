namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "Comment");
        }
    }
}
