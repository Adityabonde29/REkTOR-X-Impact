using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetapp.Models;
using dotnetapp.Data;

namespace dotnetapp.Services
{
    public class DonationOfferService
    {
        private readonly ApplicationDbContext _context;

        public DonationOfferService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DonationOffer> CreateOfferAsync(DonationOffer offer)
        {
            _context.DonationOffers.Add(offer);
            await _context.SaveChangesAsync();
            return offer;
        }

        public async Task<DonationOffer> GetOfferByIdAsync(int offerId)
        {
            return await _context.DonationOffers.FindAsync(offerId);
        }

        public async Task UpdateOfferAsync(DonationOffer offer)
        {
            _context.DonationOffers.Update(offer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOfferAsync(int offerId)
        {
            var offer = await _context.DonationOffers.FindAsync(offerId);
            if (offer != null)
            {
                _context.DonationOffers.Remove(offer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DonationOffer>> GetAllOffersAsync()
        {
            return await _context.DonationOffers.ToListAsync();
        }
    }
}