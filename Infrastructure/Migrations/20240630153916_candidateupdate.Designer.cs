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
    [Migration("20240630153916_candidateupdate")]
    partial class candidateupdate
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

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

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
                            PasswordHash = new byte[] { 226, 199, 198, 65, 174, 68, 22, 199, 229, 108, 112, 34, 84, 231, 66, 34, 131, 8, 36, 212, 250, 39, 35, 11, 33, 86, 122, 250, 120, 94, 211, 152, 193, 17, 13, 232, 109, 62, 162, 93, 54, 159, 211, 51, 142, 97, 96, 158, 19, 175, 67, 223, 247, 121, 73, 184, 136, 131, 235, 194, 30, 131, 6, 217 },
                            PasswordSalt = new byte[] { 75, 244, 119, 43, 155, 21, 13, 61, 182, 75, 87, 94, 251, 248, 131, 20, 3, 102, 183, 10, 197, 238, 224, 127, 100, 193, 99, 246, 106, 4, 173, 88, 6, 229, 49, 44, 168, 182, 123, 244, 255, 139, 81, 246, 188, 170, 174, 182, 215, 28, 120, 116, 228, 128, 58, 39, 10, 25, 105, 81, 25, 35, 155, 149, 164, 58, 31, 13, 200, 99, 227, 205, 3, 129, 18, 106, 148, 138, 100, 250, 10, 112, 96, 8, 87, 22, 15, 166, 100, 51, 42, 106, 233, 187, 49, 121, 150, 6, 123, 18, 130, 98, 80, 45, 232, 112, 72, 4, 192, 4, 63, 116, 245, 146, 39, 194, 115, 142, 30, 222, 87, 17, 223, 125, 233, 54, 21, 6 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 106, 127, 111, 158, 68, 21, 59, 222, 26, 250, 114, 18, 158, 26, 246, 63, 109, 72, 59, 153, 176, 147, 54, 84, 154, 91, 14, 49, 9, 121, 5, 72, 85, 43, 216, 211, 198, 240, 255, 81, 106, 123, 177, 185, 174, 226, 246, 71, 56, 201, 141, 24, 193, 90, 12, 47, 36, 45, 233, 54, 205, 105, 130, 53 },
                            PasswordSalt = new byte[] { 116, 54, 125, 103, 209, 188, 21, 155, 1, 86, 82, 191, 69, 230, 165, 239, 92, 85, 164, 41, 181, 149, 116, 157, 158, 64, 224, 132, 6, 66, 89, 60, 182, 87, 168, 91, 203, 43, 26, 176, 222, 64, 34, 42, 58, 39, 3, 62, 14, 178, 235, 123, 251, 124, 163, 155, 152, 193, 169, 29, 190, 102, 94, 196, 158, 124, 134, 189, 38, 35, 200, 178, 172, 103, 66, 178, 28, 157, 0, 91, 7, 115, 161, 27, 89, 109, 253, 0, 239, 99, 128, 92, 74, 172, 206, 154, 227, 25, 101, 202, 41, 145, 71, 92, 158, 223, 34, 207, 98, 230, 208, 58, 89, 209, 232, 118, 144, 183, 51, 38, 45, 106, 132, 135, 202, 191, 217, 149 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 144, 162, 73, 201, 3, 85, 147, 212, 146, 192, 132, 119, 213, 73, 172, 178, 95, 88, 5, 62, 87, 38, 205, 237, 20, 223, 10, 195, 22, 158, 183, 251, 146, 174, 120, 196, 165, 106, 228, 220, 166, 206, 83, 39, 175, 227, 66, 51, 55, 77, 210, 128, 227, 73, 136, 54, 204, 224, 78, 232, 17, 155, 38, 58 },
                            PasswordSalt = new byte[] { 237, 180, 173, 31, 110, 111, 115, 162, 179, 235, 188, 17, 113, 204, 254, 222, 84, 30, 178, 39, 174, 125, 2, 218, 107, 187, 223, 152, 15, 35, 73, 93, 119, 31, 62, 56, 162, 168, 147, 107, 178, 128, 229, 248, 190, 158, 202, 188, 135, 136, 30, 25, 208, 169, 16, 169, 216, 127, 243, 52, 222, 185, 24, 227, 146, 13, 143, 174, 252, 22, 120, 26, 163, 72, 86, 172, 210, 124, 249, 94, 226, 103, 85, 13, 95, 80, 69, 85, 119, 58, 168, 81, 40, 191, 214, 126, 227, 159, 114, 254, 94, 96, 152, 60, 177, 226, 30, 11, 242, 226, 179, 116, 134, 105, 85, 28, 121, 49, 199, 176, 131, 94, 170, 32, 195, 1, 125, 8 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 69, 63, 115, 171, 103, 24, 233, 7, 126, 95, 128, 123, 147, 133, 77, 6, 199, 65, 123, 72, 246, 102, 151, 130, 131, 81, 92, 52, 237, 46, 129, 6, 99, 98, 106, 197, 206, 239, 1, 174, 197, 161, 111, 220, 97, 43, 229, 95, 190, 74, 39, 214, 21, 67, 152, 110, 181, 54, 15, 100, 195, 223, 101, 42 },
                            PasswordSalt = new byte[] { 86, 79, 136, 47, 73, 182, 2, 66, 171, 44, 207, 7, 226, 234, 101, 248, 160, 58, 213, 254, 25, 165, 57, 171, 216, 68, 105, 105, 200, 170, 141, 59, 99, 51, 231, 129, 40, 47, 41, 253, 107, 112, 36, 27, 159, 77, 224, 222, 245, 145, 194, 145, 40, 197, 246, 35, 15, 77, 212, 147, 178, 6, 230, 165, 26, 223, 208, 66, 67, 31, 142, 145, 47, 255, 241, 75, 142, 60, 73, 42, 85, 44, 174, 81, 221, 238, 246, 179, 47, 88, 55, 88, 149, 83, 26, 187, 137, 201, 140, 242, 3, 116, 154, 128, 134, 11, 33, 150, 45, 194, 203, 161, 120, 59, 104, 91, 68, 152, 28, 29, 6, 75, 193, 139, 39, 252, 125, 82 },
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

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.HasOne("Domain.Entities.UserAccount", "Owner")
                        .WithMany("Assessments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
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
                    b.Navigation("JobTrainingPrograms");

                    b.Navigation("TrainingProgramResources");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("UserMeetings");
                });
#pragma warning restore 612, 618
        }
    }
}
