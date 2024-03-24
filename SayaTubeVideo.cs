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
            // kondisi untuk title maks panjang char 100 dan tidak null
            if (title == null || title.Length > 100 )
            {
                throw new ArgumentException("Judul video melebihi 100 kata atau belum diisi");
            }

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
            if (hitungPemutaran < 0 || hitungPemutaran > 10000)
            {
                throw new ArgumentException("Jumlah penambahan pemutaran tidak valid");
            }

            try
            {
                checked
                {
                    this.playCount += hitungPemutaran;
                }
            } catch (OverflowException)
            {
                Console.WriteLine("Jumlah pemutaran melebihi batas maksimal");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah Pemutaran: {playCount}");
        }
    }
}
