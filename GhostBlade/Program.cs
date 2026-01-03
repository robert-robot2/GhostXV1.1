using System.Diagnostics;

namespace GhostBlade
{
   internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from C#");

            Process p = new Process();
            p.StartInfo.FileName = @"C:\Development2\GhostX\X64\Release\GhostBladeX.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;

            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine("Output from C++:");
            Console.WriteLine(output);
        }
    }
}


