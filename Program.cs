namespace FlipCoin
{
    class FlipCoin
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number you want flip coin");
            int flips = Convert.ToInt32(Console.ReadLine());
            float headPercentage = 0, tailPercentage = 0;
            int head = 0, tail = 0;

            for(int i = 0; i < flips; i++)
            {
                Random random = new Random();
               int coin= random.Next(2);

                if (coin == 0)
                {

                    head++;
                    Console.WriteLine("head increment " + head);
                }
                else if(coin==1)
                {

                    tail++;
                    Console.WriteLine("tail increment " + tail);
                }

            }
            headPercentage = (head * 100) / flips;
            Console.WriteLine("Head percentage is "+headPercentage);

            tailPercentage = (tail * 100) / flips;
            Console.WriteLine("tail percentage is " + tailPercentage);

        }
    }
}