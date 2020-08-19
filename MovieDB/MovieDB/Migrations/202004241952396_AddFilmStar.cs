namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmStar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "NumberOfStars", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "NumberOfStars");
        }
    }
}
