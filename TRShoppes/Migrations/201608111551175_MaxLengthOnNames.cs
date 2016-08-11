namespace TRShoppes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "LastName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "LastName", c => c.String());
            AlterColumn("dbo.Customer", "FirstName", c => c.String());
        }
    }
}
