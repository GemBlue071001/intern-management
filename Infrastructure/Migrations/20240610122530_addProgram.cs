﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addProgram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    CourseObject = table.Column<string>(type: "text", nullable: false),
                    OutputObject = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobId = table.Column<int>(type: "integer", nullable: true),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTrainingProgram_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTrainingProgram_TrainingProgram_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 187, 150, 127, 112, 67, 84, 113, 65, 139, 54, 5, 137, 56, 163, 112, 57, 157, 17, 22, 123, 55, 128, 18, 66, 241, 52, 97, 111, 111, 166, 67, 193, 208, 135, 64, 77, 217, 90, 238, 247, 58, 188, 225, 23, 204, 172, 123, 5, 68, 208, 255, 51, 238, 147, 84, 177, 139, 241, 118, 89, 55, 13, 9, 83 }, new byte[] { 71, 228, 63, 100, 225, 156, 108, 96, 61, 230, 160, 62, 214, 184, 94, 58, 242, 9, 82, 69, 223, 215, 101, 38, 43, 113, 244, 96, 77, 43, 141, 4, 225, 143, 201, 170, 148, 198, 111, 162, 54, 13, 82, 56, 118, 39, 116, 190, 201, 33, 26, 217, 138, 26, 133, 153, 249, 208, 177, 215, 184, 81, 99, 16, 175, 193, 38, 144, 107, 34, 154, 33, 43, 7, 57, 58, 200, 238, 43, 151, 99, 226, 208, 49, 70, 39, 196, 78, 154, 89, 110, 87, 20, 252, 52, 149, 31, 189, 36, 223, 26, 54, 161, 33, 239, 54, 254, 217, 10, 25, 84, 161, 28, 59, 58, 186, 149, 213, 184, 237, 154, 205, 177, 223, 207, 167, 86, 100 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 12, 80, 254, 8, 118, 188, 120, 254, 210, 196, 9, 36, 68, 249, 155, 236, 219, 221, 51, 81, 28, 58, 97, 169, 30, 65, 77, 250, 159, 94, 160, 133, 187, 217, 102, 45, 22, 93, 46, 115, 59, 196, 236, 95, 104, 163, 85, 210, 243, 131, 31, 206, 129, 250, 137, 15, 86, 216, 33, 54, 62, 123, 202 }, new byte[] { 216, 108, 73, 175, 62, 70, 178, 245, 121, 62, 12, 246, 60, 15, 183, 223, 67, 4, 102, 81, 131, 37, 98, 7, 62, 51, 5, 40, 91, 211, 242, 27, 250, 211, 114, 12, 31, 105, 5, 226, 79, 95, 90, 52, 154, 45, 221, 108, 204, 79, 168, 88, 151, 68, 0, 35, 19, 184, 169, 155, 42, 62, 136, 123, 189, 4, 197, 93, 252, 175, 13, 183, 82, 31, 87, 204, 134, 213, 167, 86, 213, 187, 33, 68, 32, 50, 203, 90, 194, 58, 192, 232, 48, 89, 22, 235, 38, 77, 19, 159, 250, 76, 57, 49, 156, 84, 169, 213, 119, 157, 38, 252, 228, 93, 67, 75, 36, 9, 224, 231, 215, 34, 7, 135, 55, 230, 2, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 125, 89, 181, 144, 17, 228, 10, 253, 45, 38, 161, 145, 247, 246, 98, 201, 99, 209, 157, 128, 39, 25, 161, 7, 101, 226, 44, 108, 178, 175, 242, 194, 28, 55, 166, 45, 23, 147, 147, 4, 208, 246, 75, 162, 118, 152, 170, 70, 154, 47, 130, 45, 13, 110, 24, 134, 137, 18, 61, 15, 129, 145, 28 }, new byte[] { 166, 247, 162, 49, 144, 218, 202, 12, 242, 202, 159, 15, 237, 251, 202, 133, 181, 79, 34, 103, 240, 23, 85, 134, 16, 162, 222, 188, 219, 94, 254, 15, 22, 193, 77, 15, 141, 52, 87, 61, 78, 84, 136, 253, 47, 172, 160, 173, 130, 224, 231, 102, 32, 139, 195, 203, 3, 58, 80, 102, 15, 94, 253, 209, 13, 177, 168, 213, 5, 56, 112, 105, 122, 119, 186, 140, 65, 75, 70, 208, 169, 37, 160, 72, 72, 200, 124, 246, 183, 122, 241, 9, 181, 14, 146, 76, 81, 213, 120, 49, 48, 213, 220, 251, 147, 228, 88, 164, 202, 155, 183, 220, 172, 107, 0, 237, 35, 105, 224, 200, 94, 153, 211, 213, 180, 238, 29, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 214, 3, 64, 230, 220, 253, 50, 60, 42, 30, 116, 1, 98, 132, 132, 148, 109, 0, 86, 222, 42, 188, 40, 139, 128, 10, 241, 243, 134, 201, 85, 184, 46, 140, 100, 17, 188, 223, 129, 226, 222, 178, 210, 207, 24, 249, 120, 123, 39, 112, 128, 244, 79, 7, 45, 198, 187, 129, 144, 164, 206, 71, 7 }, new byte[] { 175, 91, 247, 61, 224, 148, 49, 54, 188, 210, 36, 233, 207, 138, 88, 206, 121, 191, 84, 165, 255, 67, 245, 91, 132, 189, 98, 161, 18, 111, 232, 54, 174, 125, 122, 127, 10, 108, 233, 19, 138, 18, 240, 113, 156, 222, 112, 244, 43, 152, 128, 89, 242, 243, 94, 198, 158, 238, 28, 87, 28, 65, 177, 179, 154, 236, 123, 121, 159, 74, 236, 239, 250, 114, 40, 211, 75, 166, 199, 10, 14, 153, 214, 97, 169, 95, 14, 185, 234, 76, 37, 114, 66, 198, 175, 80, 126, 193, 165, 244, 86, 254, 180, 89, 133, 144, 198, 212, 83, 19, 165, 74, 36, 89, 131, 253, 19, 6, 12, 18, 237, 115, 243, 73, 237, 188, 41, 41 } });

            migrationBuilder.CreateIndex(
                name: "IX_JobTrainingProgram_JobId",
                table: "JobTrainingProgram",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTrainingProgram_TrainingProgramId",
                table: "JobTrainingProgram",
                column: "TrainingProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTrainingProgram");

            migrationBuilder.DropTable(
                name: "TrainingProgram");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 89, 2, 87, 77, 17, 173, 233, 16, 90, 6, 191, 145, 192, 241, 253, 34, 51, 242, 14, 185, 60, 73, 22, 245, 252, 94, 215, 96, 203, 106, 236, 24, 18, 71, 153, 148, 20, 244, 6, 156, 112, 55, 56, 188, 98, 54, 187, 38, 234, 193, 240, 148, 18, 91, 122, 218, 223, 235, 81, 175, 75, 230, 218, 35 }, new byte[] { 136, 216, 25, 107, 35, 173, 210, 75, 138, 241, 105, 187, 190, 243, 39, 189, 112, 163, 156, 37, 64, 12, 186, 247, 141, 189, 236, 228, 45, 125, 183, 254, 77, 238, 142, 159, 178, 148, 212, 219, 171, 181, 171, 210, 148, 176, 137, 72, 10, 84, 15, 50, 83, 191, 92, 42, 196, 235, 74, 40, 103, 228, 198, 3, 62, 208, 176, 218, 222, 126, 49, 188, 102, 140, 5, 11, 129, 49, 127, 169, 161, 21, 139, 34, 65, 30, 173, 18, 249, 93, 230, 43, 30, 229, 189, 47, 157, 240, 10, 94, 25, 253, 211, 69, 155, 119, 103, 109, 41, 53, 148, 160, 30, 42, 48, 112, 91, 146, 172, 134, 146, 206, 203, 83, 180, 186, 55, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 15, 149, 205, 163, 26, 75, 55, 183, 178, 135, 114, 65, 248, 190, 103, 126, 71, 131, 34, 79, 3, 169, 208, 1, 155, 100, 12, 248, 51, 83, 47, 108, 179, 29, 156, 117, 213, 86, 60, 190, 117, 248, 102, 132, 181, 31, 209, 146, 210, 96, 126, 60, 59, 178, 169, 189, 90, 79, 237, 225, 199, 120, 174, 4 }, new byte[] { 76, 175, 107, 144, 97, 250, 1, 228, 207, 246, 154, 225, 68, 150, 98, 38, 221, 221, 206, 236, 24, 6, 177, 10, 218, 200, 205, 25, 157, 25, 89, 16, 148, 205, 4, 109, 245, 4, 107, 203, 192, 153, 154, 43, 145, 58, 0, 225, 27, 46, 10, 13, 59, 10, 15, 44, 123, 202, 197, 190, 157, 85, 81, 177, 141, 233, 255, 237, 68, 229, 207, 244, 70, 172, 52, 137, 58, 201, 100, 96, 204, 129, 220, 13, 231, 59, 154, 76, 67, 217, 40, 228, 133, 210, 222, 123, 109, 84, 236, 57, 114, 17, 96, 16, 167, 36, 72, 37, 97, 187, 78, 238, 155, 22, 38, 89, 22, 206, 211, 44, 182, 9, 155, 109, 92, 194, 24, 4 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 2, 225, 40, 235, 80, 8, 101, 19, 111, 150, 240, 106, 103, 48, 130, 57, 159, 151, 218, 107, 129, 123, 237, 131, 231, 190, 16, 71, 131, 132, 135, 0, 223, 223, 95, 30, 164, 55, 240, 238, 45, 197, 103, 81, 234, 15, 65, 156, 90, 170, 197, 100, 237, 184, 113, 35, 78, 65, 0, 2, 147, 232, 196, 57 }, new byte[] { 112, 27, 245, 239, 110, 13, 58, 114, 112, 140, 147, 61, 30, 65, 107, 212, 206, 160, 62, 180, 98, 12, 130, 21, 101, 200, 156, 236, 94, 3, 60, 207, 212, 239, 77, 159, 94, 167, 20, 70, 23, 71, 169, 215, 96, 121, 10, 64, 192, 20, 172, 222, 80, 200, 234, 148, 144, 75, 253, 55, 7, 224, 84, 224, 23, 240, 110, 254, 53, 227, 174, 36, 232, 133, 153, 160, 165, 242, 137, 246, 160, 94, 151, 115, 176, 129, 164, 242, 220, 132, 50, 113, 20, 66, 254, 241, 225, 241, 162, 79, 154, 121, 5, 13, 58, 137, 122, 167, 251, 91, 72, 56, 190, 250, 187, 55, 11, 27, 16, 177, 248, 234, 176, 230, 190, 210, 240, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 190, 114, 192, 190, 19, 14, 229, 87, 15, 145, 23, 166, 82, 92, 123, 202, 86, 122, 206, 127, 188, 233, 67, 11, 36, 52, 53, 147, 177, 139, 134, 153, 154, 196, 104, 223, 55, 147, 77, 135, 99, 157, 173, 167, 16, 137, 63, 30, 48, 193, 61, 120, 158, 136, 110, 24, 225, 236, 11, 38, 182, 30, 46, 205 }, new byte[] { 87, 162, 173, 224, 246, 17, 137, 242, 98, 114, 17, 2, 63, 132, 28, 187, 93, 8, 246, 196, 193, 127, 144, 21, 138, 181, 62, 174, 78, 97, 0, 1, 8, 158, 74, 106, 240, 228, 95, 204, 244, 173, 6, 82, 144, 129, 59, 107, 69, 205, 44, 208, 45, 204, 224, 100, 125, 46, 187, 247, 128, 167, 79, 205, 17, 202, 116, 153, 155, 56, 216, 131, 255, 10, 241, 130, 28, 161, 179, 247, 208, 139, 110, 136, 125, 86, 117, 246, 201, 216, 15, 238, 116, 184, 240, 128, 230, 255, 113, 198, 202, 223, 112, 5, 32, 87, 182, 87, 87, 202, 212, 163, 168, 82, 138, 39, 62, 126, 204, 106, 170, 135, 145, 25, 190, 113, 95, 71 } });
        }
    }
}