using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210042
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = GenerateRandomId();
            this.title = title;
            this.playCount = 0;
        }

        // men-generate id secara random

        private int GenerateRandomId()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }

        public void IncreasePlayCount (int hitungPemutaran)
        {
            this.playCount += hitungPemutaran;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah Pemutaran: {playCount}");
        }
    }
}
