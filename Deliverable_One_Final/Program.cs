using System;

namespace Deliverable_One_Final
{
    class Program
    {
        private static string VacationType;

        static void Main(string[] args)
        {

            string VacationType;
            int GroupSize;
            string Destination;
            string TravelSuggestion;

            Console.WriteLine("Hello Travellers!");


            string testString;
            Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? - ");
            VacationType = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", VacationType);



            Console.Write("How many people will be in your party?: ");

            string input = Console.ReadLine();

            // ToInt32 can throw FormatException or OverflowException.
            try
            {

                GroupSize = Convert.ToInt32(input);
                if (GroupSize < Int32.MaxValue)
                {
                    Console.WriteLine("You will be travelling in a party of {0} people", GroupSize);
                }
                else
                {
                    Console.WriteLine("numVal cannot be incremented beyond its current value");
                }
            }
            catch { }

            
            
            Console.WriteLine("You will be travelling to New Orleans", VacationType);
            if (VacationType == "tropical") { Destination = "Beach vacation in Mexico"; };
            Console.WriteLine("You will be experiencing a beach vacation in Mexico", VacationType);
            if (VacationType == "adventurous") { Destination = "Whitewater rafting the Grand Canyon"; };
            Console.WriteLine("You will be travelling to the Grand Canyon to whitewater raft", VacationType);
          


          


           














        }



        



    }
    }

