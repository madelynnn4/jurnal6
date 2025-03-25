using System;

namespace jurnal6;

public class Program1
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Valentino Bimo");
        SayaTubeVideo video = new SayaTubeVideo("Video1");
        SayaTubeVideo video2 = new SayaTubeVideo("Video2");
        SayaTubeVideo video3 = new SayaTubeVideo("Video3");
        
        user.AddVideo(video);
        user.AddVideo(video2);
        user.AddVideo(video3);

        video.IncreasePlayCount(500);
        video2.IncreasePlayCount(1000);
        video3.IncreasePlayCount(1500);

        user.PrintAllVideoPlayCount();
    }
}