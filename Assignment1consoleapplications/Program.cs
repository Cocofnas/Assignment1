namespace Assignment1consoleapplications
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup the console window appearance
            SetupConsoleWindow();

            // Create an instance of the Pet class
            Pet myPet = new Pet();
            myPet.Start();

            Console.WriteLine("==========");

            // Create an instance of the TicketSeller class
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();

            Console.WriteLine("==========");
           

            // Create an instance of the Album class
            Album myAlbum = new Album();
            myAlbum.Start();

            Console.WriteLine("==========");

            // Create an instance of the Food class
            Food myFood = new Food();
            myFood.Start();
            Console.WriteLine("==========");

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void SetupConsoleWindow()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();  // Paint the background with the above color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "My Console Classes";
        }
    }
}
