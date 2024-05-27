namespace ArraySorting
{
    class Program
    {
        static void Main()
        {
            // Initialize an array of integers
            int[] num = { 5, 3, 8, 4, 2, 7, 1, 6 };

            // Display the array before sorting
            Console.WriteLine("Array before sorting:");
            DisplayArray(num);

            // Sort the array
            Array.Sort(num);

            // Display the array after sorting
            Console.WriteLine("\nArray after sorting:");
            DisplayArray(num);
        }

        // Method to display the elements of the array
        static void DisplayArray(int[] array) 
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
