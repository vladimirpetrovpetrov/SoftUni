using System;
using System.Collections.Generic;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //all symbols which are not letters from english alphabet are ignored.
            //every first 'c','o','n' will count but not be shown in the phrase.
            //every second,third etc. c,o,n will be shown.
            string command = " ";
            string phrase = "";
            int countC = 0;
            int countO = 0;
            int countN = 0;
            List<string> words = new List<string>();
            while (command != "End")
            {

                command = Console.ReadLine();

                char letter;
                if (command == "End")
                {
                    break;
                }
                else
                {
                    letter = char.Parse(command);
                }

                if (!char.IsLetter(letter))
                {
                    continue;
                }
                else
                {
                    if (letter == 'c')
                    {
                        countC++;
                        if (countC < 2)
                        {
                            if (countC > 0 && countN > 0 && countO > 0)
                            {
                                words.Add(phrase + ' ');
                                phrase = "";
                                countC = 0;
                                countN = 0;
                                countO = 0;
                            }
                            continue;
                        }
                        else
                        {
                            phrase += letter;
                        }
                    }
                    else if (letter == 'o')
                    {
                        countO++;
                        if (countO < 2)
                        {
                            if (countC > 0 && countN > 0 && countO > 0)
                            {
                                words.Add(phrase + ' ');
                                phrase = "";
                                countC = 0;
                                countN = 0;
                                countO = 0;
                            }
                            continue;
                        }
                        else
                        {
                            phrase += letter;
                        }
                    }
                    else if (letter == 'n')
                    {
                        countN++;
                        if (countN < 2)
                        {
                            if (countC > 0 && countN > 0 && countO > 0)
                            {
                                words.Add(phrase + ' ');
                                phrase = "";
                                countC = 0;
                                countN = 0;
                                countO = 0;
                            }
                            continue;
                        }
                        else
                        {
                            phrase += letter;
                        }
                    }
                    else
                    {
                        phrase += letter;
                    }
                }

            }
            foreach (string word in words)
            {
                Console.Write(word);
            }
        }
    }
}
