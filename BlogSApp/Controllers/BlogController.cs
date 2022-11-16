using BlogsApp.BusinessLayer.Interfaces;
using BlogSApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public Blog Get([FromQuery]int id)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }

        [HttpPost]
        public Blog AddBlog(Blog blog)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Status DeleteBlogByID([FromQuery] int id)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }
    }
}