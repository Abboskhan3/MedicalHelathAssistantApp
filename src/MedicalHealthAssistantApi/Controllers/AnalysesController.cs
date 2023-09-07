﻿using MedicalHealthAssistantApi.Models;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Analyses;
using Service.Interfaces;

namespace MedicalHealthAssistantApi.Controllers;

public class AnalysesController :BaseController
{
    private readonly IAnalyseService analyseService;
    public AnalysesController(IAnalyseService analyseService)
    {
        this.analyseService = analyseService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> AddAsync(AnalyseCreationDto dto)
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.analyseService.CreateAsync(dto)
        });

    [HttpDelete("delete/{id:long}")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.analyseService.DeleteAsync(id)
        });

    [HttpDelete("remove/{id:long}")]

    [HttpGet("get/{id:long}")]
    public async Task<IActionResult> GetByIdAsync(long id)
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.analyseService.GetAsync(id)
        });

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllsync()
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = analyseService.GetAllAnalysesAsync()
        });
}