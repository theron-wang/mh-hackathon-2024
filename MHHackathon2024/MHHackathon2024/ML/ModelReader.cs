using System.Diagnostics;
using System.Reflection;

namespace MHHackathon2024.ML;

public class ModelReader : IModelReader
{
    public async Task<string> GetRecommendedField(List<int> input)
    {
        var processInfo = new ProcessStartInfo("py.exe")
        {
            ArgumentList = { "ModelHMH24.py", string.Join(",", input) },
            WorkingDirectory = Path.Join(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ML"),
            RedirectStandardOutput = true
        };

        var process = Process.Start(processInfo);
        process!.BeginOutputReadLine();

        string output = "";

        process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
        {
            output += e.Data;
        };

        await process.WaitForExitAsync();

        return output;
    }
}
