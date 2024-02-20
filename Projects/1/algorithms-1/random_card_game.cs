using System;

namespace algohomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // The part where the initial values ​​of empty lists and scores are determined.
            string[] a1 = new string[15];
            string[] a2 = new string[15];
            string[] a3 = new string[15];
            string[] deu = { "D", "E", "U" };
            Random random = new Random();
            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
            int player_1_score = 120;
            int player_2_score = 120;

            // Since there is no need to check in the first time and my for block starts with check, the block where the first letter is randomly generated.
            Console.WriteLine("Player 1 =>\t\t" + "(Player 1: " + (player_1_score - 5) + ", Player 2: " + player_2_score + ")");
            int number_of_line = random.Next(0, 3);
            if (number_of_line == 0)
            {
                int number_of_deu = random.Next(0, 3);
                string the_letter = deu[number_of_deu];
                a1[0] = the_letter;
            }
            else if (number_of_line == 1)
            {
                int number_of_deu = random.Next(0, 3);
                string the_letter = deu[number_of_deu];
                a2[0] = the_letter;
            }
            else if (number_of_line == 2)
            {
                int number_of_deu = random.Next(0, 3);
                string the_letter = deu[number_of_deu];
                a3[0] = the_letter;
            }
            Console.Write("A1:");
            for (int x = 0; x < a1.Length; x++)
            {
                Console.Write(a1[x]);
            }
            Console.Write("\nA2:");
            for (int y = 0; y < a2.Length; y++)
            {
                Console.Write(a2[y]);
            }
            Console.Write("\nA3:");
            for (int z = 0; z < a1.Length; z++)
            {
                Console.Write(a3[z]);
            }

            int i = 0;
            int t = 0;
            int j = 0;
            int q = 0;
            string win = "";
            while (i < 1)
            {
                for (t = 0; t < a1.Length + a2.Length + a3.Length; t++)
                {
                    // Block of control.
                    for (j = 0; j < a1.Length; j++)
                    {
                        q++;
                        if ((a1[j] == "D" && a2[j] == "E" && a3[j] == "U") || (a1[j] == "U" && a2[j] == "E" && a3[j] == "D"))
                        {
                            if (j % 2 != 0)
                            {
                                Console.WriteLine("\nPlayer 1 Win!");
                                t = 999;
                                j = 15;
                                i++;
                                win = "Player_1";

                            }
                            else
                            {
                                Console.WriteLine("\nPlayer 2 Win!");
                                j = 15;
                                i++;
                                win = "Player_2";

                            }

                            t = 999;
                            break;
                        }
                        else if (j < a1.Length - 2)
                        {
                            if ((a1[j] == "D" && a2[j + 1] == "E" && a3[j + 2] == "U") || (a1[j + 2] == "D" && a2[j + 1] == "E" && a3[j] == "U"))
                            {
                                if (j % 2 != 0)
                                {
                                    Console.WriteLine("\nPlayer 1 Win!");
                                    t = 999;
                                    j = 15;
                                    i++;
                                    win = "Player_1";

                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer 2 Win!");
                                    j = 15;
                                    i++;
                                    win = "Player_2";

                                }
                                t = 999;
                                break;
                            }
                            else if ((a1[j] == "D" && a1[j + 1] == "E" && a1[j + 2] == "U") || (a1[j + 2] == "D" && a1[j + 1] == "E" && a1[j] == "U"))
                            {
                                if (j % 2 != 0)
                                {
                                    Console.WriteLine("\nPlayer 1 Win!");
                                    t = 999;
                                    j = 15;
                                    i++;
                                    win = "Player_1";

                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer 2 Win!");
                                    j = 15;
                                    i++;
                                    win = "Player_2";

                                }
                                t = 999;
                                break;
                            }
                            else if ((a2[j] == "D" && a2[j + 1] == "E" && a2[j + 2] == "U") || (a2[j + 2] == "D" && a2[j + 1] == "E" && a2[j] == "U"))
                            {
                                if (j % 2 != 0)
                                {
                                    Console.WriteLine("\nPlayer 1 Win!");
                                    t = 999;
                                    j = 15;
                                    i++;
                                    win = "Player_1";

                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer 2 Win!");
                                    j = 15;
                                    i++;
                                    win = "Player_2";

                                }
                                t = 999;
                                break;
                            }
                            else if ((a3[j] == "D" && a3[j + 1] == "E" && a3[j + 2] == "U") || (a3[j + 2] == "D" && a3[j + 1] == "E" && a3[j] == "U"))
                            {
                                if (j % 2 != 0)
                                {
                                    Console.WriteLine("\nPlayer 1 Win!");
                                    t = 999;
                                    j = 15;
                                    i++;
                                    win = "Player_1";

                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer 2 Win!");
                                    j = 15;
                                    i++;
                                    win = "Player_2";

                                }
                                t = 999;
                                break;
                            }
                            else if ((a1[j] == "U" && a2[j + 1] == "E" && a3[j + 2] == "D") || (a1[j + 2] == "D" && a2[j + 1] == "E" && a3[j] == "U"))
                            {
                                if (j % 2 != 0)
                                {
                                    Console.WriteLine("\nPlayer 1 Win!");
                                    t = 999;
                                    j = 15;
                                    i++;
                                    win = "Player_1";

                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer 2 Win!");
                                    j = 15;
                                    i++;
                                    win = "Player_2";

                                }
                                t = 999;
                                break;
                            }

                        }
                    }

                    // If the game is not over after the control, the player's name is the block where the score is written.
                    if (q % 2 != 0 && t != 999)
                    {
                        player_1_score -= 5;
                        Console.WriteLine("\nPlayer 2 =>\t\t" + "(Player 1: " + player_1_score + ", Player 2: " + (player_2_score -5) + ")");
                    }
                    else if (q % 2 != 1 && t != 999)
                    {
                        player_2_score -= 5;
                        Console.WriteLine("\nPlayer 1 =>\t\t" + "(Player 1: " + (player_1_score - 5) + ", Player 2: " + player_2_score + ")");

                    }

                    //Block to check for random letter formation.
                    int ii = 0;
                    while (ii < 1)
                    {
                        number_of_line = random.Next(0, 3);
                        if ((number_of_line == 0) && (a1[14] != "D" && a1[14] != "E" && a1[14] != "U"))
                        {
                            for (int a = 0; a < a1.Length; a++)
                            {
                                int number_of_deu = random.Next(0, 3);
                                string the_letter = deu[number_of_deu];
                                if (a1[a] != "D" && a1[a] != "E" && a1[a] != "U")
                                {
                                    a1[a] = the_letter;
                                    ii++;
                                    a = 15;
                                }

                            }

                        }
                        if ((number_of_line == 1) && (a2[14] != "D" && a2[14] != "E" && a2[14] != "U"))
                        {
                            for (int b = 0; b < a2.Length; b++)
                            {
                                int number_of_deu = random.Next(0, 3);
                                string the_letter = deu[number_of_deu];
                                if (a2[b] != "D" && a2[b] != "E" && a2[b] != "U")
                                {
                                    a2[b] = the_letter;
                                    ii++;
                                    b = 15;
                                }

                            }
                        }
                        if ((number_of_line == 2) && (a3[14] != "D" && a3[14] != "E" && a3[14] != "U"))
                        {
                            for (int c = 0; c < a3.Length; c++)
                            {
                                int number_of_deu = random.Next(0, 3);
                                string the_letter = deu[number_of_deu];
                                if (a3[c] != "D" && a3[c] != "E" && a3[c] != "U")
                                {
                                    a3[c] = the_letter;
                                    ii++;
                                    c = 15;
                                }

                            }
                        }
                    }
                    // The block where the state of the arrays at that stage is written.
                    if (t < 45)
                    {
                        Console.Write("A1:");
                        for (int x = 0; x < a1.Length; x++)
                        {
                            Console.Write(a1[x]);
                        }
                        Console.Write("\nA2:");
                        for (int y = 0; y < a2.Length; y++)
                        {
                            Console.Write(a2[y]);
                        }
                        Console.Write("\nA3:");
                        for (int z = 0; z < a1.Length; z++)
                        {
                            Console.Write(a3[z]);
                        }
                    }

                }
            }
            // Block where the scoreboard is written.
            int sort = 0;
            int maks = 0;
            int temp = 0;
            if (win == "Player_1")
                maks = player_1_score - 5;
            else
                maks = player_2_score - 5;
            for (sort = 0; sort < 12; sort++)
            {
                if (maks > scores[sort])
                {
                    temp = sort;
                    sort = 13;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Name          Score");
            int space = 0;

            for (sort = 0; sort < 12; sort++)
            {
                if (temp == sort)
                {
                    Console.WriteLine(win + "      " + maks);

                    Console.Write(names[sort]);
                    for (space = 0; space < 14 - names[sort].Length; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(scores[sort]);
                }
                else
                {
                    Console.Write(names[sort]);
                    for (space = 0; space < 14 - names[sort].Length; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(scores[sort]);
                }
            }
        }
    }
}
