namespace HomeVidProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'SciFi')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Drama')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (5, 'Romance')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (6, 'Family')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
