using System;
public class Kata
{
    public static int SquareDigits(int n)
    {
        string nn = "";
        int number = 0;
        int tensPlace = (int)Math.Pow(10, n.ToString().Length);
        do
        {
            n -= tensPlace * number;
            tensPlace /= 10;
            number = n / tensPlace;
            nn = nn.Insert(nn.Length,Math.Pow(number, 2).ToString());
        } while (tensPlace > 1);
        return Convert.ToInt32(nn);
    }
}
