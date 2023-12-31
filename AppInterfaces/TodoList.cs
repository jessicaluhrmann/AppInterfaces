﻿namespace AppInterfaces
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach (var todo in Todos)
                Console.WriteLine(todo);
        }

        public void Reset()
        {
            Array.Clear(Todos);
            nextOpenIndex = 0;
        }
    }
}