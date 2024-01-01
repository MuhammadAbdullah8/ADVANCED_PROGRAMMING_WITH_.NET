namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedreviewdby : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adminhotelreviews", "reviewdby", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adminhotelreviews", "reviewdby");
        }
    }
}
