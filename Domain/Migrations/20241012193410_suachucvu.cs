using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class suachucvu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_chuVu_IdNhanVien",
                table: "nhanViens");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "nhanViens",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "nhanViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_IdchucVu",
                table: "nhanViens",
                column: "IdchucVu");

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_chuVu_IdchucVu",
                table: "nhanViens",
                column: "IdchucVu",
                principalTable: "chuVu",
                principalColumn: "IdChucVu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_chuVu_IdchucVu",
                table: "nhanViens");

            migrationBuilder.DropIndex(
                name: "IX_nhanViens_IdchucVu",
                table: "nhanViens");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "nhanViens",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "nhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_chuVu_IdNhanVien",
                table: "nhanViens",
                column: "IdNhanVien",
                principalTable: "chuVu",
                principalColumn: "IdChucVu",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
