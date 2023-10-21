using System;
namespace TodayPractice
{
    public class Notebook : INotebook
    {
        public void GetByID(int id)
        {
            Console.WriteLine("Notebook");
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}

