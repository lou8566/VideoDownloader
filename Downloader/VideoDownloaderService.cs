using System;
using VideoLibrary;

namespace VideoDownloader.con.Downloader
{
    public class VideoDownloaderService
    {
        public void Download(string url)
        {
            var videoUri = url;
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(videoUri);
            var path = "/youtube/" + video.FullName;
            Console.WriteLine("Downloading...");
            System.IO.File.WriteAllBytes(path, video.GetBytes());
            Console.WriteLine("Completed");
        }


    }
}
