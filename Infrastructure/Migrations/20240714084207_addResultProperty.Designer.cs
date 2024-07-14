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
    [Migration("20240714084207_addResultProperty")]
    partial class addResultProperty
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
                        .IsRequired()
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
                            Email = "HRAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "HRAccount",
                            PasswordHash = new byte[] { 44, 110, 73, 139, 85, 155, 144, 81, 162, 12, 232, 129, 161, 229, 173, 44, 226, 200, 143, 21, 167, 124, 175, 241, 117, 109, 53, 44, 157, 243, 228, 65, 203, 165, 108, 173, 225, 235, 56, 135, 122, 4, 54, 219, 44, 79, 101, 13, 133, 244, 149, 200, 241, 37, 120, 167, 140, 225, 190, 39, 2, 121, 125, 64 },
                            PasswordSalt = new byte[] { 51, 45, 147, 236, 227, 72, 232, 230, 164, 184, 35, 19, 245, 191, 112, 98, 100, 216, 13, 255, 243, 217, 166, 55, 182, 219, 239, 135, 27, 86, 229, 25, 55, 208, 67, 48, 9, 113, 137, 203, 228, 11, 139, 31, 60, 46, 41, 165, 93, 23, 66, 153, 16, 11, 114, 45, 145, 9, 45, 54, 53, 1, 199, 142, 2, 190, 24, 28, 112, 128, 231, 242, 148, 249, 125, 124, 227, 146, 125, 200, 190, 200, 140, 40, 58, 245, 44, 242, 36, 145, 156, 181, 169, 61, 200, 170, 176, 219, 205, 116, 34, 109, 150, 204, 12, 101, 200, 30, 150, 166, 123, 251, 254, 204, 109, 128, 85, 62, 47, 245, 138, 50, 146, 45, 129, 128, 24, 196 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 248, 232, 205, 51, 63, 110, 147, 152, 68, 144, 152, 178, 247, 148, 254, 7, 162, 90, 6, 52, 157, 178, 67, 105, 81, 24, 185, 100, 207, 157, 77, 250, 32, 19, 173, 40, 134, 145, 226, 44, 117, 56, 152, 36, 250, 251, 251, 116, 107, 56, 198, 230, 52, 83, 67, 78, 193, 115, 113, 235, 16, 187, 150, 156 },
                            PasswordSalt = new byte[] { 42, 100, 82, 144, 101, 2, 145, 164, 214, 103, 41, 191, 237, 45, 153, 186, 183, 62, 207, 215, 74, 121, 2, 136, 67, 149, 123, 38, 42, 16, 20, 125, 216, 34, 201, 127, 24, 5, 148, 74, 135, 159, 15, 154, 211, 24, 144, 195, 212, 173, 49, 191, 154, 253, 163, 26, 212, 7, 232, 220, 91, 114, 117, 59, 81, 213, 27, 28, 164, 70, 215, 68, 10, 137, 181, 201, 54, 203, 24, 62, 217, 188, 167, 94, 177, 8, 243, 43, 232, 54, 213, 248, 221, 107, 253, 216, 159, 125, 201, 175, 41, 206, 193, 48, 123, 16, 127, 14, 121, 140, 88, 124, 91, 182, 19, 33, 197, 131, 246, 151, 167, 125, 141, 67, 153, 26, 11, 160 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 240, 86, 222, 10, 245, 235, 244, 105, 158, 181, 236, 59, 26, 65, 45, 147, 75, 125, 235, 237, 186, 214, 112, 94, 201, 80, 31, 86, 249, 213, 85, 228, 153, 230, 205, 214, 128, 129, 217, 110, 90, 43, 207, 149, 119, 251, 121, 203, 32, 39, 206, 23, 29, 6, 128, 36, 203, 74, 14, 6, 177, 35, 98, 3 },
                            PasswordSalt = new byte[] { 164, 207, 110, 240, 189, 139, 90, 147, 146, 194, 133, 223, 153, 111, 211, 26, 144, 248, 95, 12, 150, 138, 1, 235, 33, 184, 3, 3, 253, 128, 48, 218, 10, 12, 23, 45, 103, 196, 149, 52, 127, 184, 238, 129, 216, 214, 35, 182, 186, 0, 246, 225, 70, 16, 182, 177, 146, 85, 75, 147, 20, 240, 15, 3, 196, 135, 136, 219, 218, 196, 177, 195, 14, 49, 140, 90, 33, 174, 174, 18, 174, 30, 25, 90, 170, 157, 254, 58, 224, 169, 163, 200, 42, 64, 122, 132, 198, 182, 16, 31, 216, 195, 45, 184, 211, 43, 160, 218, 162, 206, 180, 96, 219, 251, 228, 36, 6, 183, 4, 149, 177, 12, 55, 85, 5, 153, 84, 208 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 24, 229, 27, 208, 118, 177, 62, 39, 196, 10, 146, 157, 56, 177, 116, 41, 165, 253, 194, 138, 236, 90, 173, 185, 137, 225, 104, 29, 140, 238, 44, 186, 169, 105, 134, 145, 226, 37, 230, 133, 172, 73, 78, 143, 232, 26, 26, 212, 38, 233, 247, 39, 108, 99, 117, 208, 181, 67, 49, 214, 218, 144, 44, 27 },
                            PasswordSalt = new byte[] { 27, 41, 111, 42, 115, 85, 116, 65, 49, 145, 29, 169, 144, 46, 149, 11, 18, 208, 220, 71, 244, 140, 49, 31, 23, 96, 66, 120, 107, 157, 123, 224, 52, 243, 12, 39, 209, 38, 58, 230, 26, 87, 231, 5, 208, 244, 157, 141, 25, 255, 161, 229, 54, 159, 193, 127, 220, 48, 150, 214, 17, 253, 245, 83, 243, 150, 57, 115, 36, 121, 225, 63, 104, 140, 248, 84, 11, 191, 209, 45, 149, 144, 53, 243, 86, 150, 194, 218, 254, 111, 250, 102, 78, 183, 179, 150, 170, 236, 8, 252, 188, 129, 173, 67, 174, 171, 60, 54, 59, 127, 62, 147, 159, 216, 18, 230, 230, 45, 2, 196, 14, 14, 73, 222, 221, 146, 120, 74 },
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

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.Property<int>("ProgramKpiId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProgramKpiId");

                    b.HasIndex("UserId");

                    b.ToTable("UserResults");
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
                    b.HasOne("Domain.Entities.ProgramKPI", "ProgramKPI")
                        .WithMany("UserResults")
                        .HasForeignKey("ProgramKpiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserAccount", "User")
                        .WithMany("UserResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramKPI");

                    b.Navigation("User");
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

            modelBuilder.Entity("Domain.Entities.ProgramKPI", b =>
                {
                    b.Navigation("UserResults");
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
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("UserMeetings");

                    b.Navigation("UserResults");
                });
#pragma warning restore 612, 618
        }
    }
}
