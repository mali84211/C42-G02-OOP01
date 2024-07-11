namespace C42_G02_OOP01
{
    public enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday

    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        
        
       
        static void Main(string[] args)
        {
            #region 1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region 2
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            Season season;
            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid season name entered.");
            }
            #endregion

            #region 3
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            Permissions userPermissions = Permissions.None;

            userPermissions = AddPermission(userPermissions, Permissions.Read);
            userPermissions = AddPermission(userPermissions, Permissions.Write);

            Console.WriteLine("Has Read Permission: " + HasPermission(userPermissions, Permissions.Read));
            Console.WriteLine("Has Write Permission: " + HasPermission(userPermissions, Permissions.Write));
            Console.WriteLine("Has Delete Permission: " + HasPermission(userPermissions, Permissions.Delete));

            userPermissions = RemovePermission(userPermissions, Permissions.Read);
            Console.WriteLine("Has Read Permission after removal: " + HasPermission(userPermissions, Permissions.Read));

            static Permissions AddPermission(Permissions current, Permissions toAdd)
            {
                return current | toAdd;
            }

            static Permissions RemovePermission(Permissions current, Permissions toRemove)
            {
                return current & ~toRemove;
            }

            static bool HasPermission(Permissions current, Permissions toCheck)
            {
                return (current & toCheck) == toCheck;
            }
            #endregion

            #region 4
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string input1 = Console.ReadLine();

            Colors color;
            if (Enum.TryParse(input1, true, out color))
            {
                if (IsPrimaryColor(color))
                {
                    Console.WriteLine($"{input1} is a primary color.");
                }

            }
            else
            {
                Console.WriteLine($"{input1} is not a primary color.");
            }
            static bool IsPrimaryColor(Colors color)
            {
                return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
            }
            #endregion
        }
    }
}
