using System;
using System.Collections.Generic;

namespace jurnal6
{
    public class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
                throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter.");

            this.id = new Random().Next(10000, 99999); // ID acak
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentNullException("Video tidak boleh null.");

            if (uploadedVideos.Count >= 8)
                throw new InvalidOperationException("Maksimal 8 video yang bisa ditambahkan.");

            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {username}");

            int maxVideos = Math.Min(uploadedVideos.Count, 8);
            for (int i = 0; i < maxVideos; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}