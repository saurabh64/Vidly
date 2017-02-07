namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemembershiptypenames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Membershiptypes SET Name='Pay as you go' WHERE id=1");
            Sql("UPDATE Membershiptypes SET Name='Monthly' WHERE id=2");
            Sql("UPDATE Membershiptypes SET Name='Quarterly' WHERE id=3");
            Sql("UPDATE Membershiptypes SET Name='Yearly' WHERE id=4");

        }
        
        public override void Down()
        {
        }
    }
}
