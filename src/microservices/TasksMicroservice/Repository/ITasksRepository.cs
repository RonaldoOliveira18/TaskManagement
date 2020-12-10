using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksMicroservice.Model;

namespace TasksMicroservice.Repository
{
    public interface ITasksRepository
    {
        double? GetPeriodProgress(int idTask);
        void InsertTask(TaskEntity entity);
        void UpdateTask(TaskEntity task);
    }
}
