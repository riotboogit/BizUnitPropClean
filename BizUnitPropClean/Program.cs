using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main()
    {
        // Initialize the hashtable
        Hashtable bizUnits = new Hashtable();

        // Path to the text file
        string filePathIn =@"C:\work\bizunit.props";
        string filePathConfig = @"C:\work\FloridaProperties.csv";
        string[] keysToRemove = { };

        try
        {
            // Read all lines from the text file
            string[] lines = File.ReadAllLines(filePathIn);

            // Iterate through each line and add to the hashtable
            foreach (string line in lines)
            {
                // Assuming each line is in the format "key=value"
                if (line.Length > 15)
                {

                }
                else
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        // Add key-value pair to the hashtable
                        bizUnits[key] = value;
                    }
                }
            }
            using (StreamReader sr = new StreamReader(filePathConfig))

                // Display the contents of the bizUnits
                foreach (DictionaryEntry entry in bizUnits)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
