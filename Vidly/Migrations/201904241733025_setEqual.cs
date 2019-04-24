namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setEqual : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Movies.NumberAvailable = Movies.NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
