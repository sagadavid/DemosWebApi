using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        public PostsController()
        {
            _postService = new PostService();//no DI, coupling
        }

        [HttpGet("id")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var idPost = await _postService.GetPost(id);
            if (idPost == null)
            {
                return NotFound();
            }
            return Ok(idPost);
        }

        [HttpPost]
        public async Task<ActionResult<Post>> CreatePost(Post post)
        {
            await _postService.CreatePost(post);
            return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
        }



    }
}
