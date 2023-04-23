using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Queue<int> numberOfTask = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            
            Stack<int> Time = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

          
            int DarthVaderDucky = 0;
            int ThorDucky = 0;
            int BigBlueRubberDucky = 0;
            int SmallYellowRubberDucky = 0;

            while (Time.Count != 0 && numberOfTask.Count != 0)
            {
                int timeNeeded = Time.Peek() * numberOfTask.Peek();

                if (timeNeeded>0&&timeNeeded <= 60)
                {
                    Time.Pop();
                    numberOfTask.Dequeue();
                    DarthVaderDucky++;
                }
                else if (timeNeeded>=61&&timeNeeded<=120)
                {
                    Time.Pop();
                    numberOfTask.Dequeue();
                    ThorDucky++;
                }
                else if (timeNeeded >= 121 && timeNeeded <= 180)
                {
                    Time.Pop();
                    numberOfTask.Dequeue();
                    BigBlueRubberDucky++;
                }
                else if (timeNeeded >= 181 && timeNeeded <= 240)
                {
                    SmallYellowRubberDucky++;
                    Time.Pop();
                    numberOfTask.Dequeue();
                }
                else 
                {
                    int decrease=Time.Pop()-2;
                    Time.Push(decrease);
                    int back = numberOfTask.Dequeue();
                    numberOfTask.Enqueue(back);


                }
               
            }
            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded: ");
            Console.WriteLine($"Darth Vader Ducky: {DarthVaderDucky}");
            Console.WriteLine($"Thor Ducky: {ThorDucky}");
            Console.WriteLine($"Big Blue Rubber Ducky: {BigBlueRubberDucky}");
            Console.WriteLine($"Small Yellow Rubber Ducky: {SmallYellowRubberDucky}");
        }
    }
}
