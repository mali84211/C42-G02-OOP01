namespace C42_G02_OOP01
{
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
        }
    }
}
