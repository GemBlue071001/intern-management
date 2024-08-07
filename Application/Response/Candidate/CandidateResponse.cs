﻿using Application.Response.Campaign;
using Application.Response.Job;
using Domain.Entities;
using System.Text.Json.Serialization;

namespace Application.Response.Candidate
{
    public class CandidateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string CVPath { get; set; } = string.Empty;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CandidateStatus CandidateStatus { get; set; }

        public JobResponse Job { get; set; }
        public CampaignResponse Campaign { get; set; }
    }
}
