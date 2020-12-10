using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksMicroservice.Model;
using TasksMicroservice.Repository;

namespace TasksMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITasksRepository _tasksRepository;

        public TaskController(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        [HttpGet("GetPeriod/{idTask}")]
        public ActionResult<IEnumerable<double>> GetPeriod(int idTask)
        {
            var tasks = _tasksRepository.GetPeriodProgress(idTask);

            return Ok(tasks);
        }

        [HttpPost]
        public ActionResult Post(TaskEntity task)
        {
            try
            {
                _tasksRepository.InsertTask(task);

                return Ok();
            }
            catch (Exception ex)
            {
                return new NoContentResult();
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] TaskEntity task)
        {
            if (task != null)
            {
                _tasksRepository.UpdateTask(task);
                return new OkResult();
            }
            return new NoContentResult();
        }

    }
}
