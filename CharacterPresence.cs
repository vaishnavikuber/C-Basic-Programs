using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class CharacterPresence
    {

        public static void Presence(string str)
        {
            int a = 0, e = 0, p = 0;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')
                {
                    a++;
                }
                else if (chars[i] == 'e')
                {
                    e++;
                }
                else if (chars[i] == 'p')
                {
                    p++;
                }

            }

            if (a != 0 && e != 0 && p != 0)
            {
                Console.WriteLine("All Present");
            }
            else if (e != 0 || p != 0 || a != 0)
            {
                Console.WriteLine("One or More Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }


        }
    }
}
