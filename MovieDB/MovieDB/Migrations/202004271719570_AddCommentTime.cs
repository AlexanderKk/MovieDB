namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCommentTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "CommentTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "CommentTime");
        }
    }
}
