namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movie", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movie", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movie", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Rating", c => c.String());
            AlterColumn("dbo.Movie", "Genre", c => c.String());
            AlterColumn("dbo.Movie", "Title", c => c.String());
        }
    }
}
