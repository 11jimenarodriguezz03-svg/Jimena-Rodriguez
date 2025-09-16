using System;

class Rhombus
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter the size of the rhombus (ESC to quit): ");
            bool esc;
            string input = ReadLineOrEsc(out esc);
            if (esc)
            {
                Console.WriteLine("Program finished.");
                break;
            }

            if (!int.TryParse(input, out int size) || size <= 0)
            {
                Console.WriteLine("Invalid value. It must be a positive integer.");
                continue;
            }

            DrawRhombus(size);
        }
    }

    static string ReadLineOrEsc(out bool esc)
    {
        esc = false;
        var sb = new System.Text.StringBuilder();
        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape) { esc = true; Console.WriteLine(); return null; }
            if (key.Key == ConsoleKey.Enter) { Console.WriteLine(); return sb.ToString(); }
            if (key.Key == ConsoleKey.Backspace)
            {
                if (sb.Length > 0)
                {
                    sb.Length--;
                    Console.Write("\b \b");
                }
                continue;
            }
            if (char.IsDigit(key.KeyChar))
            {
                sb.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        }
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

