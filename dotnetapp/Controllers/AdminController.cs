using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using dotnetapp.Services;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _adminService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("organizations")]
        public async Task<IActionResult> GetAllOrganizations()
        {
            var organizations = await _adminService.GetAllOrganizationsAsync();
            return Ok(organizations);
        }

        [HttpPut("approve/{id}")]
        public async Task<IActionResult> ApproveOrganization(int id)
        {
            await _adminService.ApproveOrganizationAsync(id);
            return NoContent();
        }

        [HttpGet("stats")]
        public async Task<IActionResult> GetStats()
        {
            var stats = await _adminService.GetStatsAsync();
            return Ok(stats);
        }
    }
}