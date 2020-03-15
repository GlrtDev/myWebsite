using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using MyWebsite.Services;
namespace MyWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubReposController : ControllerBase
    {
        public GithubReposController(JsonFileGithubRepoService productService)
        {
            ProductService = productService;
        }

        public JsonFileGithubRepoService ProductService { get; }

        [HttpGet]
        public IEnumerable<GithubRepo> Get()
        {
            return ProductService.GetGithubRepos();
        }

        //[HttpPatch]
        //public ActionResult Patch([FromBody] RatingRequest request)
        //{
        //    ProductService.AddRating(request.ProductId, request.Rating);

        //    return Ok();
        //}

        //public class RatingRequest
        //{
        //    public string ProductId { get; set; }
        //    public int Rating { get; set; }
        //}
    }
}