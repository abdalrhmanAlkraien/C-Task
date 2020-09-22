using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{

    class Program
    {
        public static  bool isfind(List<string> str, string s)
        {
            foreach(var x in str)
            {
                if (s == x)
                return true;
            }
            return false;
                

        }
        static void Main(string[] args)
        {
            
            string str;
            char test;
            List<string> ch = new List<string>();
            string duplicate="";



            while (true)
            {
                str = Console.ReadLine();
                if (str == duplicate)
                {
                    break;
                }
                else if (str.Length != 1)
                {
                    break;
                }

                else
                {
                    test = char.Parse(str);
                    if (Char.IsLetter(test))
                    {
                        str = str.ToUpper();
                        if (isfind(ch,str) ==false)
                        {
                            ch.Add(str);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            ch.Sort();
            int length = ch.Count;
            Console.WriteLine(length);


            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    {
                        if (j == length)
                        {
                            //ch.RemoveAt(i);

                            break;
                        }
                        else
                        {

                            Console.WriteLine(ch[i] + ch[j]);
                        }
                    }
                }
                
            }

            Console.ReadKey();
            
        }
    }
}
