
using FileMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileMicroservices.Repository
{
    public interface IFileTaskRepository
    {
        List<FileTaskEntity> getFilesByTask(int idTask);
        void InsertFileTask(FileTaskEntity entity);
        void UpdateFileTask(FileTaskEntity task);
    }
}
