using UnityEngine;

namespace SRDebugger.Services
{
    public class BugReport
    {
        // Fields
        public System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry> ConsoleLog;
        public string Email;
        public byte[] ScreenshotData;
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> SystemInformation;
        public string UserDescription;
        
        // Methods
        public BugReport()
        {
        
        }
    
    }

}
