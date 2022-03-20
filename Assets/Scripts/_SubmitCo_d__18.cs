using UnityEngine;
private sealed class BugReportSheetController.<SubmitCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRDebugger.UI.Other.BugReportSheetController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BugReportSheetController.<SubmitCo>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SRDebugger.UI.Other.BugReportSheetController val_16;
        int val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Byte[] val_22;
        var val_23;
        val_16 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_17 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        if(SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData != null)
        {
            goto label_9;
        }
        
        if((this.<>4__this.TakingScreenshot) != 0)
        {
                this.<>4__this.TakingScreenshot.Invoke();
        }
        
        val_17 = 1;
        this.<>1__state = val_17;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_17;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.ScreenshotComplete) != 0)
        {
                this.<>4__this.ScreenshotComplete.Invoke();
        }
        
        label_9:
        object val_2 = SRF.Service.SRServiceManager.GetService<System.Object>();
        typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_C = this.<>4__this.EmailField.m_Text;
        typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_18 = this.<>4__this.DescriptionField.m_Text;
        SRDebugger.Services.IConsoleService val_4 = SRDebugger.Internal.Service.Console;
        var val_15 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_17;
        }
        
        var val_14 = 0;
        label_19:
        val_18 = mem[mem[1179403735] + 0];
        val_18 = mem[1179403735] + 0;
        if(val_18 == null)
        {
            goto label_18;
        }
        
        val_14 = val_14 + 1;
        if(((uint)val_14 & 65535) < mem[1179403825])
        {
            goto label_19;
        }
        
        label_17:
        val_19 = 0;
        goto label_20;
        label_2:
        this.<>1__state = 0;
        System.Collections.IEnumerator val_5 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotCaptureCo();
        val_18 = 0;
        UnityEngine.Coroutine val_6 = val_16.StartCoroutine(routine:  0);
        this.<>1__state = 2;
        this.<>2__current = val_16;
        val_17 = 1;
        return (bool)val_17;
        label_18:
        var val_7 = mem[1179403735] + 0;
        val_15 = val_15 + (((mem[1179403735] + 0) + 4) << 3);
        val_19 = val_15 + 220;
        label_20:
        System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
        typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_8 = 0;
        object val_9 = SRF.Service.SRServiceManager.GetService<System.Object>();
        var val_16 = 0;
        val_18 = mem[as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_58 + 0];
        val_18 = as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_58 + 0;
        if(val_18 != null)
        {
                val_16 = val_16 + 1;
            val_18 = (uint)val_16 & 65535;
            val_20 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
        }
        
        if(new SRDebugger.Services.BugReport() != 0)
        {
                typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_14 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            val_21 = null;
            val_22 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData;
        }
        else
        {
                typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_14 = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            val_22 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData;
            val_21 = 1152921505027932252;
        }
        
        typeof(SRDebugger.Services.BugReport).__il2cppRuntimeField_10 = val_22;
        SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData = 0;
        SRDebugger.Services.BugReportCompleteCallback val_11 = new SRDebugger.Services.BugReportCompleteCallback(object:  val_16, method:  new IntPtr(433858656));
        val_16 = null;
        val_16 = new SRDebugger.Services.BugReportProgressCallback(object:  val_16, method:  new IntPtr(433859680));
        var val_17 = 0;
        val_18 = mem[as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_58 + 0];
        val_18 = as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_58 + 0;
        if(val_18 != null)
        {
                val_17 = val_17 + 1;
            val_23 = public static SRDebugger.Services.IBugReportService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IBugReportService>();
        }
        
        val_17 = 0;
        return (bool)val_17;
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
