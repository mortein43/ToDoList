﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Controllers;

[ApiController]
public class TodoItemsController : Controller
{
    private readonly TodoContext _context;

    public TodoItemsController(TodoContext context)
    {
        _context = context;
    }

    // GET: TodoItems

    [HttpGet]
    [Route("api/TodoItems")]
    public async Task<IActionResult> Index()
    {
        return View(await _context.TodoItems.ToListAsync());
    }

    // GET: TodoItems/Details/5
    [HttpGet]
    [Route("api/TodoItems/{id}")]
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var todoItem = await _context.TodoItems
            .FirstOrDefaultAsync(m => m.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        return View(todoItem);
    }

    // GET: TodoItems/Create
    [HttpGet]
    [Route("api/TodoItems/Create")]
    public IActionResult Create()
    {
        return View();
    }

    // POST: TodoItems/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Route("api/TodoItems/Create")]
    public async Task<IActionResult> Create([Bind("Id,Name,IsComplete")] TodoItem todoItem)
    {
        if (ModelState.IsValid)
        {
            _context.Add(todoItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(todoItem);
    }

    // GET: TodoItems/Edit/5
    [HttpGet]
    [Route("api/TodoItems/Edit/{id}")]
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        return View(todoItem);
    }

    // POST: TodoItems/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPut]
    [ValidateAntiForgeryToken]
    [Route("api/TodoItems/Edit/{id}")]
    public async Task<IActionResult> Edit(long id, [Bind("Id,Name,IsComplete")] TodoItem todoItem)
    {
        if (id != todoItem.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(todoItem);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(todoItem.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(todoItem);
    }

    // GET: TodoItems/Delete/5
    [HttpDelete]
    [Route("api/TodoItems/Delete/{id}")]
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var todoItem = await _context.TodoItems
            .FirstOrDefaultAsync(m => m.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        return View(todoItem);
    }

    // POST: TodoItems/Delete/5
    [HttpDelete]
    [Route("api/TodoItems/Delete/{id}")]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem != null)
        {
            _context.TodoItems.Remove(todoItem);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TodoItemExists(long id)
    {
        return _context.TodoItems.Any(e => e.Id == id);
    }

    [HttpPost]
    [Route("api/TodoItems")]
    public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
    {
        _context.TodoItems.Add(todoItem);
        await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
    }

    [HttpGet("{id}")]
    [Route("api/TodoItems/{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }


}
*/