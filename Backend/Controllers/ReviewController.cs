using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ReviewAPI.Data;
using ReviewAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewContext _context;

        public ReviewController(ReviewContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            return await _context.Reviews.Find(review => true).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Review>> CreateReview(Review review)
        {
            await _context.Reviews.InsertOneAsync(review);
            return CreatedAtAction(nameof(GetReviews), new { id = review.Id }, review);
        }
    }
}
