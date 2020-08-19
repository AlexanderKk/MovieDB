namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmFilePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "FilePath");
        }
    }
}
