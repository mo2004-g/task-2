namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int small = 9999; int large = 0;
            Console.Write("Enter your  storage space: ");
            x = int.Parse(Console.ReadLine());

            List<int> sum = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"Enter numbers {i} :");
                sum.Add(int.Parse(Console.ReadLine()));
            }
            char c;
            do
            {

                Console.WriteLine(" P - Print nymber\n"
                                      + " A - Add nmber\n"
                                      + " M - Dispay mean of the number\n"
                                      + " S - Display the smalest number\n"
                                      + " L - Display the largest number\n"
                                      + " Q - Quit");
                Console.Write("Enter your chois :");
                c = char.Parse(Console.ReadLine());
                if (c == 'P' || c == 'p')
                {
                    Console.Write("[");
                    for (int i = 0; i < sum.Count; i++)
                    {

                        Console.Write($" {sum[i]} ");
                    }
                    Console.WriteLine("]");

                }


                if (c == 'A' || c == 'a')
                {
                    Console.Write("Enter new number : ");
                    int y = int.Parse(Console.ReadLine());
                    sum.Add(y);
                    Console.WriteLine($"{y} added");
                    Console.WriteLine("Duplicate List Entries are OK");


                }



                if (c == 'M' || c == 'm')
                {
                    int summ = 0;
                    for (int i = 0; i < sum.Count; i++)
                    {
                        summ += sum[i];
                    }
                    double avv = summ / sum.Count;
                    Console.WriteLine($"Average :{avv}");

                }

                if (c == 'S' || c == 's')
                {
                    for (int i = 0; i < sum.Count; i++)
                    {
                        if (sum[i] < small)
                        {
                            small = sum[i];
                        }
                    }
                    Console.WriteLine($"The smallest number : {small}");

                }

                if (c == 'L' || c == 'l')
                {
                    for (int i = 0; i < sum.Count; i++)
                    {
                        if (sum[i] > large)
                        {
                            large = sum[i];
                        }
                    }
                    Console.WriteLine($"The largest number : {large}");
                }
                if (c == 'Q' || c == 'q')
                {
                    Console.WriteLine("Good bye ");
                }



            } while (c != 'Q' && c != 'q');

        }
    }
}
