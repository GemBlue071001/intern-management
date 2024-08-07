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
    [Migration("20240720142447_addDateToProgram")]
    partial class addDateToProgram
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ActualTime")
                        .HasColumnType("integer");

                    b.Property<int>("AssessmentStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EstimateTime")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Domain.Entities.AssessmentSubmition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AssessmentId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
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

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.ToTable("AssessmentSubmition");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
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

                    b.Property<DateTime>("EstimateEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EstimateStartDate")
                        .HasColumnType("timestamp with time zone");

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

                    b.HasIndex("CampaignId");

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

                    b.Property<int?>("CampaignJobId")
                        .HasColumnType("integer");

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

                    b.HasKey("Id");

                    b.HasIndex("CampaignJobId");

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

                    b.Property<string>("Location")
                        .HasColumnType("text");

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

            modelBuilder.Entity("Domain.Entities.JobTrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("JobId")
                        .HasColumnType("integer");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("JobTrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.KPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("KPI");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Minutes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Domain.Entities.ProgramKPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KPIId")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("KPIId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("ProgramKPI");
                });

            modelBuilder.Entity("Domain.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
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

                    b.HasKey("Id");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseObject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OutputObject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgramResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResourceId")
                        .HasColumnType("integer");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramResource");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CampaignJobId")
                        .HasColumnType("integer");

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

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CampaignJobId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7217),
                            Email = "HRAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "HRAccount",
                            PasswordHash = new byte[] { 103, 188, 239, 174, 77, 236, 255, 57, 59, 80, 47, 203, 25, 41, 211, 137, 228, 249, 166, 41, 163, 117, 208, 215, 45, 80, 66, 143, 234, 58, 179, 117, 193, 252, 77, 220, 12, 33, 243, 175, 215, 64, 157, 144, 254, 213, 87, 199, 136, 120, 52, 194, 147, 184, 101, 120, 0, 179, 32, 149, 191, 94, 2, 114 },
                            PasswordSalt = new byte[] { 90, 226, 80, 228, 244, 116, 89, 137, 183, 58, 237, 177, 125, 150, 210, 148, 76, 217, 80, 226, 215, 40, 229, 104, 236, 242, 240, 57, 206, 200, 188, 23, 28, 156, 11, 168, 222, 97, 50, 100, 99, 125, 208, 92, 108, 3, 73, 185, 114, 41, 66, 230, 229, 78, 174, 74, 89, 58, 141, 49, 182, 112, 186, 57, 69, 114, 242, 172, 133, 143, 231, 155, 154, 41, 28, 42, 87, 233, 202, 210, 99, 20, 220, 127, 105, 55, 77, 147, 103, 36, 236, 44, 138, 215, 80, 52, 119, 31, 160, 196, 121, 245, 76, 91, 21, 104, 47, 196, 169, 61, 216, 54, 190, 139, 225, 11, 121, 212, 227, 60, 155, 7, 246, 5, 115, 109, 237, 27 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7224),
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 49, 181, 73, 136, 91, 125, 219, 185, 175, 16, 51, 125, 38, 101, 82, 225, 237, 248, 164, 124, 164, 15, 9, 160, 255, 116, 138, 156, 181, 51, 112, 115, 142, 137, 213, 17, 129, 8, 29, 152, 246, 138, 165, 62, 65, 131, 58, 130, 151, 165, 108, 56, 179, 137, 254, 152, 195, 161, 93, 232, 76, 12, 78, 215 },
                            PasswordSalt = new byte[] { 100, 201, 33, 219, 147, 240, 0, 22, 80, 136, 47, 75, 195, 129, 187, 79, 132, 78, 77, 17, 110, 84, 233, 44, 152, 163, 109, 22, 145, 5, 130, 252, 2, 150, 27, 213, 109, 120, 78, 145, 138, 139, 191, 171, 67, 251, 213, 81, 97, 193, 201, 181, 222, 225, 41, 41, 157, 161, 65, 248, 10, 58, 103, 214, 229, 154, 81, 141, 143, 125, 14, 50, 155, 67, 185, 75, 73, 245, 240, 237, 74, 28, 64, 112, 33, 95, 88, 205, 7, 129, 241, 236, 220, 195, 25, 49, 42, 182, 203, 88, 30, 111, 83, 200, 3, 166, 137, 149, 77, 59, 250, 10, 154, 144, 165, 6, 137, 85, 103, 146, 145, 74, 104, 20, 57, 125, 74, 51 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7227),
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 46, 88, 10, 194, 96, 216, 53, 208, 1, 67, 202, 68, 128, 85, 82, 242, 59, 56, 43, 208, 133, 116, 175, 31, 221, 69, 170, 201, 81, 2, 237, 59, 150, 132, 93, 144, 238, 117, 99, 108, 42, 162, 67, 240, 198, 67, 82, 241, 61, 82, 157, 96, 217, 227, 19, 251, 13, 45, 179, 184, 164, 197, 213, 76 },
                            PasswordSalt = new byte[] { 212, 201, 252, 40, 66, 177, 232, 78, 13, 144, 200, 218, 141, 203, 213, 238, 146, 218, 243, 204, 252, 187, 237, 72, 7, 57, 86, 247, 94, 94, 149, 193, 134, 103, 50, 245, 102, 186, 13, 92, 85, 105, 183, 79, 164, 235, 238, 87, 108, 183, 14, 55, 85, 20, 180, 15, 87, 43, 87, 194, 117, 43, 164, 165, 135, 226, 205, 157, 124, 223, 195, 153, 31, 151, 14, 54, 180, 210, 27, 119, 8, 50, 183, 209, 57, 200, 236, 226, 4, 103, 240, 86, 77, 143, 83, 190, 8, 231, 222, 7, 136, 69, 97, 168, 11, 26, 35, 17, 128, 130, 160, 0, 164, 120, 106, 202, 172, 211, 188, 88, 164, 163, 252, 22, 78, 202, 153, 190 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7228),
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 51, 140, 137, 158, 124, 118, 232, 95, 141, 100, 254, 105, 212, 37, 125, 38, 243, 232, 117, 231, 152, 52, 219, 217, 234, 130, 169, 40, 99, 16, 55, 252, 155, 143, 242, 186, 82, 0, 186, 253, 252, 42, 170, 155, 76, 4, 222, 49, 152, 244, 190, 161, 149, 51, 154, 239, 59, 239, 151, 139, 23, 126, 12, 138 },
                            PasswordSalt = new byte[] { 43, 188, 168, 31, 45, 255, 245, 7, 84, 177, 46, 200, 175, 124, 85, 128, 175, 134, 75, 241, 192, 157, 169, 129, 146, 108, 224, 167, 250, 9, 169, 107, 187, 69, 7, 140, 2, 169, 207, 221, 65, 149, 193, 216, 154, 67, 254, 187, 190, 250, 91, 130, 152, 83, 230, 24, 10, 219, 249, 138, 200, 174, 65, 132, 44, 97, 73, 181, 43, 5, 94, 130, 45, 39, 49, 153, 185, 12, 26, 97, 67, 85, 22, 90, 22, 78, 219, 84, 99, 243, 238, 82, 64, 75, 11, 74, 175, 73, 178, 253, 181, 240, 0, 186, 127, 177, 56, 193, 187, 224, 189, 5, 204, 201, 249, 211, 158, 19, 34, 165, 128, 250, 151, 237, 106, 202, 46, 249 },
                            Role = 0,
                            UserName = "InternAccount"
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserMeeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MeetingId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMeeting");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProgramId")
                        .HasColumnType("integer");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserResultDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserResultId")
                        .HasColumnType("integer");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserResultId");

                    b.ToTable("UserResultDetail");
                });

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Assessments")
                        .HasForeignKey("TrainingProgramId");

                    b.HasOne("Domain.Entities.UserAccount", "Owner")
                        .WithMany("Assessments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.AssessmentSubmition", b =>
                {
                    b.HasOne("Domain.Entities.Assessment", "Assessment")
                        .WithMany("AssessmentSubmitions")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessment");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.HasOne("Domain.Entities.Campaign", "Campaign")
                        .WithMany("CampaignJobs")
                        .HasForeignKey("CampaignId")
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
                    b.HasOne("Domain.Entities.CampaignJob", "CampaignJob")
                        .WithMany("Candidates")
                        .HasForeignKey("CampaignJobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("CampaignJob");
                });

            modelBuilder.Entity("Domain.Entities.JobTrainingProgram", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Job");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.ProgramKPI", b =>
                {
                    b.HasOne("Domain.Entities.KPI", "KPI")
                        .WithMany("ProgramKPI")
                        .HasForeignKey("KPIId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("ProgramKPI")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KPI");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgramResource", b =>
                {
                    b.HasOne("Domain.Entities.Resource", "Resource")
                        .WithMany("TrainingProgramResources")
                        .HasForeignKey("ResourceId");

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("TrainingProgramResources")
                        .HasForeignKey("TrainingProgramId");

                    b.Navigation("Resource");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.HasOne("Domain.Entities.CampaignJob", "CampaignJob")
                        .WithMany("Interns")
                        .HasForeignKey("CampaignJobId");

                    b.Navigation("CampaignJob");
                });

            modelBuilder.Entity("Domain.Entities.UserMeeting", b =>
                {
                    b.HasOne("Domain.Entities.Meeting", "Meeting")
                        .WithMany("UserMeetings")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserAccount", "User")
                        .WithMany("UserMeetings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "Program")
                        .WithMany("UserResults")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserAccount", "User")
                        .WithMany("UserResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserResultDetail", b =>
                {
                    b.HasOne("Domain.Entities.UserResult", "UserResult")
                        .WithMany("UserResultDetails")
                        .HasForeignKey("UserResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserResult");
                });

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.Navigation("AssessmentSubmitions");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Navigation("CampaignJobs");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Interns");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Navigation("CampaignJobs");

                    b.Navigation("JobTrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.KPI", b =>
                {
                    b.Navigation("ProgramKPI");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Navigation("UserMeetings");
                });

            modelBuilder.Entity("Domain.Entities.Resource", b =>
                {
                    b.Navigation("TrainingProgramResources");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("JobTrainingPrograms");

                    b.Navigation("ProgramKPI");

                    b.Navigation("TrainingProgramResources");

                    b.Navigation("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("UserMeetings");

                    b.Navigation("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.Navigation("UserResultDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
