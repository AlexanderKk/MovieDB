namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "view");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "view", c => c.Boolean());
        }
    }
}
