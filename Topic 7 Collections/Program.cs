namespace Topic_7_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();
            int choice;
            bool cont = true;
            List<int> numbers = new List<int>();
            Console.WriteLine("here is a list of numbers");
            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(1, 100));
                Console.Write(numbers[i] + " ");
                
            }

                while (cont)
                {
                    Console.WriteLine();
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1 - Sort the list");
                    Console.WriteLine("2 - Make a new list of random numbers");
                    Console.WriteLine("3 - Remove a number (by value)");
                    Console.WriteLine("4 - Add a value to the list");
                    Console.WriteLine("5 - Count the number of occurrences of a specified number");
                    Console.WriteLine("6 - Print the largest value");
                    Console.WriteLine("7 - Print the smallest value");
                    Console.WriteLine("8 - Quit");

                    if (Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                // Sort the list
                                numbers.Sort();
                                for (int j = 0; j < numbers.Count; j++)
                                {
                                    Console.WriteLine("Sorted list:" + numbers[j]);
                                }
                                break;
                            case 2:
                                // Make a new list of random numbers
                                numbers.Clear();
                            Console.WriteLine("New list:");
                                for (int a = 0; a < 25; a++)
                                {
                                    numbers.Add(generator.Next(1, 100));
                                    Console.Write(numbers[a]);
                                }

                                break;
                            case 3:

                                // Remove a number (by value)
                                Console.WriteLine("Enter the number to remove:");
                                int Remove = Convert.ToInt32(Console.ReadLine());
                                numbers.RemoveAll(x => x == Remove);
                                Console.WriteLine("List:");
                                for (int k = 0; k < numbers.Count; k++)
                                {
                                    
                                    Console.Write(numbers[k]);
                                }
                                break;
                            case 4:
                                // Add a value to the list
                                Console.WriteLine("Enter the number to add:");
                                int toAdd = int.Parse(Console.ReadLine());
                                numbers.Add(toAdd);
                                for (int l = 0; l < numbers.Count; l++)
                                {
                                    Console.WriteLine("List:");
                                    Console.Write(numbers[l]);
                                }
                                break;
                            case 5:
                                // Count the number of occurrences of a specified number
                                Console.WriteLine("Enter the number to count:");
                                int toCount = Convert.ToInt32(Console.ReadLine());
                                int count = numbers.Count(x => x == toCount);
                                Console.WriteLine("Count: " + count);
                                break;
                            case 6:
                                // Print the largest value
                                int max = numbers.Max();
                                Console.WriteLine("Largest value: " + max);
                                break;
                            case 7:
                                // Print the smallest value
                                int min = numbers.Min();
                                Console.WriteLine("Smallest value: " + min);
                                break;
                            case 8:

                                cont = false;
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }

                        Console.WriteLine();
                    }

                    // Print sum and average of the numbers in the list
                    int sum = numbers.Sum();
                    double avg = numbers.Average();
                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Average: " + avg);


                }
            

        }
    }
}