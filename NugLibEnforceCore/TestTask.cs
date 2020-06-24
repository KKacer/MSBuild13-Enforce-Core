using System.Diagnostics;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace ProDevelopers.ProBuild.Tasks
{
    public class TestTask : Task
    {

        public override bool Execute()
        {
            Log.LogMessage(importance: MessageImportance.High, "==== MHM: We are currently in the custom task! ");
            Process.Start("notepad.exe");
            return true;
        }
    }
}
