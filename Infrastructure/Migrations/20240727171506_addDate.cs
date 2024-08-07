﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmissionDeadline",
                table: "Campaigns",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(888), new byte[] { 132, 11, 203, 145, 183, 234, 235, 171, 226, 88, 240, 61, 105, 135, 172, 84, 49, 20, 222, 160, 129, 67, 31, 104, 25, 32, 40, 231, 198, 26, 217, 133, 6, 59, 183, 111, 70, 252, 114, 28, 186, 70, 91, 225, 192, 203, 165, 218, 159, 189, 37, 0, 201, 182, 91, 228, 81, 216, 28, 134, 204, 148, 245, 51 }, new byte[] { 127, 183, 169, 156, 56, 117, 184, 140, 255, 156, 13, 71, 220, 91, 187, 17, 88, 60, 1, 91, 243, 16, 144, 39, 221, 131, 188, 243, 28, 177, 30, 227, 162, 141, 24, 138, 5, 38, 165, 54, 207, 210, 43, 230, 208, 118, 7, 231, 169, 101, 166, 202, 194, 210, 143, 139, 132, 92, 105, 26, 193, 116, 4, 6, 103, 203, 41, 157, 57, 14, 220, 46, 39, 226, 65, 115, 56, 128, 230, 57, 240, 246, 133, 195, 134, 128, 119, 60, 43, 233, 218, 23, 183, 67, 4, 16, 76, 57, 112, 207, 158, 18, 64, 133, 148, 138, 54, 164, 89, 10, 30, 54, 69, 86, 163, 154, 193, 160, 118, 56, 120, 26, 128, 74, 185, 70, 135, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(895), new byte[] { 108, 254, 5, 237, 134, 164, 78, 38, 118, 220, 162, 141, 196, 90, 229, 64, 160, 245, 57, 153, 225, 44, 157, 86, 197, 45, 156, 166, 168, 169, 80, 190, 38, 85, 36, 247, 197, 71, 159, 213, 216, 209, 74, 142, 121, 5, 52, 194, 247, 67, 47, 145, 230, 188, 13, 202, 55, 241, 153, 30, 133, 121, 84, 149 }, new byte[] { 187, 124, 154, 213, 200, 215, 96, 220, 89, 24, 90, 176, 110, 34, 117, 122, 214, 105, 188, 254, 185, 137, 90, 205, 71, 141, 126, 161, 243, 217, 149, 96, 191, 149, 54, 248, 123, 80, 27, 173, 6, 17, 17, 52, 172, 149, 152, 133, 197, 95, 247, 31, 134, 247, 204, 127, 149, 64, 85, 148, 20, 109, 116, 47, 112, 240, 152, 125, 253, 45, 57, 35, 184, 246, 13, 59, 219, 34, 128, 176, 167, 169, 19, 50, 215, 182, 178, 225, 156, 176, 15, 203, 221, 126, 14, 138, 69, 71, 148, 0, 190, 201, 7, 74, 78, 240, 211, 34, 236, 15, 205, 144, 149, 43, 51, 50, 157, 38, 10, 58, 159, 51, 147, 223, 46, 194, 162, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(942), new byte[] { 56, 252, 32, 236, 155, 85, 158, 55, 20, 107, 133, 231, 72, 25, 146, 209, 247, 25, 143, 13, 233, 143, 12, 73, 182, 222, 146, 38, 252, 165, 179, 4, 232, 156, 233, 212, 100, 204, 11, 169, 39, 54, 204, 242, 250, 161, 111, 16, 163, 101, 121, 15, 217, 192, 46, 127, 106, 115, 79, 191, 250, 169, 155, 203 }, new byte[] { 17, 252, 72, 16, 82, 123, 176, 122, 202, 97, 161, 108, 207, 2, 81, 126, 132, 123, 198, 136, 95, 57, 229, 132, 97, 59, 119, 36, 233, 188, 237, 205, 17, 178, 25, 63, 220, 94, 42, 221, 16, 37, 149, 253, 31, 71, 38, 165, 135, 3, 186, 182, 233, 245, 52, 164, 185, 76, 48, 81, 243, 231, 235, 41, 203, 154, 172, 50, 128, 66, 162, 54, 178, 95, 39, 42, 211, 219, 76, 16, 22, 178, 36, 221, 5, 94, 171, 126, 134, 206, 84, 155, 140, 180, 54, 97, 45, 213, 48, 93, 65, 194, 68, 69, 175, 249, 207, 148, 206, 29, 219, 203, 104, 132, 96, 104, 196, 164, 35, 200, 33, 192, 149, 42, 25, 125, 80, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(944), new byte[] { 86, 224, 131, 76, 125, 57, 86, 122, 178, 106, 80, 141, 22, 186, 26, 206, 40, 115, 116, 101, 70, 85, 70, 95, 95, 77, 105, 97, 79, 79, 214, 161, 254, 52, 129, 14, 214, 248, 226, 222, 10, 234, 5, 250, 174, 20, 244, 242, 161, 217, 6, 192, 29, 4, 200, 22, 71, 236, 111, 163, 108, 243, 125, 86 }, new byte[] { 50, 155, 188, 110, 54, 166, 117, 125, 244, 179, 100, 9, 82, 155, 128, 137, 109, 132, 249, 191, 198, 180, 242, 226, 175, 196, 97, 161, 202, 220, 122, 102, 254, 68, 138, 236, 183, 203, 76, 78, 153, 22, 247, 54, 148, 186, 57, 165, 224, 201, 158, 129, 21, 194, 179, 61, 29, 160, 141, 85, 110, 148, 173, 248, 29, 64, 255, 0, 237, 46, 1, 69, 206, 123, 38, 140, 76, 253, 253, 43, 93, 59, 97, 203, 219, 48, 220, 210, 39, 177, 183, 210, 97, 183, 235, 145, 194, 142, 204, 73, 145, 34, 218, 254, 1, 243, 181, 217, 148, 33, 174, 218, 177, 99, 100, 6, 32, 136, 232, 148, 152, 175, 134, 72, 133, 114, 129, 248 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmissionDeadline",
                table: "Campaigns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(9935),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(704), new byte[] { 140, 90, 153, 3, 144, 85, 200, 249, 53, 35, 74, 201, 130, 198, 75, 45, 169, 177, 222, 145, 190, 185, 190, 88, 67, 171, 1, 140, 51, 41, 234, 83, 166, 77, 73, 85, 117, 98, 177, 101, 100, 59, 146, 55, 141, 14, 117, 30, 81, 254, 138, 91, 152, 28, 56, 128, 207, 173, 104, 114, 114, 55, 30, 239 }, new byte[] { 190, 194, 226, 130, 125, 71, 160, 175, 145, 170, 56, 68, 29, 84, 248, 131, 238, 82, 152, 108, 209, 157, 63, 119, 170, 180, 156, 237, 140, 193, 115, 68, 41, 17, 96, 217, 72, 200, 11, 118, 3, 100, 251, 8, 1, 88, 140, 6, 87, 136, 72, 204, 103, 57, 199, 60, 121, 53, 35, 117, 73, 143, 43, 243, 199, 33, 201, 140, 0, 224, 186, 112, 234, 90, 248, 252, 31, 101, 87, 45, 196, 61, 194, 208, 33, 234, 131, 142, 147, 202, 137, 247, 178, 65, 118, 35, 107, 255, 196, 58, 218, 131, 26, 109, 147, 174, 80, 53, 237, 17, 165, 79, 238, 168, 15, 58, 215, 69, 222, 50, 225, 173, 217, 89, 50, 137, 211, 213 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(1375), new byte[] { 248, 71, 194, 176, 202, 7, 238, 193, 196, 146, 214, 128, 101, 68, 31, 152, 89, 220, 21, 176, 123, 23, 59, 126, 183, 0, 219, 194, 26, 66, 65, 95, 90, 65, 223, 107, 60, 185, 128, 241, 38, 84, 78, 220, 119, 143, 228, 141, 65, 211, 51, 184, 192, 94, 168, 235, 177, 241, 9, 149, 53, 68, 62, 102 }, new byte[] { 255, 54, 97, 136, 66, 70, 250, 86, 86, 213, 247, 23, 226, 200, 93, 37, 241, 71, 221, 191, 22, 231, 208, 45, 46, 71, 169, 67, 242, 117, 214, 61, 159, 46, 75, 76, 183, 45, 50, 225, 194, 11, 4, 242, 155, 7, 136, 48, 67, 242, 75, 79, 190, 226, 129, 90, 136, 124, 42, 60, 188, 234, 190, 143, 15, 167, 8, 148, 7, 50, 29, 115, 232, 165, 136, 60, 251, 200, 107, 41, 13, 245, 23, 60, 52, 37, 154, 35, 50, 207, 139, 205, 8, 207, 51, 27, 166, 142, 71, 169, 122, 253, 186, 94, 133, 74, 232, 43, 103, 6, 57, 232, 80, 242, 2, 200, 244, 190, 167, 159, 93, 86, 17, 81, 134, 214, 38, 206 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(1381), new byte[] { 242, 193, 235, 197, 45, 146, 98, 53, 110, 179, 21, 236, 43, 86, 1, 216, 41, 70, 16, 143, 179, 0, 118, 67, 202, 129, 23, 215, 69, 216, 2, 224, 183, 231, 238, 216, 167, 59, 157, 222, 56, 29, 252, 138, 106, 204, 217, 164, 215, 204, 55, 105, 245, 191, 134, 84, 107, 111, 205, 182, 27, 68, 66, 35 }, new byte[] { 253, 11, 27, 73, 123, 37, 216, 42, 226, 123, 163, 54, 44, 193, 42, 205, 24, 122, 18, 56, 82, 7, 72, 238, 158, 174, 72, 104, 220, 247, 131, 245, 67, 237, 130, 82, 92, 240, 101, 88, 240, 78, 132, 181, 129, 163, 106, 156, 216, 190, 212, 121, 223, 166, 87, 169, 173, 67, 114, 199, 111, 86, 200, 199, 126, 28, 43, 19, 84, 229, 75, 250, 42, 99, 163, 42, 242, 85, 191, 218, 152, 20, 142, 35, 233, 73, 173, 167, 183, 8, 88, 120, 47, 73, 60, 25, 248, 49, 97, 97, 2, 107, 119, 192, 128, 218, 60, 145, 94, 85, 93, 86, 234, 33, 150, 74, 170, 87, 227, 6, 68, 248, 9, 51, 26, 173, 220, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 52, 0, 977, DateTimeKind.Utc).AddTicks(1383), new byte[] { 74, 64, 122, 254, 68, 68, 121, 51, 177, 232, 188, 7, 147, 13, 150, 168, 236, 41, 160, 28, 190, 76, 58, 85, 41, 167, 228, 79, 171, 6, 64, 108, 139, 149, 96, 104, 168, 113, 18, 15, 139, 246, 47, 205, 26, 177, 51, 173, 202, 91, 123, 22, 234, 47, 156, 217, 13, 131, 7, 101, 232, 123, 124, 48 }, new byte[] { 185, 120, 82, 135, 170, 72, 197, 154, 31, 101, 162, 202, 31, 133, 253, 82, 160, 168, 59, 222, 40, 251, 137, 112, 82, 147, 77, 53, 15, 157, 192, 72, 113, 159, 245, 56, 158, 92, 39, 82, 46, 27, 168, 228, 51, 74, 202, 148, 15, 172, 245, 227, 248, 135, 81, 240, 162, 74, 141, 190, 112, 44, 70, 20, 255, 77, 133, 42, 232, 31, 220, 122, 51, 141, 127, 30, 123, 73, 161, 39, 177, 222, 178, 29, 185, 188, 73, 20, 32, 83, 158, 153, 81, 67, 18, 249, 208, 203, 164, 253, 147, 54, 178, 26, 200, 26, 158, 109, 140, 115, 180, 63, 200, 104, 45, 221, 160, 42, 61, 123, 109, 52, 142, 197, 77, 240, 68, 60 } });
        }
    }
}
