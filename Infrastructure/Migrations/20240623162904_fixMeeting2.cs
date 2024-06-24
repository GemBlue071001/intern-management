﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixMeeting2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMeeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    MeetingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeeting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMeeting_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMeeting_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 226, 125, 3, 76, 246, 227, 73, 207, 247, 185, 228, 69, 101, 150, 23, 151, 107, 245, 245, 218, 24, 136, 145, 121, 87, 179, 80, 65, 197, 186, 90, 222, 77, 187, 59, 215, 153, 169, 70, 180, 49, 208, 27, 14, 214, 55, 177, 77, 172, 233, 42, 152, 56, 174, 18, 114, 232, 16, 166, 105, 41, 26, 66 }, new byte[] { 160, 64, 200, 237, 82, 142, 170, 226, 60, 173, 218, 2, 241, 239, 181, 87, 122, 113, 48, 145, 71, 244, 196, 158, 133, 208, 28, 229, 12, 153, 156, 132, 97, 204, 168, 18, 156, 159, 53, 232, 71, 127, 15, 252, 63, 203, 161, 157, 36, 159, 135, 125, 37, 162, 252, 188, 219, 71, 66, 114, 136, 215, 59, 168, 96, 254, 164, 242, 236, 134, 252, 128, 243, 193, 19, 73, 0, 39, 195, 63, 239, 252, 13, 94, 166, 3, 86, 166, 45, 112, 73, 171, 199, 29, 52, 82, 7, 96, 98, 29, 209, 119, 150, 163, 229, 179, 246, 82, 212, 8, 230, 138, 11, 234, 211, 235, 170, 21, 208, 88, 136, 71, 241, 150, 45, 251, 36, 229 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 29, 74, 47, 176, 219, 195, 154, 10, 173, 231, 126, 240, 252, 123, 203, 73, 147, 50, 255, 140, 109, 253, 100, 126, 252, 34, 233, 65, 23, 59, 138, 75, 135, 34, 37, 37, 139, 88, 197, 153, 56, 224, 184, 31, 26, 217, 39, 139, 168, 69, 75, 58, 85, 126, 205, 63, 215, 32, 124, 37, 69, 6, 32 }, new byte[] { 183, 167, 193, 76, 218, 163, 99, 159, 92, 104, 203, 152, 66, 132, 180, 40, 178, 230, 59, 219, 143, 122, 205, 243, 147, 168, 252, 85, 190, 27, 207, 57, 89, 102, 202, 134, 154, 159, 186, 160, 146, 209, 121, 86, 245, 55, 92, 248, 70, 160, 18, 107, 49, 135, 117, 91, 235, 146, 37, 52, 218, 65, 24, 87, 221, 55, 121, 43, 31, 216, 24, 220, 9, 68, 161, 249, 245, 37, 37, 187, 69, 170, 189, 60, 118, 39, 26, 112, 71, 175, 51, 148, 61, 4, 27, 190, 143, 79, 84, 192, 192, 121, 9, 85, 129, 235, 215, 181, 78, 92, 47, 45, 168, 118, 202, 252, 42, 87, 36, 42, 53, 52, 223, 215, 57, 233, 38, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 206, 10, 109, 152, 119, 100, 5, 3, 186, 99, 7, 193, 59, 140, 22, 90, 57, 8, 171, 96, 200, 219, 84, 143, 115, 12, 253, 110, 105, 166, 240, 218, 177, 147, 34, 191, 186, 223, 143, 134, 30, 15, 225, 49, 133, 187, 138, 2, 81, 64, 221, 87, 188, 207, 228, 55, 125, 50, 123, 17, 54, 154, 204 }, new byte[] { 226, 190, 14, 186, 49, 39, 201, 20, 248, 145, 139, 242, 189, 209, 254, 136, 186, 106, 47, 196, 216, 152, 251, 243, 53, 107, 68, 73, 94, 3, 24, 168, 91, 41, 148, 255, 123, 140, 177, 99, 149, 205, 51, 137, 190, 54, 67, 172, 46, 233, 234, 197, 4, 83, 13, 118, 231, 133, 65, 236, 226, 112, 24, 70, 28, 197, 114, 30, 65, 88, 32, 40, 101, 128, 123, 201, 249, 148, 113, 165, 50, 98, 15, 14, 6, 40, 117, 85, 45, 237, 236, 113, 56, 88, 186, 199, 173, 143, 187, 42, 147, 221, 103, 34, 195, 187, 122, 37, 128, 70, 209, 24, 245, 67, 112, 105, 246, 185, 3, 94, 18, 182, 115, 79, 213, 193, 44, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 181, 250, 168, 89, 2, 75, 11, 134, 31, 243, 161, 237, 140, 4, 159, 233, 98, 87, 224, 121, 109, 67, 43, 203, 161, 5, 111, 229, 131, 131, 244, 169, 56, 108, 11, 86, 101, 172, 64, 11, 16, 192, 148, 216, 235, 71, 202, 140, 181, 52, 130, 149, 240, 108, 38, 126, 78, 169, 252, 166, 125, 22, 117 }, new byte[] { 20, 252, 15, 139, 62, 54, 200, 198, 251, 53, 7, 229, 125, 44, 60, 90, 241, 138, 29, 190, 119, 104, 39, 69, 223, 139, 68, 158, 82, 222, 115, 153, 154, 30, 52, 93, 49, 18, 24, 132, 242, 245, 21, 164, 108, 241, 29, 204, 46, 176, 40, 92, 237, 133, 27, 79, 125, 69, 147, 245, 7, 165, 146, 99, 193, 173, 165, 183, 86, 214, 206, 242, 144, 216, 74, 169, 56, 61, 17, 220, 24, 243, 41, 173, 16, 174, 210, 141, 133, 180, 99, 253, 215, 186, 225, 56, 198, 36, 73, 217, 76, 114, 36, 166, 66, 42, 51, 224, 84, 101, 233, 12, 250, 54, 218, 113, 122, 54, 178, 159, 196, 4, 114, 191, 247, 175, 178, 168 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserMeeting_MeetingId",
                table: "UserMeeting",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMeeting_UserId",
                table: "UserMeeting",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMeeting");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 24, 58, 104, 43, 230, 192, 133, 66, 243, 93, 93, 92, 38, 75, 45, 92, 105, 156, 204, 15, 76, 141, 244, 0, 68, 208, 177, 147, 36, 81, 127, 27, 188, 32, 35, 4, 180, 42, 12, 113, 166, 154, 129, 186, 168, 161, 242, 36, 2, 84, 233, 21, 48, 30, 187, 236, 222, 44, 248, 60, 131, 63, 106 }, new byte[] { 195, 52, 123, 9, 91, 255, 181, 204, 161, 54, 12, 210, 82, 134, 64, 15, 199, 176, 254, 17, 78, 145, 18, 164, 183, 162, 171, 170, 28, 82, 60, 43, 178, 35, 211, 11, 245, 34, 79, 130, 91, 214, 216, 141, 69, 43, 190, 101, 241, 24, 199, 209, 51, 41, 44, 217, 151, 145, 183, 240, 202, 254, 242, 226, 156, 205, 121, 58, 134, 108, 225, 114, 200, 146, 135, 159, 53, 29, 24, 127, 50, 100, 3, 209, 206, 246, 92, 22, 100, 217, 154, 153, 239, 28, 162, 13, 118, 255, 117, 110, 5, 255, 26, 211, 13, 104, 20, 215, 63, 251, 82, 30, 255, 218, 147, 66, 25, 36, 84, 24, 156, 171, 219, 70, 155, 164, 243, 108 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 154, 216, 60, 238, 163, 182, 34, 96, 154, 15, 211, 218, 226, 210, 172, 227, 146, 154, 127, 169, 122, 77, 38, 190, 218, 137, 203, 79, 151, 48, 204, 156, 69, 169, 10, 116, 156, 218, 20, 97, 37, 101, 179, 208, 79, 209, 193, 134, 75, 89, 173, 60, 72, 54, 101, 174, 35, 210, 248, 219, 99, 226, 238 }, new byte[] { 39, 128, 120, 14, 131, 181, 58, 216, 240, 21, 183, 60, 164, 84, 79, 224, 183, 79, 149, 234, 144, 114, 12, 228, 243, 105, 98, 98, 101, 48, 8, 250, 151, 253, 76, 121, 104, 105, 86, 160, 117, 16, 117, 229, 214, 207, 28, 57, 159, 14, 50, 103, 26, 207, 17, 233, 81, 11, 18, 197, 43, 193, 235, 11, 35, 180, 77, 173, 165, 92, 100, 226, 241, 255, 171, 51, 2, 78, 55, 75, 96, 214, 46, 184, 21, 27, 107, 161, 38, 134, 243, 36, 24, 15, 24, 170, 174, 183, 112, 247, 178, 175, 176, 14, 95, 102, 37, 133, 245, 127, 53, 236, 75, 37, 217, 95, 66, 166, 83, 226, 119, 160, 146, 197, 199, 188, 160, 183 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 198, 145, 38, 42, 211, 58, 10, 1, 230, 165, 86, 82, 6, 107, 64, 124, 207, 29, 55, 52, 240, 27, 32, 112, 32, 93, 173, 197, 48, 211, 34, 14, 92, 60, 232, 69, 114, 254, 164, 122, 247, 144, 2, 40, 30, 82, 52, 48, 188, 221, 99, 29, 19, 10, 40, 171, 111, 74, 17, 227, 69, 89, 182, 252 }, new byte[] { 37, 27, 150, 159, 85, 203, 96, 222, 82, 213, 0, 99, 244, 143, 133, 132, 110, 101, 115, 176, 181, 177, 90, 204, 120, 143, 94, 29, 14, 179, 230, 114, 201, 100, 145, 245, 209, 234, 160, 12, 110, 234, 109, 253, 162, 214, 28, 201, 43, 161, 118, 163, 195, 180, 116, 120, 101, 192, 126, 74, 243, 200, 142, 181, 67, 16, 118, 105, 170, 218, 237, 10, 246, 43, 224, 128, 19, 32, 69, 165, 171, 74, 156, 13, 237, 50, 35, 147, 238, 224, 136, 78, 176, 1, 237, 251, 89, 238, 89, 99, 55, 156, 183, 61, 241, 74, 87, 183, 100, 98, 214, 69, 86, 30, 169, 52, 165, 226, 32, 245, 76, 180, 207, 212, 80, 165, 124, 150 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 139, 112, 9, 214, 30, 161, 114, 29, 140, 214, 111, 124, 160, 196, 169, 66, 213, 177, 223, 47, 230, 70, 71, 18, 133, 208, 28, 141, 241, 101, 20, 140, 174, 38, 169, 170, 185, 105, 91, 81, 177, 91, 139, 245, 151, 84, 37, 228, 129, 162, 9, 23, 201, 198, 95, 6, 238, 169, 19, 100, 205, 173, 21 }, new byte[] { 247, 64, 247, 109, 71, 110, 90, 26, 202, 100, 255, 35, 117, 15, 47, 135, 34, 222, 98, 139, 181, 112, 7, 235, 250, 91, 26, 203, 131, 254, 222, 20, 242, 25, 138, 102, 28, 39, 239, 144, 215, 47, 60, 206, 23, 177, 113, 32, 43, 177, 201, 186, 252, 138, 8, 131, 223, 166, 50, 253, 38, 126, 242, 164, 20, 212, 55, 24, 126, 6, 150, 150, 200, 64, 226, 44, 25, 175, 24, 143, 184, 58, 18, 175, 221, 140, 86, 244, 184, 234, 178, 244, 235, 243, 141, 178, 195, 119, 114, 94, 222, 116, 14, 152, 98, 74, 86, 132, 188, 239, 161, 236, 53, 226, 159, 53, 4, 131, 162, 239, 108, 193, 214, 132, 119, 179, 241, 49 } });
        }
    }
}
