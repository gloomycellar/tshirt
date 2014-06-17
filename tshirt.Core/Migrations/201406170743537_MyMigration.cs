namespace tshirt.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tshirts", newName: "Products");
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Availability", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Products", "Category", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Discriminator");
            DropColumn("dbo.Products", "Availability");
            DropTable("dbo.Carts");
            RenameTable(name: "dbo.Products", newName: "Tshirts");
        }
    }
}
