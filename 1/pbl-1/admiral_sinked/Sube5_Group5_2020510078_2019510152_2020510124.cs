using System;

namespace Tiangle_Battleship_Last_Version
{
    class Program
    {
        
        static string player_name_or_nickname = "", select_options = "";
        static double Area_ship = 0, score = 0;
        static void Main(string[] arg)
        {
            string player_name_or_nickname = "";
            double score = 0;
            int Ax = -1, Ay = -1, Bx = -1, By = -1, Cx = -1, Cy = -1;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            int i = 0;
            while (i < 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                
                // Intro image.
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                                                                                                                                                                                                  ");
                Console.WriteLine("                                                                                                                               |\\**/|                                                                            ");
                Console.WriteLine("                                                                            |\\**/|                                             \\ == /                                                                           ");
                Console.WriteLine("                                                                            \\ == /                                              |  |                                                                             ");
                Console.WriteLine("                                     |\\**/|                                  |  |                                               |  |                                                                             ");
                Console.WriteLine("                                     \\ == /                                  |  |                                              \\    /                                                                           ");
                Console.WriteLine("                                      |  |                                  \\    /                                              \\  /                                                                            ");
                Console.WriteLine("                                      |  |                                   \\  /                                                ||                                                                              ");
                Console.WriteLine("                                     \\   /                                    ||                                                                                                                                 ");
                Console.WriteLine("                                      \\ /                          )___(                                                                                            )___("                                        );
                Console.WriteLine("                                       |                     _______/__/_                                                                                     _______/__/_"                                        );
                Console.WriteLine("                                                __    _     /===========|                                                                            ___     /===========|  "                                      );
                Console.WriteLine("                                   ____       __   [\\]___/____________|__[///]                                                     ____       __   [\\ ]___/____________|__[///]|"                                );
                Console.WriteLine("                                \\   \\_____[\\]__/___________________________\\__[//]__                                    \\   \\_____[\\]__/___________________________\\__[//]"                                );
                Console.WriteLine("                                 \\40A                                                |                                   \\40A                                                |"                                  );
                Console.WriteLine("                                  \\                                                 /                                     \\                                                 /"                                   );
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                
                // Intro and manu.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\n                                                                                        WELCOME TO THE TRIANGLE BATTLEHIP!                                                                                        ");
                Console.WriteLine("                                                                              ----->>>>> TRIANGLE BATTLESHIP IS STARTING <<<<<-----                                                                               ");
                Console.WriteLine("                                                                        The 3 points you will enter will be the corner points of your ship.                                                                       ");
                Console.WriteLine("                                                       Abscissa points must be between 0-30 and be integer; ordinate points must be between 0-12 and be integer.!                                                 ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n\n\n                                                                                        PLEASE SELECT FROM THE OPTIONS BELOW:\n                                                                                        1- Enter the ship location.\n                                                                                        2- Ship info.\n                                                                                        3- shoot at the ship\n                                                                                        4- Show high score table.\n                                                                                        5- Exit.");
                Console.WriteLine("                                                                                        Write an options number 1-5");
                Console.SetCursorPosition(92, 72);
                string select_options = Console.ReadLine();

                // If information about the ship is requested before the ship's points are determined, or if it is desired to shoot at the ship, it is requested to enter the ship points.
                if (select_options == "2" || select_options == "3")
                {
                    Console.WriteLine("                                                                 In order to get ship info or shoot at to ship, you must first enter the coordinates!");
                    Console.WriteLine("                                                                 Do you want to go menu? If you want, please press \"y\"");
                    Console.SetCursorPosition(88, 45);
                    string want_go_menu = Console.ReadLine();
                    if (want_go_menu == "y")
                    {
                        select_options = "1";
                    }
                    else
                    {
                        Console.WriteLine("Triangle Battleship closed...");
                        i += 1;
                    }
                }
                else
                {

                    // Loop that will cause the game to close.
                    Console.Clear();
                    int k = 0;
                    while (k < 1)
                    {

                        // Code block that will run if 1 option is selected from the menu.
                        if (select_options == "1")
                        {

                            // Loops that check if points are in the correct range.
                            Console.Clear();
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the first coordinate's abscissa: ");
                                Ax = Convert.ToInt16(Console.ReadLine());
                                if (Ax <= 30 && 0 < Ax)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 30. Please re-enter the first abscissa.");
                                }
                            }
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the first coordinate's ordinate: ");
                                Ay = Convert.ToInt16(Console.ReadLine());
                                if (Ay <= 12 && 0 < Ay)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 12. Please re-enter the first ordinate.");
                                }
                            }
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the second coordinate's abscissa: ");
                                Bx = Convert.ToInt16(Console.ReadLine());
                                if (Bx <= 30 && 0 < Bx)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 30. Please re-enter the second abscissa.");
                                }
                            }
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the second coordinate's ordinate: ");
                                By = Convert.ToInt16(Console.ReadLine());
                                if (By <= 12 && 0 < By)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 12. Please re-enter the second ordinate.");
                                }
                            }
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the third coordinate's abscissa: ");
                                Cx = Convert.ToInt16(Console.ReadLine());
                                if (Cx <= 30 && 0 < Cx)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 30. Please re-enter the third abscissa.");
                                }
                            }
                            i = 0;
                            while (i < 1)
                            {
                                Console.WriteLine("Please enter the third coordinate's ordinate: ");
                                Cy = Convert.ToInt16(Console.ReadLine());
                                if (Cy <= 12 && 0 < Cy)
                                {
                                    Console.WriteLine("The point you entered is in the correct field.");
                                    i += 1;
                                }
                                else
                                {
                                    Console.WriteLine("The point you entered is out of range. The point must be between in 0 and 12. Please re-enter the third ordinate.");
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("The points you entered: A(" + Ax + "," + Ay + ")" + "," + " B(" + Bx + "," + By + ")" + "," + " C(" + Cx + "," + Cy + ")");

                            // Block that checks if the points form a triangle.
                            if (Cy - By / Cx - Bx == By - Ay / Bx - Ax || Ax == Bx && Ay == By || Ax == Cx && Ay == Cy || Bx == Cx && By == Cy)
                            {
                                Console.WriteLine("The coordinates you have entered are not from a triangle. Please re-enter the coordinates.");
                                select_options = "1";
                            }
                            else
                            {

                                // Block that prints the coordinate plane.
                                Console.WriteLine("The appearance of the coordinates you entered in the coordinate plane is as follows.\n");
                                string coordinate_plane = " 12|                              \n 11|                              \n 10|                              \n  9|                              \n  8|                              \n  7|                              \n  6|                              \n  5|                              \n  4|                              \n  3|                              \n  2|                              \n  1|                              \n --+------------------------------\n   |123456789012345678901234567890\n";
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(coordinate_plane);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(4, 3);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 4);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 5);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 6);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 7);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 8);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 9);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 10);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 11);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 12);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 13);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 14);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition((int)(3 + Ax), (int)(15 - Ay));
                                Console.WriteLine("A");
                                Console.SetCursorPosition((int)(3 + Bx), (int)(15 - By));
                                Console.WriteLine("B");
                                Console.SetCursorPosition((int)(3 + Cx), (int)(15 - Cy));
                                Console.WriteLine("C");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 18);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("What do you want to do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- Shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_one = Console.ReadLine();
                                select_options = select_number_one;
                            }
                        }

                        // code block that will run if 2 option is selected from the menu.
                        else if (select_options == "2")
                        {

                            // Block that prevents requesting ship info without entering points after going to the leaderboard.
                            if (Ax == -1 && Ay == -1 && Bx == -1 && By == -1 && Cx == -1 && Cy == -1)
                            {
                                Console.WriteLine("First, you need to enter coordianates. If you want to enter coordinates, please press \"y\": ");
                                string want_enter = Console.ReadLine();
                                if (want_enter == "y")
                                {
                                    select_options = "1";
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 0);
                                Console.WriteLine("The points you entered: A(" + Ax + "," + Ay + ")" + "," + " B(" + Bx + "," + By + ")" + "," + " C(" + Cx + "," + Cy + ")");
                                Console.WriteLine("The appearance of the coordinates you entered in the coordinate plane is as follows.\n");
                                string coordinate_plane = " 12|                              \n 11|                              \n 10|                              \n  9|                              \n  8|                              \n  7|                              \n  6|                              \n  5|                              \n  4|                              \n  3|                              \n  2|                              \n  1|                              \n --+------------------------------\n   |123456789012345678901234567890\n";
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(coordinate_plane);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(4, 3);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 4);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 5);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 6);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 7);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 8);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 9);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 10);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 11);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 12);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 13);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 14);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition((int)(3 + Ax), (int)(15 - Ay));
                                Console.WriteLine("A");
                                Console.SetCursorPosition((int)(3 + Bx), (int)(15 - By));
                                Console.WriteLine("B");
                                Console.SetCursorPosition((int)(3 + Cx), (int)(15 - Cy));
                                Console.WriteLine("C");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 18);

                                // Block that calculates ship data.
                                double size_a = Math.Sqrt(((Cx - Bx) * (Cx - Bx)) + ((Cy - By) * (Cy - By)));
                                double size_b = Math.Sqrt(((Cx - Ax) * (Cx - Ax)) + ((Cy - Ay) * (Cy - Ay)));
                                double size_c = Math.Sqrt(((Ax - Bx) * (Ax - Bx)) + ((Ay - By) * (Ay - By)));
                                double perimeter = size_a + size_b + size_c;
                                double angle_A = (Math.Acos((((size_b * size_b) + (size_c * size_c) - (size_a * size_a)) / (2 * size_b * size_c)))) * 180 / Math.PI;
                                double angle_B = (Math.Acos((((size_a * size_a) + (size_c * size_c) - (size_b * size_b)) / (2 * size_a * size_c)))) * 180 / Math.PI;
                                double angle_C = (Math.Acos((((size_a * size_a) + (size_b * size_b) - (size_c * size_c)) / (2 * size_a * size_b)))) * 180 / Math.PI;
                                double area_ship = 0.5 * size_a * size_b * Math.Sin(angle_C * Math.PI / 180);
                                double median_ax = (Bx + Cx) / 2;
                                double median_ay = (By + Cy) / 2;
                                double median_bx = (Ax + Cx) / 2;
                                double median_by = (Ay + Cy) / 2;
                                double median_cx = (Ax + Bx) / 2;
                                double median_cy = (Ay + By) / 2;
                                double centroid_ship_x = (Ax + Bx + Cx) / 3;
                                double centroid_ship_y = (Ay + By + Cy) / 3;
                                double side_b_bisector = Math.Round(((size_a * size_b) / (size_c + size_b)), 4);
                                double side_c_bisector = Math.Round((size_a - side_b_bisector), 4);
                                double interior_angle_bisector_lenght = Math.Sqrt((size_c * size_b) - (side_b_bisector * side_c_bisector));
                                double c_to_exterior_bisector = (size_a * size_b) / (size_c - size_b);
                                double exterior_angle_bisector_lenght = Math.Sqrt((c_to_exterior_bisector * (c_to_exterior_bisector + size_a)) - (size_b * size_c));
                                double radius_of_tangent_circle = area_ship / (perimeter / 2);
                                double area_of_tangent_circle = Math.PI * radius_of_tangent_circle * radius_of_tangent_circle;
                                double radius_of_outer_tangent_circle = size_a * size_b * size_c / area_ship / 4;
                                double area_of_outer_tangent_circle = Math.PI * radius_of_outer_tangent_circle * radius_of_outer_tangent_circle;

                                // Block that prints the ship's data.
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("=> Lenght of side |BC|= " + Math.Round((size_a), 2));
                                Console.WriteLine("=> Lenght of side |AC|= " + Math.Round((size_b), 2));
                                Console.WriteLine("=> Lenght od side |AB|= " + Math.Round((size_c), 2));
                                Console.WriteLine("=> Perimeter of the ship = " + Math.Round((perimeter), 2));
                                Console.WriteLine("=> The area of ship = " + Math.Round((area_ship), 2));
                                Console.WriteLine("=> The angle A is = " + Math.Round((angle_A), 2));
                                Console.WriteLine("=> The angle B is = " + Math.Round((angle_B), 2));
                                Console.WriteLine("=> The angle C is = " + Math.Round((angle_C), 2));
                                Console.WriteLine("=> The median point of a = (" + median_ax + "," + median_ay + ")");
                                Console.WriteLine("=> The median point of b = (" + median_bx + "," + median_by + ")");
                                Console.WriteLine("=> The median point of c = (" + median_cx + "," + median_cy + ")");
                                Console.WriteLine("=> The centroid of the ship = (" + Math.Round((centroid_ship_x), 2) + "," + Math.Round((centroid_ship_y), 2) + ")");
                                Console.WriteLine("=> Lenght of the interior bisector = (" + Math.Round((interior_angle_bisector_lenght), 2) + ")");
                                if (angle_A != 60)
                                {
                                    Console.WriteLine("=> Lenght of the exterior bisector = (" + Math.Round(exterior_angle_bisector_lenght) + ")");
                                }
                                Console.WriteLine("=> Area of tangent circle = " + Math.Round(area_of_tangent_circle, 2));
                                Console.WriteLine("=> Area of outer tangent circle = " + Math.Round(area_of_outer_tangent_circle, 2));
                                if (size_a == size_b && size_a == size_c)
                                {
                                    Console.WriteLine("=> The ship is a equilateral triangle.");
                                }
                                if (size_a == size_b && size_b != size_c || size_a == size_c && size_a != size_b || size_b == size_c && size_b != size_a)
                                {
                                    Console.WriteLine("=> The ship is a isosceles triangle.");
                                }
                                if (size_a != size_b && size_b != size_c && size_a != size_c)
                                {
                                    Console.WriteLine("=> The ship is a scalene triangle.");
                                }
                                if (angle_A == 90 || angle_B == 90 || angle_C == 90)
                                {
                                    Console.WriteLine("=> The ship is a right angled triangle.");
                                }
                                if (angle_A < 90 && angle_B < 90 && angle_C < 90)
                                {
                                    Console.WriteLine("=> The ship is a acute angled triangle.");
                                }
                                if (angle_A > 90 || angle_B > 90 || angle_C > 90)
                                {
                                    Console.WriteLine("=> The ship is a abtuse angled triangle.\n");
                                }
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("What do you want to do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- Shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_two = Console.ReadLine();
                                select_options = select_number_two;
                            }
                        }

                        // Code block that will run if 3 option is selected from the menu.
                        else if (select_options == "3")
                        {

                            // Block from being fired without entering the points after going to the leaderboard.
                            if (Ax == -1 && Ay == -1 && Bx == -1 && By == -1 && Cx == -1 && Cy == -1)
                            {
                                Console.WriteLine("First, you need to enter coordianates. If you want to enter coordinates, please press \"y\": ");
                                string want_enter = Console.ReadLine();
                                if (want_enter == "y")
                                {
                                    select_options = "1";
                                }
                            }
                            else
                            {

                                // Block showing the ship and the place where the bomb fell.
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 0);
                                Console.WriteLine("The points you entered: A(" + Ax + "," + Ay + ")" + "," + " B(" + Bx + "," + By + ")" + "," + " C(" + Cx + "," + Cy + ")");
                                Console.WriteLine("The appearance of the coordinates you entered in the coordinate plane is as follows.\n");
                                string coordinate_plane = " 12|                              \n 11|                              \n 10|                              \n  9|                              \n  8|                              \n  7|                              \n  6|                              \n  5|                              \n  4|                              \n  3|                              \n  2|                              \n  1|                              \n --+------------------------------\n   |123456789012345678901234567890\n";
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(coordinate_plane);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(4, 3);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 4);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 5);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 6);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 7);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 8);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 9);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 10);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 11);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 12);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 13);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.SetCursorPosition(4, 14);
                                Console.WriteLine("._.-._.-._.-._.-._.-._.-._.-._");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition((int)(3 + Ax), (int)(15 - Ay));
                                Console.WriteLine("A");
                                Console.SetCursorPosition((int)(3 + Bx), (int)(15 - By));
                                Console.WriteLine("B");
                                Console.SetCursorPosition((int)(3 + Cx), (int)(15 - Cy));
                                Console.WriteLine("C");
                                Console.SetCursorPosition(0, 19);
                                Random shoot = new Random();
                                int shoot_x = shoot.Next(0, 31);
                                int shoot_y = shoot.Next(0, 13);
                                Console.SetCursorPosition((int)(3 + shoot_x), (int)(15 - shoot_y));
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("X");
                                Console.SetCursorPosition(0, 18);
                                Console.ForegroundColor = ConsoleColor.Black;

                                // Block that checks if the ship has been hit.
                                double Area_ship = Math.Abs((Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2.0);
                                double Area_BC = Math.Abs((shoot_x * (By - Cy) + Bx * (Cy - shoot_y) + Cx * (shoot_y - By)) / 2.0);
                                double Area_AC = Math.Abs((Ax * (shoot_y - Cy) + shoot_x * (Cy - Ay) + Cx * (Ay - shoot_y)) / 2.0);
                                double Area_AB = Math.Abs((Ax * (By - shoot_y) + Bx * (shoot_y - Ay) + shoot_x * (Ay - By)) / 2.0);
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Area_ship != Area_AB + Area_AC + Area_BC)
                                {

                                    // If the ship survived, the player name is taken and shown on the scoreboard.
                                    Console.WriteLine("Your ship survived. Please enter your name / nickname: ");
                                    player_name_or_nickname = Console.ReadLine();
                                    score = Area_ship;
                                    if (score >= 60)
                                    {
                                        Console.WriteLine("HIGH SCORE TABLE:\n     Name                   Score\n\n");
                                        int a = 0;
                                        Console.Write(player_name_or_nickname);
                                        for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(score + "\n");
                                        Console.WriteLine("Nazan Kaya                  60\nAli Kurt                    30\n");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\nWhat do you want do do now?");
                                        Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                        Console.WriteLine("Enter an option number: ");
                                        string select_number_three = Console.ReadLine();
                                        select_options = select_number_three;
                                    }
                                    else if (60 > score && score >= 30)
                                    {
                                        Console.WriteLine("HIGH SCORE TABLE:\n    Name                  Score\n\nNazan Kaya                  60");
                                        int a = 0;
                                        Console.Write(player_name_or_nickname);
                                        for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(score);
                                        Console.WriteLine("\nAli Kurt                    30\n");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\nWhat do you want do do now?");
                                        Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                        Console.WriteLine("Enter an option number: ");
                                        string select_number_three = Console.ReadLine();
                                        select_options = select_number_three;
                                    }
                                    else if (30 > score && score >= 24)
                                    {
                                        Console.WriteLine("HIGH SCORE TABLE:\n     Name                  Score\n\nNazan Kaya                  60\nAli Kurt                    30");
                                        int a = 0;
                                        Console.Write(player_name_or_nickname);
                                        for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(score);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\nWhat do you want do do now?");
                                        Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                        Console.WriteLine("Enter an option number: ");
                                        string select_number_three = Console.ReadLine();
                                        select_options = select_number_three;
                                    }
                                    else
                                    {
                                        Console.WriteLine("HIGH SCORE TABLE:\n     Name                   Score\n\nNazan Kaya                  60\nAli Kurt                    30\nElif Polat                  24");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\nWhat do you want do do now?");
                                        Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                        Console.WriteLine("Enter an option number: ");
                                        string select_number_three = Console.ReadLine();
                                        select_options = select_number_three;
                                    }
                                }
                                else
                                {

                                    // Block asking if you want to play again if the ship has sunk.
                                    Console.WriteLine("Your ship sanked. Your score is \"0\". If you want to play again, please press y?");
                                    string play_again = Console.ReadLine();
                                    if (play_again == "y")
                                    {
                                        select_options = "1";
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\nWhat do you want do do now?");
                                        Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                        Console.WriteLine("Enter an option number: ");
                                        string select_number_three = Console.ReadLine();
                                        select_options = select_number_three;
                                    }
                                    else
                                    {
                                        select_options = "5";

                                    }
                                }
                            }
                        }

                        // Code block that will run if 4 option is selected from the menu.
                        else if (select_options == "4")
                        {

                            // The block on which the scoreboard is printed.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            if (score >= 60)
                            {
                                Console.WriteLine("HIGH SCORE TABLE:\n     Name                   Score\n\n");
                                int a = 0;
                                Console.Write(player_name_or_nickname);
                                for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(score + "\n");
                                Console.WriteLine("Nazan Kaya                  60\nAli Kurt                    30\n");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\nWhat do you want do do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_three = Console.ReadLine();
                                select_options = select_number_three;
                            }
                            else if (60 > score && score >= 30)
                            {
                                Console.WriteLine("HIGH SCORE TABLE:\n\n     Name                  Score\n\nNazan Kaya                  60");
                                int a = 0;
                                Console.Write(player_name_or_nickname);
                                for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(score);
                                Console.WriteLine("\nAli Kurt                    30\n");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\nWhat do you want do do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_three = Console.ReadLine();
                                select_options = select_number_three;
                            }
                            else if (30 > score && score >= 24)
                            {
                                Console.WriteLine("HIGH SCORE TABLE:\n\n     Name                   Score\n\nNazan Kaya                  60\nAli Kurt                    30");
                                int a = 0;
                                Console.Write(player_name_or_nickname);
                                for (a = 0; a < 28 - player_name_or_nickname.Length; a++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(score);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\nWhat do you want do do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_three = Console.ReadLine();
                                select_options = select_number_three;
                            }
                            else
                            {
                                Console.WriteLine("HIGH SCORE TABLE:\n\n     Name                   Score\n\nNazan Kaya                  60\nAli Kurt                    30\nElif Polat                  24");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\nWhat do you want do do now?");
                                Console.WriteLine("1- Enter the ship location.\n2- Ship info.\n3- shoot at the ship\n4- Show high score table.\n5- Exit.");
                                Console.WriteLine("Enter an option number: ");
                                string select_number_three = Console.ReadLine();
                                select_options = select_number_three;
                            }
                        }

                        // Code block that will run if 5 option is selected from the menu. 
                        else if (select_options == "5")
                        {

                            // Block that closes the application and suppresses this information.
                            Console.WriteLine("\nTriangle Battleship is closed...");
                            i += 1;
                            k += 1;
                        }
                    }
                }
            }
        }
    }
}

