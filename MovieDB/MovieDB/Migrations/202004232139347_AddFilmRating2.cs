namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmRating2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Rating", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Rating");
        }
    }
}
