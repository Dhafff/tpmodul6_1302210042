using System;
using tpmodul6_1302210042;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo videoAku = new SayaTubeVideo("Tutorial Design By Contract - Dhafa Arrizki Gusman_1302210042");

            videoAku.IncreasePlayCount(5);

            videoAku.PrintVideoDetails();

            videoAku.IncreasePlayCount(10000000); // men-trigger OverflowException
        } catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        } catch (OverflowException)
        {
            Console.WriteLine("Jumlah pemutaran melebihi batas maksimum");
        }
    }
}