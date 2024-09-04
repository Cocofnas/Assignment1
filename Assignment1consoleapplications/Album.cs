namespace Assignment1consoleapplications
{
    public class Album
    {
        // Fields to store album details
        private string title = string.Empty;
        private string artist = string.Empty;
        private int yearReleased;

        // Method to read album details from the user
        public void ReadAlbumDetails()
        {
            Console.Write("Enter the album title: ");
            title = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter the artist name: ");
            artist = Console.ReadLine() ?? string.Empty;

            bool validYear = false;
            while (!validYear)
            {
                Console.Write("Enter the year of release (four digits, e.g., 2023): ");
                string yearInput = Console.ReadLine() ?? "0";

                // Check if the input is a valid integer and if it's a four-digit number
                if (int.TryParse(yearInput, out yearReleased) && yearReleased >= 1000 && yearReleased <= 9999)
                {
                    validYear = true;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid four-digit year.");
                }
            }
        }

        // Method to display album details
        public void DisplayAlbumDetails()
        {
            Console.WriteLine($"\nAlbum Details:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Year Released: {yearReleased}");
        }

        // Start method to initiate the process
        public void Start()
        {
            ReadAlbumDetails();       // Call the method to get album details
            DisplayAlbumDetails();    // Call the method to display the album details
        }
    }
}
