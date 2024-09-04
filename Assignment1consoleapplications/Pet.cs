namespace Assignment1consoleapplications
{
    public class Pet
    {
        // Private fields to store pet details
        private string name = string.Empty;
        private int age = 0;
        private bool isFemale;

        // Method to read input from the user
        public void ReadInput()
        {
            // Get and validate pet name
            Console.Write("Enter the pet's name: ");
            name = Console.ReadLine() ?? string.Empty; // Use an empty string if the input is null

            // Get and validate pet age
            bool validAge = false;
            while (!validAge)
            {
                Console.Write("Enter the pet's age: ");
                string ageInput = Console.ReadLine() ?? "0";

                if (int.TryParse(ageInput, out age))
                {
                    validAge = true;
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a valid number.");
                }
            }

            // Get and validate pet gender
            Console.Write("Is the pet female? (yes/no): ");
            string genderInput = Console.ReadLine()?.ToLower() ?? "no";
            isFemale = (genderInput == "yes");
        }

        // Method to display pet information
        public void DisplayPetInfo()
        {
            Console.WriteLine($"\nPet Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {(isFemale ? "Female" : "Male")}");
        }

        // Start method to initiate the process
        public void Start()
        {
            ReadInput();       // Call the method to get user input
            DisplayPetInfo();  // Call the method to display the pet information
        }
    }
}


