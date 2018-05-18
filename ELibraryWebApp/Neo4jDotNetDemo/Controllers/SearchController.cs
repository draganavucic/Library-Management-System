using ELibraryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELibraryWebApp.Controllers
{
    [RoutePrefix("search")]
    public class SearchController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult SearchBooksByTitle(string q)
        {

            var data = WebApiConfig.GraphClient.Cypher
               .Match("(m:Book)")
               .Where("m.Title =~ {title}")
               .WithParam("title", "(?i).*" + q + ".*")
               .Return<Book>("m")
               .Results.ToList();

            return Ok(data.Select(c => new { book = c}));
        }

    }
}
