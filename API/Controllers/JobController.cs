﻿using Application.Interface;
using Application.Request.Job;
using Application.Request.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public IJobService _service;
        public JobController(IJobService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddJob(JobRequest request)
        {
            var result = await _service.AddJob(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("TrainingProgram")]
        public async Task<IActionResult> AddTrainingProgramToJobAsync(JobTrainingRequest request)
        {
            var result = await _service.AddTrainingProgramToJobAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("TrainingProgram")]
        public async Task<IActionResult> RemoveTrainingProgramFromJobAsync(JobTrainingRequest request)
        {
            var result = await _service.RemoveTrainingProgramFromJobAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJob()
        {
            var result = await _service.GetAllJob();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var result = await _service.DeleteJob(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateJob(UpdateJobRequest request)
        {
            var result = await _service.UpdateJobAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
