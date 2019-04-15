using FreshToDo.Application.ToDoItems.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshToDo.Application.ToDoItems.Queries
{
    //Request - <thing>Query : IRequest<ReturnType>
    
    public class GetAllToDoQuery : IRequest<List<ToDoItemDto>>
    {
        
    }
}
