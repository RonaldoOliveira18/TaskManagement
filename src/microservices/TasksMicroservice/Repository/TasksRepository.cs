using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksMicroservice.Context;
using TasksMicroservice.Model;

namespace TasksMicroservice.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly CRUDContext _context;
        public TasksRepository(CRUDContext context)
        {
            _context = context;
        }

        public double? GetPeriodProgress(int idTask)
        {
            var tarefa = _context.Tasks.SingleOrDefault(x => x.Id == idTask);
            var defaultDate = default(DateTime);

            if (tarefa.DtEnd is null || tarefa.DtStart is null)
                return null;
            else
                return tarefa?.DtEnd?.Subtract(tarefa.DtStart is null ? defaultDate : Convert.ToDateTime(tarefa.DtStart)).TotalHours;
        }


        public void InsertTask(TaskEntity entity)
        {
            _context.Tasks.Add(entity);
            _context.SaveChanges();
        }


        public void UpdateTask(TaskEntity task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }


    }
}
