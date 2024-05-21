using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController(IPostService _postService) : ControllerBase // DI by primarykey injection
    {
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

        [HttpPut("id")]
        public async Task<ActionResult> UpdatePost(Post post, int id)
        {
            if (id != post.Id) { return BadRequest(); }
            var toUpdate = await _postService.UpdatePost(id, post);
            if (toUpdate == null) { return NotFound(); }
            return Ok(toUpdate);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeletePost(int id)
        {
            await _postService.DeletePost(id);
            return Ok();
        }

    }
}
