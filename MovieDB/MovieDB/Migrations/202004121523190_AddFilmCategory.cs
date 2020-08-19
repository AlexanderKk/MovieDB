namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Category");
        }
    }
}
