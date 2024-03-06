//Program
using System;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This class contains the main entry point of the program.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Calls the TestGame method in the Testing class to do the testing.
                Testing.TestGame();
            }
            catch (Exception ex)
            {
                // If an exception occurs during testing, display an error message.
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
