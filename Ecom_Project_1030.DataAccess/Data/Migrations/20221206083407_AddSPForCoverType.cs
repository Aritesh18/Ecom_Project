using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecom_Project_1030.DataAccess.Migrations
{
    public partial class AddSPForCoverType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE CreateCoverTypes
                                @name varchar(50)
                                AS
                                insert CoverTypes values(@name)
                                ");

            migrationBuilder.Sql(@"CREATE PROCEDURE UpdateCoverTypes
                                @id int,
                                @name varchar(50)
                                AS
                                update CoverTypes set Name=@name where Id=@id
                                ");

            migrationBuilder.Sql(@"CREATE PROCEDURE DeleteCoverTypes
                                @id int
                                AS
                                delete CoverTypes where Id=@id
                                ");

            migrationBuilder.Sql(@"CREATE PROCEDURE GetCoverTypes
                                AS
                                select*from CoverTypes
                                ");

            migrationBuilder.Sql(@"CREATE PROCEDURE GetCoverType
                                @id int
                                AS
                                select*from CoverTypes where Id=@id
                                ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
