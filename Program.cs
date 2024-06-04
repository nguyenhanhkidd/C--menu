using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();

                string choice = GetValidChoice();

                if (choice == "5")
                {
                    break;
                }

                double so1 = GetValidNumber("Nhap so thu nhat: ");
                double so2 = GetValidNumber("Nhap so thu hai: ");

                double result = Calculate(choice, so1, so2);
                Console.WriteLine("Ket qua la: " + result);

                Console.WriteLine("Nhan phim bat ki de tiep tuc");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("___Menu___");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            Console.WriteLine("5. Exit");
        }

        static string GetValidChoice()
        {
            Console.WriteLine("Nhap lua chon cua ban: ");
            string choice = Console.ReadLine();

            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                Console.WriteLine("Nhap lai: ");
                choice = Console.ReadLine();
            }

            return choice;
        }

        static double GetValidNumber(string message)
        {
            Console.WriteLine(message);
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Nhap lai " + message.ToLower());
            }
            return number;
        }

        static double Calculate(string choice, double so1, double so2)
        {
            double result = 0;
            switch (choice)
            {
                case "1":
                    result = so1 + so2;
                    break;
                case "2":
                    result = so1 - so2;
                    break;
                case "3":
                    result = so1 * so2;
                    break;
                case "4":
                    if (so2 == 0)
                    {
                        Console.WriteLine("Loi: Khong the chia cho 0");
                    }
                    else
                    {
                        result = so1 / so2;
                    }
                    break;
            }
            return result;
        }
    }
}
