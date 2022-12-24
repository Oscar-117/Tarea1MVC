using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tareas1MVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id From AspNetRoles Where Id = '35d2fd14-9705-486b-a14c-d7bb40fef811')
BEGIN 
	INSERT AspNetRoles (Id, [Name], [NormalizedName])
	VALUES ('35d2fd14-9705-486b-a14c-d7bb40fef811', 'admin', 'ADMIN')

END");
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = '35d2fd14-9705-486b-a14c-d7bb40fef811'");

        }
    }
}
