using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using FreshToDo.Application.ToDoItems.Models;
using FreshToDo.Application.ToDoItems.Queries;

namespace FreshToDo.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase 
    {

        protected readonly IMediator _mediator;

            public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        //[ProducesResponseType(typeof(IEnumerable<Application.TodoItems.Models.ToDoItemDto>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {

            var response = await _mediator.Send(new FreshToDo.Application.ToDoItems.Queries.GetAllToDoQuery());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItemDto>> GetTodoItem(int Id)
        {

            var query = new GetToItemDoQuery() { ID = Id };


            var response = await _mediator.Send(query);

            return Ok(response);

        }


        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        //{
        //    if (id != todoItem.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(todoItem).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteToDoItem(long id)
        //{
        //    var toDoItemForDelete = await _context.TodoItems.FindAsync(id);

        //    if (toDoItemForDelete == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TodoItems.Remove(toDoItemForDelete);
        //    await _context.SaveChangesAsync();

        //    return NoContent();

        //}



        //[HttpPost]
        //public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item)
        //{
        //    _context.TodoItems.Add(item);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);

        //}







        //private void CreateItemIfContextIsEmpty()
        //{

        //    if (_context.TodoItems.Count() == 0)
        //    {

        //        _context.TodoItems.Add(new TodoItem { Name = "Item1" });
        //        _context.SaveChanges();

        //    }
    }
    }
