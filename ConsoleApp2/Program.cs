using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int erkek = 0;
        int kadın = 0;

        for (int i = 0; i < 100; i++)
        {
            int sayi = rand.Next(0, 2);

            if (sayi == 0)
            {
                erkek++;
            }
            else
            {
                while(sayi == 1)
                {
                    kadın++;
                    sayi = rand.Next(0, 2);
                }
                erkek++;

            }

        }
        Console.WriteLine("erkek sayisi = " + erkek);
        Console.WriteLine("kadin sayisi =" + kadın);
    }
}
