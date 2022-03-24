using Cwk.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            var post = new Post() { Id = Id, Content="Hello world!" };
            return Ok(post);
        }
    }
}
