using System.Diagnostics;
using Serilog;

namespace PP_Capital.Jobs.PythonJobs;

public class BasePythonJob(ConfigSettings configSettings, ILogger logger)
{
    protected void RunScript(string scriptPath)
    {
        int timeout = configSettings.PythonTimeoutMs;

        // Create a new process start info
        ProcessStartInfo start = new ProcessStartInfo
        {
            FileName = configSettings.PythonPaths.Python,
            WorkingDirectory = configSettings.PythonPaths.Wd,
            Arguments = scriptPath,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
        };

        // Start the process
        using (Process process = new Process())
        {
            process.StartInfo = start;
            process.Start();

            // Wait for the process to exit, but not longer than the timeout
            bool finishedInTime = process.WaitForExit(timeout);

            if (finishedInTime)
            {
                // If process finished in time, check the output
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                Console.WriteLine("Output: " + output);
                Console.WriteLine("Error: " + error);
            }
            else
            {
                // If process did not finish in time, kill it
                Console.WriteLine($"Process exceeded the timeout of {timeout / 1000} seconds. Killing the process...");
                process.Kill();
            }

            // Ensure the process is completely cleaned up
            process.WaitForExit();
        }
    }
}