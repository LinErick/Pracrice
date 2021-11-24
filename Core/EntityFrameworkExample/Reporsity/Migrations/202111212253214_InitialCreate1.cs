namespace Reporsity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("ef.Employee", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("ef.Employee", "Name");
        }
    }
}
