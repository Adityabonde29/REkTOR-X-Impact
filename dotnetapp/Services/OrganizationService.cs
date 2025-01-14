using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using dotnetapp.Models;
using dotnetapp.Data;

namespace dotnetapp.Services
{
    public class OrganizationService
    {
        private readonly ApplicationDbContext _context;

        public OrganizationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Organization> RegisterOrganizationAsync(Organization organization)
        {
            _context.Organizations.Add(organization);
            await _context.SaveChangesAsync();
            return organization;
        }

        public async Task<Organization> GetOrganizationByIdAsync(int organizationId)
        {
            return await _context.Organizations.FindAsync(organizationId);
        }

        public async Task UpdateOrganizationAsync(Organization organization)
        {
            _context.Organizations.Update(organization);
            await _context.SaveChangesAsync();
        }

        public async Task VerifyOrganizationAsync(int organizationId)
        {
            var organization = await _context.Organizations.FindAsync(organizationId);
            if (organization != null)
            {
                organization.IsVerified = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}