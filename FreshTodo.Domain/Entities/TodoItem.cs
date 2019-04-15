using System;

namespace FreshToDo.Domain
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
