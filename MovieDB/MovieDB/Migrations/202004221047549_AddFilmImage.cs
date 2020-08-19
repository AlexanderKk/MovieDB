namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Image");
        }
    }
}
