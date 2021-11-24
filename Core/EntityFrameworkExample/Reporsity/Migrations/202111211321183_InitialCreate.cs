namespace Reporsity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ef.DemoTableDetail",
                c => new
                    {
                        SN = c.Int(nullable: false, identity: true),
                        DemoTableSN = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SN)
                .ForeignKey("ef.DemoTable", t => t.DemoTableSN, cascadeDelete: true)
                .Index(t => t.DemoTableSN);
            
            CreateTable(
                "ef.DemoTable",
                c => new
                    {
                        SN = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.SN);
            
            CreateTable(
                "ef.Employee",
                c => new
                    {
                        SN = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ef.DemoTableDetail", "DemoTableSN", "ef.DemoTable");
            DropIndex("ef.DemoTableDetail", new[] { "DemoTableSN" });
            DropTable("ef.Employee");
            DropTable("ef.DemoTable");
            DropTable("ef.DemoTableDetail");
        }
    }
}
