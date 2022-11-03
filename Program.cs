using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //array to be searched
        string [] okta = new string[86];
        //number of element in the array
        int n;
        //get the number of element to store in the array
        int i;
        public void input()
        {
            while(true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n < 86))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 element.\n");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter array element");
            Console.WriteLine("-----------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                okta[i] = Console.ReadLine();
            }
        }
        public void insertionsort()
        {
            string temp = null;
            for (int i = 1; i < okta.Length - 1; i++)
            {
                for (int OR = i + 1; OR > 0; OR--)
                {
                    if (okta[OR].CompareTo(okta[OR - 1]) < 0)
                    {
                        temp = okta[OR];
                        okta[OR] = okta[OR - 1];
                        okta[OR - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
