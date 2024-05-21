using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        public ActionResult<List<Post>> GetPosts()
        {
            return new List<Post>{
                new () { UserId = 1, Id = 1, Title = "Title1", Body = "Body1" },
                 new () { UserId = 2, Id = 2, Title = "Title2", Body = "Body2" },
                  new () { UserId = 3, Id = 3, Title = "Title3", Body = "Body3" },
                   new () { UserId = 4, Id = 4, Title = "Title4", Body = "Body4" },
                   new () { UserId = 5, Id = 5, Title = "Title5", Body = "Body5" }

            };
        }
    }
}
