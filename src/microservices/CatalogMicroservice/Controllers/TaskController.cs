using CatalogMicroservice.Context;
using CatalogMicroservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly CRUDContext _context;

        public TaskController(CRUDContext context)
        {
            _context = context;
        }

        // GET: api/<CartController>
        [HttpGet]
        public ActionResult<IEnumerable<TaskEntity>> Get()
        {
            //CRUDContext _context2 = new CRUDContext()

            var tasks = _context.tasks;

            //return Ok(cartItems);
            return Ok(tasks);
        }

    }
}
