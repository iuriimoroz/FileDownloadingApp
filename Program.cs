using System;

namespace FileDownloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourceUrl;
            string targetdownloadedFile;

                Console.WriteLine("Input the URL where the file you wish to download located and press [Enter] button:");
                sourceUrl = Console.ReadLine();
                Console.WriteLine("Input the path where to save downloaded file and its name e.g. C:\\FileLocation\\filename.txt and press [Enter] button:");
                targetdownloadedFile = Console.ReadLine();
                DownloadManager downloadManager = new DownloadManager();
                downloadManager.DownloadFile(sourceUrl, targetdownloadedFile);
                Console.ReadKey();
        }

    }
}
