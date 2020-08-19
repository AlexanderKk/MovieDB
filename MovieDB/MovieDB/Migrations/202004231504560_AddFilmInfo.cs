namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.Films", "Country", c => c.String());
            AddColumn("dbo.Films", "Tagline", c => c.String());
            AddColumn("dbo.Films", "Director", c => c.String());
            AddColumn("dbo.Films", "Genre", c => c.String());
            AddColumn("dbo.Films", "Premiere", c => c.DateTime());
            AddColumn("dbo.Films", "Time", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Time");
            DropColumn("dbo.Films", "Premiere");
            DropColumn("dbo.Films", "Genre");
            DropColumn("dbo.Films", "Director");
            DropColumn("dbo.Films", "Tagline");
            DropColumn("dbo.Films", "Country");
            DropColumn("dbo.Films", "Year");
        }
    }
}
