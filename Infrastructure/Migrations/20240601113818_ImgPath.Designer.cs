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
    [Migration("20240601113818_ImgPath")]
    partial class ImgPath
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

            modelBuilder.Entity("Domain.Entities.CampaignTrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampaignId")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("CampaignTrainingPrograms");
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
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

                    b.ToTable("TrainingPrograms");
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

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

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
                            PasswordHash = new byte[] { 144, 164, 171, 15, 171, 219, 120, 216, 196, 128, 41, 86, 103, 246, 192, 184, 65, 133, 171, 188, 217, 56, 110, 149, 196, 98, 71, 148, 7, 253, 248, 208, 248, 204, 21, 141, 225, 41, 75, 131, 191, 119, 24, 16, 56, 80, 96, 145, 41, 127, 90, 191, 131, 244, 242, 243, 111, 91, 168, 129, 158, 1, 206, 37 },
                            PasswordSalt = new byte[] { 154, 16, 47, 172, 193, 45, 243, 127, 178, 191, 192, 60, 23, 218, 255, 18, 36, 160, 85, 249, 195, 15, 254, 147, 242, 27, 45, 72, 209, 184, 144, 105, 128, 5, 113, 84, 12, 7, 42, 11, 195, 79, 216, 134, 119, 22, 252, 155, 79, 15, 201, 120, 195, 171, 156, 200, 113, 74, 18, 92, 251, 1, 83, 163, 23, 49, 126, 215, 199, 204, 101, 241, 232, 32, 229, 24, 105, 49, 214, 232, 131, 37, 23, 95, 129, 62, 139, 118, 44, 180, 154, 43, 133, 217, 76, 84, 52, 216, 94, 43, 29, 199, 118, 195, 72, 7, 214, 207, 50, 182, 133, 165, 156, 145, 103, 147, 85, 222, 210, 116, 63, 27, 77, 55, 34, 219, 214, 37 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 33, 158, 227, 79, 68, 196, 94, 229, 245, 6, 167, 117, 1, 210, 235, 219, 96, 74, 148, 75, 7, 1, 208, 114, 144, 212, 78, 126, 151, 13, 83, 83, 191, 91, 197, 170, 81, 40, 42, 136, 161, 146, 63, 18, 147, 102, 99, 102, 85, 136, 211, 240, 87, 45, 193, 247, 229, 1, 216, 87, 86, 225, 112, 168 },
                            PasswordSalt = new byte[] { 227, 77, 37, 236, 110, 84, 211, 115, 161, 255, 137, 161, 56, 96, 37, 45, 173, 50, 2, 18, 126, 81, 5, 2, 65, 124, 72, 112, 143, 210, 122, 63, 246, 92, 219, 183, 116, 1, 214, 7, 22, 125, 40, 230, 14, 178, 66, 157, 171, 80, 7, 81, 171, 24, 55, 134, 166, 190, 78, 54, 189, 37, 157, 205, 155, 189, 157, 148, 177, 183, 254, 194, 111, 156, 48, 35, 224, 222, 74, 129, 76, 173, 227, 131, 105, 121, 45, 58, 191, 152, 7, 110, 253, 112, 179, 124, 244, 35, 147, 232, 142, 203, 204, 88, 41, 36, 97, 240, 70, 171, 100, 221, 224, 5, 245, 234, 161, 53, 250, 227, 1, 248, 47, 245, 235, 162, 104, 86 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 184, 109, 169, 197, 21, 242, 91, 201, 188, 174, 10, 168, 224, 234, 132, 107, 111, 18, 179, 12, 217, 116, 116, 183, 92, 107, 252, 196, 35, 41, 209, 39, 167, 72, 16, 126, 239, 84, 255, 76, 175, 160, 243, 3, 56, 87, 54, 220, 73, 62, 50, 117, 83, 210, 85, 48, 178, 231, 99, 248, 85, 177, 228, 131 },
                            PasswordSalt = new byte[] { 134, 54, 197, 75, 183, 159, 21, 94, 217, 88, 155, 111, 237, 188, 25, 110, 73, 149, 112, 126, 119, 0, 244, 100, 137, 69, 11, 190, 90, 186, 102, 243, 5, 125, 83, 93, 228, 203, 95, 18, 229, 225, 65, 254, 253, 245, 218, 62, 98, 220, 149, 5, 115, 7, 49, 181, 250, 62, 6, 13, 178, 129, 59, 187, 235, 144, 42, 65, 94, 130, 33, 37, 73, 68, 177, 164, 44, 74, 51, 2, 154, 141, 70, 8, 50, 38, 51, 235, 102, 102, 43, 59, 56, 197, 139, 84, 157, 46, 58, 41, 231, 160, 54, 61, 173, 53, 57, 86, 33, 103, 117, 129, 57, 151, 195, 233, 159, 229, 56, 74, 16, 83, 118, 255, 62, 206, 14, 221 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 88, 99, 69, 134, 19, 12, 154, 4, 24, 160, 62, 72, 203, 220, 153, 188, 190, 156, 79, 210, 61, 219, 232, 204, 71, 15, 32, 195, 106, 186, 164, 190, 252, 231, 142, 136, 221, 167, 109, 249, 142, 159, 252, 197, 209, 188, 103, 43, 230, 234, 187, 64, 229, 131, 93, 31, 18, 58, 7, 10, 32, 220, 191, 221 },
                            PasswordSalt = new byte[] { 133, 227, 90, 198, 89, 90, 126, 53, 54, 146, 252, 237, 39, 223, 193, 70, 61, 123, 173, 9, 241, 195, 82, 65, 115, 229, 108, 104, 91, 255, 15, 86, 230, 151, 208, 200, 118, 123, 36, 158, 226, 247, 237, 78, 209, 49, 115, 239, 0, 252, 211, 156, 173, 225, 124, 16, 108, 22, 145, 251, 73, 11, 70, 142, 0, 11, 153, 233, 75, 85, 205, 24, 87, 43, 114, 70, 179, 112, 187, 31, 175, 218, 156, 172, 143, 81, 115, 2, 216, 165, 24, 81, 203, 212, 253, 151, 245, 153, 64, 89, 235, 134, 81, 111, 245, 176, 35, 26, 38, 228, 171, 27, 63, 210, 106, 165, 218, 60, 120, 190, 125, 91, 166, 58, 17, 105, 31, 157 },
                            Role = 0,
                            UserName = "InternAccount"
                        });
                });

            modelBuilder.Entity("Domain.Entities.CampaignTrainingProgram", b =>
                {
                    b.HasOne("Domain.Entities.Campaign", "Campaign")
                        .WithMany("CampaignTrainingPrograms")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("CampaignTrainingPrograms")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.Candidate", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Candidates")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Interns")
                        .HasForeignKey("TrainingProgramId");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Navigation("CampaignTrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Navigation("CampaignTrainingPrograms");

                    b.Navigation("Candidates");

                    b.Navigation("Interns");
                });
#pragma warning restore 612, 618
        }
    }
}
