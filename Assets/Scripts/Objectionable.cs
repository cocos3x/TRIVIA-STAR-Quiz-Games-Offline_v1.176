using UnityEngine;
public class Objectionable
{
    // Fields
    private static bool initialized;
    private static string[] objectionables;
    
    // Methods
    public static bool Valid(string words)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(Objectionable.initialized != true)
        {
                Objectionable.initialize();
        }
        
        val_4 = 0;
        label_16:
        val_5 = null;
        val_5 = null;
        if(val_4 >= (Objectionable.objectionables + 12))
        {
            goto label_9;
        }
        
        val_6 = null;
        val_6 = null;
        string val_1 = Objectionable.objectionables + 12 + 16.ToLower();
        val_7 = 0;
        val_4 = val_4 + 1;
        if((words.Contains(value:  Objectionable.objectionables + 12 + 16)) == false)
        {
            goto label_16;
        }
        
        return (bool)val_7;
        label_9:
        val_7 = 1;
        return (bool)val_7;
    }
    public static string FoundObjectionable(string words)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        val_3 = null;
        val_3 = null;
        if(Objectionable.initialized != true)
        {
                Objectionable.initialize();
        }
        
        val_4 = 0;
        label_16:
        val_5 = null;
        val_5 = null;
        if(val_4 >= (Objectionable.objectionables + 12))
        {
            goto label_9;
        }
        
        val_6 = null;
        val_6 = null;
        string val_1 = Objectionable.objectionables + 12 + 16.ToLower();
        val_7 = Objectionable.objectionables + 12 + 16;
        val_4 = val_4 + 1;
        if((words.Contains(value:  val_7)) == false)
        {
            goto label_16;
        }
        
        return;
        label_9:
        val_7 = System.String.alignConst;
    }
    private static void initialize()
    {
        System.String[] val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = 0;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(158519296)});
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  -1774860464, systemTypeInstance:  158519296);
        if(("data/objectionables") != 0)
        {
                val_8 = null;
            if(null != val_8)
        {
                val_8 = null;
        }
        
            val_7 = 0;
            if(null != val_8)
        {
                "data/objectionables" = 0;
        }
        
            val_7 = "data/objectionables";
        }
        
        string val_3 = val_7.text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_9 = 0;
        System.String[] val_4 = val_7.Split(separator:  478563824);
        val_10 = null;
        val_10 = null;
        Objectionable.objectionables = val_7;
        goto label_13;
        label_26:
        string val_5 = System.Text.RegularExpressions.Regex.Replace(input:  R8 + 16, pattern:  -1774860352, replacement:  1098586544);
        mem2[0] = R8 + 16;
        val_9 = 1;
        val_10 = null;
        label_13:
        val_10 = null;
        if(Objectionable.objectionables == null)
        {
                val_10 = null;
        }
        
        if(val_9 < 0)
        {
            goto label_26;
        }
        
        val_10 = null;
        Objectionable.initialized = true;
    }
    public Objectionable()
    {
    
    }
    private static Objectionable()
    {
    
    }

}
