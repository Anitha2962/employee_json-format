 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_data_storage_in_D_drive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string designation;
            int salary;

            Console.WriteLine("enter employee id:");
             id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("enter employee designation:");
            designation = Console.ReadLine();
            Console.WriteLine("enter employee salary:");
            salary = Convert.ToInt32(Console.ReadLine()); 
            
            string path = @"D:\EQ SOFT\C#\employee5.txt";
           
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(id);
                    sw.WriteLine(name);
                    sw.WriteLine(designation);
                    sw.WriteLine(salary);
                   
                }
           using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Content read from file:");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            
           
        }
    }
}