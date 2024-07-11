using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace C42_G02_OOP01
{
    public enum Days{ 
    saturday,
    sunday,
    monday,
    tuesday,
    wednesday,  
    thursday,
    friday,

    }
    public enum gender : int
    {
        male=1 , female=2
    }
    enum roles
    {
        Admin=10 , Editor=20 ,Viewer=30
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            static void DoSomeCode()
            {
                try
                {
                    int x, y, z;
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    z = x / y;
                    int[] Numbers = { 1, 2, 3 };
                    Numbers[10] = 100;
                }
                catch(Exception ex) 
                {
                Console.WriteLine(ex.Message);
                }

            }
            DoSomeCode();
            static void DoSomeProtectiveCode()
            {
                int x, y, z;
                bool Flag;
                do
                {
                    Console.WriteLine("Enter First Num :");
                  Flag =  int.TryParse(Console.ReadLine(), out x);
                } while(!Flag);
                do
                {
                    Console.WriteLine("Enter Second Num :");
                    Flag = int.TryParse(Console.ReadLine(), out y);
                } while (!Flag || y==0);
                //x= int.Parse(Console.ReadLine());
               // y = int.Parse(Console.ReadLine());
                z = x / y;
                int[] Numbers = { 1, 2, 3 };
                if (Numbers.Length > 10)
                {
                    Numbers[10] = 100;
                }
            }
            try
            {
                DoSomeProtectiveCode();
                throw new Exception();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.WriteLine("finally"); }
            Console.WriteLine("After try catch");
            #endregion
            #region V2
            Days day =Days.wednesday;


            //gender g1 =gender.female;
            //Console.WriteLine(g1);
            //gender g2 =(gender)2;
            //Console.WriteLine(g2);

            string gender = "male";
            // gender x=(gender) gender;

            Enum.TryParse(typeof(gender), gender, out object result);
            Console.WriteLine(result);

            //gender x = new gender();
            //Console.WriteLine(x);


            #endregion
        }
    }
    //class Employee
    //{
    //   string name;
    //      int  age;
    //       double salary;
    //       string gender;
    //}
}
