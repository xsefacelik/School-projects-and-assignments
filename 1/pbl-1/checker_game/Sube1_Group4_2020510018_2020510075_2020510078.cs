using System;
using System.Threading;

namespace cengcheckers
{
    class Program
    {

        static void Menu()//Printing the menu to console
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                           88                                88                                                                                    |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                           88                                88                                                                                    |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                           88                                88                                                                                    |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                ,a dPPYba, 88,dPPYba,   ,adPPYba,  ,adPPYba, 88   ,d8  ,adPPYba, 8b,dPPYba, ,adPPYba,                                              |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                               a 8'     '' 88P'    '8a a8P_____88 a8'     '' 88 ,a8'  a8P_____88 88P'   'Y8 I8[    ''                                              |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                               8b          88       88 8PP''''''' 8b         8888[8PP''''''''''' 88          `'Y8ba,                                               |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                               '8a,   , aa 88       88 '8b,   ,aa '8a,   ,aa 88`'Yba, '8b,   ,aa 88      aa      ]8I                                               |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                 `'Ybbd8'' 88       88  `'Ybbd8''  `'Ybbd8'' 88   `Y8a `'Ybbd8'' 88         `'YbbdP''                                              |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>   WELCOME TO CENG CHECKERS   <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |-> WHAT DO YOU WANT TO DO? PLEASE SELECT AN OPTİON <-|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>            MENU:             <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>          1- Rules            <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>          2- Play             <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>          3- EXIT             <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>                              <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>          YOUR OPTİON:        <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |------>>>>>                              <<<<<-------|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                |_____________________________________________________|                                                            |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|                                                                                                                                                                                   |~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~|___________________________________________________________________________________________________________________________________________________________________________________|~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.SetCursorPosition(102, 36);

        }
      
        static void Writing(int sx, int sy, string[,] cengarray)//
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("  12345678 ");
            Console.WriteLine(" +--------+ ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write((i + 1) + "|");
                for (int j = 0; j < 8; j++)
                {
                    if (cengarray[i, j] == "x")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(cengarray[i, j]);
                    }
                    else if (cengarray[i, j] == ".")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(cengarray[i, j]);
                    }
                    else if (cengarray[i, j] == "o")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(cengarray[i, j]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("|");
            }
            Console.WriteLine(" +--------+ ");
            Console.SetCursorPosition(sx, sy);
        }
         static void Winner(string winner)//determining the winner
        {
            Console.SetCursorPosition(13, 1);
            Console.WriteLine("WİNNER : {0}      ", winner);
            Console.SetCursorPosition(13, 2);
            Console.WriteLine("                ");
            Console.SetCursorPosition(13, 15);
        }
        static void Main(string[] args)
        {//prosedürlü
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                int number;
                Menu();

                do
                {
                    number = Convert.ToInt16(Console.ReadLine());
                } while (number != 1 && number != 2 && number != 3);

                if (number == 3)
                { break; }

                if (number == 1)
                {
                    Console.Clear();
                    Console.WriteLine("-----------------Rules-----------------");
                    Console.WriteLine("");
                    Console.WriteLine("All the moves are in 4 directions, diagonal moves cannot be used.");
                    Console.WriteLine("There are 2 move types for a player in each turn: Either a step or jump(s).");
                    Console.WriteLine("•Step: If adjacent square of a piece in any direction (left, right, up or down) is empty, that piece can step into the empty square.");
                    Console.WriteLine("•Jump: A piece can jump over only a single adjacent piece (his/her or opponent's). Jumping over 2 or more pieces or distant pieces is not allowed. ");
                    Console.WriteLine();
                    Console.WriteLine("Jumping operations can be continued with successive jumps (called jump chain) if ");
                    Console.WriteLine("possible, in the same turn. On the contrary, step operation is a single one. There is no ");
                    Console.WriteLine("capturing in this game, so all pieces remain active during the game. ");
                    Console.WriteLine();
                    Console.WriteLine("For each step or jump operation; human user firstly chooses the piece to move, then ");
                    Console.WriteLine("chooses the target square of the piece. ");
                    Console.WriteLine("1. Move cursor to the location of the piece");
                    Console.WriteLine("2. Choose the piece by pressing key Z");
                    Console.WriteLine("3. Move cursor to the target location ");
                    Console.WriteLine("4. Choose target square by pressing key X After the move;");
                    Console.WriteLine("5. If there is no successive jumps, end the move by pressing key C");
                    Console.WriteLine("6. If the player wants to jump again, go to stage 3  ");
                    Console.WriteLine(" Please press ESC to return menu!");
                    do
                    {
                        keyInfo = Console.ReadKey(true);
                    } while (keyInfo.Key != ConsoleKey.Escape);
                }


                if (number == 2)
                {
                    Console.Clear();
                    int sx = 2, sy = 2, chooseZx = 2, chooseZy = 2; bool flag, flag2 = true, flag3jump = true; string turn = "x"; int round = 1, a = 2, b = 2;


                    string[,] cengarray = new string[,] {
                                               {"o", "o", "o",".",".",".",".","."},
                                               {"o", "o", "o",".",".",".",".","."},
                                               {"o", "o", "o",".",".",".",".","."},
                                               {".", ".", ".",".",".",".",".","."},
                                               {".", ".", ".",".",".",".",".","."},
                                               {".", ".", ".",".",".","x","x","x"},
                                               {".", ".", ".",".",".","x","x","x"},
                                               {".", ".", ".",".",".","x","x","x"}};

                    Writing(sx, sy, cengarray);
                    Console.SetCursorPosition(13, 1);
                    Console.WriteLine("Round:" + round);
                    Console.SetCursorPosition(13, 2);
                    Console.WriteLine("Turn:" + turn);
                    do
                    {
                        flag = true;

                        if (wincmptr(cengarray) == false)
                        {
                            Winner("o");
                            break;
                        }
                        else if (winhuman(cengarray) == false)
                        {
                            Winner("x");
                            break;
                        }


                        if (turn == "x")
                        {
                            Console.SetCursorPosition(13, 2);
                            Console.WriteLine("Turn:" + turn);
                            turn = "o";
                        }

                        keyInfo = Console.ReadKey(true);
                        //These are the codes that we actually use to play game.
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (sy == 2)//It limits the area that cursor can move in.
                                    sy++;
                                sy--;
                                Console.SetCursorPosition(sx, sy);

                                break;

                            case ConsoleKey.DownArrow:
                                if (sy == 9)//It limits the area that cursor can move in.
                                    sy--;
                                sy++;
                                Console.SetCursorPosition(sx, sy);

                                break;

                            case ConsoleKey.RightArrow:
                                if (sx == 9)//It limits the area that cursor can move in.
                                    sx--;
                                sx++;
                                Console.SetCursorPosition(sx, sy);

                                break;

                            case ConsoleKey.LeftArrow:
                                if (sx == 2)//It limits the area that cursor can move in.
                                    sx++;
                                sx--;
                                Console.SetCursorPosition(sx, sy);

                                break;

                            case ConsoleKey.Z:

                                if (cengarray[sy - 2, sx - 2] == "x")//ok
                                {
                                    if (!flag3jump)
                                    {
                                        chooseZx = a;
                                        chooseZy = b;
                                        break;
                                    }
                                    chooseZx = sx - 2;
                                    chooseZy = sy - 2;
                                }
                                break;
                            case ConsoleKey.X:
                                //for step
                                //If step does, flag2 becomes false, preventing jumping.
                                //if it jumps, flag3jump will be false and prevent stepping, only allow sucsessive jumping
                                if (cengarray[sy - 2, sx - 2] == "." && sx - 2 == chooseZx && sy - 3 == chooseZy && flag3jump == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    flag3jump = false;
                                    flag2 = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx - 2 == chooseZx && sy - 1 == chooseZy && flag3jump == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    flag3jump = false;
                                    flag2 = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx - 1 == chooseZx && sy - 2 == chooseZy && flag3jump == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    flag3jump = false;
                                    flag2 = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx - 3 == chooseZx && sy - 2 == chooseZy && flag3jump == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    flag3jump = false;
                                    flag2 = false;
                                }

                                //for  single jump
                                if (cengarray[sy - 2, sx - 2] == "." && sx - 2 == chooseZx && sy - 4 == chooseZy && (cengarray[sy - 3, sx - 2] == "x" || cengarray[sy - 3, sx - 2] == "o") && flag2 == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    a = sx - 2;
                                    b = sy - 2;
                                    flag3jump = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx - 2 == chooseZx && sy == chooseZy && (cengarray[sy - 1, sx - 2] == "x" || cengarray[sy - 1, sx - 2] == "o") && flag2 == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    a = sx - 2;
                                    b = sy - 2;
                                    flag3jump = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx == chooseZx && sy - 2 == chooseZy && (cengarray[sy - 2, sx - 1] == "x" || cengarray[sy - 2, sx - 1] == "o") && flag2 == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    a = sx - 2;
                                    b = sy - 2;
                                    flag3jump = false;
                                }
                                else if (cengarray[sy - 2, sx - 2] == "." && sx - 4 == chooseZx && sy - 2 == chooseZy && (cengarray[sy - 2, sx - 3] == "x" || cengarray[sy - 2, sy - 3] == "o") && flag2 == true)
                                {
                                    stepjump(sx, sy, chooseZx, chooseZy, cengarray);

                                    a = sx - 2;
                                    b = sy - 2;
                                    flag3jump = false;
                                }
                                chooseZy = 2;
                                chooseZx = 2;
                                break;

                            case ConsoleKey.C:
                                if (flag3jump)
                                    break;
                                flag = false;
                                break;

                        }

                        if (flag == false)
                        {

                            flag2 = true;
                            flag3jump = true;
                            chooseZy = 2;
                            chooseZx = 2;
                            for (int i = 0; i < cengarray.GetLength(0); i++)
                            {
                                for (int j = 0; j < cengarray.GetLength(1); j++)
                                {
                                    if (cengarray[i, j] == "o")
                                    {
                                        // FOR SUCSESSIVE JUMP!
                                        if (i < 6 && j < 6 && (cengarray[i, j + 1] == "o" || cengarray[i, j + 1] == "x") && cengarray[i, j + 2] == "." && (cengarray[i + 1, j + 2] == "o" || cengarray[i + 1, j + 2] == "x") && cengarray[i + 2, j + 2] == ".")//controls right side then controls down side
                                        {
                                            if ((i == 5 && Counterforcomputer(cengarray) >= 3) || (i == 4 && Counterforcomputer6(cengarray) >= 3) )
                                            {

                                            }
                                            else
                                            {
                                                Cmpjump(cengarray, j + 4, i + 4, i + 2, j + 2, i, j);

                                                flag2 = false;
                                                break;
                                            }
                                        }

                                        if (i < 6 && j < 6 && (cengarray[i + 1, j] == "o" || cengarray[i + 1, j] == "x") && cengarray[i + 2, j] == "." && (cengarray[i + 2, j + 1] == "o" || cengarray[i + 2, j + 1] == "x") && cengarray[i + 2, j + 2] == ".")//controls down side then controls right side
                                        {
                                            if ((i == 5 && Counterforcomputer(cengarray) >= 3) || (i == 4 && Counterforcomputer6(cengarray) >= 3) )
                                            { }
                                            else
                                            {

                                                Cmpjump(cengarray, j + 4, i + 4, i + 2, j + 2, i, j);

                                                flag2 = false;
                                                break;
                                            }
                                        }
                                        if (j < 4 && (cengarray[i, j + 1] == "o" || cengarray[i, j + 1] == "x") && cengarray[i, j + 2] == "." && (cengarray[i, j + 3] == "o" || cengarray[i, j + 3] == "x") && cengarray[i, j + 4] == ".")// controls right side then controls right side
                                        {
                                            
                                                Cmpjump(cengarray, j + 6, i + 2, i, j + 4, i, j);

                                                flag2 = false;
                                                break;
                                            
                                        }
                                        if (i < 4 && (cengarray[i + 1, j] == "o" || cengarray[i + 1, j] == "x") && cengarray[i + 2, j] == "." && (cengarray[i + 3, j] == "o" || cengarray[i + 3, j] == "x") && cengarray[i + 4, j] == ".")// controls down side then controls down side
                                        {
                                            if ((Counterforcomputer(cengarray) >= 3 && i == 3) || (Counterforcomputer6(cengarray) >= 3 && i == 2))
                                            { }
                                            else
                                            {
                                                Cmpjump(cengarray, j + 2, i + 6, i + 4, j, i, j);

                                                flag2 = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (!flag2)

                                    break;
                            }
                            if (flag2 == true)
                            {
                                for (int i = 0; i < cengarray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < cengarray.GetLength(1); j++)
                                    {
                                        if (cengarray[i, j] == "o")
                                        {
                                            //FOR JUMP!
                                            if (j < 6 && (cengarray[i, j + 1] == "o" || cengarray[i, j + 1] == "x") && cengarray[i, j + 2] == ".")////controls right side.
                                            {
                                                

                                                    Cmpjump(cengarray, j + 4, i + 2, i, j + 2, i, j);

                                                    flag2 = false;
                                                    break;
                                                
                                            }

                                            if (i < 6 && (cengarray[i + 1, j] == "o" || cengarray[i + 1, j] == "x") && cengarray[i + 2, j] == ".")//controls down side.
                                            {
                                                if ((i == 5 && Counterforcomputer(cengarray) >= 3) || (i == 4 && Counterforcomputer6(cengarray) >= 3))
                                                { }
                                                else
                                                {
                                                    Cmpjump(cengarray, j + 2, i + 4, i + 2, j, i, j);

                                                    flag2 = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (!flag2)

                                        break;
                                }
                            }

                            if (flag2 == true)
                            {
                                for (int i = 0; i < cengarray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < cengarray.GetLength(1); j++)
                                    {
                                        if (cengarray[i, j] == "o")
                                        {

                                            //FOR STEP!
                                            if (i < 7 && cengarray[i + 1, j] == ".")//controls down side.
                                            {
                                                if ((i == 6 && Counterforcomputer(cengarray) >= 3) || (i == 5 && Counterforcomputer6(cengarray) >= 3))
                                                { }
                                                else
                                                {
                                                    Cmpjump(cengarray, j + 2, i + 3, i + 1, j, i, j);

                                                    flag2 = false;
                                                    break;
                                                }
                                            } 

                                            if (j < 7 && cengarray[i, j + 1] == ".")//controls right side.
                                            {
                                               

                                                    Cmpjump(cengarray, j + 3, i + 2, i, j + 1, i, j);
                                                    flag2 = false;
                                                    break;
                                                
                                            }
                                            
                                        }
                                    }
                                    if (!flag2)

                                        break;
                                }


                            }
                            if (flag2 == true)
                            {
                                for (int i = 0; i < cengarray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < cengarray.GetLength(1); j++)
                                    {
                                        if (cengarray[i, j] == "o")
                                        {

                                            //FOR  REVERSE STEP!
                                            if (j > 0 && cengarray[i, j - 1] == ".")//controls left side.
                                            {
                                                Cmpjump(cengarray, j + 1, i + 2, i, j - 1, i, j);
                                                flag2 = false;
                                                break;
                                            }
                                            if (i > 0 && cengarray[i - 1, j] == ".")//controls up side.
                                            {
                                                Cmpjump(cengarray, j + 2, i + 1, i - 1, j, i, j);

                                                flag2 = false;
                                                break;
                                            }
                                        }
                                    }
                                    if (!flag2)

                                        break;
                                }
                            }
                            flag2 = true;
                            round++;

                            Console.SetCursorPosition(13, 2);
                            Console.WriteLine("Turn:" + turn);
                            Thread.Sleep(400);
                            Console.SetCursorPosition(13, 1);
                            Console.WriteLine("Round:" + round);
                            turn = "x";

                        }
                    } while (keyInfo.Key != ConsoleKey.Escape|| wincmptr(cengarray) == false|| winhuman(cengarray) == false);//If player press ESC game is being ended.
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
        }
        static void stepjump(int sx, int sy, int chooseZx, int chooseZy, string[,] cengarray)//step and jump operations for human
        {
            Console.SetCursorPosition(chooseZx + 2, chooseZy + 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(".");
            cengarray[chooseZy, chooseZx] = ".";
            cengarray[sy - 2, sx - 2] = "x";
            Console.SetCursorPosition(sx, sy);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("x");

        }
        static void Cmpjump(string[,] cengarray, int b, int a, int c, int d, int e, int f)// step jump operations for computer
        {
            Console.SetCursorPosition(f + 2, e + 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(".");
            Console.SetCursorPosition(b, a);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("o");
            cengarray[c, d] = "o";
            cengarray[e, f] = ".";

        }
        static bool wincmptr(string[,] cengarray)//counter for determining the winner
        {
            int counter = 0;
            bool check = true;
            for (int i = 5; i < 8; i++)
            {
                for (int j = 5; j < 8; j++)
                {
                    if (cengarray[i, j] == "o")
                    { counter += 1; }
                }
            }
            if (counter == 9)
            {
                check = false;
            }
            return check;

        }
        static bool winhuman(string[,] cengarray)
        {
            bool flaghumanwin = true;
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cengarray[i, j] == "x")
                    { counter += 1; }
                }
            }
            if (counter == 9)
            {
                
                flaghumanwin = false;
            }
            return flaghumanwin;



        }//counter for determining the winner

       
        static int Counterforcomputer(string[,] cengarray)
        {
            int counter = 0;
            for (int i = 0; i < cengarray.GetLength(1); i++)
            {
                if (cengarray[7, i] == "o")
                {
                    counter++;

                }
            }
            return counter;
        }

        static int Counterforcomputer6(string[,] cengarray)
        {
            int counter = 0;
            for (int i = 0; i < cengarray.GetLength(1); i++)
            {
                if (cengarray[6, i] == "o")
                {
                    counter++;

                }
            }
            return counter;
        }
    }
}
