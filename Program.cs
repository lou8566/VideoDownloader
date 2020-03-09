using VideoDownloader.con.Downloader;

namespace VideoDownloader.con
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.youtube.com/embed/wzhcZ-aBgBg.mp4";
            var vds = new VideoDownloaderService();
            vds.Download(url);
        }
    }
}
