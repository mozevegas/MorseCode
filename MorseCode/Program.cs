using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var morseFile = "morse.csv";

            Dictionary<string, string> morseDiction = new Dictionary<string, string>();
            morseDiction = new Dictionary<string, string>();
            using (var writing = new StreamReader(morseFile))
            {
                while (writing.Peek() > -1)
                {
                    var line = writing.ReadLine().Split(',');// ["B","..--"]
                    morseDiction.Add(line[0], line[1]);
                }
            }

            // Testing for proof
            foreach (KeyValuePair<string, string> element in morseDiction)
            {
                Console.WriteLine(element.Key + element.Value);
            }

            Console.WriteLine("Input a word you would like to convert to Morse Code");
            string conVerto = Console.ReadLine();
            conVerto = conVerto.ToUpper();


            //string upConvo = conVerto.ToUpper();
            Console.WriteLine($"You would like to convert {conVerto.ToUpper()}");
            Console.WriteLine(conVerto);


            // convert string to characters and return translation from Morse


            Console.WriteLine($"here is F {morseDiction["F"]}");

            if (morseDiction.ContainsKey("A"))
            {
                Console.WriteLine(morseDiction.Values);
            }


            // convert to Character Array
            char[] conAir = conVerto.ToCharArray();

            // conAir is an array--Proof
            foreach (var here in conAir)
            {
                Console.Write(here);
                var herepart = here.ToString();
                Console.WriteLine($" ==  {morseDiction[herepart]}");
            }




        }
    }
}
