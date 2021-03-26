using System;

namespace TaskStruct
{
    struct Task
    {
        public int id;
        public bool isComplete;
        public string title;
        public DateTime? date;
        public string description;
    }
    class Program
    {
        static void ConsoleOutput(Task task)
        {
            char isComplete;
            if (task.isComplete){
                isComplete = 'X';
            }
            else
            {
                isComplete = ' ';
            }
            Console.WriteLine($"{task.id,3}.\t[{isComplete}] {task.title}{task.date?.ToString(" (MMM d)")}\n\t{task.description}");
        }

        static void Main(string[] args)
        {
            Task task1 = new Task(){
            id = 1,
            isComplete = true,
            title = "First task",
            date = new DateTime(2000, 12, 5),
            description = "Use fields: id, isComplete, title, date"
            };
            ConsoleOutput(task1);
        }
    }
}
