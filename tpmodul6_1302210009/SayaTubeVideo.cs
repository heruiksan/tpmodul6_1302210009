using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210009
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 100 && title != null, "judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.");
            this.title = title;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount > 10000000 || playCount<0, "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
                catch (OverflowException e)
            {
                Console.WriteLine("Overflow exception : " + e.Message);
            }
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}