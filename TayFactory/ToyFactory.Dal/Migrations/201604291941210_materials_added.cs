namespace ToyFactory.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class materials_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        PasspartCode = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FamilyName = c.String(),
                        AddressLine = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Title = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Toy_ToyId = c.Int(),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.Toys", t => t.Toy_ToyId)
                .Index(t => t.Toy_ToyId);
            
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        ToyId = c.Int(nullable: false, identity: true),
                        Article = c.String(),
                        Title = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ToyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Toy_ToyId", "dbo.Toys");
            DropIndex("dbo.Materials", new[] { "Toy_ToyId" });
            DropTable("dbo.Toys");
            DropTable("dbo.Materials");
            DropTable("dbo.Customers");
        }
    }
}
