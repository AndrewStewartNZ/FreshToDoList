using FreshToDo.Application.ToDoItems.Models;
using FreshToDo.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreshToDo.Application.ToDoItems.Queries
{
    public class GetToDoItemQueryHandler : IRequestHandler   <GetToItemDoQuery, ToDoItemDto>
    {
        private readonly ToDoDbContext _context;

        public GetToDoItemQueryHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<ToDoItemDto> Handle(GetToItemDoQuery request, CancellationToken cancellationToken)
        {
            var foundToDoItem = await  _context.TodoItems.FindAsync(request.ID);
            var returnDto = new ToDoItemDto();


            if (foundToDoItem != null )
            {
                returnDto.Id = foundToDoItem.Id;
                returnDto.IsComplete = foundToDoItem.IsComplete;
                returnDto.Description = foundToDoItem.Description;
            }

            return returnDto;

        }
    }
}
