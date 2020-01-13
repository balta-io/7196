using System;
using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid id, string email);
        IEnumerable<TodoItem> GetAll(string email);
        IEnumerable<TodoItem> GetAllDone(string email);
        IEnumerable<TodoItem> GetAllUndone(string email);
        IEnumerable<TodoItem> GetByPeriod(string email, DateTime date, bool done);
    }
}