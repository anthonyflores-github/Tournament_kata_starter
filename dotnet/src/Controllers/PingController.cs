﻿namespace Tournaments.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {

        [HttpGet]
        public void Ping()
        {

        }
    }
}