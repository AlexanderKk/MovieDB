namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Attachments", name: "Users_Id", newName: "UsersID");
            RenameIndex(table: "dbo.Attachments", name: "IX_Users_Id", newName: "IX_UsersID");
            DropColumn("dbo.Attachments", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attachments", "UserID", c => c.Int());
            RenameIndex(table: "dbo.Attachments", name: "IX_UsersID", newName: "IX_Users_Id");
            RenameColumn(table: "dbo.Attachments", name: "UsersID", newName: "Users_Id");
        }
    }
}
