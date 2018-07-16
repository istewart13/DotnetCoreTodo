﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTodo.Models;
using CoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            // Get to-do items from database
            var items = await _todoItemService.GetIncompleteItemsAsync();
            
            // Put items into a model
            var model = new TodoViewModel()
            {
                Items = items
            };

            // Render view using the model
            return View(model);
        }
    }
}