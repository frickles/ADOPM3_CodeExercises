using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            for (; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i==5)
                {
                    //Critical error
                    AppLog.Instance.LogInformation("Critical error");
                }
            }
            AppLog.Instance.LogInformation($"Loop executed {i} times");



            AppLog.Instance.LogInformation("Hello", "World");
            AppLog.Instance.LogInformation("Hello", "World", "Again");
            AppLog.Instance.LogException(new OutOfMemoryException("Oh No! Not again!!"));

            foreach (var item in AppLog.Instance.ToList())
            {
                Console.WriteLine(item);
            }

            AppLog.Instance.WriteToDisk();          
        }
    }
}

//Exercises
//1. Add a DateTime to the AppLogItem and modify ToString() accordingly
//2. Set the DateTime in LogInformation() and LogException()
//3. Modify AppLog to Write the Log to a stream
//4. Log the exceptions in Errorhandling project

//Event Exercises
//5. In Applog implement event Broadcaster
//      - implement the method OnWrittenToDisk(string) that invokes the event WrittenToDisk
//      - invoke OnWrittenToDisk(string) when the log has been written to disk
//7. In Program implement event Subscriber
//      - write a eventhandler that prints out to console what file has been written
//      - assign the eventhandler to Applog.Instance.WrittenToDisk
//      - execute program and see that the event is both broadcasted and subscribed
