namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilmDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "FilmDescription");
        }
    }
}
