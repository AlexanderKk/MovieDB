namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "Users_Id", "dbo.Users");
            DropIndex("dbo.Films", new[] { "Users_Id" });
            DropColumn("dbo.Films", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Users_Id", c => c.Int());
            CreateIndex("dbo.Films", "Users_Id");
            AddForeignKey("dbo.Films", "Users_Id", "dbo.Users", "Id");
        }
    }
}
