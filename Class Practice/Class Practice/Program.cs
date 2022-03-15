using System;
using Class_Practice.models;
namespace Class_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("daxil edin");
            int lenght = Convert.ToInt32(Console.ReadLine());

            book[] arr = new book[lenght];
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Genre =>");
                    string Genre = Console.ReadLine();

                    Console.WriteLine("No =>");
                    int No = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Name =>");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Price");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Count");
                    int count = Convert.ToInt32(Console.ReadLine());

                    arr[i] = new book(Genre, No, Name, price, count);
                    Console.WriteLine("Kitab yaradildi");
                    {
                        Console.ReadLine();
                        Console.WriteLine("\t1.Kitablari qiymete gore filterle \n \t2.Butun kitablari goster \n\t0.Proqrami bagla");

                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                
                                double minPrice = GetInputDouble("Min. price:", -1);
                                double maxPrice = GetInputDouble("Max. price:", 0);
                                for ( i=0; i < arr.Length; i++)
                                {
                                    if (arr[i].price <= maxPrice && arr[i].price > minPrice)
                                    {
                                        Console.WriteLine($"No: {arr[i].No} ");
                                        Console.WriteLine($"Name: {arr[i].Name} ");
                                        Console.WriteLine($"Price: {arr[i].price}");
                                        Console.WriteLine($"Genre: {arr[i].Genre}");
                                    }
                                }
                                    break;

                            case 2:

                                for ( i=0; i < arr.Length; i++)
                                {
                                    Console.WriteLine($"No: {arr[i].No} ");
                                    Console.WriteLine($"Name: {arr[i].Name} ");
                                    Console.WriteLine($"Price: {arr[i].price}");
                                    Console.WriteLine($"Genre: {arr[i].Genre}");
                                }
                                    break;



                            case 0:
                                Console.WriteLine("======================");
                                Console.WriteLine("Program was terminated");
                                Console.WriteLine("======================");
                                    break;
                        }
                        static double GetInputDouble(string text, double min, double max = int.MaxValue)
                        {
                            double input;
                            do
                            {

                                Console.WriteLine(text);
                                input = Convert.ToDouble(Console.ReadLine());
                            }
                            while (input < min || input > max);

                            return input;


                        }
                    }
                }
            }
        }
    }
}
