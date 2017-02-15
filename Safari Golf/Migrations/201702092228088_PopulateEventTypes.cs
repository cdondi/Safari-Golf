namespace SafariGolf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEventTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EventTypes (Id, Name) VALUES ( 0, 'Tournament')");
            Sql("INSERT INTO EventTypes (Id, Name) VALUES ( 1, 'Mug')");
            Sql("INSERT INTO EventTypes (Id, Name) VALUES ( 2, 'Mini Master')");
            Sql("INSERT INTO EventTypes (Id, Name) VALUES ( 3, 'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
