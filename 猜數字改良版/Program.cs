using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜數字改良版
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random secret = new Random();
            int ans = secret.Next(-10,10);
            bool win = true;
            Console.WriteLine("====猜數字遊戲====");
            int count = 1;
            while (win)
            {
                
                Console.Write("請輸入數字 : ");
                int input = int.Parse(Console.ReadLine());
 
                if (input < ans)
                {
                    Console.WriteLine("再大一點");
                }
                else if (input > ans)
                {
                    Console.WriteLine("再小一點");
                }
                else
                {
                    Console.WriteLine("答對了");
                    win = false;
                    break;
                }

                if (count == 3)
                {
                    Console.WriteLine("你輸了!!");
                    win = false;
                }
                count++;
            }
            Console.ReadLine();
           
        }
    }
}
