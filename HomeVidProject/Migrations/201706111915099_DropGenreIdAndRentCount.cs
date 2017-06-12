namespace HomeVidProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropGenreIdAndRentCount : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "CountOfRents");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "CountOfRents", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
