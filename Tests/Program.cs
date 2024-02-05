using System.Diagnostics;

ProcessStartInfo startInfo = new ProcessStartInfo
{
    FileName = "bash",
    Arguments = "./executar-teste-local.sh",
    RedirectStandardOutput = false,
    RedirectStandardError = false,
    UseShellExecute = false,
    CreateNoWindow = false
};
using Process processo = new() { StartInfo = startInfo };

processo.Start();

Console.ReadLine();
