using FileMicroservice.Context;
using FileMicroservice.Model;
using System.Collections.Generic;
using System.Linq;

namespace FileMicroservices.Repository
{
    public class FileTaskRepository : IFileTaskRepository
    {
        private readonly CRUDContext _context;
        public FileTaskRepository(CRUDContext context)
        {
            _context = context;
        }

        public void InsertFileTask(FileTaskEntity entity)
        {
            _context.FileTask.Add(entity);
            _context.SaveChanges();
        }    
        
        public List<FileTaskEntity> getFilesByTask(int idTask)
        {
           return _context.FileTask.Where(x => x.IdTask == idTask).ToList();
        }


        public void UpdateFileTask(FileTaskEntity task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }


    }
}
