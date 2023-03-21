using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class Song
    {
        private string _title;
        private string _performer;
        private int _year;
        private string _lyrics;

        public Song(string title, string performer, int year, string lyrics)
        {
            _title = title;
            _performer = performer;
            _year = year;
            _lyrics = lyrics;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetPerformer()
        {
            return _performer;
        }

        public int GetYear()
        {
            return _year;
        }

        public string GetLyrics()
        {
            return _lyrics;
        }

        public string GetInformation()
        {
            return $"Title: {_title}\nPerformer: {_performer}\nYear: {_year}\nLyrics:\n{_lyrics}\n";
        }

        public string GetMorseCode()
        {
            string morseCode = "";
            foreach (char c in _lyrics)
            {
                if (Char.IsLetter(c))
                {
                    string letter = c.ToString().ToUpper();
                    string code = MorseCodeDictionary.Dictionary[letter];
                    morseCode += code + " ";
                }
                else if (c == ' ')
                {
                    morseCode += "/ ";
                }
                else if (c == '\n')
                {
                    morseCode += "\n";
                }
            }
            return morseCode;
        }
    }

    public static class MorseCodeDictionary
    {
        public static readonly Dictionary<string, string> Dictionary = new Dictionary<string, string>
        {
            {"A", ".-"},
            {"B", "-..."},
            {"C", "-.-."},
            {"D", "-.."},
            {"E", "."},
            {"F", "..-."},
            {"G", "--."},
            {"H", "...."},
            {"I", ".."},
            {"J", ".---"},
            {"K", "-.-"},
            {"L", ".-.."},
            {"M", "--"},
            {"N", "-."},
            {"O", "---"},
            {"P", ".--."},
            {"Q", "--.-"},
            {"R", ".-."},
            {"S", "..."},
            {"T", "-"},
            {"U", "..-"},
            {"V", "...-"},
            {"W", ".--"},
            {"X", "-..-"},
            {"Y", "-.--"},
            {"Z", "--.."},
        };
    }
}
