using UnityEngine;
public static class UnityLoggerListener
{
    // Fields
    private const int MAX_LOGS = 10;
    private static readonly object _threadLock;
    public static SRDebugger.CircularBuffer<string> _allConsoleEntries;
    
    // Methods
    private static void RegisterForLogs()
    {
        var val_5;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        SRDebugger.CircularBuffer<System.String> val_3 = new SRDebugger.CircularBuffer<System.String>(capacity:  10);
        val_5 = null;
        val_5 = null;
        UnityLoggerListener._allConsoleEntries = null;
        Application.LogCallback val_4 = new Application.LogCallback(object:  0, method:  new IntPtr(3511176256));
        UnityEngine.Application.add_logMessageReceivedThreaded(value:  150691840);
    }
    private static void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type)
    {
        object val_7;
        SRDebugger.CircularBuffer<System.String> val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_7 = condition;
        val_8 = 35628734;
        if((type & (~1)) == 2)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        System.Threading.Monitor.Enter(obj:  UnityLoggerListener._threadLock, lockTaken: ref  bool val_2 = true);
        string val_3 = System.String.Format(format:  -783665728, arg0:  val_7, arg1:  stackTrace);
        val_10 = null;
        val_10 = null;
        if((UnityLoggerListener._allConsoleEntries + 16) <= 0)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        if(UnityLoggerListener._allConsoleEntries == 0)
        {
            goto label_10;
        }
        
        val_12 = mem[UnityLoggerListener._allConsoleEntries + 16];
        val_12 = UnityLoggerListener._allConsoleEntries + 16;
        goto label_11;
        label_7:
        val_8 = "";
        goto label_12;
        label_10:
        val_12 = 2621443;
        label_11:
        string val_5 = UnityLoggerListener._allConsoleEntries.Item[val_12 - 1];
        val_8 = UnityLoggerListener._allConsoleEntries;
        label_12:
        val_7 = 0;
        if((val_8.Equals(value:  -783665728)) != true)
        {
                val_13 = null;
            val_13 = null;
            if(UnityLoggerListener._allConsoleEntries.IsFull != false)
        {
                val_14 = null;
            val_14 = null;
            UnityLoggerListener._allConsoleEntries.PopFront();
        }
        
            val_15 = null;
            val_15 = null;
            val_8 = UnityLoggerListener._allConsoleEntries;
            val_8.PushBack(item:  -783665728);
        }
        
        if(0 != 0)
        {
                System.Threading.Monitor.Exit(obj:  UnityLoggerListener._threadLock);
        }
        
        if(val_7 == 0)
        {
                return;
        }
    
    }
    private static UnityLoggerListener()
    {
        UnityLoggerListener._threadLock = new System.Object();
    }

}
