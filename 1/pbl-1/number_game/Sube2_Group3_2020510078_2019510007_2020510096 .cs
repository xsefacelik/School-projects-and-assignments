using System;

namespace project_2_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            // arrays
            int[] line1 = new int[30];
            int[] line2 = new int[30];
            int[] line3 = new int[30];
            Random num = new Random();
            int index, number;
            int random_array, count = 0;
            int cursor_x = 0, cursor_y = 0;   // position of cursor
            ConsoleKeyInfo cki;
            int score = 0;

            
            while (count != 30)
            {
                // adding numbers to arrays
                random_array = num.Next(1, 4);
                index = num.Next(0, 30);
                number = num.Next(1, 4);
                if (random_array == 1)
                {
                    if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                    {

                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                        {
                            while (line1[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line1[index] = number;
                        count++;
                    }
                    else
                    {
                        line1[index] = number;
                        count++;
                    }
                }
                if (random_array == 2)
                {
                    if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                    {
                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                        {
                            while (line2[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line2[index] = number;
                        count++;
                    }
                    else
                    {
                        line2[index] = number;
                        count++;
                    }
                }
                if (random_array == 3)
                {
                    if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                    {
                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                        {
                            while (line3[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line3[index] = number;
                        count++;
                    }
                    else
                    {
                        line3[index] = number;
                        count++;
                    }
                }
            }
            int k = 0;
            while (k < 1)
            {
                for (int i = 0; i < 29; i++)
                {
                    if (line1[i] == line1[i + 1])
                    {
                        if (line1[i] != 0 && line1[i + 1] != 0)
                        {
                            score += 10;
                            line1[i] = 0;
                            line1[i + 1] = 0;

                        }
                    }
                    if (line2[i] == line2[i + 1])
                    {
                        if (line2[i] != 0 && line2[i + 1] != 0)
                        {
                            score += 10;
                            line2[i] = 0;
                            line2[i + 1] = 0;
                        }
                    }
                    if (line3[i] == line3[i + 1])
                    {
                        if (line3[i] != 0 && line3[i + 1] != 0)
                        {
                            score += 10;
                            line3[i] = 0;
                            line3[i + 1] = 0;
                        }
                    }
                }
                count = 0;
                while (count < (score / 5))
                {
                    // adding numbers to arrays
                    random_array = num.Next(1, 4);
                    index = num.Next(0, 30);
                    number = num.Next(1, 4);
                    if (random_array == 1)
                    {
                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                        {

                            index = num.Next(0, 30);
                            number = num.Next(1, 4);
                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                            {
                                while (line1[index] != 0)
                                {
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                }
                            }
                            line1[index] = number;
                            count++;
                        }
                        else
                        {
                            line1[index] = number;
                            count++;
                        }
                    }
                    if (random_array == 2)
                    {
                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                        {
                            index = num.Next(0, 30);
                            number = num.Next(1, 4);
                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                            {
                                while (line2[index] != 0)
                                {
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                }
                            }
                            line2[index] = number;
                            count++;
                        }
                        else
                        {
                            line2[index] = number;
                            count++;
                        }
                    }
                    if (random_array == 3)
                    {
                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                        {
                            index = num.Next(0, 30);
                            number = num.Next(1, 4);
                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                            {
                                while (line3[index] != 0)
                                {
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                }
                            }
                            line3[index] = number;
                            count++;
                        }
                        else
                        {
                            line3[index] = number;
                            count++;
                        }
                    }
                }
                int score_1 = score;
                for (int i = 0; i < 29; i++)
                {
                    if (line1[i] == line1[i + 1])
                    {
                        if (line1[i] != 0 && line1[i + 1] != 0)
                        {
                            score += 10;
                            line1[i] = 0;
                            line1[i + 1] = 0;

                        }
                    }
                    if (line2[i] == line2[i + 1])
                    {
                        if (line2[i] != 0 && line2[i + 1] != 0)
                        {
                            score += 10;
                            line2[i] = 0;
                            line2[i + 1] = 0;
                        }
                    }
                    if (line3[i] == line3[i + 1])
                    {
                        if (line3[i] != 0 && line3[i + 1] != 0)
                        {
                            score += 10;
                            line3[i] = 0;
                            line3[i + 1] = 0;
                        }
                    }
                    if (score_1 == score)
                        k++;
                }
            }
            
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|");
            Console.SetCursorPosition(1, 1);
            for (int i = 0; i < line1.Length; i++)
            {
                if (line1[i] > 0)
                {
                    Console.Write(line1[i]);
                }
                else if (line1[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("|");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i < line2.Length; i++)
            {
                if (line2[i] > 0)
                {
                    Console.Write(line2[i]);
                }
                else if (line2[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("|");
            Console.SetCursorPosition(1, 3);
            for (int i = 0; i < line3.Length; i++)
            {
                if (line3[i] > 0)
                {
                    Console.Write(line3[i]);
                }
                else if (line3[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("|");
            Console.WriteLine("\n|------------------------------|");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Score: " + score);

            cursor_x = 0;
            cursor_y = 0;
            Console.SetCursorPosition(cursor_x + 1, cursor_y + 1);
            while (true)
            {
                if (Console.KeyAvailable)
                {       // true: there is a key in keyboard bufferda
                    cki = Console.ReadKey(true);       // true: do not write character 

                    if (cki.Key == ConsoleKey.RightArrow && cursor_x < 29)
                    {
                        cursor_x++;
                        Console.SetCursorPosition(cursor_x + 1, cursor_y + 1);
                    }
                    else if (cki.Key == ConsoleKey.LeftArrow && cursor_x > 0)
                    {
                        cursor_x -= 1;
                        Console.SetCursorPosition(cursor_x + 1, cursor_y + 1);
                    }
                    else if (cki.Key == ConsoleKey.UpArrow && cursor_y > 0)
                    {
                        cursor_y -= 1;
                        Console.SetCursorPosition(cursor_x + 1, cursor_y + 1);
                    }
                    else if (cki.Key == ConsoleKey.DownArrow && cursor_y < 2)
                    {
                        cursor_y++;
                        Console.SetCursorPosition(cursor_x + 1, cursor_y + 1);
                    }
                    else if (cki.Key == ConsoleKey.W)
                    {
                        if (cursor_y == 1 && line1[cursor_x] == 0)
                        {
                            int second_line_first_number = line2[cursor_x];
                            line2[cursor_x] = 0;
                            line1[cursor_x] = second_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 1, cursor_y);
                        }
                        else if (cursor_y == 2 && line2[cursor_x] == 0)
                        {
                            int third_line_first_number = line3[cursor_x];
                            line3[cursor_x] = 0;
                            line2[cursor_x] = third_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 1, cursor_y);
                        }
                    }
                    else if (cki.Key == ConsoleKey.S)
                    {
                        if (cursor_y == 0 && line2[cursor_x] == 0)
                        {
                            int first_line_first_number = line1[cursor_x];
                            line1[cursor_x] = 0;
                            line2[cursor_x] = first_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 1, cursor_y + 2);
                        }
                        else if (cursor_y == 1 && line3[cursor_x] == 0)
                        {
                            int second_line_first_number = line2[cursor_x];
                            line2[cursor_x] = 0;
                            line3[cursor_x] = second_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 1, cursor_y + 2);
                        }  
                    }
                    else if (cki.Key == ConsoleKey.A)
                    {
                        if (cursor_y == 0 && line1[cursor_x + 1] == 0 && line1[cursor_x - 1] == 0)
                        {
                            int first_line_first_number = line1[cursor_x];
                            line1[cursor_x] = 0;
                            line1[cursor_x - 1] = first_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x, cursor_y + 1);
                        }
                        if (cursor_y == 1 && line2[cursor_x + 1] == 0 && line2[cursor_x - 1] == 0)
                        {
                            int second_line_first_number = line2[cursor_x];
                            line2[cursor_x] = 0;
                            line2[cursor_x - 1] = second_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x, cursor_y + 1);
                        }
                        if (cursor_y == 2 && line3[cursor_x + 1] == 0 && line3[cursor_x - 1] == 0)
                        {
                            int third_line_first_number = line3[cursor_x];
                            line3[cursor_x] = 0;
                            line3[cursor_x - 1] = third_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x, cursor_y + 1);
                        }
                    }
                    else if (cki.Key == ConsoleKey.D)
                    {
                        if (cursor_y == 0 && line1[cursor_x + 1] == 0 && line1[cursor_x - 1] == 0)
                        {
                            int first_line_first_number = line1[cursor_x];
                            line1[cursor_x] = 0;
                            line1[cursor_x + 1] = first_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 2, cursor_y + 1);
                        }
                        else if (cursor_y == 1 && line2[cursor_x + 1] == 0 && line2[cursor_x - 1] == 0)
                        {
                            int second_line_first_number = line2[cursor_x];
                            line2[cursor_x] = 0;
                            line2[cursor_x + 1] = second_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 2, cursor_y + 1);
                        }
                        else if (cursor_y == 2 && line3[cursor_x + 1] == 0 && line3[cursor_x - 1] == 0)
                        {
                            int third_line_first_number = line3[cursor_x];
                            line3[cursor_x] = 0;
                            line3[cursor_x + 1] = third_line_first_number;

                            k = 0;
                            while (k < 1)
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                }
                                count = 0;
                                while (count < 2)
                                {
                                    // adding numbers to arrays
                                    random_array = num.Next(1, 4);
                                    index = num.Next(0, 30);
                                    number = num.Next(1, 4);
                                    if (random_array == 1)
                                    {
                                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                        {

                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                                            {
                                                while (line1[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line1[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line1[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 2)
                                    {
                                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                                            {
                                                while (line2[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line2[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line2[index] = number;
                                            count++;
                                        }
                                    }
                                    if (random_array == 3)
                                    {
                                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                                            {
                                                while (line3[index] != 0)
                                                {
                                                    index = num.Next(0, 30);
                                                    number = num.Next(1, 4);
                                                }
                                            }
                                            line3[index] = number;
                                            count++;
                                        }
                                        else
                                        {
                                            line3[index] = number;
                                            count++;
                                        }
                                    }
                                }
                                int score_1 = score;
                                for (int i = 0; i < 29; i++)
                                {
                                    if (line1[i] == line1[i + 1])
                                    {
                                        if (line1[i] != 0 && line1[i + 1] != 0)
                                        {
                                            score += 10;
                                            line1[i] = 0;
                                            line1[i + 1] = 0;

                                        }
                                    }
                                    if (line2[i] == line2[i + 1])
                                    {
                                        if (line2[i] != 0 && line2[i + 1] != 0)
                                        {
                                            score += 10;
                                            line2[i] = 0;
                                            line2[i + 1] = 0;
                                        }
                                    }
                                    if (line3[i] == line3[i + 1])
                                    {
                                        if (line3[i] != 0 && line3[i + 1] != 0)
                                        {
                                            score += 10;
                                            line3[i] = 0;
                                            line3[i + 1] = 0;
                                        }
                                    }
                                    if (score_1 == score)
                                        k++;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 1);
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 2);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine();
                            Console.WriteLine("|");
                            Console.SetCursorPosition(1, 3);
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("|");
                            Console.WriteLine("\n|------------------------------|");
                            Console.SetCursorPosition(40, 2);
                            Console.WriteLine("Score: " + score);
                            Console.SetCursorPosition(cursor_x + 2, cursor_y + 1);
                        }
                    }    
                }
            }
        }
    }
}
