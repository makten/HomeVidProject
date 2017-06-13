using System.Windows.Markup;

namespace HomeVidProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Action')" );
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Comedy')" );
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'Drama')" );
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Family')" );
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (5, 'SciFi')" );
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
