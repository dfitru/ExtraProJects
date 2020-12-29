using OutingsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutGoing_Console
{
    public class UI
    {
        private OutingRepo _outingRepo = new OutingRepo();
        
        public void Run()
        {
            SeedData();
            while (Menu())
            {
                Console.WriteLine( "Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Goodbye!\n" +
                "Press any Key to Exit.....");
            Console.ReadKey();
        }
        public void SeedData()
        {
            var outing1 = new Outings(6,new DateTime(2020,9,12),20.98m,40.98m,EventType.AmusingPark);
            _outingRepo.AddOuting(outing1);
        }
        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("For Outgoing, Please select an option.\n\n" +
                "1. View all Outings\n" +
                "2. Add a new Outing\n" +
                "3. Update a Outing\n" +
                //"4. Delete a Developer\n" +
                //"5. See which developers still need acces to Pluralsight\n\n" +
                //"6. View all Teams\n" +
                //"7. Add a new Team\n" +
                //"8. Update a Team\n" +
                //"9. Delete a Team\n\n" +
                "0. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    //Display all EventOutings
                    DisplayAllEventOutings();
                    break;
                case "2":
                    //Create a developer
                    AddIndividualOutings();
                    break;
                case "3":
                    //Update an existing developer
                   UpdateOuting();
                    break;
       
                    //break;
                case "0":
                    //Exit
                    return false;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            return true;

        }

        public void DisplayAllEventOutings()
        {
            Console.Clear();
            var allOuting = _outingRepo.GetOutings();
            foreach (var outing in allOuting)
            {
                DisplayOuting(outing);
            }
            Console.WriteLine();
        }
        public void AddIndividualOutings()
        {

            Console.Clear();
            Console.WriteLine("Enter Number of People:");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter date");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Eneter Cost per person per event ");
            decimal totalCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Eneter Cost per person per event ");
            decimal cost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter event type:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Ausing Park\n" +
                "4. Concert");
            string outingType = Console.ReadLine();
            int eventType = int.Parse(outingType);

            Outings outings = new Outings(numberOfPeople,date,totalCost,cost,(EventType)eventType);
        }
        public void UpdateOuting()
        {

        }
        public void DisplayOuting(Outings outings)
        {
            Console.WriteLine($"\t" +
                $"\nNumber if Peoples- {outings.NumberOfPeople}" +
                $"\nDate:{outings.Date}" +
                $"\nTotal Cost for Event per Persone:{outings.TotalCostPerPersonPerEvent}" +
                $"\ntotal cost per event:{outings.TotalCostForEvent}");
        }

    }
}
