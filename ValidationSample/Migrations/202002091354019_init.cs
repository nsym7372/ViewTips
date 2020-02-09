namespace ValidationSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Developer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Memo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeopleDevices",
                c => new
                    {
                        Device_Id = c.Int(nullable: false),
                        People_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Device_Id, t.People_Id })
                .ForeignKey("dbo.Devices", t => t.Device_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.People_Id, cascadeDelete: true)
                .Index(t => t.Device_Id)
                .Index(t => t.People_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeopleDevices", "People_Id", "dbo.People");
            DropForeignKey("dbo.PeopleDevices", "Device_Id", "dbo.Devices");
            DropIndex("dbo.PeopleDevices", new[] { "People_Id" });
            DropIndex("dbo.PeopleDevices", new[] { "Device_Id" });
            DropTable("dbo.PeopleDevices");
            DropTable("dbo.People");
            DropTable("dbo.Devices");
        }
    }
}
