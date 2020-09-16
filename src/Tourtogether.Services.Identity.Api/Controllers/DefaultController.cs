using System;
using Microsoft.AspNetCore.Mvc;
using Tourtogether.Services.Identity.Core.Models;

namespace Tourtogether.Services.Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public User Get()
        {
            return new User()
            {
                Email = "mateuszprzeliorz@test.com",
                Name = "Mateusz",
                CreatedAt = DateTime.Now,
                IsCreated = true
            };
        }
    }
}
