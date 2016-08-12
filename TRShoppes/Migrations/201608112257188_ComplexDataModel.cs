namespace TRShoppes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Budget = c.Decimal(nullable: false, storeType: "money"),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpLastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Product", "DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "Department_EmployeeID", c => c.Int());
            AlterColumn("dbo.Customer", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Product", "ProdDesc", c => c.String(maxLength: 50));
            CreateIndex("dbo.Product", "Department_EmployeeID");
            AddForeignKey("dbo.Product", "Department_EmployeeID", "dbo.Department", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Department_EmployeeID", "dbo.Department");
            DropForeignKey("dbo.Department", "EmployeeID", "dbo.Employee");
            DropIndex("dbo.Department", new[] { "EmployeeID" });
            DropIndex("dbo.Product", new[] { "Department_EmployeeID" });
            AlterColumn("dbo.Product", "ProdDesc", c => c.String());
            AlterColumn("dbo.Customer", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "FirstName", c => c.String(maxLength: 50));
            DropColumn("dbo.Product", "Department_EmployeeID");
            DropColumn("dbo.Product", "DepartmentID");
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
        }
    }
}
