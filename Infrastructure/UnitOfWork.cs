﻿using Application;
using Application.Repositories;
using Application.Repository;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IUserAccountRepository UserAccounts { get; }
        public IJobRepository Jobs { get; }
        public ICandidateRepository Candidates { get; }
        public ICampaignJobRepository CampaignJobs { get; }
        public ICampaignRepository Campaigns { get; }

        public ITrainingProgramRepository TrainingPrograms { get; }
        public IAssessmentRepository Assessment { get; }

        public IResourceRepository Resources { get; }

        public ITrainingProgramResourceRepository TrainingProgramResources { get; }

        public IUserMeetingRepository UserMeetings { get; }

        public IMeetingRepository Meetings { get; }

        public IJobTrainingProgramRepository JobTrainingPrograms { get; }
        public IKPIRepository KPIs { get; }

        public IProgramKPIRepository ProgramKPIs { get; }

        public IUserResultRepository UserResults { get; }

        public IAssessmentSubmitionsRepository AssessmentSubmitions { get; }
        public IConversationRepository Conversations { get; }
        public IMessageRepository Messages { get; }

        public IConversationUserRepository ConversationsUsers { get; }

        public IAttendanceRepository Attendances { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            Jobs = new JobRepository(context);
            Candidates = new CandidateRepository(context);
            CampaignJobs = new CampaignJobRepository(context);
            Campaigns = new CampaignRepository(context);
            TrainingPrograms = new TrainingProgramRepository(context);
            Assessment = new AssessmentRepository(context);
            Resources = new ResourceRepository(context);
            TrainingProgramResources = new TrainingProgramResourceRepository(context);
            UserMeetings = new UserMeetingRepository(context);
            Meetings = new MeetingRepository(context);
            JobTrainingPrograms = new JobTrainingProgramRepository(context);
            KPIs = new KPIRepository(context);
            ProgramKPIs = new ProgramKPIRepository(context);
            UserResults = new UserResultRepository(context);
            AssessmentSubmitions = new AssessmentSubmitionsRepository(context);
            Conversations = new ConversationRepository(context);
            Messages = new MessageRepository(context);
            ConversationsUsers = new ConversationUserRepository(context);
            Attendances = new AttendanceRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
