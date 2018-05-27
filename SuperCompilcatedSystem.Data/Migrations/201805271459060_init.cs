namespace SuperCompilcatedSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                        equipmentType_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.equipmentTypes", t => t.equipmentType_id)
                .Index(t => t.equipmentType_id);
            
            CreateTable(
                "dbo.equipmentTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "equipmentType_id", "dbo.equipmentTypes");
            DropIndex("dbo.Equipments", new[] { "equipmentType_id" });
            DropTable("dbo.equipmentTypes");
            DropTable("dbo.Equipments");
        }
    }
}
