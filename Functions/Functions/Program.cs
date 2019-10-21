using System;
using System.Linq;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-4):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-4, mitään ei tapahdu.
            if (int.TryParse(input, out int select) == true)
            {
                if (select == 1)
                {
                    Console.WriteLine("Please input a number:");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int n) == true && n > 0)
                    {
                        Console.WriteLine("Vastaus: " + Stars(n));
                    } else if ( n <= 0)
                    {
                        Console.WriteLine("Numero " + n + " ei ole sallittu luku.");
                    } else
                    {
                        Console.WriteLine("Vain luvut ovat hyväksyttyjä.");
                    }
                }
                else if (select == 2)
                {
                    Console.Write("Please input a number: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int input1) == true)
                    {
                        Console.Write("Please input a second number:");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out int input2) == true)
                        {
                            Console.WriteLine("Luku " + Minimi(input1, input2) + " on pienempi kuin <PH>.");
                        } else
                        {
                            Console.WriteLine("Number input is required, please reboot.");
                        }

                    } else
                    {
                        Console.WriteLine("Number input is required, please reboot.");
                    }
                }
                else if (select == 3)
                {
                    int lowerBound = 3;
                    int upperBound = 47;

                    int RetNumber = numberFromRange(lowerBound, upperBound);
                    Console.WriteLine("Given number was " + RetNumber + ".");
                }
                else if (select == 4)
                {
                    Biggest();
                }
                else
                {
                    Console.WriteLine("Invalid selection, please reboot.");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
        }

        static string Stars(int input)
        {
            string result = "";

            for (int i = input; i > 0; i--)
            {
                result += "*";
            }

            return result;
        }

        static int Minimi(int input1, int input2)
        {
            if (input1 < input2)
            {
                return input1;
            } else if (input2 < input1)
            {
                return input2;
            } else
            {
                return input1;
            }
        }

        static int numberFromRange(int lower, int upper)
        {
            int number = 0;
            int processed = 0;

            Console.WriteLine("Please input number between " + lower + " and " + upper + ":");
            string input = Console.ReadLine();

            do
            {
                if (int.TryParse(input, out number) == false)
                {
                    Console.WriteLine("Invalid input, input must be a number.");
                    Console.WriteLine();
                    Console.WriteLine("Please input number between " + lower + " and " + upper + ":");
                    input = Console.ReadLine();

                } else if (number < lower || number > upper)
                {
                    Console.WriteLine("Invalid input, number must be within given bounds.");
                    Console.WriteLine();
                    Console.WriteLine("Please input number between " + lower + " and " + upper + ":");
                    input = Console.ReadLine();
                }

            } while (number < lower || number > upper);

            processed = number;
            return processed;
        }

        static void Biggest()
        {
            int[] numbers = new int[10];
            string input;

            Console.WriteLine("Please input a set of 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int number) == false)
                {
                    Console.WriteLine("Invalid input, input must be a number.");
                    Console.WriteLine("Please input number:");

                    i--;

                } else
                {
                    numbers[i] = number;
                }
            }

            Console.WriteLine("You inputted the following numbers:");

            foreach (int j in numbers)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            Console.WriteLine("The largest of which was " + numbers.Max() + ".");
        }
    }
}
