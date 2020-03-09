using System;
using VideoDownloader.con.Downloader;

namespace VideoDownloader.con
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage VideoDownloader.con.exe <videoId>");
                Console.Read();
                return;
            }
            var videoId = args[0];
            var url = $"https://www.youtube.com/embed/{videoId}.mp4";
            var vds = new VideoDownloaderService();
            vds.Download(url);
        }
    }
}
