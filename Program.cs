using System;
using tpmodul6_1302210042;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo videoAku = new SayaTubeVideo("Tutorial Design By Contract - Dhafa Arrizki Gusman_1302210042");

        videoAku.IncreasePlayCount(5);

        videoAku.PrintVideoDetails();
    }
}