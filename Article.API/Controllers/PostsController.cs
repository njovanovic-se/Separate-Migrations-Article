using Microsoft.AspNetCore.Mvc;

namespace Medium.Separating.Migrations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        /// <summary></summary>
        /// <param name="cancellationToken"></param>
        [HttpGet]
        public async Task<IActionResult> GetAllPosts(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}
