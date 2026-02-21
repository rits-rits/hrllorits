namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu();
        {
        while(true)
            {
        Console.WriteLine("Book Your Flight!");
        Console.WriteLine("1. View Available Flights");
        Console.WriteLine("2. Book Flight");
        Console.WriteLine("3. View Bookings");
        Console.WriteLine("4. Cancel Booking");
        Console.WriteLine("5. Exit");
            
        Console.WriteLine("");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        switch(choice)
            {
            case "1":
            ViewFlights();
        break;
            case "2":
            BookFlight();
        break;
            case "3":
            ViewBookkings();
        break;
            case "4":
            CancelBooking();
        break;
            case "5"
            Console.Writeline("Exiting System...");
        break;
            default:
            Console.Writeline("Invalid Choice!!!");
        }
            }
            }
    

static void ViewFlights()
{
    Console.WriteLine("AVAILABLE FLIGHTS");
    Console.WriteLine("Tokyo, South Korea");
}
static void BookFlights()
{
    Console.WriteLine("BOOK FLIGHT");
    Console.Write("Select an option: ");
    string flightID = Console.ReadLine();

    Console.Write("Enter Passenger Name: ");
    string name = Console.ReadLine();

    Console.Write("Booking Confirmed: ");

}



    

    


    }
}
