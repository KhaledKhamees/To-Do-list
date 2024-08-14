using System; 
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Your TO-DO List");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine(name +" choose the operation that you want ");
            int c;
            string[] tasks = new string[15];
            int i = 0;
            Char ans;
            do
            {
                Console.WriteLine("1.Add task\n2.Make task completed\n3.display tasks\n4.Remnove Task");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter your Task");
                        tasks[i++] = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("what is the number of the task the finished");
                        int d = Convert.ToInt32(Console.ReadLine());
                        string ended = tasks[d - 1];
                        tasks[d - 1] = ended + "\t completed";
                        break;
                    case 3:
                        Console.WriteLine("the task list :-");
                        for (int k = 0 ; k < i;k++)
                        {
                            Console.WriteLine(tasks[k]);
                        }
                        break;
                    case 4:
                        Console.WriteLine("what is the number of the task that you want to remove");
                        int remove = Convert.ToInt32(Console.ReadLine());
                        for (int j = remove - 1; j < i - 1; j++)
                        {
                            tasks[j] = tasks[j + 1];
                        }
                        i--;
                        break;
                    default:
                        Console.WriteLine("there is no operation like this");
                        break;
                }
                Console.WriteLine("do you want do any other operations ? y or n");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y');
            Console.WriteLine("thank you for using our applecation");

        }
    }
}
