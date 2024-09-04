namespace Assignment1consoleapplications
{
    public class TicketSeller
    {
        // Constants for ticket prices
        private const double adultPrice = 20.00;
        private const double childPrice = 2.00;

        // Fields to store the number of tickets sold
        private int numberOfAdultTicketsSold;
        private int numberOfChildTicketsSold;
        private double totalRevenue;

        // Method to read the number of tickets sold
        public void ReadTicketSales()
        {
            Console.Write("Enter the number of adult tickets sold: ");
            string adultTicketsInput = Console.ReadLine() ?? "0";
            numberOfAdultTicketsSold = int.TryParse(adultTicketsInput, out int adults) ? adults : 0;

            Console.Write("Enter the number of child tickets sold: ");
            string childTicketsInput = Console.ReadLine() ?? "0";
            numberOfChildTicketsSold = int.TryParse(childTicketsInput, out int children) ? children : 0;
        }

        // Method to calculate total revenue
        public void CalculateTotalRevenue()
        {
            totalRevenue = (numberOfAdultTicketsSold * adultPrice) + (numberOfChildTicketsSold * childPrice);
        }

        // Method to display the total revenue
        public void DisplayTotalRevenue()
        {
            Console.WriteLine($"\nTotal Revenue: ${totalRevenue:F2}");
        }

        // Start method to initiate the process
        public void Start()
        {
            ReadTicketSales();       // Call the method to get ticket sales
            CalculateTotalRevenue();  // Call the method to calculate revenue
            DisplayTotalRevenue();    // Call the method to display the total revenue
        }
    }
}
