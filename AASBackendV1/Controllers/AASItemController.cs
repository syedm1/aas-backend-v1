using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

using WebApi.Services;
using WebApi.Models.AASItems;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AASItemController : ControllerBase
    {
        private readonly IAASItemService _aasItemService;
        private readonly IMapper _mapper;

        public AASItemController(
            IAASItemService aasItemService,
            IMapper mapper)
        {
            _aasItemService = aasItemService;
            _mapper = mapper;
        }

        // GET: api/<AASItem>
        [HttpGet]
        public IEnumerable<AASItemResponse> Get()
        {
            return _aasItemService.GetAll();
        }

        // GET api/<AASItem>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("register")]
        public IActionResult Add(AddAASItemRequestModel model)
        {
            if (_aasItemService.Add(model))
                return Ok(new { message = "Registration successful, please check your email for verification instructions" });
            else
                return BadRequest();
        }

        // PUT api/<AASItem>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AASItem>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
