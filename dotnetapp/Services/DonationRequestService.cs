using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetapp.Models;
using dotnetapp.Data;

namespace dotnetapp.Services
{
    public class DonationRequestService
    {
        private readonly ApplicationDbContext _context;

        public DonationRequestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DonationRequest> CreateRequestAsync(DonationRequest request)
        {
            _context.DonationRequests.Add(request);
            await _context.SaveChangesAsync();
            return request;
        }

        public async Task<DonationRequest> GetRequestByIdAsync(int requestId)
        {
            return await _context.DonationRequests.FindAsync(requestId);
        }

        public async Task UpdateRequestAsync(DonationRequest request)
        {
            _context.DonationRequests.Update(request);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRequestAsync(int requestId)
        {
            var request = await _context.DonationRequests.FindAsync(requestId);
            if (request != null)
            {
                _context.DonationRequests.Remove(request);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DonationRequest>> GetAllRequestsAsync()
        {
            return await _context.DonationRequests.ToListAsync();
        }
    }
}