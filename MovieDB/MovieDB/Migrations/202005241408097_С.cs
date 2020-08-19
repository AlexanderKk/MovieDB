namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class С : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Tagline", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Tagline", c => c.String(maxLength: 300));
        }
    }
}
