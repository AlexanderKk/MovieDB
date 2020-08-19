namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "User", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "User");
        }
    }
}
