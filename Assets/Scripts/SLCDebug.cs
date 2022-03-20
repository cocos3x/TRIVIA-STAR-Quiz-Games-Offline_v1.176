using UnityEngine;
public static class SLCDebug
{
    // Fields
    private static int maxLength;
    private static string logs;
    private static bool errorOccurred;
    
    // Methods
    public static string GetLogs()
    {
        null = null;
    }
    public static void Log(string logMessage, string colorHash = "#FFFFFF", bool isError = False)
    {
        string val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        int val_13;
        val_7 = isError;
        val_8 = 35636125;
        val_9 = null;
        val_9 = null;
        if(SLCDebug.errorOccurred == true)
        {
                return;
        }
        
        if(val_7 != false)
        {
                val_9 = null;
            val_10 = 1152921504901419016;
            SLCDebug.errorOccurred = true;
        }
        
        val_9 = null;
        val_8 = 0;
        val_7 = SLCDebug.logs;
        float val_1 = UnityEngine.Time.time;
        string val_2 = 0.ToString(format:  -1773242864);
        string val_3 = System.String.Format(format:  -1773242768, arg0:  -1773230676, arg1:  colorHash, arg2:  logMessage);
        string val_4 = val_7 + -1773242768(-1773242768);
        val_11 = null;
        SLCDebug.logs = val_7;
        if(SLCDebug.logs == null)
        {
                val_11 = null;
        }
        
        if(SLCDebug.logs != null)
        {
                val_13 = SLCDebug.maxLength;
            val_7 = mem[SLCDebug.logs + 8];
            val_7 = SLCDebug.logs.m_stringLength;
        }
        else
        {
                val_7 = mem[SLCDebug.logs + 8];
            val_7 = SLCDebug.logs.m_stringLength;
            val_13 = SLCDebug.maxLength;
        }
        
        string val_6 = SLCDebug.logs.Substring(startIndex:  val_7 - val_13);
        SLCDebug.logs = SLCDebug.logs;
    }
    private static SLCDebug()
    {
        SLCDebug.maxLength = 10000;
        SLCDebug.logs = "";
        SLCDebug.errorOccurred = false;
    }

}
