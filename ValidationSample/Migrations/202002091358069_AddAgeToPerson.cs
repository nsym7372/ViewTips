namespace ValidationSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeToPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Age");
        }
    }
}
