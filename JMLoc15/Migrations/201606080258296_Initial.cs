namespace JMLoc15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Celphone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Celphone", c => c.String());
        }
    }
}
