using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class OldPhonePadConverter
{
    private static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
    {
        {'1', "&'("},
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"},
        {'0', " "}
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        int i = 0;
        int n = input.Length;

        while (i < n)
        {
            char currentChar = input[i];

            if (currentChar == '#')
            {
                break;
            }
            else if (currentChar == '*')
            {
                if (output.Length > 0)
                {
                    output.Length--;
                }
                i++;
            }
            else if (currentChar == ' ')
            {
                i++; // Reset character count on space
            }
            else
            {
                char key = currentChar;
                int count = 0;
                while (i < n && input[i] == key)
                {
                    count++;
                    i++;
                }
                if (KeyMap.ContainsKey(key))
                {
                    if (key == '0') // Special handling for 0 to add multiple spaces
                    {
                        output.Append(' ', count);
                    }
                    else
                    {
                        string letters = KeyMap[key];
                        int index = (count - 1) % letters.Length;
                        output.Append(letters[index]);
                    }
                }
            }
        }

        return output.ToString();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the message: (Press # to send):");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
        {
            Console.WriteLine("Please press # to send the message.");
        }
        else if (!input.All(c => char.IsDigit(c) || c == '*' || c == '#' || c == ' '))
        {
            Console.WriteLine("Invalid input. Please enter only numbers, '*' and '#'.");
        }
        else
        {
            string output = OldPhonePad(input);
            Console.WriteLine("Output: " + output);
        }
    }
}
