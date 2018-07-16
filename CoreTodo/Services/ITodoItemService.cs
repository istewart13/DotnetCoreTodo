using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTodo.Models;

namespace CoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
