using Neo4jClient.Cypher;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ELibraryWebApp.Models;

namespace ELibraryWebApp.Controllers
{
    [RoutePrefix("book")]
    public class CommentController : ApiController
    {
        [HttpGet]
        [Route("{title}")]
        public IHttpActionResult GetBookCommentsByTitle(string title)
        {
            var data = WebApiConfig.GraphClient.Cypher
               .Match("(m:Comment)")
               .Where("m.CommentedBook =~ {CommentedBook}")
               .WithParam("CommentedBook", "(?i).*" + title + ".*")
               .Return<Comment>("m")
               .Results.ToList();

            return Ok(data.Select(c => new { com = c }));
        }
    }
}
