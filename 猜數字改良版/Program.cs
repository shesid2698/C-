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
                string tips = "";
                if (input < ans)
                {
                    tips = "再大一點";
                    Console.WriteLine(tips);
                }
                else if (input > ans)
                {
                    tips = "再小一點";
                    Console.WriteLine(tips);
                }
                else
                {
                    tips = "答對了";
                    Console.WriteLine(tips);
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
