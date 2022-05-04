using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            AppLog.Instance.LogInformation("Hello", "World");
            AppLog.Instance.LogInformation("Hello", "World", "Again");
            AppLog.Instance.LogException(new OutOfMemoryException("Oh No! Not again!!"));

            foreach (var item in AppLog.Instance.ToList())
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

//Exercises
//1. Add a DateTime to the AppLogItem and modify ToString() accordingly
//2. Set the DateTime in LogInformation() and LogException()
//3. Modify AppLog to Write the Log to a stream
