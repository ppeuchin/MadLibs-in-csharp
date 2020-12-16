using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterHeader();
            KristoffsLoveLetter();
        }
        static void LetterHeader()
        {
            Console.WriteLine("WELCOME TO MADLIBS!!!");
            Console.WriteLine("Let's get started! \n");
        }
        /*We'll need 6 adjectives, 2 names(must have at least one feminine name), 2 parts of the body,
         2 nouns, 3 plural nouns and a place*/
        static void KristoffsLoveLetter()
        {
            Console.WriteLine("Before we begin, i would like to know your name. I'm Tamsin, how about you? ");
            string username = Console.ReadLine();
            Console.WriteLine("Nice to meet you," + username + "!");
            Console.WriteLine("Shall we begin.. Write down any six adjectives.(Don't forget to hit enter after you input anything..)");
            Console.WriteLine("1: ");
            string adj1 = Console.ReadLine();
            Console.WriteLine("2: ");
            string adj2 = Console.ReadLine();
            Console.WriteLine("3: ");
            string adj3 = Console.ReadLine();
            Console.WriteLine("4: ");
            string adj4 = Console.ReadLine();
            Console.WriteLine("5: ");
            string adj5 = Console.ReadLine();
            Console.WriteLine("6: ");
            string adj6 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Good. Now give any two names.(can be both feminine or 1 feminine,1 masculine) ");
            Console.WriteLine("(feminine) 1: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("2: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Nice. Mention any two parts of the body, one must be in plural.");
            Console.WriteLine("1: ");
            string part1 = Console.ReadLine();
            Console.WriteLine("2: ");
            string part2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Give me any five nouns, three of them must be plural nouns");
            Console.WriteLine("(Plural noun) 1: ");
            string noun1 = Console.ReadLine();
            Console.WriteLine("(Plural noun) 2: ");
            string noun2 = Console.ReadLine();
            Console.WriteLine("(Plural noun) 3: ");
            string noun3 = Console.ReadLine();
            Console.WriteLine("4: ");
            string noun4 = Console.ReadLine();
            Console.WriteLine("5: ");
            string noun5 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("For the last one, name any place of your choice: ");
            string place = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"WELL DONE {username}!! Hit enter to reveal your awesome MADLIBS... ");
            Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("  KRISTOFF'S LOVE LETTER");
            Console.WriteLine("\n");
            Console.WriteLine($"My dear,{adj1} Anna,");
            Console.WriteLine($"I'm not very {adj2} at expressing myself with words.I mean, I'm an ice guy-- we're not the most romantic {noun1}." +
                $"Luckily, I was raised by {noun2}-- who,as you know, are love experts!Yes,they can be a bit inappropriate,overbearing,and {adj3} at times," +
                $"but they have a way with {noun3}.{name1},my troll mother,said I just need to speak straight from my {part1}-- so here goes." +
                $"Anna, you are a very special {noun4},and one day,I could see myself falling head over {part2} in love with you." +
                $"There's no one else in (the) {place} quite like you! It was so {adj4} of you to buy me that new {noun5} when my other one plunged over the cliff." +
                $"I love the way you treat my reindeer,{name2}.You didn't judge me when i stared in total admiration at Elsa's {adj5} ice palace,because ice is my life." +
                $"Anyway,you're a/an {adj6} girl,and i hope you feel the same way about me.");
            Console.WriteLine("\n");
            Console.WriteLine("-Kristoff");
        }
    }
}
