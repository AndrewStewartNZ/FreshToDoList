using FreshToDo.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshToDo.Application.ToDoItems.Models
{
    public class ToDoItemDto
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }

               
        public static Expression<Func<ToDoItem, ToDoItemDto>> Projection
        {
            get
            {
                return item => new ToDoItemDto
                {
                    Id = item.Id,
                    Description = item.Description ,
                    IsComplete = item.IsComplete 
                
                };
            }
        }


    }
}
