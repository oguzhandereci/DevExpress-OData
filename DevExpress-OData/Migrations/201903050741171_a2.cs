namespace DevExpress_OData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Phone", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Phone", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
