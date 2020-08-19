namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Attachments", "FilmKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attachments", "FilmKey", c => c.Int());
        }
    }
}
