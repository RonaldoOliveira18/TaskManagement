
using FileMicroservice.Model;
using FileMicroservices.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileTaskController : ControllerBase
    {
        private readonly IFileTaskRepository _fileTaskRepository;

        public FileTaskController(IFileTaskRepository fileTaskRepository)
        {
            _fileTaskRepository = fileTaskRepository;
        }

        [HttpGet("GetFilesByTask/{idTask}")]
        public ActionResult<IEnumerable<List<FileTaskEntity>> > GetFilesByTask(int idTask)
        {
            var tasks = _fileTaskRepository.getFilesByTask(idTask);

            return Ok(tasks);
        }

        [HttpPost]
        public ActionResult Post(FileTaskEntity task)
        {
            try
            {
                _fileTaskRepository.InsertFileTask(task);

                return Ok();
            }
            catch (Exception ex)
            {
                return new NoContentResult();
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] FileTaskEntity task)
        {
            if (task != null)
            {
                _fileTaskRepository.UpdateFileTask(task);
                return new OkResult();
            }
            return new NoContentResult();
        }

    }
}
