using System;

namespace Calendar.Work
{
    class Program
    {
        static void Main(string[] args)
        {

            string the_first_month = "";
            int first_month_number = 0;
            string the_second_month = "";
            int second_month_number = 0;
            int day_of_the_first_date = 0;
            int first_year = 0;
            int second_year = 0;
            int day_of_the_second_date = 0;

            // Block where first date is taken and checked.
            int i = 0;
            int z = 0;
            int w = 0;
            int q = 0;
            while (i < 1)
            {
                i = 0;
                w = 0;
                z = 0;
                q = 0;
                while (z < 1)
                {
                    Console.WriteLine("Enter the first mounth of the first date: ");
                    the_first_month = Console.ReadLine();
                    the_first_month.ToLower();
                    if (the_first_month == "january")
                    {
                        first_month_number = 1;
                        z++;
                    }
                    else if (the_first_month == "february")
                    {
                        first_month_number = 2;
                        z++;
                    }
                    else if (the_first_month == "march")
                    {
                        first_month_number = 3;
                        z++;
                    }
                    else if (the_first_month == "april")
                    {
                        first_month_number = 4;
                        z++;
                    }
                    else if (the_first_month == "may")
                    {
                        first_month_number = 5;
                        z++;
                    }
                    else if (the_first_month == "june")
                    {
                        first_month_number = 6;
                        z++;
                    }
                    else if (the_first_month == "july")
                    {
                        first_month_number = 7;
                        z++;
                    }
                    else if (the_first_month == "august")
                    {
                        first_month_number = 8;
                        z++;
                    }
                    else if (the_first_month == "september")
                    {
                        first_month_number = 9;
                        z++;
                    }
                    else if (the_first_month == "october")
                    {
                        first_month_number = 10;
                        z++;
                    }
                    else if (the_first_month == "november")
                    {
                        first_month_number = 11;
                        z++;
                    }
                    else if (the_first_month == "december")
                    {
                        first_month_number = 12;
                        z++;
                    }
                    else if (first_month_number == 0)
                    {
                        Console.WriteLine("You entered the month incorrectly, please re-enter.");
                    }
                }
                Console.WriteLine("Enter the number of the first day of the first date: ");
                day_of_the_first_date = Convert.ToInt32(Console.ReadLine());
                while (w < 1)
                {


                    if (first_month_number == 1 || first_month_number == 3 || first_month_number == 5 || first_month_number == 7 || first_month_number == 8 || first_month_number == 10 || first_month_number == 12)
                    {
                        if (day_of_the_first_date > 31 || 1 > day_of_the_first_date)
                        {
                            Console.WriteLine("In " + the_first_month + ", the day must be between 0 and 32, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the first date: ");
                            day_of_the_first_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (first_month_number == 4 || first_month_number == 6 || first_month_number == 9 || first_month_number == 11)
                    {
                        if (day_of_the_first_date > 30 || 1 > day_of_the_first_date)
                        {
                            Console.WriteLine("In " + the_first_month + ", the day must be between 0 and 31, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the first date: ");
                            day_of_the_first_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (first_month_number == 2 && first_year % 4 == 0)
                    {
                        if (day_of_the_first_date > 29 || 1 > day_of_the_first_date)
                        {
                            Console.WriteLine("In " + the_first_month + ", the day must be between 0 and 30, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the first date: ");
                            day_of_the_first_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (first_month_number == 2 && first_year % 4 != 0)
                    {
                        if (day_of_the_first_date > 28 || 1 > day_of_the_first_date)
                        {
                            Console.WriteLine("In " + the_first_month + ", the day must be between 0 and 29, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the first date: ");
                            day_of_the_first_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                }
                Console.WriteLine("Enter the first year: ");
                first_year = Convert.ToInt32(Console.ReadLine());
                while (q < 1)
                {
                    if (first_year < 2015)
                    {
                        Console.WriteLine("The year must be greater than 2014.");
                        Console.WriteLine("Enter the first year: ");
                        first_year = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        q++;
                        i++;
                    }
                }
            }

            // Block where second date is taken and checked.
            i = 0;
            z = 0;
            w = 0;
            q = 0;
            while (i < 1)
            {
                i = 0;
                w = 0;
                z = 0;
                q = 0;
                while (z < 1)
                {
                    Console.WriteLine("Enter the first mounth of the second date: ");
                    the_second_month = Console.ReadLine();
                    the_second_month.ToLower();
                    if (the_second_month == "january")
                    {
                        second_month_number = 1;
                        z++;
                    }
                    else if (the_second_month == "february")
                    {
                        second_month_number = 2;
                        z++;
                    }
                    else if (the_second_month == "march")
                    {
                        second_month_number = 3;
                        z++;
                    }
                    else if (the_second_month == "april")
                    {
                        second_month_number = 4;
                        z++;
                    }
                    else if (the_second_month == "may")
                    {
                        second_month_number = 5;
                        z++;
                    }
                    else if (the_second_month == "june")
                    {
                        second_month_number = 6;
                        z++;
                    }
                    else if (the_second_month == "july")
                    {
                        second_month_number = 7;
                        z++;
                    }
                    else if (the_second_month == "august")
                    {
                        second_month_number = 8;
                        z++;
                    }
                    else if (the_second_month == "september")
                    {
                        second_month_number = 9;
                        z++;
                    }
                    else if (the_second_month == "october")
                    {
                        second_month_number = 10;
                        z++;
                    }
                    else if (the_second_month == "november")
                    {
                        second_month_number = 11;
                        z++;
                    }
                    else if (the_second_month == "december")
                    {
                        second_month_number = 12;
                        z++;
                    }
                    else if (second_month_number == 0)
                    {
                        Console.WriteLine("You entered the month incorrectly, please re-enter.");
                    }
                }
                Console.WriteLine("Enter the number of the day of the second date: ");
                day_of_the_second_date = Convert.ToInt32(Console.ReadLine());
                while (w < 1)
                {


                    if (second_month_number == 1 || second_month_number == 3 || second_month_number == 5 || second_month_number == 7 || second_month_number == 8 || second_month_number == 10 || second_month_number == 12)
                    {
                        if (day_of_the_second_date > 31 || 1 > day_of_the_second_date)
                        {
                            Console.WriteLine("In " + the_second_month + ", the day must be between 0 and 32, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the second date: ");
                            day_of_the_second_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (second_month_number == 4 || second_month_number == 6 || second_month_number == 9 || second_month_number == 11)
                    {
                        if (day_of_the_second_date > 30 || 1 > day_of_the_second_date)
                        {
                            Console.WriteLine("In " + the_second_month + ", the day must be between 0 and 31, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the second date: ");
                            day_of_the_second_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (second_month_number == 2 && second_year % 4 == 0)
                    {
                        if (day_of_the_second_date > 29 || 1 > day_of_the_second_date)
                        {
                            Console.WriteLine("In " + the_second_month + ", the day must be between 0 and 30, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the second date: ");
                            day_of_the_second_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                    else if (second_month_number == 2 && second_year % 4 != 0)
                    {
                        if (day_of_the_second_date > 28 || 1 > day_of_the_second_date)
                        {
                            Console.WriteLine("In " + the_second_month + ", the day must be between 0 and 29, please re-enter.");
                            Console.WriteLine("Enter the number of the first day of the second date: ");
                            day_of_the_second_date = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            w++;
                        }
                    }
                }
                Console.WriteLine("Enter the second year: ");
                second_year = Convert.ToInt32(Console.ReadLine());
                while (q < 1)
                {
                    if (second_year < 2015)
                    {
                        Console.WriteLine("The year must be greater than 2014.");
                        Console.WriteLine("Enter the second year: ");
                        second_year = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        q++;
                        i++;
                    }
                }
            }


            // Block where the first date is after the second date.
            if (first_year > second_year)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int temp_day = 0;
                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;
                while (second_year <= first_year)
                {
                    // Block with transactions to be made until the years are equalized.
                    if (second_year < first_year)
                    {
                        if (second_month_number < 13)
                        {
                            // Block that prints which season it is.
                            if (second_month_number == 1 || second_month_number == 2 || second_month_number == 12)
                            {
                                if (winter % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Winter ");
                                    winter = 0;
                                }
                                winter++;
                            }
                            else if (second_month_number == 3 || second_month_number == 4 || second_month_number == 5)
                            {
                                if (spring % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Spring ");
                                    spring = 0;
                                }
                                spring++;

                            }
                            else if (second_month_number == 6 || second_month_number == 7 || second_month_number == 8)
                            {
                                if (summer % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Summer ");
                                    summer = 0;
                                }
                                summer++;
                            }
                            else if (second_month_number == 9 || second_month_number == 10 || second_month_number == 11)
                            {
                                if (autumn % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Autumn ");
                                    autumn = 0;
                                }
                                autumn++;
                            }
                            // Blocks in which the number of days of the month is determined.
                            if (second_month_number == 1 || second_month_number == 3 || second_month_number == 5 || second_month_number == 7 || second_month_number == 8 || second_month_number == 10 || second_month_number == 12)
                            {
                                temp_day = 31;
                            }
                            else if (second_month_number == 4 || second_month_number == 6 || second_month_number == 9 || second_month_number == 11)
                            {
                                temp_day = 30;
                            }
                            else
                            {
                                if (second_year % 4 == 0)
                                {
                                    temp_day = 29;
                                }
                                else
                                {
                                    temp_day = 28;
                                }
                            }
                            // Block of which month it is printed.
                            while (day_of_the_second_date <= temp_day)
                            {
                                Console.Write(day_of_the_second_date);
                                if (second_month_number == 1)
                                {
                                    Console.Write(" January ");
                                }
                                else if (second_month_number == 2)
                                {
                                    Console.Write(" February ");
                                }
                                else if (second_month_number == 3)
                                {
                                    Console.Write(" March ");
                                }
                                else if (second_month_number == 4)
                                {
                                    Console.Write(" April ");
                                }
                                else if (second_month_number == 5)
                                {
                                    Console.Write(" May ");
                                }
                                else if (second_month_number == 6)
                                {
                                    Console.Write(" June ");
                                }
                                else if (second_month_number == 7)
                                {
                                    Console.Write(" July ");
                                }
                                else if (second_month_number == 8)
                                {
                                    Console.Write(" August ");
                                }
                                else if (second_month_number == 9)
                                {
                                    Console.Write(" Sptember ");
                                }
                                else if (second_month_number == 10)
                                {
                                    Console.Write(" October ");
                                }
                                else if (second_month_number == 11)
                                {
                                    Console.Write(" November ");
                                }
                                else if (second_month_number == 12)
                                {
                                    Console.Write(" December ");
                                }
                                Console.Write(second_year);
                                // Block that finds which day the date falls on.
                                if (second_month_number == 1 || second_month_number == 2)
                                {
                                    int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                    if (number_of_second_day == 0)
                                    {
                                        string second_day = " Saturday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 1)
                                    {
                                        string second_day = " Sunday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 2)
                                    {
                                        string second_day = " Monday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 3)
                                    {
                                        string second_day = " Tuesday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 4)
                                    {
                                        string second_day = " Wednasday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 5)
                                    {
                                        string second_day = " Thursday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 6)
                                    {
                                        string second_day = " Friday";
                                        Console.WriteLine(second_day);
                                    }
                                }
                                else
                                {
                                    int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                    if (number_of_second_day == 0)
                                    {
                                        string second_day = " Saturday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 1)
                                    {
                                        string second_day = " Sunday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 2)
                                    {
                                        string second_day = " Monday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 3)
                                    {
                                        string second_day = " Tuesday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 4)
                                    {
                                        string second_day = " Wednasday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 5)
                                    {
                                        string second_day = " Thursday";
                                        Console.WriteLine(second_day);
                                    }
                                    else if (number_of_second_day == 6)
                                    {
                                        string second_day = " Friday";
                                        Console.WriteLine(second_day);
                                    }
                                }
                                day_of_the_second_date += amount_of_increase;
                            }
                            day_of_the_second_date -= temp_day;
                            second_month_number += 1;
                        }
                    }
                    // Block with the transactions that need to be done when the years are equalized.
                    else if (second_year == first_year)
                    {
                        while (second_month_number <= first_month_number)
                        {
                            // Block that prints which season it is.
                            if (second_month_number == 1 || second_month_number == 2 || second_month_number == 12)
                            {
                                if (winter % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Winter ");
                                    winter = 0;
                                }
                                winter++;
                            }
                            else if (second_month_number == 3 || second_month_number == 4 || second_month_number == 5)
                            {
                                if (spring % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Spring ");
                                    spring = 0;
                                }
                                spring++;

                            }
                            else if (second_month_number == 6 || second_month_number == 7 || second_month_number == 8)
                            {
                                if (summer % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Summer ");
                                    summer = 0;
                                }
                                summer++;
                            }
                            else if (second_month_number == 9 || second_month_number == 10 || second_month_number == 11)
                            {
                                if (autumn % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Autumn ");
                                    autumn = 0;
                                }
                                autumn++;
                            }
                            // Blocks in which the number of days of the month is determined.
                            if (second_month_number == 1 || second_month_number == 3 || second_month_number == 5 || second_month_number == 7 || second_month_number == 8 || second_month_number == 10 || second_month_number == 12)
                            {
                                temp_day = 31;
                            }
                            else if (second_month_number == 4 || second_month_number == 6 || second_month_number == 9 || second_month_number == 11)
                            {
                                temp_day = 30;
                            }
                            else
                            {
                                if (second_year % 4 == 0)
                                {
                                    temp_day = 29;
                                }
                                else
                                {
                                    temp_day = 28;
                                }
                            }
                            if (first_month_number != second_month_number)
                            {
                                while (day_of_the_second_date <= temp_day)
                                {
                                    // Block of which month it is printed.
                                    Console.Write(day_of_the_second_date);
                                    if (second_month_number == 1)
                                    {
                                        Console.Write(" January ");
                                    }
                                    else if (second_month_number == 2)
                                    {
                                        Console.Write(" February ");
                                    }
                                    else if (second_month_number == 3)
                                    {
                                        Console.Write(" March ");
                                    }
                                    else if (second_month_number == 4)
                                    {
                                        Console.Write(" April ");
                                    }
                                    else if (second_month_number == 5)
                                    {
                                        Console.Write(" May ");
                                    }
                                    else if (second_month_number == 6)
                                    {
                                        Console.Write(" June ");
                                    }
                                    else if (second_month_number == 7)
                                    {
                                        Console.Write(" July ");
                                    }
                                    else if (second_month_number == 8)
                                    {
                                        Console.Write(" August ");
                                    }
                                    else if (second_month_number == 9)
                                    {
                                        Console.Write(" Sptember ");
                                    }
                                    else if (second_month_number == 10)
                                    {
                                        Console.Write(" October ");
                                    }
                                    else if (second_month_number == 11)
                                    {
                                        Console.Write(" November ");
                                    }
                                    else if (second_month_number == 12)
                                    {
                                        Console.Write(" December ");
                                    }
                                    Console.Write(second_year);
                                    // Block that finds which day the date falls on.
                                    if (second_month_number == 1 || second_month_number == 2)
                                    {
                                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                        if (number_of_second_day == 0)
                                        {
                                            string second_day = " Saturday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 1)
                                        {
                                            string second_day = " Sunday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 2)
                                        {
                                            string second_day = " Monday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 3)
                                        {
                                            string second_day = " Tuesday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 4)
                                        {
                                            string second_day = " Wednasday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 5)
                                        {
                                            string second_day = " Thursday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 6)
                                        {
                                            string second_day = " Friday";
                                            Console.WriteLine(second_day);
                                        }
                                    }
                                    else
                                    {
                                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                        if (number_of_second_day == 0)
                                        {
                                            string second_day = " Saturday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 1)
                                        {
                                            string second_day = " Sunday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 2)
                                        {
                                            string second_day = " Monday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 3)
                                        {
                                            string second_day = " Tuesday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 4)
                                        {
                                            string second_day = " Wednasday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 5)
                                        {
                                            string second_day = " Thursday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 6)
                                        {
                                            string second_day = " Friday";
                                            Console.WriteLine(second_day);
                                        }
                                    }
                                    day_of_the_second_date += amount_of_increase;
                                }
                            }
                            else
                            {
                                while (day_of_the_second_date <= day_of_the_first_date)
                                {
                                    // Block of which month it is printed.
                                    Console.Write(day_of_the_second_date);
                                    if (second_month_number == 1)
                                    {
                                        Console.Write(" January ");
                                    }
                                    else if (second_month_number == 2)
                                    {
                                        Console.Write(" February ");
                                    }
                                    else if (second_month_number == 3)
                                    {
                                        Console.Write(" March ");
                                    }
                                    else if (second_month_number == 4)
                                    {
                                        Console.Write(" April ");
                                    }
                                    else if (second_month_number == 5)
                                    {
                                        Console.Write(" May ");
                                    }
                                    else if (second_month_number == 6)
                                    {
                                        Console.Write(" June ");
                                    }
                                    else if (second_month_number == 7)
                                    {
                                        Console.Write(" July ");
                                    }
                                    else if (second_month_number == 8)
                                    {
                                        Console.Write(" August ");
                                    }
                                    else if (second_month_number == 9)
                                    {
                                        Console.Write(" Sptember ");
                                    }
                                    else if (second_month_number == 10)
                                    {
                                        Console.Write(" October ");
                                    }
                                    else if (second_month_number == 11)
                                    {
                                        Console.Write(" November ");
                                    }
                                    else if (second_month_number == 12)
                                    {
                                        Console.Write(" December ");
                                    }
                                    Console.Write(second_year);
                                    // Block that finds which day the date falls on.
                                    if (second_month_number == 1 || second_month_number == 2)
                                    {
                                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                        if (number_of_second_day == 0)
                                        {
                                            string second_day = " Saturday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 1)
                                        {
                                            string second_day = " Sunday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 2)
                                        {
                                            string second_day = " Monday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 3)
                                        {
                                            string second_day = " Tuesday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 4)
                                        {
                                            string second_day = " Wednasday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 5)
                                        {
                                            string second_day = " Thursday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 6)
                                        {
                                            string second_day = " Friday";
                                            Console.WriteLine(second_day);
                                        }
                                    }
                                    else
                                    {
                                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                        if (number_of_second_day == 0)
                                        {
                                            string second_day = " Saturday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 1)
                                        {
                                            string second_day = " Sunday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 2)
                                        {
                                            string second_day = " Monday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 3)
                                        {
                                            string second_day = " Tuesday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 4)
                                        {
                                            string second_day = " Wednasday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 5)
                                        {
                                            string second_day = " Thursday";
                                            Console.WriteLine(second_day);
                                        }
                                        else if (number_of_second_day == 6)
                                        {
                                            string second_day = " Friday";
                                            Console.WriteLine(second_day);
                                        }
                                    }
                                    day_of_the_second_date += amount_of_increase;
                                }
                            }
                            day_of_the_second_date -= temp_day;
                            second_month_number += 1;
                        }
                        second_year += 1;
                    }
                    if (second_month_number == 13)
                    {
                        second_year += 1;
                        second_month_number = 1;
                    }
                }
            }


            //Block where the second date is after the first date.
            else if (second_year > first_year)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int temp_day = 0;
                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;
                while (first_year <= second_year)
                {
                    // Block with transactions to be made until the years are equalized.
                    if (first_year < second_year)
                    {
                        if (first_month_number < 13)
                        {
                            // Block that prints which season it is.
                            if (first_month_number == 1 || first_month_number == 2 || first_month_number == 12)
                            {
                                if (winter % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Winter ");
                                    winter = 0;
                                }
                                winter++;
                            }
                            else if (first_month_number == 3 || first_month_number == 4 || first_month_number == 5)
                            {
                                if (spring % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Spring ");
                                    spring = 0;
                                }
                                spring++;

                            }
                            else if (first_month_number == 6 || first_month_number == 7 || first_month_number == 8)
                            {
                                if (summer % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Summer ");
                                    summer = 0;
                                }
                                summer++;
                            }
                            else if (first_month_number == 9 || first_month_number == 10 || first_month_number == 11)
                            {
                                if (autumn % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Autumn ");
                                    autumn = 0;
                                }
                                autumn++;
                            }
                            // Blocks in which the number of days of the month is determined.
                            if (first_month_number == 1 || first_month_number == 3 || first_month_number == 5 || first_month_number == 7 || first_month_number == 8 || first_month_number == 10 || first_month_number == 12)
                            {
                                temp_day = 31;
                            }
                            else if (first_month_number == 4 || first_month_number == 6 || first_month_number == 9 || first_month_number == 11)
                            {
                                temp_day = 30;
                            }
                            else
                            {
                                if (first_year % 4 == 0)
                                {
                                    temp_day = 29;
                                }
                                else
                                {
                                    temp_day = 28;
                                }
                            }
                            while (day_of_the_first_date <= temp_day)
                            {
                                // Block of which month it is printed.
                                Console.Write(day_of_the_first_date);
                                if (first_month_number == 1)
                                {
                                    Console.Write(" January ");
                                }
                                else if (first_month_number == 2)
                                {
                                    Console.Write(" February ");
                                }
                                else if (first_month_number == 3)
                                {
                                    Console.Write(" March ");
                                }
                                else if (first_month_number == 4)
                                {
                                    Console.Write(" April ");
                                }
                                else if (first_month_number == 5)
                                {
                                    Console.Write(" May ");
                                }
                                else if (first_month_number == 6)
                                {
                                    Console.Write(" June ");
                                }
                                else if (first_month_number == 7)
                                {
                                    Console.Write(" July ");
                                }
                                else if (first_month_number == 8)
                                {
                                    Console.Write(" August ");
                                }
                                else if (first_month_number == 9)
                                {
                                    Console.Write(" Sptember ");
                                }
                                else if (first_month_number == 10)
                                {
                                    Console.Write(" October ");
                                }
                                else if (first_month_number == 11)
                                {
                                    Console.Write(" November ");
                                }
                                else if (first_month_number == 12)
                                {
                                    Console.Write(" December ");
                                }
                                Console.Write(first_year);
                                // Block that finds which day the date falls on.
                                if (first_month_number == 1 || first_month_number == 2)
                                {
                                    int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                    if (number_of_first_day == 0)
                                    {
                                        string fist_day = " Saturday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 1)
                                    {
                                        string fist_day = " Sunday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 2)
                                    {
                                        string fist_day = " Monday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 3)
                                    {
                                        string fist_day = " Tuesday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 4)
                                    {
                                        string fist_day = " Wednasday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 5)
                                    {
                                        string fist_day = " Thursday";
                                        Console.WriteLine(fist_day);
                                    }
                                    else if (number_of_first_day == 6)
                                    {
                                        string fist_day = " Friday";
                                        Console.WriteLine(fist_day);
                                    }
                                }
                                else
                                {
                                    int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                    if (number_of_first_day == 0)
                                    {
                                        string first_day = " Saturday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 1)
                                    {
                                        string first_day = " Sunday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 2)
                                    {
                                        string first_day = " Monday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 3)
                                    {
                                        string first_day = " Tuesday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 4)
                                    {
                                        string first_day = " Wednasday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 5)
                                    {
                                        string first_day = " Thursday";
                                        Console.WriteLine(first_day);
                                    }
                                    else if (number_of_first_day == 6)
                                    {
                                        string first_day = " Friday";
                                        Console.WriteLine(first_day);
                                    }
                                }
                                day_of_the_first_date += amount_of_increase;
                            }
                            day_of_the_first_date -= temp_day;
                            first_month_number += 1;
                        }
                    }
                    // Block with the transactions that need to be done when the years are equalized.
                    else if (second_year == first_year)
                    {
                        while (first_month_number <= second_month_number)
                        {
                            // Block that prints which season it is.
                            if (first_month_number == 1 || first_month_number == 2 || first_month_number == 12)
                            {
                                if (winter % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Winter ");
                                    winter = 0;
                                }
                                winter++;
                            }
                            else if (first_month_number == 3 || first_month_number == 4 || first_month_number == 5)
                            {
                                if (spring % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Spring ");
                                    spring = 0;
                                }
                                spring++;

                            }
                            else if (first_month_number == 6 || first_month_number == 7 || first_month_number == 8)
                            {
                                if (summer % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Summer ");
                                    summer = 0;
                                }
                                summer++;
                            }
                            else if (first_month_number == 9 || first_month_number == 10 || first_month_number == 11)
                            {
                                if (autumn % 3 == 0)
                                {
                                    if (first_season_print_of != 0)
                                        Console.WriteLine("");
                                    first_season_print_of++;
                                    Console.WriteLine(" Autumn ");
                                    autumn = 0;
                                }
                                autumn++;
                            }
                            // Blocks in which the number of days of the month is determined.
                            if (first_month_number == 1 || first_month_number == 3 || first_month_number == 5 || first_month_number == 7 || first_month_number == 8 || first_month_number == 10 || first_month_number == 12)
                            {
                                temp_day = 31;
                            }
                            else if (first_month_number == 4 || first_month_number == 6 || first_month_number == 9 || first_month_number == 11)
                            {
                                temp_day = 30;
                            }
                            else
                            {
                                if (first_year % 4 == 0)
                                {
                                    temp_day = 29;
                                }
                                else
                                {
                                    temp_day = 28;
                                }
                            }
                            if (first_month_number != second_month_number)
                            {
                                while (day_of_the_first_date <= temp_day)
                                {
                                    // Block of which month it is printed.
                                    Console.Write(day_of_the_first_date);
                                    if (first_month_number == 1)
                                    {
                                        Console.Write(" January ");
                                    }
                                    else if (first_month_number == 2)
                                    {
                                        Console.Write(" February ");
                                    }
                                    else if (first_month_number == 3)
                                    {
                                        Console.Write(" March ");
                                    }
                                    else if (first_month_number == 4)
                                    {
                                        Console.Write(" April ");
                                    }
                                    else if (first_month_number == 5)
                                    {
                                        Console.Write(" May ");
                                    }
                                    else if (first_month_number == 6)
                                    {
                                        Console.Write(" June ");
                                    }
                                    else if (first_month_number == 7)
                                    {
                                        Console.Write(" July ");
                                    }
                                    else if (first_month_number == 8)
                                    {
                                        Console.Write(" August ");
                                    }
                                    else if (first_month_number == 9)
                                    {
                                        Console.Write(" Sptember ");
                                    }
                                    else if (first_month_number == 10)
                                    {
                                        Console.Write(" October ");
                                    }
                                    else if (first_month_number == 11)
                                    {
                                        Console.Write(" November ");
                                    }
                                    else if (first_month_number == 12)
                                    {
                                        Console.Write(" December ");
                                    }
                                    Console.Write(first_year);
                                    // Block that finds which day the date falls on.
                                    if (first_month_number == 1 || first_month_number == 2)
                                    {
                                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                        if (number_of_first_day == 0)
                                        {
                                            string fist_day = " Saturday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 1)
                                        {
                                            string fist_day = " Sunday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 2)
                                        {
                                            string fist_day = " Monday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 3)
                                        {
                                            string fist_day = " Tuesday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 4)
                                        {
                                            string fist_day = " Wednasday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 5)
                                        {
                                            string fist_day = " Thursday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 6)
                                        {
                                            string fist_day = " Friday";
                                            Console.WriteLine(fist_day);
                                        }
                                    }
                                    else
                                    {
                                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                        if (number_of_first_day == 0)
                                        {
                                            string first_day = " Saturday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 1)
                                        {
                                            string first_day = " Sunday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 2)
                                        {
                                            string first_day = " Monday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 3)
                                        {
                                            string first_day = " Tuesday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 4)
                                        {
                                            string first_day = " Wednasday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 5)
                                        {
                                            string first_day = " Thursday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 6)
                                        {
                                            string first_day = " Friday";
                                            Console.WriteLine(first_day);
                                        }
                                    }
                                    day_of_the_first_date += amount_of_increase;
                                }
                            }
                            else
                            {
                                while (day_of_the_first_date <= day_of_the_second_date)
                                {
                                    // Block of which month it is printed.
                                    Console.Write(day_of_the_first_date);
                                    if (first_month_number == 1)
                                    {
                                        Console.Write(" January ");
                                    }
                                    else if (first_month_number == 2)
                                    {
                                        Console.Write(" February ");
                                    }
                                    else if (first_month_number == 3)
                                    {
                                        Console.Write(" March ");
                                    }
                                    else if (first_month_number == 4)
                                    {
                                        Console.Write(" April ");
                                    }
                                    else if (first_month_number == 5)
                                    {
                                        Console.Write(" May ");
                                    }
                                    else if (first_month_number == 6)
                                    {
                                        Console.Write(" June ");
                                    }
                                    else if (first_month_number == 7)
                                    {
                                        Console.Write(" July ");
                                    }
                                    else if (first_month_number == 8)
                                    {
                                        Console.Write(" August ");
                                    }
                                    else if (first_month_number == 9)
                                    {
                                        Console.Write(" Sptember ");
                                    }
                                    else if (first_month_number == 10)
                                    {
                                        Console.Write(" October ");
                                    }
                                    else if (first_month_number == 11)
                                    {
                                        Console.Write(" November ");
                                    }
                                    else if (first_month_number == 12)
                                    {
                                        Console.Write(" December ");
                                    }
                                    Console.Write(first_year);
                                    // Block that finds which day the date falls on.
                                    if (first_month_number == 1 || first_month_number == 2)
                                    {
                                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                        if (number_of_first_day == 0)
                                        {
                                            string fist_day = " Saturday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 1)
                                        {
                                            string fist_day = " Sunday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 2)
                                        {
                                            string fist_day = " Monday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 3)
                                        {
                                            string fist_day = " Tuesday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 4)
                                        {
                                            string fist_day = " Wednasday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 5)
                                        {
                                            string fist_day = " Thursday";
                                            Console.WriteLine(fist_day);
                                        }
                                        else if (number_of_first_day == 6)
                                        {
                                            string fist_day = " Friday";
                                            Console.WriteLine(fist_day);
                                        }
                                    }
                                    else
                                    {
                                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                        if (number_of_first_day == 0)
                                        {
                                            string first_day = " Saturday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 1)
                                        {
                                            string first_day = " Sunday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 2)
                                        {
                                            string first_day = " Monday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 3)
                                        {
                                            string first_day = " Tuesday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 4)
                                        {
                                            string first_day = " Wednasday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 5)
                                        {
                                            string first_day = " Thursday";
                                            Console.WriteLine(first_day);
                                        }
                                        else if (number_of_first_day == 6)
                                        {
                                            string first_day = " Friday";
                                            Console.WriteLine(first_day);
                                        }
                                    }
                                    day_of_the_first_date += amount_of_increase;
                                }
                            }
                            day_of_the_first_date -= temp_day;
                            first_month_number += 1;
                        }
                        first_year += 1;
                    }
                    if (first_month_number == 13)
                    {
                        first_year += 1;
                        first_month_number = 1;
                    }
                }
            }



            // Block where two dates have the same year, different months, and the first date comes after the second date.
            else if (first_year == second_year && first_month_number > second_month_number)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int temp_day = 0;
                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;

                while (second_month_number <= first_month_number)
                {
                    // Block that prints which season it is.
                    if (second_month_number == 1 || second_month_number == 2 || second_month_number == 12)
                    {
                        if (winter % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Winter ");
                            winter = 0;
                        }
                        winter++;
                    }
                    else if (second_month_number == 3 || second_month_number == 4 || second_month_number == 5)
                    {
                        if (spring % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Spring ");
                            spring = 0;
                        }
                        spring++;

                    }
                    else if (second_month_number == 6 || second_month_number == 7 || second_month_number == 8)
                    {
                        if (summer % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Summer ");
                            summer = 0;
                        }
                        summer++;
                    }
                    else if (second_month_number == 9 || second_month_number == 10 || second_month_number == 11)
                    {
                        if (autumn % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Autumn ");
                            autumn = 0;
                        }
                        autumn++;
                    }
                    // Blocks in which the number of days of the month is determined.
                    if (second_month_number == 1 || second_month_number == 3 || second_month_number == 5 || second_month_number == 7 || second_month_number == 8 || second_month_number == 10 || second_month_number == 12)
                    {
                        temp_day = 31;
                    }
                    else if (second_month_number == 4 || second_month_number == 6 || second_month_number == 9 || second_month_number == 11)
                    {
                        temp_day = 30;
                    }
                    else
                    {
                        if (second_year % 4 == 0)
                        {
                            temp_day = 29;
                        }
                        else
                        {
                            temp_day = 28;
                        }
                    }
                    if (first_month_number != second_month_number)
                    {
                        while (day_of_the_second_date <= temp_day)
                        {
                            // Block of which month it is printed.
                            Console.Write(day_of_the_second_date);
                            if (second_month_number == 1)
                            {
                                Console.Write(" January ");
                            }
                            else if (second_month_number == 2)
                            {
                                Console.Write(" February ");
                            }
                            else if (second_month_number == 3)
                            {
                                Console.Write(" March ");
                            }
                            else if (second_month_number == 4)
                            {
                                Console.Write(" April ");
                            }
                            else if (second_month_number == 5)
                            {
                                Console.Write(" May ");
                            }
                            else if (second_month_number == 6)
                            {
                                Console.Write(" June ");
                            }
                            else if (second_month_number == 7)
                            {
                                Console.Write(" July ");
                            }
                            else if (second_month_number == 8)
                            {
                                Console.Write(" August ");
                            }
                            else if (second_month_number == 9)
                            {
                                Console.Write(" Sptember ");
                            }
                            else if (second_month_number == 10)
                            {
                                Console.Write(" October ");
                            }
                            else if (second_month_number == 11)
                            {
                                Console.Write(" November ");
                            }
                            else if (second_month_number == 12)
                            {
                                Console.Write(" December ");
                            }
                            Console.Write(second_year);
                            // Block that finds which day the date falls on.
                            if (second_month_number == 1 || second_month_number == 2)
                            {
                                int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                if (number_of_second_day == 0)
                                {
                                    string second_day = " Saturday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 1)
                                {
                                    string second_day = " Sunday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 2)
                                {
                                    string second_day = " Monday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 3)
                                {
                                    string second_day = " Tuesday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 4)
                                {
                                    string second_day = " Wednasday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 5)
                                {
                                    string second_day = " Thursday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 6)
                                {
                                    string second_day = " Friday";
                                    Console.WriteLine(second_day);
                                }
                            }
                            else
                            {
                                int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                if (number_of_second_day == 0)
                                {
                                    string second_day = " Saturday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 1)
                                {
                                    string second_day = " Sunday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 2)
                                {
                                    string second_day = " Monday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 3)
                                {
                                    string second_day = " Tuesday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 4)
                                {
                                    string second_day = " Wednasday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 5)
                                {
                                    string second_day = " Thursday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 6)
                                {
                                    string second_day = " Friday";
                                    Console.WriteLine(second_day);
                                }
                            }
                            day_of_the_second_date += amount_of_increase;
                        }
                    }
                    else
                    {
                        while (day_of_the_second_date <= day_of_the_first_date)
                        {
                            // Block of which month it is printed.
                            Console.Write(day_of_the_second_date);
                            if (second_month_number == 1)
                            {
                                Console.Write(" January ");
                            }
                            else if (second_month_number == 2)
                            {
                                Console.Write(" February ");
                            }
                            else if (second_month_number == 3)
                            {
                                Console.Write(" March ");
                            }
                            else if (second_month_number == 4)
                            {
                                Console.Write(" April ");
                            }
                            else if (second_month_number == 5)
                            {
                                Console.Write(" May ");
                            }
                            else if (second_month_number == 6)
                            {
                                Console.Write(" June ");
                            }
                            else if (second_month_number == 7)
                            {
                                Console.Write(" July ");
                            }
                            else if (second_month_number == 8)
                            {
                                Console.Write(" August ");
                            }
                            else if (second_month_number == 9)
                            {
                                Console.Write(" Sptember ");
                            }
                            else if (second_month_number == 10)
                            {
                                Console.Write(" October ");
                            }
                            else if (second_month_number == 11)
                            {
                                Console.Write(" November ");
                            }
                            else if (second_month_number == 12)
                            {
                                Console.Write(" December ");
                            }
                            Console.Write(second_year);
                            // Block that finds which day the date falls on.
                            if (second_month_number == 1 || second_month_number == 2)
                            {
                                int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                if (number_of_second_day == 0)
                                {
                                    string second_day = " Saturday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 1)
                                {
                                    string second_day = " Sunday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 2)
                                {
                                    string second_day = " Monday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 3)
                                {
                                    string second_day = " Tuesday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 4)
                                {
                                    string second_day = " Wednasday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 5)
                                {
                                    string second_day = " Thursday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 6)
                                {
                                    string second_day = " Friday";
                                    Console.WriteLine(second_day);
                                }
                            }
                            else
                            {
                                int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                                if (number_of_second_day == 0)
                                {
                                    string second_day = " Saturday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 1)
                                {
                                    string second_day = " Sunday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 2)
                                {
                                    string second_day = " Monday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 3)
                                {
                                    string second_day = " Tuesday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 4)
                                {
                                    string second_day = " Wednasday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 5)
                                {
                                    string second_day = " Thursday";
                                    Console.WriteLine(second_day);
                                }
                                else if (number_of_second_day == 6)
                                {
                                    string second_day = " Friday";
                                    Console.WriteLine(second_day);
                                }
                            }
                            day_of_the_second_date += amount_of_increase;
                        }
                    }
                    day_of_the_second_date -= temp_day;
                    second_month_number += 1;
                }
            }



            // Block where two dates have the same year, different months, and the second date comes after the first date.
            else if (first_year == second_year && second_month_number > first_month_number)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int temp_day = 0;
                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;

                while (first_month_number <= second_month_number)
                {
                    // Block that prints which season it is.
                    if (first_month_number == 1 || first_month_number == 2 || first_month_number == 12)
                    {
                        if (winter % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Winter ");
                            winter = 0;
                        }
                        winter++;
                    }
                    else if (first_month_number == 3 || first_month_number == 4 || first_month_number == 5)
                    {
                        if (spring % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Spring ");
                            spring = 0;
                        }
                        spring++;

                    }
                    else if (first_month_number == 6 || first_month_number == 7 || first_month_number == 8)
                    {
                        if (summer % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Summer ");
                            summer = 0;
                        }
                        summer++;
                    }
                    else if (first_month_number == 9 || first_month_number == 10 || first_month_number == 11)
                    {
                        if (autumn % 3 == 0)
                        {
                            if (first_season_print_of != 0)
                                Console.WriteLine("");
                            first_season_print_of++;
                            Console.WriteLine(" Autumn ");
                            autumn = 0;
                        }
                        autumn++;
                    }
                    // Blocks in which the number of days of the month is determined.
                    if (first_month_number == 1 || first_month_number == 3 || first_month_number == 5 || first_month_number == 7 || first_month_number == 8 || first_month_number == 10 || first_month_number == 12)
                    {
                        temp_day = 31;
                    }
                    else if (first_month_number == 4 || first_month_number == 6 || first_month_number == 9 || first_month_number == 11)
                    {
                        temp_day = 30;
                    }
                    else
                    {
                        if (first_year % 4 == 0)
                        {
                            temp_day = 29;
                        }
                        else
                        {
                            temp_day = 28;
                        }
                    }
                    if (first_month_number != second_month_number)
                    {
                        while (day_of_the_first_date <= temp_day)
                        {
                            // Block of which month it is printed.
                            Console.Write(day_of_the_first_date);
                            if (first_month_number == 1)
                            {
                                Console.Write(" January ");
                            }
                            else if (first_month_number == 2)
                            {
                                Console.Write(" February ");
                            }
                            else if (first_month_number == 3)
                            {
                                Console.Write(" March ");
                            }
                            else if (first_month_number == 4)
                            {
                                Console.Write(" April ");
                            }
                            else if (first_month_number == 5)
                            {
                                Console.Write(" May ");
                            }
                            else if (first_month_number == 6)
                            {
                                Console.Write(" June ");
                            }
                            else if (first_month_number == 7)
                            {
                                Console.Write(" July ");
                            }
                            else if (first_month_number == 8)
                            {
                                Console.Write(" August ");
                            }
                            else if (first_month_number == 9)
                            {
                                Console.Write(" Sptember ");
                            }
                            else if (first_month_number == 10)
                            {
                                Console.Write(" October ");
                            }
                            else if (first_month_number == 11)
                            {
                                Console.Write(" November ");
                            }
                            else if (first_month_number == 12)
                            {
                                Console.Write(" December ");
                            }
                            Console.Write(first_year);
                            // Block that finds which day the date falls on.
                            if (first_month_number == 1 || first_month_number == 2)
                            {
                                int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                if (number_of_first_day == 0)
                                {
                                    string fist_day = " Saturday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 1)
                                {
                                    string fist_day = " Sunday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 2)
                                {
                                    string fist_day = " Monday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 3)
                                {
                                    string fist_day = " Tuesday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 4)
                                {
                                    string fist_day = " Wednasday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 5)
                                {
                                    string fist_day = " Thursday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 6)
                                {
                                    string fist_day = " Friday";
                                    Console.WriteLine(fist_day);
                                }
                            }
                            else
                            {
                                int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                if (number_of_first_day == 0)
                                {
                                    string first_day = " Saturday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 1)
                                {
                                    string first_day = " Sunday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 2)
                                {
                                    string first_day = " Monday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 3)
                                {
                                    string first_day = " Tuesday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 4)
                                {
                                    string first_day = " Wednasday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 5)
                                {
                                    string first_day = " Thursday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 6)
                                {
                                    string first_day = " Friday";
                                    Console.WriteLine(first_day);
                                }
                            }
                            day_of_the_first_date += amount_of_increase;
                        }
                    }
                    else
                    {
                        while (day_of_the_first_date <= day_of_the_second_date)
                        {
                            // Block of which month it is printed.
                            Console.Write(day_of_the_first_date);
                            if (first_month_number == 1)
                            {
                                Console.Write(" January ");
                            }
                            else if (first_month_number == 2)
                            {
                                Console.Write(" February ");
                            }
                            else if (first_month_number == 3)
                            {
                                Console.Write(" March ");
                            }
                            else if (first_month_number == 4)
                            {
                                Console.Write(" April ");
                            }
                            else if (first_month_number == 5)
                            {
                                Console.Write(" May ");
                            }
                            else if (first_month_number == 6)
                            {
                                Console.Write(" June ");
                            }
                            else if (first_month_number == 7)
                            {
                                Console.Write(" July ");
                            }
                            else if (first_month_number == 8)
                            {
                                Console.Write(" August ");
                            }
                            else if (first_month_number == 9)
                            {
                                Console.Write(" Sptember ");
                            }
                            else if (first_month_number == 10)
                            {
                                Console.Write(" October ");
                            }
                            else if (first_month_number == 11)
                            {
                                Console.Write(" November ");
                            }
                            else if (first_month_number == 12)
                            {
                                Console.Write(" December ");
                            }
                            Console.Write(first_year);
                            // Block that finds which day the date falls on.
                            if (first_month_number == 1 || first_month_number == 2)
                            {
                                int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                if (number_of_first_day == 0)
                                {
                                    string fist_day = " Saturday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 1)
                                {
                                    string fist_day = " Sunday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 2)
                                {
                                    string fist_day = " Monday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 3)
                                {
                                    string fist_day = " Tuesday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 4)
                                {
                                    string fist_day = " Wednasday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 5)
                                {
                                    string fist_day = " Thursday";
                                    Console.WriteLine(fist_day);
                                }
                                else if (number_of_first_day == 6)
                                {
                                    string fist_day = " Friday";
                                    Console.WriteLine(fist_day);
                                }
                            }
                            else
                            {
                                int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                                if (number_of_first_day == 0)
                                {
                                    string first_day = " Saturday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 1)
                                {
                                    string first_day = " Sunday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 2)
                                {
                                    string first_day = " Monday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 3)
                                {
                                    string first_day = " Tuesday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 4)
                                {
                                    string first_day = " Wednasday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 5)
                                {
                                    string first_day = " Thursday";
                                    Console.WriteLine(first_day);
                                }
                                else if (number_of_first_day == 6)
                                {
                                    string first_day = " Friday";
                                    Console.WriteLine(first_day);
                                }
                            }
                            day_of_the_first_date += amount_of_increase;
                        }
                    }
                    day_of_the_first_date -= temp_day;
                    first_month_number += 1;
                }
            }



            // Block where the year and month of the two dates are the same and the first date comes after the second date.
            else if (first_year == second_year && the_first_month == the_second_month && day_of_the_first_date > day_of_the_second_date)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;

                // Block that prints which season it is.
                if (second_month_number == 1 || second_month_number == 2 || second_month_number == 12)
                {
                    if (winter % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Winter ");
                        winter = 0;
                    }
                    winter++;
                }
                else if (second_month_number == 3 || second_month_number == 4 || second_month_number == 5)
                {
                    if (spring % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Spring ");
                        spring = 0;
                    }
                    spring++;

                }
                else if (second_month_number == 6 || second_month_number == 7 || second_month_number == 8)
                {
                    if (summer % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Summer ");
                        summer = 0;
                    }
                    summer++;
                }
                else if (second_month_number == 9 || second_month_number == 10 || second_month_number == 11)
                {
                    if (autumn % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Autumn ");
                        autumn = 0;
                    }
                    autumn++;
                }
                while (day_of_the_second_date <= day_of_the_first_date)
                {
                    // Block of which month it is printed.
                    Console.Write(day_of_the_second_date);
                    if (second_month_number == 1)
                    {
                        Console.Write(" January ");
                    }
                    else if (second_month_number == 2)
                    {
                        Console.Write(" February ");
                    }
                    else if (second_month_number == 3)
                    {
                        Console.Write(" March ");
                    }
                    else if (second_month_number == 4)
                    {
                        Console.Write(" April ");
                    }
                    else if (second_month_number == 5)
                    {
                        Console.Write(" May ");
                    }
                    else if (second_month_number == 6)
                    {
                        Console.Write(" June ");
                    }
                    else if (second_month_number == 7)
                    {
                        Console.Write(" July ");
                    }
                    else if (second_month_number == 8)
                    {
                        Console.Write(" August ");
                    }
                    else if (second_month_number == 9)
                    {
                        Console.Write(" Sptember ");
                    }
                    else if (second_month_number == 10)
                    {
                        Console.Write(" October ");
                    }
                    else if (second_month_number == 11)
                    {
                        Console.Write(" November ");
                    }
                    else if (second_month_number == 12)
                    {
                        Console.Write(" December ");
                    }
                    Console.Write(second_year);
                    // Block that finds which day the date falls on.
                    if (second_month_number == 1 || second_month_number == 2)
                    {
                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 13) / 5) + Convert.ToInt32((second_year % 100) - 1) + +Convert.ToInt32(((second_year % 100) - 1) / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                        if (number_of_second_day == 0)
                        {
                            string second_day = " Saturday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 1)
                        {
                            string second_day = " Sunday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 2)
                        {
                            string second_day = " Monday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 3)
                        {
                            string second_day = " Tuesday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 4)
                        {
                            string second_day = " Wednasday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 5)
                        {
                            string second_day = " Thursday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 6)
                        {
                            string second_day = " Friday";
                            Console.WriteLine(second_day);
                        }
                    }
                    else
                    {
                        int number_of_second_day = (day_of_the_second_date + Convert.ToInt32(13 * (second_month_number + 1) / 5) + Convert.ToInt32(second_year % 100) + +Convert.ToInt32(second_year % 100 / 4) + Convert.ToInt32(second_year / 400) - 2 * (Convert.ToInt32(second_year / 100))) % 7;
                        if (number_of_second_day == 0)
                        {
                            string second_day = " Saturday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 1)
                        {
                            string second_day = " Sunday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 2)
                        {
                            string second_day = " Monday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 3)
                        {
                            string second_day = " Tuesday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 4)
                        {
                            string second_day = " Wednasday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 5)
                        {
                            string second_day = " Thursday";
                            Console.WriteLine(second_day);
                        }
                        else if (number_of_second_day == 6)
                        {
                            string second_day = " Friday";
                            Console.WriteLine(second_day);
                        }
                    }
                    day_of_the_second_date += amount_of_increase;
                }
            }



            // Block where the year and month of the two dates are the same and the second date comes after the first date.
            else if (first_year == second_year && the_first_month == the_second_month && day_of_the_second_date > day_of_the_first_date)
            {
                Console.WriteLine("Enter the number of times you want the dates to progress.");
                int amount_of_increase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int first_season_print_of = 0;
                int winter = 0;
                int spring = 0;
                int summer = 0;
                int autumn = 0;

                // Block that prints which season it is.
                if (first_month_number == 1 || first_month_number == 2 || first_month_number == 12)
                {
                    if (winter % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Winter ");
                        winter = 0;
                    }
                    winter++;
                }
                else if (first_month_number == 3 || first_month_number == 4 || first_month_number == 5)
                {
                    if (spring % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Spring ");
                        spring = 0;
                    }
                    spring++;

                }
                else if (first_month_number == 6 || first_month_number == 7 || first_month_number == 8)
                {
                    if (summer % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Summer ");
                        summer = 0;
                    }
                    summer++;
                }
                else if (first_month_number == 9 || first_month_number == 10 || first_month_number == 11)
                {
                    if (autumn % 3 == 0)
                    {
                        if (first_season_print_of != 0)
                            Console.WriteLine("");
                        first_season_print_of++;
                        Console.WriteLine(" Autumn ");
                        autumn = 0;
                    }
                    autumn++;
                }
                while (day_of_the_first_date <= day_of_the_second_date)
                {
                    // Block of which month it is printed.
                    Console.Write(day_of_the_first_date);
                    if (first_month_number == 1)
                    {
                        Console.Write(" January ");
                    }
                    else if (first_month_number == 2)
                    {
                        Console.Write(" February ");
                    }
                    else if (first_month_number == 3)
                    {
                        Console.Write(" March ");
                    }
                    else if (first_month_number == 4)
                    {
                        Console.Write(" April ");
                    }
                    else if (first_month_number == 5)
                    {
                        Console.Write(" May ");
                    }
                    else if (first_month_number == 6)
                    {
                        Console.Write(" June ");
                    }
                    else if (first_month_number == 7)
                    {
                        Console.Write(" July ");
                    }
                    else if (first_month_number == 8)
                    {
                        Console.Write(" August ");
                    }
                    else if (first_month_number == 9)
                    {
                        Console.Write(" Sptember ");
                    }
                    else if (first_month_number == 10)
                    {
                        Console.Write(" October ");
                    }
                    else if (first_month_number == 11)
                    {
                        Console.Write(" November ");
                    }
                    else if (first_month_number == 12)
                    {
                        Console.Write(" December ");
                    }
                    Console.Write(first_year);
                    // Block that finds which day the date falls on.
                    if (first_month_number == 1 || first_month_number == 2)
                    {
                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 13) / 5) + Convert.ToInt32((first_year % 100) - 1) + +Convert.ToInt32(((first_year % 100) - 1) / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                        if (number_of_first_day == 0)
                        {
                            string fist_day = " Saturday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 1)
                        {
                            string fist_day = " Sunday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 2)
                        {
                            string fist_day = " Monday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 3)
                        {
                            string fist_day = " Tuesday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 4)
                        {
                            string fist_day = " Wednasday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 5)
                        {
                            string fist_day = " Thursday";
                            Console.WriteLine(fist_day);
                        }
                        else if (number_of_first_day == 6)
                        {
                            string fist_day = " Friday";
                            Console.WriteLine(fist_day);
                        }
                    }
                    else
                    {
                        int number_of_first_day = (day_of_the_first_date + Convert.ToInt32(13 * (first_month_number + 1) / 5) + Convert.ToInt32(first_year % 100) + +Convert.ToInt32(first_year % 100 / 4) + Convert.ToInt32(first_year / 400) - 2 * (Convert.ToInt32(first_year / 100))) % 7;
                        if (number_of_first_day == 0)
                        {
                            string first_day = " Saturday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 1)
                        {
                            string first_day = " Sunday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 2)
                        {
                            string first_day = " Monday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 3)
                        {
                            string first_day = " Tuesday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 4)
                        {
                            string first_day = " Wednasday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 5)
                        {
                            string first_day = " Thursday";
                            Console.WriteLine(first_day);
                        }
                        else if (number_of_first_day == 6)
                        {
                            string first_day = " Friday";
                            Console.WriteLine(first_day);
                        }
                    }
                    day_of_the_first_date += amount_of_increase;
                }
            }
        }
    }
}