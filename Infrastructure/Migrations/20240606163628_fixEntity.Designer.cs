﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240606163628_fixEntity")]
    partial class fixEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.Property<string>("ScopeOfWork")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampaignId")
                        .HasColumnType("integer");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("CampaignJobs");
                });

            modelBuilder.Entity("Domain.Entities.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CVPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Benefits")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.Property<string>("ScopeOfWork")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TotalMember")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("JobId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "HRAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "HRAccount",
                            PasswordHash = new byte[] { 57, 37, 224, 106, 194, 81, 96, 129, 179, 195, 202, 11, 97, 32, 7, 72, 27, 225, 229, 154, 90, 9, 110, 20, 229, 227, 123, 105, 163, 103, 56, 70, 138, 87, 8, 156, 226, 156, 11, 127, 4, 30, 231, 1, 122, 12, 158, 143, 156, 221, 53, 32, 247, 166, 78, 99, 56, 193, 147, 211, 109, 20, 28, 126 },
                            PasswordSalt = new byte[] { 12, 205, 109, 62, 66, 61, 59, 147, 100, 30, 225, 59, 200, 145, 78, 107, 35, 101, 81, 96, 176, 23, 144, 88, 36, 201, 8, 195, 86, 56, 117, 61, 107, 206, 122, 165, 216, 246, 107, 12, 53, 59, 154, 224, 130, 91, 239, 254, 181, 142, 116, 17, 82, 71, 156, 10, 247, 87, 226, 135, 120, 162, 173, 92, 31, 80, 115, 136, 169, 59, 62, 12, 31, 223, 150, 122, 159, 222, 100, 89, 51, 1, 87, 105, 68, 89, 127, 121, 23, 255, 226, 178, 249, 111, 122, 44, 30, 166, 63, 140, 207, 104, 85, 67, 94, 20, 202, 244, 219, 222, 138, 194, 61, 235, 67, 78, 114, 81, 32, 143, 99, 14, 105, 116, 149, 14, 182, 69 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 1, 21, 120, 182, 16, 208, 86, 73, 31, 188, 5, 147, 202, 130, 157, 50, 26, 143, 177, 100, 11, 198, 241, 16, 123, 12, 181, 219, 193, 138, 234, 128, 51, 186, 202, 143, 98, 1, 179, 133, 141, 8, 8, 59, 215, 30, 225, 223, 8, 169, 189, 237, 170, 100, 242, 244, 218, 202, 55, 254, 107, 181, 228, 83 },
                            PasswordSalt = new byte[] { 164, 62, 15, 16, 78, 135, 211, 42, 29, 2, 254, 210, 154, 98, 207, 104, 231, 233, 41, 149, 79, 185, 13, 228, 79, 61, 250, 46, 116, 37, 77, 8, 56, 150, 169, 215, 88, 11, 181, 200, 192, 15, 236, 116, 61, 36, 84, 147, 232, 44, 154, 85, 157, 38, 204, 6, 168, 97, 232, 26, 36, 99, 110, 66, 210, 199, 219, 101, 212, 237, 72, 198, 67, 222, 124, 96, 104, 6, 166, 242, 44, 42, 121, 181, 68, 1, 3, 49, 246, 38, 194, 58, 17, 165, 64, 53, 65, 48, 82, 104, 194, 194, 76, 243, 195, 132, 220, 119, 37, 25, 190, 145, 218, 102, 184, 26, 45, 78, 87, 169, 63, 135, 109, 228, 249, 40, 163, 215 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 54, 195, 191, 172, 160, 175, 33, 60, 129, 28, 177, 166, 18, 63, 212, 199, 112, 43, 191, 121, 172, 233, 132, 10, 209, 149, 118, 46, 116, 229, 120, 35, 55, 37, 173, 254, 179, 89, 1, 39, 24, 38, 252, 144, 22, 0, 67, 98, 215, 68, 149, 169, 164, 171, 28, 248, 13, 191, 29, 232, 144, 8, 56, 254 },
                            PasswordSalt = new byte[] { 61, 235, 70, 13, 180, 241, 128, 54, 172, 220, 58, 123, 212, 66, 192, 225, 202, 238, 80, 232, 1, 175, 193, 63, 192, 239, 219, 101, 248, 229, 216, 47, 189, 189, 111, 249, 182, 114, 155, 242, 2, 137, 1, 121, 134, 67, 115, 97, 35, 229, 199, 13, 94, 58, 197, 24, 139, 48, 38, 6, 174, 112, 88, 215, 66, 158, 69, 134, 223, 212, 241, 171, 175, 180, 159, 78, 24, 202, 185, 124, 206, 41, 206, 52, 45, 18, 50, 47, 29, 109, 18, 200, 253, 237, 119, 157, 98, 233, 81, 217, 169, 113, 153, 10, 196, 134, 216, 173, 98, 199, 200, 2, 33, 46, 79, 111, 214, 1, 94, 5, 54, 87, 157, 102, 151, 34, 105, 140 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 114, 69, 104, 255, 99, 188, 186, 161, 34, 231, 118, 49, 210, 114, 201, 67, 21, 141, 227, 79, 212, 187, 25, 14, 87, 69, 65, 56, 185, 151, 37, 48, 67, 8, 76, 221, 79, 100, 8, 120, 111, 248, 233, 91, 176, 71, 197, 67, 104, 162, 133, 103, 96, 56, 81, 79, 18, 172, 218, 68, 39, 86, 113, 147 },
                            PasswordSalt = new byte[] { 210, 145, 106, 109, 139, 96, 67, 51, 112, 142, 141, 202, 105, 11, 72, 171, 155, 1, 66, 83, 62, 159, 86, 253, 113, 24, 121, 173, 175, 156, 188, 53, 51, 89, 16, 221, 96, 47, 239, 85, 35, 94, 223, 4, 121, 101, 75, 191, 1, 83, 83, 201, 156, 202, 88, 206, 116, 186, 33, 12, 161, 197, 138, 79, 91, 214, 233, 241, 88, 250, 204, 197, 93, 221, 146, 183, 178, 41, 17, 215, 17, 250, 168, 106, 127, 55, 23, 124, 67, 139, 56, 25, 219, 1, 50, 128, 111, 152, 200, 236, 30, 64, 146, 28, 222, 240, 251, 17, 247, 53, 155, 215, 43, 57, 147, 250, 78, 203, 170, 254, 234, 166, 247, 75, 13, 189, 175, 67 },
                            Role = 0,
                            UserName = "InternAccount"
                        });
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.HasOne("Domain.Entities.Campaign", "Campaign")
                        .WithMany("CampaignJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("CampaignJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.Candidate", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("Candidates")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("Interns")
                        .HasForeignKey("JobId");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Navigation("CampaignJobs");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Navigation("CampaignJobs");

                    b.Navigation("Candidates");

                    b.Navigation("Interns");
                });
#pragma warning restore 612, 618
        }
    }
}
