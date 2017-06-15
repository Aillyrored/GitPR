using System;
using System.Threading.Tasks;

namespace pr2
{
    public class Program
    {
        static void Main(string[] args)
        {
            UseTasks();
        }

        static void UseTasks()
        {
            var tasks = new Task[6];
            tasks[2] = Task.Run(() =>
            {            
                    Console.WriteLine("Task 3 = actived");
                    Task.Delay(500).Wait();
          
            });
            tasks[0] = tasks[2].ContinueWith((t) =>
            {
                    Console.WriteLine("Task 1 = actived");
                    Task.Delay(500).Wait();    
            });
            tasks[1] = tasks[0].ContinueWith(t =>
            {
             
                    Console.WriteLine("Task 2 = actived");
                    Task.Delay(500).Wait();
              
            });
            tasks[4] = tasks[1].ContinueWith(t =>
            {
             
                    Console.WriteLine("Task 5 = acticed");
                    Task.Delay(500).Wait();
                
            });
            tasks[3] = tasks[4].ContinueWith(t =>
            {
            
                    Console.WriteLine("Task 4 = actived");
                    Task.Delay(500).Wait();
            
            });
            tasks[5] = tasks[3].ContinueWith(t =>
            {
              
                    Console.WriteLine("Task 6 = actived");
                    Task.Delay(10000).Wait();
             
            });
            Task.WaitAll(tasks);
            //$"Task 3 - {i}, TaskId: {Task.CurrentId}"           
        }
    }
}
