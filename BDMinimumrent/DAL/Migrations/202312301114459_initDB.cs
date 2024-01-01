namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adminhotelinfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        info = c.String(nullable: false),
                        Hoteldescription = c.String(nullable: false),
                        Hotelpostinfo = c.String(maxLength: 128),
                        Datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Adminhotelrents", t => t.Hotelpostinfo)
                .Index(t => t.Hotelpostinfo);
            
            CreateTable(
                "dbo.Adminhotelreviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        time = c.DateTime(nullable: false),
                        reviewinfo = c.String(maxLength: 128),
                        hotelpostinfoid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Adminhotelinfoes", t => t.hotelpostinfoid, cascadeDelete: true)
                .ForeignKey("dbo.Adminhotelrents", t => t.reviewinfo)
                .Index(t => t.reviewinfo)
                .Index(t => t.hotelpostinfoid);
            
            CreateTable(
                "dbo.Adminhotelrents",
                c => new
                    {
                        HotelName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Hoteltype = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.HotelName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adminhotelinfoes", "Hotelpostinfo", "dbo.Adminhotelrents");
            DropForeignKey("dbo.Adminhotelreviews", "reviewinfo", "dbo.Adminhotelrents");
            DropForeignKey("dbo.Adminhotelreviews", "hotelpostinfoid", "dbo.Adminhotelinfoes");
            DropIndex("dbo.Adminhotelreviews", new[] { "hotelpostinfoid" });
            DropIndex("dbo.Adminhotelreviews", new[] { "reviewinfo" });
            DropIndex("dbo.Adminhotelinfoes", new[] { "Hotelpostinfo" });
            DropTable("dbo.Adminhotelrents");
            DropTable("dbo.Adminhotelreviews");
            DropTable("dbo.Adminhotelinfoes");
        }
    }
}
