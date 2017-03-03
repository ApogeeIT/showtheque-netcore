using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShowTheque.Business;
using ShowTheque.Business.Models;

namespace ShowTheque.Api.Controllers
{
    [Route("api/[controller]")]
    public class ShowController
    {
        private IShowRepository _repo;

        public ShowController(IShowRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Show> Get()
        {
            return _repo.GetShows();
        }

        [HttpGet("{id}")]
        public Show Get(int id)
        {
            return _repo.GetShow(id);
        }

        [HttpPost]
        public void Post([FromBody] Show show)
        {
            _repo.AddShow(show);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.DeleteShow(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Show show)
        {
            _repo.UpdateShow(show);
        }
    }
}