using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWarehouseAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodDetails",
                columns: table => new
                {
                    GoodDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GoodQuantity = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    GoodUnits = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GoodImage = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    GoodVendor = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GoodContractNum = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GoodContractDate = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodDetails", x => x.GoodDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodDetails");
        }
    }
}
