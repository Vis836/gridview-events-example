using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    /*
     * Structure:
     */
    struct Employee
    {
     public   int Eno;
     public   string Ename;
     public   static string CompanyName;
        static Employee()
        {
            CompanyName = "New Company";
        }
        internal Employee(int Eno, string Ename)
        {
            this.Eno = Eno;
            this.Ename = Ename;

        }
        public void Display()
        {
            Console.WriteLine("Employee num is {0} " , Eno);
            Console.WriteLine("Employee name is {0}" , Ename);
            Console.WriteLine("Company name {0} ",CompanyName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            
           
            Employee e = new Employee(111,"Ramu");
           
            e.Display();
            Console.ReadLine();
        }
    }
}
