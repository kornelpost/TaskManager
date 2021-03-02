using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerApp.Models;

namespace TaskManagerApp.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _context;
        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }
        public TaskModel Get(int taskId)
            => _context.tasks.SingleOrDefault(x => x.TaskId == taskId);
        public IQueryable<TaskModel> GetAllActive()
            => _context.tasks.Where(x => !x.Done);
        public void Add(TaskModel task)
        {
            _context.tasks.Add(task);
            _context.SaveChanges();
        }
        public void Update(int taskId, TaskModel task)
        {
            var result = _context.tasks.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                result.Name = task.Name;
                result.Description = task.Description;
                result.Done = task.Done;
            }
            _context.SaveChanges();
        }
        public void Delete(int taskId)
        {
            var result = _context.tasks.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                _context.tasks.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}
