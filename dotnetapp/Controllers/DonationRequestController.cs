using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using dotnetapp.Services;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonationRequestController : ControllerBase
    {
        private readonly DonationRequestService _donationRequestService;

        public DonationRequestController(DonationRequestService donationRequestService)
        {
            _donationRequestService = donationRequestService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(DonationRequest request)
        {
            var createdRequest = await _donationRequestService.CreateRequestAsync(request);
            return CreatedAtAction(nameof(GetRequestById), new { id = createdRequest.RequestId }, createdRequest);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id)
        {
            var request = await _donationRequestService.GetRequestByIdAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            return Ok(request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRequest(int id, DonationRequest request)
        {
            if (id != request.RequestId)
            {
                return BadRequest();
            }

            await _donationRequestService.UpdateRequestAsync(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            await _donationRequestService.DeleteRequestAsync(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequests()
        {
            var requests = await _donationRequestService.GetAllRequestsAsync();
            return Ok(requests);
        }
    }
}


