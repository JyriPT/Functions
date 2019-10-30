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
                //Tehtävä 1 valinta
                if (select == 1)
                {
                    //Pyytää lukua, tarkistaa onko sopiva.
                    Console.WriteLine("Please input a number:");
                    input = Console.ReadLine();

                    //Käyttää funktiota Stars() jos syöte on numero ja suurempi kuin nolla
                    //Erillinen virheviesti jos luku on negatiivinen.
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
                //Tehtävä 2 valinta
                else if (select == 2)
                {
                    //Pyytää numerosyöttöä.
                    Console.Write("Please input a number: ");
                    input = Console.ReadLine();

                    //Tarkistaa että syöttö on numero, pyytää seuraavaa jos on.
                    if (int.TryParse(input, out int input1) == true)
                    {
                        Console.Write("Please input a second number:");
                        input = Console.ReadLine();

                        //Tarkistaa että toinen syöttö on numero, kutsuu funktion Minimi() jos on.
                        if (int.TryParse(input, out int input2) == true)
                        {
                            int small = Minimi(input1, input2);

                            //Tulostaa vastauksen, riippuen kumman luvun Minimi() palautti.
                            if (small == input1)
                            {
                                Console.WriteLine("Luku " + input1 + " on pienempi kuin " + input2 + ".");

                            } else if (small == input2)
                            {
                                Console.WriteLine("Luku " + input2 + " on pienempi kuin " + input1 + ".");

                            }
                        } else
                        {
                            Console.WriteLine("Number input is required, please reboot.");
                        }

                    } else
                    {
                        Console.WriteLine("Number input is required, please reboot.");
                    }
                }
                //Tehtävä 3 valinta
                else if (select == 3)
                {
                    //Ylä ja alamääreet, muokattavissa.
                    int lowerBound = 3;
                    int upperBound = 47;

                    //Kutsuu funktion, tulostaa palautetun numeron.
                    int RetNumber = numberFromRange(lowerBound, upperBound);
                    Console.WriteLine("Given number was " + RetNumber + ".");
                }
                //Tehtävä 4 valinta
                else if (select == 4)
                {
                    //Kutsuu funktion, koko tehtävä siellä.
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
        //Tehtävän 1 funktio, tähtientulostus.
        static string Stars(int input)
        {
            //Luodaan palautettava string arvo, jätetään vielä tyhjäksi.
            string result = "";

            //Lisätään tähti toistettavaan string arvoon, toistuu pyydettyn verran.
            for (int i = input; i > 0; i--)
            {
                result += "*";
            }
            //Palautetaan string arvo.
            return result;
        }

        //Tehtävän 2 funktio, numeroiden vertaus.
        static int Minimi(int input1, int input2)
        {
            //Tarkistetaan kumpi numero on pienempi, palautetaan.
            //Jos samanarvoisia, palautetaan ensimmäinen syöte.
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

        //Tehtävän 3 funktio, numeronpyyntö.
        static int numberFromRange(int lower, int upper)
        {
            int number = 0;
            int processed = 0;

            //Pyydetään käyttäjältä syöttöä.
            Console.WriteLine("Please input number between " + lower + " and " + upper + ":");
            string input = Console.ReadLine();

            //Tarkistetaan, onko luku hyväksyttävä. Jos ei, pyydetään uusi syöte.
            //Toistetaan kunnes syöte hyväksyttävä.
            //Erilliset virheilmoitukset ei-numero ja väärän arvoisille syötteille.
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

            //Palautetaan numero.
            processed = number;
            return processed;
        }

        //Tehtävän 4 funktio, lukusarja.
        static void Biggest()
        {
            //Luodaan array jossa 10 numeroarvoa, jätetään tyhjäksi.
            int[] numbers = new int[10];
            string input;

            Console.WriteLine("Please input a set of 10 numbers:");

            //Pyydetään käyttäjältä numeroita, lisätään numero arrayhin.
            //Toistetaan 10 kertaa, jos syöte ei ole numero niin otetaan askel taaksepäin.
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

            //Tulostetaan vastaus.
            Console.WriteLine("You inputted the following numbers:");
            //Käydään jokainen arrayin arvo läpi, tulostetaan.
            foreach (int j in numbers)
            {
                Console.WriteLine(j);
            }
            //Tulostetaan suurin arrayn luvuista.
            Console.WriteLine();
            Console.WriteLine("The largest of which was " + numbers.Max() + ".");
        }
    }
}
