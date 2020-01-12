using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuniorWebApp.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] {Guid.Parse("2ED3F6BA-FD71-433B-867C-3FA3A7BCC736"), "Laptop MSI Alpha 15 (A3DD-032XPL)", 4299.00m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("3AAFDC0A-F34F-44ED-954B-A15A26B111C9"), "Laptop Acer Nitro 5 (NH.Q5XEP.003)", 2999.00m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("966E64C2-879C-43C4-9586-B043064FB86A"), "Klawiatura HYKKER dla graczy", 52.00m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("5C14ADDD-5DD8-45D7-B1E3-B0EB0E1465186"), "Laptop ASUS VivoBook E203MA N4000 4GB 64GB eMMC W10S", 1099.43m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("50921C24-8CB2-4D8F-84AF-B48A32B95517"), "Laptop ASUS VivoBook 15 (R512UB-EJ114) 4417U 4GB 256GB SSD GF-MX110 W10", 2099.99m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("D4A8BE32-D25B-4A13-B138-BAA6AA80371B"), "Monitor IIYAMA G-MASTER G2530HSU-B1", 599.00m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("7C9E6679-7425-40DE-944B-E07FC1F90AE7"), "Mysz Sharkoon Skiller SGM2", 97.01m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("C1820AB0-0E63-4DD7-8A32-EFF5F7628F92"), "Smartfon SAMSUNG Galaxy S10e, 128 GB, Dual SIM", 2339.00m }
            );
            migrationBuilder.InsertData
            (
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { Guid.Parse("178F9C73-6612-49C3-95ED-F088EE325DE3"), "Smartfon XIAOMI Redmi Note 5, 64 GB, Dual SIM", 622.00m }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("2ED3F6BA-FD71-433B-867C-3FA3A7BCC736")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("3AAFDC0A-F34F-44ED-954B-A15A26B111C9")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("966E64C2-879C-43C4-9586-B043064FB86A")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("5C14ADDD-5DD8-45D7-B1E3-B0EB0E146518")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("50921C24-8CB2-4D8F-84AF-B48A32B95517")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("D4A8BE32-D25B-4A13-B138-BAA6AA80371B")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("7C9E6679-7425-40DE-944B-E07FC1F90AE7")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("C1820AB0-0E63-4DD7-8A32-EFF5F7628F92")
            );
            migrationBuilder.DeleteData
            (
                table: "Products",
                keyColumn: "Id",
                keyValue: Guid.Parse("178F9C73-6612-49C3-95ED-F088EE325DE3")
            );
        }
    }
}
