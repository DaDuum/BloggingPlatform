﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingPlatformLib.DB.Model;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : DBController
    {
        public ValuesController(BloggingPlatformContext context) : base(context)
        {

        }


        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var authors = Context.Authors.ToList();

            return new string[] { authors.First().Email, authors.First().Username, authors.First().Id.ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
