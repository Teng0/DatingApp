﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            _context = context;

        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

      

    
        [HttpGet]
        public  async Task<IActionResult>  GetValues()
        {
           var values = await _context.Values.ToListAsync();

           return Ok(values);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue( int id)
        {
           var value = _context.Values.FirstOrDefaultAsync(x =>x.Id == id);

           return Ok(value);
        }

    }
}
