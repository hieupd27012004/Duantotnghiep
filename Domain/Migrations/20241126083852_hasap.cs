using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class hasap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("16325161-29a8-48a6-9f4c-7c253505071a"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("8ecd54b1-32e9-4b1c-ba42-01f768bb314f"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("d730d3ee-ba33-44d8-ae72-c54a81a00c23"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("6d023072-54a7-4265-8035-7cbf0b7beda1"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("83f7b90c-34ac-4229-821d-68d2ad14670d"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("c2a44607-03f7-40e9-ade2-249aa464fb51"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("f44bd6cd-9639-44c8-91b5-a922f2127308"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("088dba2a-2c1a-478d-8793-5bedece7d11d"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("6d9fd9dc-1404-4737-90ba-d947b6dc7594"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("96c14b73-7cf8-4c84-805b-2b1d46ac6bfc"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("4cf7f1f0-4f7e-48c9-a006-6160c358829c"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("ca59c74f-8475-4bd8-9653-81caa1705e14"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("d723e965-fac8-436b-80fd-ca9a48a6a237"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("8c02fb7c-5afa-4d00-a8a2-4da69f64ede4"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("8c27d1fc-aa37-4a2f-a6dc-7c7bb059d05f"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("fe1e1e7d-e1a6-47c7-9b53-e59281c565b6"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("5e92a7d6-8825-4ab5-818c-fdcb9a9d801e"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("638b2fcc-a295-41f5-be5e-754abac845c8"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("7daf32a5-1db9-4f14-a074-f8c65276be17"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("25335948-4dd0-42c9-908b-6b9c1c1b03dc"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("93978c01-e9ea-413a-a3d3-c8cd0f512d37"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("d162b121-55c6-4a7b-8f60-dc6d7b1812ac"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("16db0c45-e61a-4520-961f-882fcf29f6d0"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("30c6c9b8-5246-40c7-a1c4-251951efc9e9"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("4b602441-fe4a-499e-be0a-321269e181ca"));

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("4f742a82-f0a2-4244-80b8-041c8fbfd519"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4799), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("65774791-3560-4ce9-81b9-ae2a11aca863"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4806), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("a7b0c252-71d9-48ac-b45f-89860d8c5f1d"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 11, 26, 15, 38, 51, 114, DateTimeKind.Local).AddTicks(4804), "Admin", "Admin", "Da thật" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("118cbf1d-b30b-42b1-bbd0-10ba086b8f4e"), "QL", "Quản lý" },
                    { new Guid("6d0a6555-45d7-49e6-997f-f4c9e9495482"), "KT", "Kế toán" },
                    { new Guid("7ce0fd69-4db1-4bb0-aa88-ce67702432bd"), "KK", "Thủ kho" },
                    { new Guid("80db8063-4740-4f00-9005-e449a76b6b80"), "NV", "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("58753d0d-92f5-46d1-8c81-a64a3af84e67"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2275), "Admin", "Admin", "Giày Da" },
                    { new Guid("5e0e5135-4e39-4f12-83de-2383e7b653b6"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2278), new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2277), "Admin", "Admin", "Giày Cao Gót" },
                    { new Guid("dd01053c-1742-45ad-b004-02eb1b9e8153"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2267), new DateTime(2024, 11, 26, 15, 38, 51, 116, DateTimeKind.Local).AddTicks(2262), "Admin", "Admin", "Giày Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("19b4ce0e-b3f9-4500-a02e-0f1ceedba9f1"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("43689557-59d3-47e6-ad71-aa42f83fb214"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("71f74dfc-559a-4f65-b785-9a0ed42bea21"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("5b2c74a1-bbc9-4b1d-b024-4b3440f12925"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8564), "Admin", "Admin", "Size 37" },
                    { new Guid("64b1d8d9-a640-4f1c-a6a1-1db45e24dc7a"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8573), new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8574), "Admin", "Admin", "Size 39" },
                    { new Guid("99499f99-16ac-4176-b060-9f91d5692d07"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 11, 26, 15, 38, 51, 123, DateTimeKind.Local).AddTicks(8570), "Admin", "Admin", "Size 38" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("2ca827ea-24d8-4dd1-ba61-26cb1e500e53"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4620), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("7048ddba-4785-4d2e-b378-dbafad0aeca4"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4623), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("dbda968d-8cb5-4db6-a5f9-c02943898495"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 11, 26, 15, 38, 51, 124, DateTimeKind.Local).AddTicks(4608), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("447ce7e3-c728-4186-a021-babea486804f"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6881), "Admin", "Admin", "Green" },
                    { new Guid("8f88025c-2e97-4338-8954-798e08049c81"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6884), "Admin", "Admin", "Blue" },
                    { new Guid("b0f90871-cc84-4687-befa-ba39427a5e51"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 11, 26, 15, 38, 51, 127, DateTimeKind.Local).AddTicks(6878), "Admin", "Admin", "Red" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("62fcc884-b18e-4db3-97f9-bd3c7e19e058"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8297), "Admin", "Admin", "Nike" },
                    { new Guid("ad3a13c5-373b-401f-a185-f571a7fac3f0"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8311), new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8311), "Admin", "Admin", "Puma" },
                    { new Guid("f3a3cc20-624d-4a7f-9ba7-7cbd02a3cd22"), 1, new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 11, 26, 15, 38, 51, 134, DateTimeKind.Local).AddTicks(8309), "Admin", "Admin", "Adidas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("4f742a82-f0a2-4244-80b8-041c8fbfd519"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("65774791-3560-4ce9-81b9-ae2a11aca863"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("a7b0c252-71d9-48ac-b45f-89860d8c5f1d"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("118cbf1d-b30b-42b1-bbd0-10ba086b8f4e"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("6d0a6555-45d7-49e6-997f-f4c9e9495482"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("7ce0fd69-4db1-4bb0-aa88-ce67702432bd"));

            migrationBuilder.DeleteData(
                table: "chuVu",
                keyColumn: "IdChucVu",
                keyValue: new Guid("80db8063-4740-4f00-9005-e449a76b6b80"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("58753d0d-92f5-46d1-8c81-a64a3af84e67"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("5e0e5135-4e39-4f12-83de-2383e7b653b6"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("dd01053c-1742-45ad-b004-02eb1b9e8153"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("19b4ce0e-b3f9-4500-a02e-0f1ceedba9f1"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("43689557-59d3-47e6-ad71-aa42f83fb214"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("71f74dfc-559a-4f65-b785-9a0ed42bea21"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("5b2c74a1-bbc9-4b1d-b024-4b3440f12925"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("64b1d8d9-a640-4f1c-a6a1-1db45e24dc7a"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("99499f99-16ac-4176-b060-9f91d5692d07"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("2ca827ea-24d8-4dd1-ba61-26cb1e500e53"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("7048ddba-4785-4d2e-b378-dbafad0aeca4"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("dbda968d-8cb5-4db6-a5f9-c02943898495"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("447ce7e3-c728-4186-a021-babea486804f"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("8f88025c-2e97-4338-8954-798e08049c81"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("b0f90871-cc84-4687-befa-ba39427a5e51"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("62fcc884-b18e-4db3-97f9-bd3c7e19e058"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("ad3a13c5-373b-401f-a185-f571a7fac3f0"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("f3a3cc20-624d-4a7f-9ba7-7cbd02a3cd22"));

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("16325161-29a8-48a6-9f4c-7c253505071a"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(21), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("8ecd54b1-32e9-4b1c-ba42-01f768bb314f"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(19), "Admin", "Admin", "Da thật" },
                    { new Guid("d730d3ee-ba33-44d8-ae72-c54a81a00c23"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 165, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(8), "Admin", "Admin", "Vải Cotton" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("6d023072-54a7-4265-8035-7cbf0b7beda1"), "KK", "Thủ kho" },
                    { new Guid("83f7b90c-34ac-4229-821d-68d2ad14670d"), "KT", "Kế toán" },
                    { new Guid("c2a44607-03f7-40e9-ade2-249aa464fb51"), "QL", "Quản lý" },
                    { new Guid("f44bd6cd-9639-44c8-91b5-a922f2127308"), "NV", "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("088dba2a-2c1a-478d-8793-5bedece7d11d"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5404), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("6d9fd9dc-1404-4737-90ba-d947b6dc7594"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5417), "Admin", "Admin", "Giày Cao Gót" },
                    { new Guid("96c14b73-7cf8-4c84-805b-2b1d46ac6bfc"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 11, 25, 18, 1, 44, 166, DateTimeKind.Local).AddTicks(5410), "Admin", "Admin", "Giày Da" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("4cf7f1f0-4f7e-48c9-a006-6160c358829c"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("ca59c74f-8475-4bd8-9653-81caa1705e14"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("d723e965-fac8-436b-80fd-ca9a48a6a237"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("8c02fb7c-5afa-4d00-a8a2-4da69f64ede4"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5172), "Admin", "Admin", "Size 38" },
                    { new Guid("8c27d1fc-aa37-4a2f-a6dc-7c7bb059d05f"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5169), "Admin", "Admin", "Size 37" },
                    { new Guid("fe1e1e7d-e1a6-47c7-9b53-e59281c565b6"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(5174), "Admin", "Admin", "Size 39" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("5e92a7d6-8825-4ab5-818c-fdcb9a9d801e"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8245), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8244), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("638b2fcc-a295-41f5-be5e-754abac845c8"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8229), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8225), "Admin", "Admin", "Thể Thao" },
                    { new Guid("7daf32a5-1db9-4f14-a074-f8c65276be17"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 11, 25, 18, 1, 44, 171, DateTimeKind.Local).AddTicks(8241), "Admin", "Admin", "Cổ Điển" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("25335948-4dd0-42c9-908b-6b9c1c1b03dc"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2642), new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2643), "Admin", "Admin", "Green" },
                    { new Guid("93978c01-e9ea-413a-a3d3-c8cd0f512d37"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2640), "Admin", "Admin", "Red" },
                    { new Guid("d162b121-55c6-4a7b-8f60-dc6d7b1812ac"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 11, 25, 18, 1, 44, 173, DateTimeKind.Local).AddTicks(2646), "Admin", "Admin", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("16db0c45-e61a-4520-961f-882fcf29f6d0"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2389), "Admin", "Admin", "Puma" },
                    { new Guid("30c6c9b8-5246-40c7-a1c4-251951efc9e9"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2388), new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2387), "Admin", "Admin", "Adidas" },
                    { new Guid("4b602441-fe4a-499e-be0a-321269e181ca"), 1, new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2385), new DateTime(2024, 11, 25, 18, 1, 44, 177, DateTimeKind.Local).AddTicks(2383), "Admin", "Admin", "Nike" }
                });
        }
    }
}
