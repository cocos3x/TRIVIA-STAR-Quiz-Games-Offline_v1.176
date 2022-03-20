using UnityEngine;
private sealed class BugReportPopoverService.<OpenCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool takeScreenshot;
    public SRDebugger.Services.Implementation.BugReportPopoverService <>4__this;
    public string descriptionText;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BugReportPopoverService.<OpenCo>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if(this.takeScreenshot == false)
        {
            goto label_4;
        }
        
        System.Collections.IEnumerator val_1 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotCaptureCo();
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this.takeScreenshot);
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = this.<>4__this;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_6 = 0;
        if((System.String.IsNullOrEmpty(value:  this.descriptionText)) == true)
        {
                return (bool)val_6;
        }
        
        val_6 = 0;
        this.<>4__this._sheet.DescriptionField.text = this.descriptionText;
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        label_4:
        UnityEngine.GameObject val_4 = this.<>4__this._popover.CachedGameObject;
        val_6 = 1;
        this.<>4__this._popover.SetActive(value:  true);
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_6;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
