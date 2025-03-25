using System;

namespace jurnal6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeUser user = new SayaTubeUser("Valentino Bimo");

                for (int i = 1; i <= 10; i++) 
                {
                    try
                    {
                        SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Valentino Bimo");
                        user.AddVideo(video);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Gagal menambahkan video ke-{i}: {ex.Message}");
                    }
                }

                user.PrintAllVideoPlayCount();

                SayaTubeVideo testVideo = new SayaTubeVideo("Test Video");
                try
                {
                    testVideo.IncreasePlayCount(30000000); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat menambah play count: {ex.Message}");
                }

                testVideo.PrintVideoDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}