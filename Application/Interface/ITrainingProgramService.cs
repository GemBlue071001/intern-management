﻿using Application.Request.KPI;
using Application.Request.TrainingProgram;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ITrainingProgramService
    {
        Task<ApiResponse> AddTrainingProgram(TrainingProgramRequest request);
        Task<ApiResponse> GetAllTrainingProgram();
        Task<ApiResponse> RemoveResourceFromTrainingProgramAsync(TrainingResourceRequest request);
        Task<ApiResponse> AddResourceToTrainingProgramAsync(TrainingResourceRequest request);
        Task<ApiResponse> UpdateTrainingProgramAsync(TrainingUpdateRequest request);
        Task<ApiResponse> DeleteTrainingProgramAsync(int id);
        Task<ApiResponse> AddKPIToTranningProgram(ProgramKPIRequest request);
        Task<ApiResponse> RemoveKPIFromTrainingProgramAsync(ProgramKPIRequest request);
        Task<ApiResponse> GetUserTrainingProgram(int userId);
    }
}
