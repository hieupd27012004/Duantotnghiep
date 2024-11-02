using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class UpdateVoucher3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayUpdate",
                table: "vouchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTao",
                table: "vouchers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NguoiUpdate",
                table: "vouchers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayUpdate",
                table: "vouchers");

            migrationBuilder.DropColumn(
                name: "NguoiTao",
                table: "vouchers");

            migrationBuilder.DropColumn(
                name: "NguoiUpdate",
                table: "vouchers");
        }
    }
}
