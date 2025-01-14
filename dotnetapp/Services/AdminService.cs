using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetapp.Models;
using dotnetapp.Data;

namespace dotnetapp.Services
{
    public class AdminService
    {
        private readonly ApplicationDbContext _context;

        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<Organization>> GetAllOrganizationsAsync()
        {
            return await _context.Organizations.ToListAsync();
        }

        public async Task ApproveOrganizationAsync(int organizationId)
        {
            var organization = await _context.Organizations.FindAsync(organizationId);
            if (organization != null)
            {
                organization.IsVerified = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Dictionary<string, int>> GetStatsAsync()
        {
            var stats = new Dictionary<string, int>
        {
            { "TotalUsers", await _context.Users.CountAsync() },
            { "TotalOrganizations", await _context.Organizations.CountAsync() },
            { "TotalDonationRequests", await _context.DonationRequests.CountAsync() },
            { "TotalDonationOffers", await _context.DonationOffers.CountAsync() }
        };

            return stats;
        }
    }
}