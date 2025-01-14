using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using dotnetapp.Services;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonationOfferController : ControllerBase
    {
        private readonly DonationOfferService _donationOfferService;

        public DonationOfferController(DonationOfferService donationOfferService)
        {
            _donationOfferService = donationOfferService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffer(DonationOffer offer)
        {
            var createdOffer = await _donationOfferService.CreateOfferAsync(offer);
            return CreatedAtAction(nameof(GetOfferById), new { id = createdOffer.OfferId }, createdOffer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfferById(int id)
        {
            var offer = await _donationOfferService.GetOfferByIdAsync(id);
            if (offer == null)
            {
                return NotFound();
            }
            return Ok(offer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffer(int id, DonationOffer offer)
        {
            if (id != offer.OfferId)
            {
                return BadRequest();
            }

            await _donationOfferService.UpdateOfferAsync(offer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            await _donationOfferService.DeleteOfferAsync(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOffers()
        {
            var offers = await _donationOfferService.GetAllOffersAsync();
            return Ok(offers);
        }
    }
}