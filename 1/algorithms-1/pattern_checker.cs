using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {


            string text = "";
            int i = 0;
            while (i < 1) // The block where the text to be scanned is received and checked.
            {
                Console.WriteLine("Enter the text you want to scan: ");
                Console.WriteLine("The text contains only English alphabet letters and two punctuations dot (.) and comma (,).");
                text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ,.";
                    if (j < text.Length - 1 && alphabet.IndexOf(text[j]) == -1)
                    {
                        Console.WriteLine("The text contains only English alphabet letters and two punctuations dot (.) and comma (,).");
                        break;
                    }
                    else if (j == text.Length - 1 && alphabet.IndexOf(text[j]) != -1)
                        i++;
                }
            }
            string[] text_list = text.Split(" ");
            Console.WriteLine(text_list.Length);
            string pattern = "";
            i = 0;
            while (i < 1) // Block where items to be scanned are received and checked.
            {
                Console.WriteLine("The pattern can contain letters, as well as either the character(s) of “*” or the character(s) of “-”, but not both of them.\n The symbol “*” corresponds to any number of letters(zero or more).\n The symbol “-“ corresponds to only one letter.\n For example; if a pattern contains a single “*”, this symbol should match any number of letters in the word; the other characters in the word and pattern must be equal. ");
                Console.WriteLine("Enter a pattern: ");
                pattern = Console.ReadLine();
                if (pattern.IndexOf("*") != -1 && pattern.IndexOf("-") != -1)
                    Console.WriteLine("The pattern can contain letters, as well as either the character(s) of “*” or the character(s) of “-”, but not both of them.");
                else
                    i++;
            }
            
            
            if (pattern.IndexOf("-") != -1) // Block specifying whether "-" is used or not.
            {
                for (int x = 0; x < text_list.Length; x++)
                {
                    int counter_1 = 0; // Variable counting how many "-".
                    int counter_2 = 0; // Variable that counts matches other than "-".
                    for (int k = 0; k < pattern.Length; k++) // The block in which the number "-" is calculated.
                    {
                        if (pattern[k] == Convert.ToChar("-"))
                            counter_1++;
                    }
                    if (pattern.Length == text_list[x].Length)
                    {
                        if (counter_1 == pattern.Length)
                        {
                            Console.WriteLine(text_list[x]);
                        }
                        else
                        {
                            for (int l = 0; l < pattern.Length; l++)
                            {
                                if (pattern[l] != Convert.ToChar("-") && pattern[l] == text_list[x][l])
                                {
                                    counter_2++;
                                    if (pattern.Length != counter_1 && pattern.Length - counter_1 == counter_2)
                                    {
                                        Console.WriteLine(text_list[x]);
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (pattern.IndexOf("*") != -1) // Block specifying whether "*" is used or not.
            {
                if (pattern.Length == 1) // Block where all words are written if only "*" is entered.
                {
                    foreach (string item in text_list)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    for (int y = 0; y < text_list.Length; y++)
                    {
                        int count_3 = 0; // Variable that calculates how many "*" there are.
                        for (int a = 0; a < pattern.Length; a++) // The block that calculates how many "*" there are.
                        {
                            if (pattern[a] == Convert.ToChar("*"))
                            {
                                count_3++;
                            }
                        }
                        if (count_3 == 1) // The block with the algorithm to use when there is one "*".
                        {
                            if (pattern.IndexOf("*") == 0) // Block to use when "*" is in first digit.
                            {
                                if (text_list[y].Substring(text_list[y].Length - (pattern.Length - 1)) == pattern.Substring(1))
                                {
                                    Console.WriteLine(text_list[y]);
                                }
                            }
                            else if (pattern.IndexOf("*") == pattern.Length - 1) // Block to use when "*" is in last digit.
                            {
                                if (text_list[y].Substring(0, pattern.Length - 1) == pattern.Substring(0, pattern.Length - 1))
                                {
                                    Console.WriteLine(text_list[y]);
                                }
                            }
                            else if (pattern.IndexOf("*") != 0 && pattern.IndexOf("*") != pattern.Length -1) // Block to use when "*" is in a middle digit.
                            {
                                int index_of_middle = pattern.IndexOf("*");
                                if (text_list[y].Substring(0 , index_of_middle - 1) == pattern.Substring(0 , index_of_middle - 1) && text_list[y].Substring(text_list[y].Length - (pattern.Length - index_of_middle - 1)) == pattern.Substring(index_of_middle + 1))
                                {
                                    Console.WriteLine(text_list[y]);
                                }
                            }
                        }
                        else if (count_3 != 1) // Block to be used but not completed when more than one "*" is used.
                        {

                        }
                    }
                }
            }
        }
    }
}
