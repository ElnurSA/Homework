using System;
namespace TodayPractice
{
    public class Book : Test, IBook
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        //public string GetText()
        //{
        //    return "salam";
        //}

        //public void Show()
        //{
        //    Console.WriteLine("asdasd");
        //}

        //public void Test()
        //{
        //    Console.WriteLine("adafasdf");
        //}
        public void ShowAll()
        {
            Console.WriteLine("Show Books");
        }
    }
}

