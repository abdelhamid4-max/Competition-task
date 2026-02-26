namespace Competition_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_Service employee = new Employee_Service();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("1- Add");
                Console.WriteLine("2- Delete");
                Console.WriteLine("3- Edit");
                Console.WriteLine("4- Display");
                Console.WriteLine("5- Import From Excel");
                Console.WriteLine("6- Exit");
                Console.WriteLine("=============================");

                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        
                        employee.Add();
                        break;
                    case "2":
                        employee.remove();
                        break;
                    case "3":
                        employee.Edit();
                        break;
                    case "4":
                        employee.Display();
                        break;
                    case "5":
                        break;
                        case "6":
                        Console.WriteLine("The Progrm Closed");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option - Try Again");
                        break;
                }

            }
        }
    }
}
