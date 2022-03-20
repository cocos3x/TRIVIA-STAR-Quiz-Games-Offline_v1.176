using UnityEngine;
public class D
{
    // Fields
    public const string vLog = "log";
    public const string vWarn = "warn";
    public const string vError = "error";
    public static string[] typeList;
    
    // Methods
    public static void LogClientError(string developer, string filter = "default", UnityEngine.Object context, object[] strings)
    {
        var val_3;
        object val_4;
        val_3 = 0;
        string val_1 = filter + 1788552112 + developer + 1788552112;
        val_4 = filter;
        goto label_1;
        label_4:
        string val_2 = val_4 + 472754880;
        val_3 = 1;
        val_4 = val_4;
        label_1:
        if(val_3 < val_4)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.LogError(message:  val_4, context:  context);
    }
    public static void LogS(object[] strings)
    {
        var val_3;
        var val_4;
        if((D.allow(filter:  1788750208)) == false)
        {
                return;
        }
        
        val_3 = 0;
        val_4 = "default : NA : ";
        goto label_4;
        label_7:
        string val_2 = 1788750304 + 472754880;
        val_3 = 1;
        val_4 = val_4;
        label_4:
        if(val_3 < val_4)
        {
            goto label_7;
        }
        
        D.LogOut(text:  1788750304, visualType:  1788750416, context:  0);
    }
    public static void Log(string developer = "NA", string filter = "default", string visualType = "log", UnityEngine.Object context, object[] strings)
    {
        var val_4;
        object val_5;
        if((D.allow(filter:  filter)) == false)
        {
                return;
        }
        
        val_4 = 0;
        string val_2 = filter + 1788552112 + developer + 1788552112;
        val_5 = filter;
        goto label_4;
        label_7:
        string val_3 = val_5 + 472754880;
        val_4 = 1;
        val_5 = val_5;
        label_4:
        if(val_4 < val_5)
        {
            goto label_7;
        }
        
        D.LogOut(text:  val_5, visualType:  visualType, context:  context);
    }
    public static void LogB(string developer = "NA", string filter = "default", string visualType = "log", bool show = False, UnityEngine.Object context, object[] strings)
    {
        var val_4;
        object val_5;
        if(show == false)
        {
                return;
        }
        
        if((D.allow(filter:  filter)) == false)
        {
                return;
        }
        
        val_4 = 0;
        string val_2 = filter + 1788552112 + developer + 1788552112;
        val_5 = filter;
        goto label_5;
        label_8:
        string val_3 = val_5 + 472754880;
        val_4 = 1;
        val_5 = val_5;
        label_5:
        if(val_4 < val_5)
        {
            goto label_8;
        }
        
        D.LogOut(text:  val_5, visualType:  visualType, context:  context);
    }
    public static void LogF(string developer = "NA", string filter = "default", string visualType = "log", string formatString = "{0}", UnityEngine.Object context, object[] strings)
    {
        if((D.allow(filter:  filter)) == false)
        {
                return;
        }
        
        string val_2 = filter + 1788552112 + developer + 1788552112;
        string val_3 = filter + formatString;
        string val_4 = System.String.Format(format:  filter, args:  strings);
        D.LogOut(text:  filter, visualType:  visualType, context:  context);
    }
    public static void LogC(System.Func<string> callback, string developer = "NA", string filter = "default", string visualType = "log", UnityEngine.Object context)
    {
        if((D.allow(filter:  filter)) == false)
        {
                return;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = filter;
        typeof(System.String[]).__il2cppRuntimeField_14 = " : ";
        typeof(System.String[]).__il2cppRuntimeField_18 = developer;
        typeof(System.String[]).__il2cppRuntimeField_1C = " : ";
        string val_2 = callback.Invoke();
        typeof(System.String[]).__il2cppRuntimeField_20 = callback;
        string val_3 = +477709520;
        D.LogOut(text:  477709520, visualType:  visualType, context:  context);
    }
    public static void LogC(string formatString, System.Func<string> callback, string developer = "NA", string filter = "default", string visualType = "log", UnityEngine.Object context)
    {
        if((D.allow(filter:  filter)) == false)
        {
                return;
        }
        
        string val_2 = filter + 1788552112 + developer + 1788552112;
        string val_3 = filter + formatString;
        string val_4 = callback.Invoke();
        string val_5 = System.String.Format(format:  filter, arg0:  callback);
        D.LogOut(text:  filter, visualType:  visualType, context:  context);
    }
    private static void LogOut(string text, string visualType, UnityEngine.Object context)
    {
        if((System.String.op_Equality(a:  visualType, b:  1789890464)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  text, context:  context);
            return;
        }
        
        if((System.String.op_Equality(a:  visualType, b:  1622838032)) != false)
        {
                UnityEngine.Debug.LogError(message:  text, context:  context);
            return;
        }
        
        UnityEngine.Debug.Log(message:  text, context:  context);
    }
    private static bool allow(string filter)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((System.Array.IndexOf<System.String>(array:  D.typeList, value:  1790019952)) > 1)
        {
                return true;
        }
        
        val_4 = null;
        val_4 = null;
        var val_3 = ~(System.Array.IndexOf<System.String>(array:  D.typeList, value:  filter));
        val_3 = val_3 >> 31;
        return (bool)val_3;
    }
    public D()
    {
    
    }
    private static D()
    {
        D.typeList = null;
    }

}
