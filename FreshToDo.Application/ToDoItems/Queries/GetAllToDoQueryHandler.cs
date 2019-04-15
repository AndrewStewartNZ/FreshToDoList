using FreshToDo.Application.ToDoItems.Models;
using FreshToDo.Application.ToDoItems.Queries;
using FreshToDo.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreshToDo.Application.ToDoItems.Queries
{
    public class GetAllToDoQueryHandler : IRequestHandler<GetAllToDoQuery, List<ToDoItemDto>>
    {
        private readonly ToDoDbContext _context;

        public GetAllToDoQueryHandler(ToDoDbContext context)
        {
            _context = context;

        }
          

        public Task<List<ToDoItemDto>> Handle(GetAllToDoQuery request, CancellationToken cancellationToken)
        {
            return _context.TodoItems
                .Select(ToDoItemDto.Projection)
                .ToListAsync(cancellationToken);
                                
        }
    }
}
