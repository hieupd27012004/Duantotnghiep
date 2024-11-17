using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class update_lan2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("4a5f767a-6dcd-42b8-ad4d-5dd3374fbfe9"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("dbc2c869-9dde-4da9-8da6-e110e3457c52"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("f5780e05-4219-49f1-b33a-776478b9a996"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("066ad9fe-0381-48b9-9497-7e6d099003c1"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("37a38214-9528-41b2-8a7f-33727e929902"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("4592e586-67a3-4292-a9ad-9231c3105061"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("883925d5-19b7-4930-87ec-8b78f1a1e886"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("8d99223c-264f-4434-bac4-a6c83f0cefac"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("c251ccc6-569e-4b19-8dba-f770dc6a06ce"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("497d80ee-64b6-4dd2-8eca-7e8f2877fe44"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("6accb8a6-1ff2-462f-8ee7-66245d3d4bf4"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("e329f2b7-4f4f-465d-be43-797be3a6f4c1"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("05639b16-4f8a-4ecd-a35d-02ef2fe196ec"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("4073068b-5622-40a9-adad-2bf61d8eec9c"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("ad992fb7-051f-4869-8199-cae0888acada"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("0c74c3b9-cc2c-4667-be1f-de2fb33e372d"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("0de25d3f-eb47-4072-87d8-15e0cea14737"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("c8ec316c-a38f-4dc0-89b7-b07243ea4d1d"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("1d6771a9-c91a-4c5e-9624-f7774c5b5d59"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("a52501f3-f0bb-4305-a7b5-d7efa11bd5d8"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("a84b9d0e-2b5c-4f75-84ee-54ae8e51d93e"));

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    WardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.WardId);
                });

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("6462b9cc-3795-4154-b85c-ebae41f3bd57"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8418), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("be47a0ac-a266-4c79-9d8a-75ab8ae47b36"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8429), new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8429), "Admin", "Admin", "Da thật" },
                    { new Guid("caecb48b-9b72-4291-aef6-58e3906d99e2"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 11, 17, 21, 48, 33, 799, DateTimeKind.Local).AddTicks(8431), "Admin", "Admin", "Vải Polyester" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("3643b547-07b4-4b56-8312-9788c213d0f7"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5141), "Admin", "Admin", "Giày Cao Gót" },
                    { new Guid("5036e79d-d219-4645-9aae-7315aecf436c"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5131), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("d0e348c6-9575-4feb-aef8-164df3edc263"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 11, 17, 21, 48, 33, 800, DateTimeKind.Local).AddTicks(5139), "Admin", "Admin", "Giày Da" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("423d6e16-7e46-4013-88e5-3f73db8df173"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("808b3ebe-bd6f-4cef-af9e-454c3ffe03bf"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("dda1d026-ebd8-4915-b7f3-e240842eb086"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("4d4740f4-db6b-461c-b874-46aa42555a6f"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4715), "Admin", "Admin", "Size 37" },
                    { new Guid("71b9d9e3-29aa-4000-990e-42c0096db7fb"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4720), "Admin", "Admin", "Size 39" },
                    { new Guid("71ce3af5-d60e-4047-8e85-91d793b00e18"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(4718), "Admin", "Admin", "Size 38" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("30a92d7d-5125-40ac-ba8e-904cf488cba9"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8442), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("318574a9-ba42-44ca-83e5-f248c0a48f7d"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8432), "Admin", "Admin", "Thể Thao" },
                    { new Guid("7add19d8-490c-4ecf-b4f1-d920d5ad637d"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 11, 17, 21, 48, 33, 805, DateTimeKind.Local).AddTicks(8440), "Admin", "Admin", "Cổ Điển" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("33430c16-0d88-479d-8dbe-ba4b9eb69fee"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9883), "Admin", "Admin", "Green" },
                    { new Guid("46a1faf8-a01b-4505-aaa7-7b48cbfa7f32"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9881), "Admin", "Admin", "Red" },
                    { new Guid("898789d1-1b0f-4da8-bea5-fdbf589e94a9"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 11, 17, 21, 48, 33, 806, DateTimeKind.Local).AddTicks(9892), "Admin", "Admin", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("4f69e642-755a-457d-aace-20185eec66ca"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2662), "Admin", "Admin", "Adidas" },
                    { new Guid("bf4acc84-8cf3-41d3-aa88-f240a78aed45"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2665), new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2664), "Admin", "Admin", "Puma" },
                    { new Guid("fd2cf426-561f-4f55-90c6-cee0308a0208"), 1, new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 11, 17, 21, 48, 33, 812, DateTimeKind.Local).AddTicks(2646), "Admin", "Admin", "Nike" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "wards");

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("6462b9cc-3795-4154-b85c-ebae41f3bd57"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("be47a0ac-a266-4c79-9d8a-75ab8ae47b36"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("caecb48b-9b72-4291-aef6-58e3906d99e2"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("3643b547-07b4-4b56-8312-9788c213d0f7"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("5036e79d-d219-4645-9aae-7315aecf436c"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("d0e348c6-9575-4feb-aef8-164df3edc263"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("423d6e16-7e46-4013-88e5-3f73db8df173"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("808b3ebe-bd6f-4cef-af9e-454c3ffe03bf"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("dda1d026-ebd8-4915-b7f3-e240842eb086"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("4d4740f4-db6b-461c-b874-46aa42555a6f"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("71b9d9e3-29aa-4000-990e-42c0096db7fb"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("71ce3af5-d60e-4047-8e85-91d793b00e18"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("30a92d7d-5125-40ac-ba8e-904cf488cba9"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("318574a9-ba42-44ca-83e5-f248c0a48f7d"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("7add19d8-490c-4ecf-b4f1-d920d5ad637d"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("33430c16-0d88-479d-8dbe-ba4b9eb69fee"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("46a1faf8-a01b-4505-aaa7-7b48cbfa7f32"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("898789d1-1b0f-4da8-bea5-fdbf589e94a9"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("4f69e642-755a-457d-aace-20185eec66ca"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("bf4acc84-8cf3-41d3-aa88-f240a78aed45"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("fd2cf426-561f-4f55-90c6-cee0308a0208"));

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("4a5f767a-6dcd-42b8-ad4d-5dd3374fbfe9"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1367), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("dbc2c869-9dde-4da9-8da6-e110e3457c52"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1371), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("f5780e05-4219-49f1-b33a-776478b9a996"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(1369), "Admin", "Admin", "Da thật" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("066ad9fe-0381-48b9-9497-7e6d099003c1"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7196), "Admin", "Admin", "Giày Da" },
                    { new Guid("37a38214-9528-41b2-8a7f-33727e929902"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7189), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("4592e586-67a3-4292-a9ad-9231c3105061"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7198), new DateTime(2024, 11, 17, 21, 41, 37, 153, DateTimeKind.Local).AddTicks(7198), "Admin", "Admin", "Giày Cao Gót" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("883925d5-19b7-4930-87ec-8b78f1a1e886"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("8d99223c-264f-4434-bac4-a6c83f0cefac"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("c251ccc6-569e-4b19-8dba-f770dc6a06ce"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("497d80ee-64b6-4dd2-8eca-7e8f2877fe44"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7859), "Admin", "Admin", "Size 37" },
                    { new Guid("6accb8a6-1ff2-462f-8ee7-66245d3d4bf4"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7861), new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7862), "Admin", "Admin", "Size 38" },
                    { new Guid("e329f2b7-4f4f-465d-be43-797be3a6f4c1"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 11, 17, 21, 41, 37, 158, DateTimeKind.Local).AddTicks(7880), "Admin", "Admin", "Size 39" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("05639b16-4f8a-4ecd-a35d-02ef2fe196ec"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(824), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("4073068b-5622-40a9-adad-2bf61d8eec9c"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(819), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("ad992fb7-051f-4869-8199-cae0888acada"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(814), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("0c74c3b9-cc2c-4667-be1f-de2fb33e372d"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9977), "Admin", "Admin", "Green" },
                    { new Guid("0de25d3f-eb47-4072-87d8-15e0cea14737"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9974), "Admin", "Admin", "Red" },
                    { new Guid("c8ec316c-a38f-4dc0-89b7-b07243ea4d1d"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9978), new DateTime(2024, 11, 17, 21, 41, 37, 159, DateTimeKind.Local).AddTicks(9979), "Admin", "Admin", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("1d6771a9-c91a-4c5e-9624-f7774c5b5d59"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(144), "Admin", "Admin", "Nike" },
                    { new Guid("a52501f3-f0bb-4305-a7b5-d7efa11bd5d8"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(162), new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(162), "Admin", "Admin", "Puma" },
                    { new Guid("a84b9d0e-2b5c-4f75-84ee-54ae8e51d93e"), 1, new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 11, 17, 21, 41, 37, 164, DateTimeKind.Local).AddTicks(160), "Admin", "Admin", "Adidas" }
                });
        }
    }
}
