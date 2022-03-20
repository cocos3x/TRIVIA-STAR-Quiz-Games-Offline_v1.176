using UnityEngine;
private sealed class SRDebugService.<>c__DisplayClass32_0
{
    // Fields
    public SRDebugger.ActionCompleteCallback onComplete;
    
    // Methods
    public SRDebugService.<>c__DisplayClass32_0()
    {
    
    }
    internal void <ShowBugReportSheet>b__0(bool succeed, string message)
    {
        if(this.onComplete == 0)
        {
                return;
        }
        
        this.onComplete.Invoke(success:  succeed);
    }

}
