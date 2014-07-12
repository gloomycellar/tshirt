namespace tshirt.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tshirts", newName: "Products");
            RenameColumn(table: "dbo.UrlDetails", name: "Tshirt_Id", newName: "Product_Id");
            RenameIndex(table: "dbo.UrlDetails", name: "IX_Tshirt_Id", newName: "IX_Product_Id");
            AlterColumn("dbo.Products", "Category", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.UrlDetails", name: "IX_Product_Id", newName: "IX_Tshirt_Id");
            RenameColumn(table: "dbo.UrlDetails", name: "Product_Id", newName: "Tshirt_Id");
            RenameTable(name: "dbo.Products", newName: "Tshirts");
        }
    }
}
