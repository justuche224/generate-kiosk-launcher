using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string url = "https://app.pinebusinessgrow.com";

        string[] browsers =
        {
            @"C:\Program Files\Google\Chrome\Application\chrome.exe",
            @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
            @"C:\Program Files\Microsoft\Edge\Application\msedge.exe",
            @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
            @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe",
            @"C:\Program Files (x86)\BraveSoftware\Brave-Browser\Application\brave.exe"
        };

        string browserPath = browsers.FirstOrDefault(File.Exists);

        if (browserPath == null)
        {
            Console.WriteLine("Could not find Chrome, Edge, or Brave.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            return;
        }

        string arguments = "--kiosk --kiosk-printing \"" + url + "\"";

        Process.Start(new ProcessStartInfo
        {
            FileName = browserPath,
            Arguments = arguments,
            UseShellExecute = false
        });
    }
}