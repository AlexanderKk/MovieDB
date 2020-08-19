namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInfoFilm : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "NumberOfStars", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "NumberOfStars", c => c.Int(nullable: false));
        }
    }
}
