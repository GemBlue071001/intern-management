﻿using Domain.Entities;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignJob> CampaignJobs { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<JobTrainingProgram> JobTrainingPrograms { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<TrainingProgramResource> TrainingProgramResource { get; set; }
        public DbSet<UserMeeting> UserMeeting { get; set; }
        public DbSet<KPI> KPI { get; set; }
        public DbSet<ProgramKPI> ProgramKPI { get; set; }
        public DbSet<UserResult> UserResults { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<UserConversation> UserConversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CandidateConfig());
            modelBuilder.ApplyConfiguration(new CampaignJobConfig());
            modelBuilder.ApplyConfiguration(new JobTrainingProgramConfig());
            modelBuilder.ApplyConfiguration(new UserMeetingConfig());
            modelBuilder.ApplyConfiguration(new AssessmentConfig());
            modelBuilder.ApplyConfiguration(new TrainingProgramResourceConfig());
            modelBuilder.ApplyConfiguration(new ProgramKPIConfig());
            modelBuilder.ApplyConfiguration(new UserResultConfig());
            modelBuilder.ApplyConfiguration(new UserConversationConfig());
            modelBuilder.ApplyConfiguration(new MessageConfig());
            modelBuilder.ApplyConfiguration(new ConversationConfig());
            modelBuilder.ApplyConfiguration(new AttendanceConfig());
        }

    }
}
