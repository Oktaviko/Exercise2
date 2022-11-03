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
            
                while (true)
                {
                    Console.Write("enter the number of element in the array : ");
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
                Console.WriteLine("Enter array element : ");
                Console.WriteLine("-----------------");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    okta[i] = Console.ReadLine();
                }
;        }
        public void insertionsort()
        {
            char ch;
            do
            {
                //add variabel
                string temp;
                int OR = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    temp = okta[i];
                    OR = i - 1;

                    while ((OR >= 0) && (okta[OR].CompareTo(temp) > 0))
                    {
                        okta[OR + 1] = okta[OR];

                        OR--;
                    }
                    okta[OR + 1] = temp;
                    
                }
                Console.WriteLine("\nContinue search y/n :");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while (( ch == 'y'));
        }
        public void meregsort(int low, int mid, int up)
        {
            char ch;
            do
            {
                //accept the number to be reached 
                Console.Write("\nEnter the elements you want to search : ");
                int item = Convert.ToInt32((Console.ReadLine()));

                int h, i, OR, k;
                if (low < mid)
                {
                    //partition list into two parts
                    //one containing elements less that or equal to k
                    h = low;
                    i = mid;
                    OR = mid + 1;
                    k = up;
                }
                Console.WriteLine("\nContinue serach y/n : ");
                ch = char.Parse((Console.ReadLine().ToUpper()));
            } while ((ch == 'y'));
           
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu option");
                    Console.WriteLine("=============");
                    Console.WriteLine("1. Insertionsort : ");
                    Console.WriteLine("2. Mergesort :");
                    Console.WriteLine("3. Exit ");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("..........");
                            Console.WriteLine("Insertionsort");
                            Console.WriteLine("..........");
                            myList.input();
                            myList.insertionsort();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("..........");
                            Console.WriteLine("Mergesort");
                            Console.WriteLine("..........");
                            myList.input();
                            
                            break ;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.Write("\nPilih menu lagi? y/n :");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');
                //to exit from the console
                Console.WriteLine("\n\nPress return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
