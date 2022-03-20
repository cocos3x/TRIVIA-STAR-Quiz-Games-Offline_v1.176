using UnityEngine;

namespace SRDebugger.Services
{
    public interface IBugReportService
    {
        // Methods
        public abstract void SendBugReport(SRDebugger.Services.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, SRDebugger.Services.BugReportProgressCallback progressCallback); // 0
    
    }

}
