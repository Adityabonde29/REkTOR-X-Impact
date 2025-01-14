using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using dotnetapp.Models;
using dotnetapp.Services;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly OrganizationService _organizationService;

        public OrganizationController(OrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(Organization organization)
        {
            var createdOrganization = await _organizationService.RegisterOrganizationAsync(organization);
            return CreatedAtAction(nameof(GetOrganizationById), new { id = createdOrganization.OrganizationId }, createdOrganization);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrganizationById(int id)
        {
            var organization = await _organizationService.GetOrganizationByIdAsync(id);
            if (organization == null)
            {
                return NotFound();
            }
            return Ok(organization);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrganization(int id, Organization organization)
        {
            if (id != organization.OrganizationId)
            {
                return BadRequest();
            }

            await _organizationService.UpdateOrganizationAsync(organization);
            return NoContent();
        }

        [HttpPut("verify/{id}")]
        public async Task<IActionResult> VerifyOrganization(int id)
        {
            await _organizationService.VerifyOrganizationAsync(id);
            return NoContent();
        }
    }

}