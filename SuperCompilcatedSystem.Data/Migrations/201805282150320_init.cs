namespace SuperCompilcatedSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Model = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PCComponents",
                c => new
                    {
                        PC_Id = c.Int(nullable: false),
                        Components_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PC_Id, t.Components_Id })
                .ForeignKey("dbo.PCs", t => t.PC_Id)
                .ForeignKey("dbo.Components", t => t.Components_Id)
                .Index(t => t.PC_Id)
                .Index(t => t.Components_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PCComponents", "Components_Id", "dbo.Components");
            DropForeignKey("dbo.PCComponents", "PC_Id", "dbo.PCs");
            DropIndex("dbo.PCComponents", new[] { "Components_Id" });
            DropIndex("dbo.PCComponents", new[] { "PC_Id" });
            DropTable("dbo.PCComponents");
            DropTable("dbo.PCs");
            DropTable("dbo.Components");
        }
    }
}
