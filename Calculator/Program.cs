using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t   CALCULATOR");
            Console.WriteLine("   1. Addition");
            Console.WriteLine("   2. Substraction");
            Console.WriteLine("   3. Multiplication");
            Console.WriteLine("   4. Division");
            Console.WriteLine("   5. Exit");
            Console.Write("   Enter Your Choice: ");
            int ch = int.Parse(Console.ReadLine());
            Console.Clear();
            int ans;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("\t\t\t\t\t\t     ADDITION");
                    Console.WriteLine();
                    Console.Write("   Enter First Number: ");
                    int fnum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("   Enter Second Number: ");
                    int snum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    ans = fnum + snum;
                    Console.WriteLine("   Answer is " + ans);
                    Console.WriteLine();
                    Console.Write("   Do you want to return to Menu(Y/N): ");
                    char ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'Y' || ch1 == 'y')
                    {
                        goto label;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                case 2:
                    Console.WriteLine("\t\t\t\t\t\t SUBSTRACTION");
                    Console.WriteLine();
                    Console.Write("   Enter First Number: ");
                    fnum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("   Enter Second Number: ");
                    snum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    ans = fnum - snum;
                    Console.WriteLine("   Answer is " + ans);
                    Console.WriteLine();
                    Console.Write("   Do you want to return to Menu(Y/N): ");
                    ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'Y' || ch1 == 'y')
                    {
                        goto label;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                case 3:
                    Console.WriteLine("\t\t\t\t\t\tMULTIPLICATION");
                    Console.WriteLine();
                    Console.Write("   Enter First Number: ");
                    fnum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("   Enter Second Number: ");
                    snum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    ans = fnum * snum;
                    Console.WriteLine("   Answer is " + ans);
                    Console.WriteLine();
                    Console.Write("   Do you want to return to Menu(Y/N): ");
                    ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'Y' || ch1 == 'y')
                    {
                        goto label;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                case 4:
                    Console.WriteLine("\t\t\t\t\t\t     DIVISION");
                    Console.WriteLine();
                    Console.Write("   Enter First Number: ");
                    fnum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("   Enter Second Number: ");
                    snum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    ans = fnum / snum;
                    Console.WriteLine("   Answer is " + ans);
                    Console.WriteLine();
                    Console.Write("   Do you want to return to Menu(Y/N): ");
                    ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'Y' || ch1 == 'y')
                    {
                        goto label;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("   Invalid Choice");
                    Console.WriteLine();
                    Console.Write("   Do you want to return to Menu(Y/N): ");
                    ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'Y' || ch1 == 'y')
                    {
                        goto label;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
            }
            Console.Read();
        }
    }
}
