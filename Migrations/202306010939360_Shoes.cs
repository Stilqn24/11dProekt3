namespace _11dProekt3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Size = c.Int(nullable: false),
                        ShoeTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoeTypes", t => t.ShoeTypeId, cascadeDelete: true)
                .Index(t => t.ShoeTypeId);
            
            CreateTable(
                "dbo.ShoeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shoes", "ShoeTypeId", "dbo.ShoeTypes");
            DropIndex("dbo.Shoes", new[] { "ShoeTypeId" });
            DropTable("dbo.ShoeTypes");
            DropTable("dbo.Shoes");
        }
    }
}
