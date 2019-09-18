using System;

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
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Vastaus: " + Stars(input1));

                }
                else if (select == 2)
                {
                    int input21 = 1;
                    int input22 = 2;

                    Minimi(input21, input22);
                }
                else if (select == 3)
                {
                    WhatEven();
                }
                else if (select == 4)
                {
                    int input41 = 0;
                    int input42 = 0;
                    int input43 = 0;
                    int input44 = 0;
                    int input45 = 0;
                    int input46 = 0;
                    int input47 = 0;
                    int input48 = 0;
                    int input49 = 0;
                    int input410 = 0;
                    Biggest(input41, input42, input43, input44, input45, input46, input47, input48, input49, input410);
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

        static string Stars(string input)
        {
            string result = "N/A";

            return result;
        }

        static int Minimi(int input1, int input2)
        {
            return input1;
        }

        static void WhatEven()
        {

        }

        static int Biggest(int input1, int input2, int input3, int input4, int input5, int input6, int input7, int input8, int input9, int input10)
        {
            return input1;
        }
    }
}
