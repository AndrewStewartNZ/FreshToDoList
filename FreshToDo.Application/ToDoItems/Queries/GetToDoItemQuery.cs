using FreshToDo.Application.ToDoItems.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshToDo.Application.ToDoItems.Queries
{
    public class GetToItemDoQuery : IRequest<ToDoItemDto>
    {
        public int ID { get; set; }

    }
}
