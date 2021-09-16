using Microsoft.EntityFrameworkCore.Migrations;

namespace akbkoleso.Migrations.akbkolesoCatalog
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_tires_wheelss",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diametr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gaika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zavod_shini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zamen_shini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tuning_shini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zavod_diskov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zamen_diskov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tuning_diski = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_tires_wheelss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podbor_akbs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_end = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mochnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emkost_ot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emkost_do = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polarnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dlina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shirina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diametr_klem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tok_xol_prok = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podbor_akbs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_tires_wheelss");

            migrationBuilder.DropTable(
                name: "Podbor_akbs");
        }
    }
}
