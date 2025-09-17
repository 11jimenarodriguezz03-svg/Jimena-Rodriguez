class Rhombus
{
    static void Main()
    {
        string input;
        do
        {
            Console.Write("Enter the size of the rhombus or type 'exit' to quit: ");
            input = Console.ReadLine()!.ToLower();

            if (input == "exit")
                break;

            if (!int.TryParse(input, out int size) || size <= 0)
            {
                Console.WriteLine("Invalid value. It must be a positive integer.");
                continue;
            }

            DrawRhombus(size);

        } while (input != "exit");

        Console.WriteLine("Program finished.");
    }

    static void DrawRhombus(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            Console.Write(new string(' ', size - i));
            Console.WriteLine(new string('#', 2 * i - 1));
        }

        for (int i = size - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', size - i));
            Console.WriteLine(new string('#', 2 * i - 1));
        }
    }
}

