﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addPropToCandidate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Candidates",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 12, 49, 10, 942, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Candidates",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Candidates",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7573), new byte[] { 32, 191, 68, 77, 35, 46, 149, 133, 110, 136, 56, 90, 120, 227, 8, 125, 147, 43, 199, 170, 4, 144, 89, 117, 58, 93, 149, 86, 63, 63, 162, 129, 246, 149, 218, 14, 242, 73, 76, 22, 179, 1, 189, 13, 124, 5, 19, 148, 99, 234, 152, 47, 1, 9, 163, 9, 223, 110, 60, 170, 154, 245, 63, 95 }, new byte[] { 40, 176, 66, 3, 108, 177, 46, 44, 116, 27, 236, 200, 146, 232, 19, 89, 103, 179, 104, 54, 131, 60, 159, 125, 148, 177, 165, 111, 14, 127, 13, 64, 207, 159, 37, 22, 130, 206, 139, 63, 246, 196, 141, 55, 254, 249, 54, 130, 43, 27, 152, 188, 97, 142, 43, 108, 33, 90, 8, 71, 72, 243, 253, 245, 219, 70, 9, 40, 159, 79, 133, 202, 179, 77, 109, 246, 98, 74, 139, 62, 223, 210, 142, 34, 138, 187, 109, 44, 14, 18, 213, 160, 181, 68, 247, 16, 1, 165, 107, 170, 232, 2, 4, 4, 105, 56, 154, 188, 94, 89, 158, 109, 166, 219, 242, 32, 100, 103, 28, 213, 189, 22, 248, 12, 237, 117, 148, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7582), new byte[] { 206, 43, 184, 105, 160, 178, 64, 20, 29, 149, 2, 185, 61, 147, 116, 18, 225, 254, 101, 89, 194, 243, 128, 172, 92, 170, 63, 95, 11, 176, 222, 251, 122, 101, 174, 63, 91, 107, 18, 165, 110, 251, 31, 12, 106, 172, 225, 75, 206, 45, 195, 98, 109, 146, 66, 128, 27, 124, 63, 185, 49, 149, 221, 226 }, new byte[] { 124, 59, 27, 106, 20, 19, 171, 1, 43, 138, 59, 191, 232, 171, 231, 220, 188, 216, 10, 5, 89, 244, 8, 8, 219, 51, 31, 107, 84, 198, 78, 168, 68, 208, 189, 77, 51, 186, 74, 62, 63, 234, 94, 41, 6, 46, 61, 112, 49, 154, 12, 42, 125, 237, 33, 230, 0, 179, 102, 61, 244, 133, 115, 41, 216, 74, 229, 75, 224, 185, 113, 0, 200, 167, 243, 205, 190, 26, 99, 88, 153, 158, 158, 44, 97, 145, 127, 240, 131, 161, 35, 93, 109, 251, 116, 21, 59, 65, 81, 92, 146, 54, 131, 107, 152, 107, 189, 16, 156, 17, 75, 13, 110, 165, 121, 73, 239, 12, 88, 122, 213, 61, 11, 235, 235, 124, 123, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7584), new byte[] { 213, 125, 248, 250, 191, 21, 159, 86, 188, 190, 2, 201, 99, 216, 23, 83, 251, 78, 110, 102, 102, 67, 20, 46, 127, 120, 155, 72, 94, 166, 30, 215, 59, 123, 50, 185, 119, 180, 89, 150, 226, 76, 85, 83, 82, 87, 7, 57, 93, 43, 85, 70, 35, 67, 187, 117, 211, 47, 32, 220, 162, 58, 253, 17 }, new byte[] { 161, 153, 60, 210, 175, 198, 186, 254, 38, 9, 82, 60, 165, 50, 204, 106, 162, 216, 66, 132, 75, 18, 239, 59, 142, 57, 60, 158, 62, 188, 102, 87, 187, 60, 46, 236, 100, 65, 120, 98, 95, 236, 165, 243, 168, 67, 186, 243, 107, 159, 208, 49, 91, 247, 94, 152, 130, 186, 140, 26, 17, 72, 137, 165, 103, 221, 104, 120, 186, 82, 152, 194, 199, 160, 46, 52, 198, 25, 201, 9, 226, 57, 249, 213, 184, 241, 34, 17, 72, 64, 49, 75, 222, 195, 18, 130, 176, 231, 255, 39, 204, 164, 250, 14, 190, 196, 128, 229, 208, 127, 55, 147, 129, 148, 84, 83, 53, 174, 135, 211, 182, 247, 144, 11, 89, 36, 211, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7586), new byte[] { 244, 90, 201, 8, 42, 73, 91, 35, 159, 18, 61, 222, 1, 139, 84, 6, 44, 38, 40, 229, 156, 146, 188, 164, 214, 151, 157, 126, 60, 195, 113, 109, 194, 74, 88, 89, 139, 156, 223, 66, 71, 29, 187, 18, 141, 21, 216, 166, 85, 30, 61, 37, 47, 167, 71, 254, 165, 45, 140, 242, 63, 143, 201, 114 }, new byte[] { 239, 192, 81, 159, 70, 84, 221, 78, 55, 117, 18, 121, 15, 216, 64, 241, 231, 249, 93, 112, 185, 34, 19, 38, 120, 250, 190, 133, 9, 167, 70, 101, 36, 47, 6, 180, 227, 122, 139, 139, 253, 16, 246, 87, 229, 253, 125, 186, 156, 227, 19, 122, 245, 192, 127, 139, 160, 169, 196, 38, 75, 212, 186, 226, 238, 156, 20, 20, 180, 212, 38, 104, 220, 139, 101, 183, 214, 45, 23, 203, 137, 89, 77, 125, 15, 89, 189, 151, 175, 113, 182, 24, 117, 74, 80, 88, 104, 180, 89, 242, 102, 80, 93, 71, 29, 197, 13, 255, 21, 253, 167, 49, 113, 162, 226, 134, 98, 145, 254, 88, 82, 229, 141, 91, 90, 53, 241, 9 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Candidates");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 53, 47, 949, DateTimeKind.Utc).AddTicks(3592), new byte[] { 31, 52, 225, 71, 139, 91, 135, 135, 240, 91, 81, 102, 64, 198, 210, 199, 31, 172, 253, 205, 183, 101, 101, 238, 228, 79, 123, 125, 167, 174, 178, 203, 118, 46, 92, 254, 127, 44, 75, 13, 130, 165, 245, 35, 229, 45, 86, 93, 13, 123, 13, 233, 218, 63, 183, 191, 222, 92, 192, 11, 102, 234, 97, 113 }, new byte[] { 16, 43, 168, 179, 140, 154, 111, 121, 194, 108, 111, 30, 7, 242, 205, 194, 167, 22, 23, 65, 28, 208, 149, 66, 226, 177, 180, 67, 192, 175, 131, 65, 253, 67, 230, 12, 175, 143, 52, 215, 253, 106, 96, 144, 56, 133, 225, 162, 14, 75, 183, 112, 41, 47, 141, 115, 135, 25, 57, 214, 55, 98, 48, 217, 162, 69, 247, 218, 236, 83, 239, 18, 143, 149, 161, 21, 62, 133, 105, 142, 12, 236, 143, 103, 80, 16, 173, 217, 238, 8, 121, 186, 196, 45, 136, 137, 179, 101, 38, 6, 134, 214, 252, 158, 243, 35, 30, 206, 253, 79, 219, 200, 149, 202, 49, 30, 96, 186, 92, 44, 48, 203, 182, 94, 140, 156, 30, 142 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 53, 47, 949, DateTimeKind.Utc).AddTicks(3610), new byte[] { 103, 2, 57, 156, 0, 65, 8, 162, 125, 19, 228, 217, 30, 178, 142, 204, 109, 2, 37, 126, 49, 88, 31, 46, 38, 109, 182, 239, 182, 40, 230, 5, 55, 223, 32, 199, 97, 168, 59, 61, 98, 105, 60, 69, 101, 60, 72, 59, 59, 126, 20, 46, 187, 86, 128, 200, 234, 15, 61, 48, 172, 225, 128, 125 }, new byte[] { 123, 194, 235, 25, 24, 78, 127, 176, 55, 127, 250, 115, 224, 169, 42, 100, 58, 231, 218, 203, 230, 19, 13, 183, 247, 251, 53, 8, 132, 193, 14, 145, 49, 66, 148, 99, 132, 113, 137, 132, 120, 79, 214, 132, 3, 154, 52, 191, 201, 205, 131, 177, 74, 59, 166, 63, 33, 1, 209, 76, 204, 54, 172, 200, 124, 36, 237, 228, 130, 64, 135, 40, 138, 130, 204, 30, 167, 194, 140, 28, 162, 170, 100, 77, 160, 128, 205, 42, 21, 154, 104, 107, 53, 87, 145, 145, 50, 34, 51, 41, 213, 91, 9, 222, 219, 50, 187, 250, 164, 182, 3, 221, 57, 3, 47, 126, 149, 86, 59, 16, 6, 137, 88, 46, 32, 41, 59, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 53, 47, 949, DateTimeKind.Utc).AddTicks(3612), new byte[] { 91, 0, 13, 74, 54, 20, 34, 91, 51, 138, 55, 198, 245, 135, 30, 50, 220, 29, 195, 28, 225, 179, 52, 247, 12, 82, 41, 141, 140, 247, 176, 15, 64, 24, 175, 227, 114, 195, 69, 25, 58, 43, 141, 141, 56, 65, 66, 70, 155, 194, 125, 192, 16, 229, 104, 101, 236, 195, 120, 20, 92, 197, 213, 71 }, new byte[] { 170, 198, 138, 42, 188, 35, 88, 98, 113, 90, 74, 16, 8, 211, 55, 252, 217, 86, 2, 157, 90, 107, 19, 148, 222, 28, 58, 101, 84, 187, 100, 59, 136, 98, 18, 42, 50, 27, 155, 54, 116, 198, 31, 14, 211, 86, 3, 212, 166, 34, 157, 99, 87, 104, 181, 180, 13, 34, 8, 184, 15, 68, 186, 234, 199, 128, 44, 125, 64, 242, 29, 242, 34, 209, 252, 216, 120, 148, 17, 221, 78, 119, 63, 110, 105, 191, 174, 228, 179, 84, 49, 77, 162, 40, 247, 21, 128, 158, 217, 200, 240, 196, 51, 214, 181, 38, 172, 154, 98, 66, 140, 115, 17, 126, 60, 57, 134, 0, 237, 243, 28, 153, 76, 40, 42, 159, 65, 234 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 53, 47, 949, DateTimeKind.Utc).AddTicks(3614), new byte[] { 133, 166, 250, 70, 60, 87, 170, 148, 113, 62, 135, 68, 45, 51, 19, 81, 47, 233, 130, 213, 237, 114, 168, 228, 103, 142, 65, 107, 171, 4, 90, 254, 53, 5, 109, 213, 201, 115, 161, 15, 2, 169, 80, 243, 67, 211, 58, 226, 50, 135, 28, 244, 248, 186, 193, 112, 189, 103, 173, 224, 99, 174, 30, 100 }, new byte[] { 217, 244, 248, 108, 209, 119, 1, 241, 148, 23, 66, 121, 201, 179, 145, 84, 15, 151, 101, 122, 97, 23, 6, 27, 247, 244, 143, 231, 216, 199, 255, 88, 33, 63, 203, 174, 80, 165, 83, 133, 6, 138, 177, 200, 115, 28, 225, 108, 61, 177, 158, 241, 145, 174, 106, 208, 63, 124, 198, 201, 228, 183, 212, 63, 44, 242, 27, 161, 135, 241, 2, 244, 150, 235, 205, 29, 53, 237, 177, 48, 67, 106, 108, 89, 125, 227, 161, 155, 84, 82, 168, 4, 47, 90, 163, 36, 170, 143, 109, 77, 8, 48, 149, 3, 72, 70, 83, 174, 20, 241, 54, 131, 179, 23, 14, 201, 10, 130, 105, 164, 25, 183, 148, 162, 177, 197, 130, 196 } });
        }
    }
}
