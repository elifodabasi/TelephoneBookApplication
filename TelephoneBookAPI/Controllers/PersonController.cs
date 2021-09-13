

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneBook.Business.PersonOps;
using TelephoneBook.Entity;

namespace TelephoneBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("add")]
        public async Task Add(Person person)
        {
            _personService.Add(person);
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = _personService.GetAll();
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task Update(Person person)
        {
            _personService.Update(person);
        }

        [HttpGet("find")]
        public async Task<IActionResult> Find(Guid id)
        {
            var result = _personService.Find(id);
            if (id == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task Delete(Person person)
        {
            _personService.Delete(person);
        }

    }
}
