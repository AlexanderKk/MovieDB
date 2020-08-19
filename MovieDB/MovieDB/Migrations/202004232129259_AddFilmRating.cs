namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Rating");
        }
    }
}
