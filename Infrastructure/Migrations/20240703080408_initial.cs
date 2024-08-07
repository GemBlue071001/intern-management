﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Descition = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramKPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KPIId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramKPI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramKPI_KPI_KPIId",
                        column: x => x.KPIId,
                        principalTable: "KPI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramKPI_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 54, 92, 22, 127, 42, 92, 227, 107, 119, 84, 229, 221, 51, 117, 112, 47, 171, 127, 12, 246, 54, 213, 212, 121, 96, 137, 126, 198, 47, 103, 179, 179, 198, 203, 34, 79, 103, 80, 166, 49, 247, 196, 126, 127, 238, 153, 67, 180, 44, 62, 79, 243, 175, 126, 23, 148, 233, 141, 11, 166, 208, 157, 236 }, new byte[] { 139, 184, 209, 32, 14, 1, 53, 43, 31, 205, 50, 242, 124, 248, 73, 51, 218, 31, 151, 248, 169, 99, 53, 229, 18, 111, 89, 14, 178, 226, 137, 210, 174, 61, 139, 230, 243, 3, 139, 194, 51, 78, 244, 180, 223, 192, 139, 177, 16, 213, 84, 122, 51, 173, 152, 104, 95, 191, 27, 152, 221, 35, 233, 68, 24, 251, 18, 228, 172, 196, 6, 30, 113, 160, 157, 118, 58, 35, 206, 212, 60, 221, 226, 102, 116, 126, 162, 45, 17, 208, 82, 149, 35, 80, 14, 7, 147, 252, 126, 90, 100, 199, 62, 60, 171, 212, 215, 250, 204, 218, 138, 105, 190, 134, 14, 239, 126, 231, 236, 169, 196, 210, 220, 15, 201, 62, 4, 3 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 67, 161, 130, 201, 232, 95, 111, 192, 114, 84, 85, 73, 3, 23, 136, 210, 212, 52, 16, 112, 24, 210, 40, 240, 176, 80, 124, 241, 145, 252, 44, 153, 229, 135, 137, 157, 77, 237, 14, 164, 109, 160, 41, 183, 132, 21, 0, 92, 181, 74, 215, 124, 10, 136, 58, 62, 8, 141, 168, 230, 225, 227, 75 }, new byte[] { 141, 86, 190, 15, 177, 91, 26, 161, 184, 169, 29, 180, 73, 3, 7, 116, 55, 156, 177, 35, 208, 73, 205, 182, 142, 44, 137, 137, 185, 164, 84, 95, 23, 150, 66, 113, 133, 170, 94, 197, 16, 176, 158, 124, 211, 1, 130, 205, 189, 26, 15, 167, 163, 234, 160, 23, 102, 37, 229, 237, 76, 35, 62, 129, 29, 122, 40, 205, 198, 19, 89, 52, 248, 236, 245, 242, 6, 182, 17, 241, 153, 232, 11, 210, 17, 18, 51, 6, 22, 142, 155, 56, 103, 211, 2, 214, 169, 166, 252, 115, 250, 135, 165, 207, 225, 98, 139, 187, 95, 185, 18, 119, 65, 198, 97, 215, 79, 31, 230, 10, 143, 61, 74, 44, 233, 63, 189, 35 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 227, 208, 185, 154, 132, 211, 110, 241, 148, 216, 204, 254, 104, 116, 161, 233, 49, 214, 223, 19, 170, 213, 113, 163, 111, 240, 161, 59, 53, 189, 215, 101, 100, 230, 132, 247, 210, 188, 48, 155, 123, 32, 20, 64, 213, 176, 197, 40, 96, 52, 140, 208, 167, 105, 16, 108, 126, 26, 87, 47, 147, 54, 133, 163 }, new byte[] { 67, 156, 254, 142, 103, 41, 202, 182, 97, 218, 201, 231, 55, 147, 3, 155, 18, 122, 193, 15, 126, 106, 216, 15, 121, 222, 176, 181, 234, 95, 223, 163, 160, 241, 75, 231, 140, 135, 128, 196, 86, 85, 102, 194, 43, 83, 38, 232, 55, 185, 138, 242, 205, 86, 86, 66, 54, 65, 184, 31, 221, 13, 221, 251, 114, 186, 1, 230, 204, 7, 53, 215, 94, 240, 193, 62, 140, 88, 51, 136, 169, 242, 105, 241, 77, 63, 250, 252, 161, 17, 29, 123, 77, 206, 201, 183, 218, 110, 17, 30, 171, 186, 165, 207, 39, 222, 229, 89, 145, 84, 87, 244, 10, 33, 37, 198, 84, 50, 70, 165, 198, 78, 29, 119, 176, 91, 64, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 7, 158, 94, 251, 192, 30, 224, 237, 142, 27, 95, 59, 17, 192, 209, 212, 31, 115, 103, 82, 181, 106, 159, 214, 152, 121, 131, 82, 82, 26, 120, 82, 104, 148, 115, 111, 69, 19, 131, 186, 255, 138, 182, 32, 121, 131, 161, 52, 172, 213, 1, 132, 132, 191, 152, 16, 107, 105, 212, 16, 220, 17, 20, 227 }, new byte[] { 91, 239, 69, 250, 98, 218, 56, 164, 130, 154, 107, 126, 197, 47, 58, 247, 129, 149, 6, 139, 249, 101, 162, 189, 154, 248, 16, 44, 4, 37, 169, 227, 162, 20, 208, 44, 86, 218, 205, 63, 74, 171, 237, 142, 181, 90, 234, 161, 150, 2, 131, 213, 88, 215, 196, 121, 91, 130, 142, 223, 146, 112, 130, 114, 157, 32, 136, 168, 123, 16, 139, 128, 72, 176, 134, 218, 35, 187, 251, 80, 190, 115, 115, 175, 123, 7, 71, 61, 196, 234, 236, 149, 38, 95, 19, 40, 254, 13, 58, 44, 147, 75, 43, 240, 8, 19, 186, 10, 180, 33, 149, 253, 53, 167, 63, 149, 13, 43, 18, 178, 94, 93, 28, 193, 87, 25, 182, 237 } });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramKPI_KPIId",
                table: "ProgramKPI",
                column: "KPIId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramKPI_TrainingProgramId",
                table: "ProgramKPI",
                column: "TrainingProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramKPI");

            migrationBuilder.DropTable(
                name: "KPI");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 199, 198, 65, 174, 68, 22, 199, 229, 108, 112, 34, 84, 231, 66, 34, 131, 8, 36, 212, 250, 39, 35, 11, 33, 86, 122, 250, 120, 94, 211, 152, 193, 17, 13, 232, 109, 62, 162, 93, 54, 159, 211, 51, 142, 97, 96, 158, 19, 175, 67, 223, 247, 121, 73, 184, 136, 131, 235, 194, 30, 131, 6, 217 }, new byte[] { 75, 244, 119, 43, 155, 21, 13, 61, 182, 75, 87, 94, 251, 248, 131, 20, 3, 102, 183, 10, 197, 238, 224, 127, 100, 193, 99, 246, 106, 4, 173, 88, 6, 229, 49, 44, 168, 182, 123, 244, 255, 139, 81, 246, 188, 170, 174, 182, 215, 28, 120, 116, 228, 128, 58, 39, 10, 25, 105, 81, 25, 35, 155, 149, 164, 58, 31, 13, 200, 99, 227, 205, 3, 129, 18, 106, 148, 138, 100, 250, 10, 112, 96, 8, 87, 22, 15, 166, 100, 51, 42, 106, 233, 187, 49, 121, 150, 6, 123, 18, 130, 98, 80, 45, 232, 112, 72, 4, 192, 4, 63, 116, 245, 146, 39, 194, 115, 142, 30, 222, 87, 17, 223, 125, 233, 54, 21, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 127, 111, 158, 68, 21, 59, 222, 26, 250, 114, 18, 158, 26, 246, 63, 109, 72, 59, 153, 176, 147, 54, 84, 154, 91, 14, 49, 9, 121, 5, 72, 85, 43, 216, 211, 198, 240, 255, 81, 106, 123, 177, 185, 174, 226, 246, 71, 56, 201, 141, 24, 193, 90, 12, 47, 36, 45, 233, 54, 205, 105, 130, 53 }, new byte[] { 116, 54, 125, 103, 209, 188, 21, 155, 1, 86, 82, 191, 69, 230, 165, 239, 92, 85, 164, 41, 181, 149, 116, 157, 158, 64, 224, 132, 6, 66, 89, 60, 182, 87, 168, 91, 203, 43, 26, 176, 222, 64, 34, 42, 58, 39, 3, 62, 14, 178, 235, 123, 251, 124, 163, 155, 152, 193, 169, 29, 190, 102, 94, 196, 158, 124, 134, 189, 38, 35, 200, 178, 172, 103, 66, 178, 28, 157, 0, 91, 7, 115, 161, 27, 89, 109, 253, 0, 239, 99, 128, 92, 74, 172, 206, 154, 227, 25, 101, 202, 41, 145, 71, 92, 158, 223, 34, 207, 98, 230, 208, 58, 89, 209, 232, 118, 144, 183, 51, 38, 45, 106, 132, 135, 202, 191, 217, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 162, 73, 201, 3, 85, 147, 212, 146, 192, 132, 119, 213, 73, 172, 178, 95, 88, 5, 62, 87, 38, 205, 237, 20, 223, 10, 195, 22, 158, 183, 251, 146, 174, 120, 196, 165, 106, 228, 220, 166, 206, 83, 39, 175, 227, 66, 51, 55, 77, 210, 128, 227, 73, 136, 54, 204, 224, 78, 232, 17, 155, 38, 58 }, new byte[] { 237, 180, 173, 31, 110, 111, 115, 162, 179, 235, 188, 17, 113, 204, 254, 222, 84, 30, 178, 39, 174, 125, 2, 218, 107, 187, 223, 152, 15, 35, 73, 93, 119, 31, 62, 56, 162, 168, 147, 107, 178, 128, 229, 248, 190, 158, 202, 188, 135, 136, 30, 25, 208, 169, 16, 169, 216, 127, 243, 52, 222, 185, 24, 227, 146, 13, 143, 174, 252, 22, 120, 26, 163, 72, 86, 172, 210, 124, 249, 94, 226, 103, 85, 13, 95, 80, 69, 85, 119, 58, 168, 81, 40, 191, 214, 126, 227, 159, 114, 254, 94, 96, 152, 60, 177, 226, 30, 11, 242, 226, 179, 116, 134, 105, 85, 28, 121, 49, 199, 176, 131, 94, 170, 32, 195, 1, 125, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 63, 115, 171, 103, 24, 233, 7, 126, 95, 128, 123, 147, 133, 77, 6, 199, 65, 123, 72, 246, 102, 151, 130, 131, 81, 92, 52, 237, 46, 129, 6, 99, 98, 106, 197, 206, 239, 1, 174, 197, 161, 111, 220, 97, 43, 229, 95, 190, 74, 39, 214, 21, 67, 152, 110, 181, 54, 15, 100, 195, 223, 101, 42 }, new byte[] { 86, 79, 136, 47, 73, 182, 2, 66, 171, 44, 207, 7, 226, 234, 101, 248, 160, 58, 213, 254, 25, 165, 57, 171, 216, 68, 105, 105, 200, 170, 141, 59, 99, 51, 231, 129, 40, 47, 41, 253, 107, 112, 36, 27, 159, 77, 224, 222, 245, 145, 194, 145, 40, 197, 246, 35, 15, 77, 212, 147, 178, 6, 230, 165, 26, 223, 208, 66, 67, 31, 142, 145, 47, 255, 241, 75, 142, 60, 73, 42, 85, 44, 174, 81, 221, 238, 246, 179, 47, 88, 55, 88, 149, 83, 26, 187, 137, 201, 140, 242, 3, 116, 154, 128, 134, 11, 33, 150, 45, 194, 203, 161, 120, 59, 104, 91, 68, 152, 28, 29, 6, 75, 193, 139, 39, 252, 125, 82 } });
        }
    }
}
