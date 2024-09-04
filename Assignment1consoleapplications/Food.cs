namespace Assignment1consoleapplications
{
    public class Food
    {
        // Private fields to store food details
        private string typeFood = string.Empty;
        private bool isHome; // Is the user eating at home
        private int scale = 0; // Excitement scale

        // Method to read input from the user
        public void ReadInput()
        {
            // Get and validate food type
            Console.Write("What are you in the mood to eat?: ");
            typeFood = Console.ReadLine() ?? string.Empty; // Use an empty string if the input is null

            // Get and validate food location
            Console.Write("Are you eating at home? (yes/no): ");
            string locationInput = Console.ReadLine()?.ToLower() ?? "no";
            isHome = (locationInput == "yes");

            // Get and validate excitement level
            bool validScale = false;
            while (!validScale)
            {
                Console.Write("How excited are you on a scale from 1 to 10 about dinner?: ");
                string scaleInput = Console.ReadLine() ?? "0";

                if (int.TryParse(scaleInput, out scale) && scale >= 1 && scale <= 10)
                {
                    validScale = true;
                }
                else
                {
                    Console.WriteLine("Invalid scale. Please enter a number between 1 and 10.");
                }
            }
        }

        // Method to display food information
        public void DisplayFoodInfo()
        {
            Console.WriteLine("\nFood Information:");
            Console.WriteLine($"Food: {typeFood}");
            Console.WriteLine($"Location: {(isHome ? "Home" : "Outside")}");
            Console.WriteLine($"Excitement Scale: {scale}");
        }

        // Start method to initiate the process
        public void Start()
        {
            ReadInput();       // Call the method to get user input
            DisplayFoodInfo(); // Call the method to display the food information
        }
    }
}
