using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Competition_task
{
    internal class Employee_Service: IEmployeeService
    {
        

      private List<string> Employee_Name = new List<string>();
        public void Add()
        {
            Console.WriteLine("Enter Employee Name");
            string enter = Console.ReadLine();

            Employee_Name.Add(enter.Trim());
            Console.WriteLine("Add Successfully");


        }
        public void remove()
        {
            Console.WriteLine("Enter Employee Want Remove");
            string enter = Console.ReadLine();
            bool remove = Employee_Name.Remove(enter.Trim());
            if (remove)
            {
                
                Console.WriteLine("Remove Successfully");
            }
            else
                Console.WriteLine("Employee NOT Found");
        }
        public void Edit()
        {
            Console.WriteLine("Enter Employee Name to Edit");
            string oldName = Console.ReadLine();

            int index = Employee_Name.IndexOf(oldName);

            if (index != -1)
            {
                Console.WriteLine("Enter New Employee Name");
                string newName = Console.ReadLine();

                Employee_Name[index] = newName;

                Console.WriteLine("Updated Successfully");
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }
        }
        public void Display()
        {
            Console.WriteLine("==============All Of Employee============");
            foreach (string employee in Employee_Name) 
            {
               
                Console.WriteLine($"{employee}\n");
               
            }
            Console.WriteLine("=========================================");
        }
    }
}
