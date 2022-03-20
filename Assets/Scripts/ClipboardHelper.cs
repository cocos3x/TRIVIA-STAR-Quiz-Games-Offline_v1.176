using UnityEngine;
public class ClipboardHelper
{
    // Fields
    private static System.Reflection.PropertyInfo m_systemCopyBufferProperty;
    
    // Properties
    public static string clipBoard { get; set; }
    
    // Methods
    private static System.Reflection.PropertyInfo GetSystemCopyBufferProperty()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((System.Reflection.PropertyInfo.op_Equality(left:  ClipboardHelper.m_systemCopyBufferProperty, right:  0)) == false)
        {
            goto label_3;
        }
        
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(183386112)});
        System.Reflection.PropertyInfo val_3 = GetProperty(name:  1808888080, bindingAttr:  40);
        val_7 = null;
        val_7 = null;
        ClipboardHelper.m_systemCopyBufferProperty = null;
        if((System.Reflection.PropertyInfo.op_Equality(left:  183386112, right:  0)) == true)
        {
            goto label_9;
        }
        
        label_3:
        val_8 = null;
        val_8 = null;
        return;
        label_9:
        System.Exception val_5 = new System.Exception(message:  -1787283744);
    }
    public static string get_clipBoard()
    {
        return UnityEngine.GUIUtility.systemCopyBuffer;
    }
    public static void set_clipBoard(string value)
    {
        UnityEngine.GUIUtility.systemCopyBuffer = value;
    }
    public ClipboardHelper()
    {
    
    }
    private static ClipboardHelper()
    {
    
    }

}
