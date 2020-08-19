namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Films_Id", "dbo.Films");
            DropIndex("dbo.Users", new[] { "Films_Id" });
            DropColumn("dbo.Users", "Films_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Films_Id", c => c.Int());
            CreateIndex("dbo.Users", "Films_Id");
            AddForeignKey("dbo.Users", "Films_Id", "dbo.Films", "Id");
        }
    }
}
