namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "UserID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "UserID");
        }
    }
}
