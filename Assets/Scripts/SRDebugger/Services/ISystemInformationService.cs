using UnityEngine;

namespace SRDebugger.Services
{
    public interface ISystemInformationService
    {
        // Methods
        public abstract System.Collections.Generic.IEnumerable<string> GetCategories(); // 0
        public abstract System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(string category); // 0
        public abstract void Add(SRDebugger.InfoEntry info, string category = "Default"); // 0
        public abstract System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> CreateReport(bool includePrivate = False); // 0
    
    }

}
