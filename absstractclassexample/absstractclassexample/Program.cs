using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absstractclassexample
{
    abstract class customer {
        internal void info()
        {
            Console.WriteLine("info calling");
        }
        
        internal abstract int X
        {
            get;
           set;
        }


        internal abstract void calbill(int totunits);
        


    }
    class industrycustomer : customer
    {
        int x;
        
        internal override void calbill(int totunits)
        {
            double totbill = totunits + 10;
            Console.WriteLine("industrycustomer bill is:" + totbill);
        }
        //private int x = 10;
        internal override int X
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
                
            }
        }
    }
    class residentialcustomer : customer
    {
        int x;
        internal override void calbill(int totunits)
        {
            double totbill = totunits * 6;
            Console.WriteLine("residentialcustomer bill is:" + totbill);
        }
        //private int x = 20;

        internal override int X
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }

    }      
    class agriculturecustomer : customer
        {
        int x;
      
            internal override void calbill(int totunits)
            {
            
                double totbill = totunits * 5;
                Console.WriteLine("agriculturecustomer bill is:" + totbill);
            }
       // private int x = 30;
        internal override int X
            {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }

        }    internal class Program
    {
        static void Main(string[] args)
        {
            customer obj = new industrycustomer();
            obj.info();
            obj.calbill(1000);
            obj.X = 10;
            Console.WriteLine("x value is:" + obj.X);
            obj =new residentialcustomer();
            obj.calbill(2000);
            obj.X = 20;
            Console.WriteLine("x value is:" + obj.X);
            obj =new agriculturecustomer();
            obj.calbill(3000);
             obj.X = 30;
            Console.WriteLine("x value is:" + obj.X);
            Console.ReadLine();
        }
    }
}
