namespace GamesVille.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUserRoles", "UserId", c=>c.String());
            AddColumn("dbo.AspNetUserRoles", "RoleId", c=>c.Int()) ;
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUserRoles", "UserId"); 
            DropColumn("dbo.AspNetUserRoles", "RoleId"); 
        }
    }
}
