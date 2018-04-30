using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingPlatformLib.DB.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/DB")]
    public class DBController : Controller
    {
        public BloggingPlatformContext Context;
        public DBController(BloggingPlatformContext context) : base()
        {
            Context = context;
        }


    }
}