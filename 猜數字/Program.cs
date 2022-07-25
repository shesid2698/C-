//猜數字
int secret_num=116;
int guess;
int guess_count = 0;
bool win=false;


do
{
    Console.Write("請輸入猜測數字:");
    guess = int.Parse(Console.ReadLine());
    guess_count++;

    if (guess > 116)
    {
        System.Console.WriteLine("請猜小一點");
    }
    else if (guess < 116)
    {
        System.Console.WriteLine("請猜大一點");
    }
    else
    {
        System.Console.WriteLine("恭喜答對");
        win = true;
    }
}
while (guess != secret_num && guess_count< 3 );

if (!win)
{
    System.Console.WriteLine("你已經死了");
}