using System;

namespace jurnal6
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 200)
                throw new ArgumentException("Judul video tidak boleh kosong dan maksimal 200 karakter.");

            this.id = new Random().Next(10000, 99999); // ID acak
            this.title = title;
            this.playCount = 0;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
                throw new ArgumentException("Play count tidak boleh negatif.");
            if (count > 25000000)
                throw new ArgumentException("Play count maksimal 25.000.000 per panggilan method.");
            
            checked
            {
                try
                {
                    this.playCount += count;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR: Play count melebihi batas integer maksimum.");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}, Judul: {title}, Play Count: {playCount}");
        }
    }
}