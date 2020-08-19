namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFavoriteFilm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "FavoriteFilm", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attachments", "FavoriteFilm");
        }
    }
}
