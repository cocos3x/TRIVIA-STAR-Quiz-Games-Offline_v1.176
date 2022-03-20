using UnityEngine;
public static class SRDebugUtil
{
    // Fields
    public const int LineBufferCount = 512;
    private static bool <IsFixedUpdate>k__BackingField;
    
    // Properties
    public static bool IsFixedUpdate { get; set; }
    
    // Methods
    public static bool get_IsFixedUpdate()
    {
        return (bool)SRDebugUtil.<IsFixedUpdate>k__BackingField;
    }
    public static void set_IsFixedUpdate(bool value)
    {
        SRDebugUtil.<IsFixedUpdate>k__BackingField = value;
    }
    public static void AssertNotNull(object value, string message, UnityEngine.MonoBehaviour instance)
    {
        var val_5;
        System.Collections.Generic.EqualityComparer<T> val_1 = System.Collections.Generic.EqualityComparer<System.Object>.Default;
        if((public static System.Collections.Generic.EqualityComparer<T> System.Collections.Generic.EqualityComparer<System.Object>::get_Default()) == 0)
        {
                return;
        }
        
        if(R5 == 0)
        {
                val_5 = "Assert Failed";
        }
        else
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = ???;
            string val_2 = SRF.SRFStringExtensions.Fmt(formatString:  -635288544, args:  472754880);
            val_5 = "NotNullAssert Failed: {0}";
        }
        
        UnityEngine.Debug.LogError(message:  -635288544, context:  R8);
        if(R8 != 0)
        {
                R8.enabled = false;
        }
        
        System.NullReferenceException val_4 = new System.NullReferenceException(message:  -635288544);
    }
    public static void Assert(bool condition, string message, UnityEngine.MonoBehaviour instance)
    {
        var val_3;
        if(condition == true)
        {
                return;
        }
        
        if(R5 == 0)
        {
                val_3 = "Assert Failed";
        }
        else
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = ???;
            string val_1 = SRF.SRFStringExtensions.Fmt(formatString:  -635154912, args:  472754880);
            val_3 = "Assert Failed: {0}";
        }
        
        UnityEngine.Debug.LogError(message:  -635154912, context:  R4);
        System.Exception val_2 = new System.Exception(message:  -635154912);
    }
    public static void EditorAssertNotNull(object value, string message, UnityEngine.MonoBehaviour instance)
    {
        SRDebugUtil.AssertNotNull(value:  value, message:  message, instance:  instance);
    }
    public static void EditorAssert(bool condition, string message, UnityEngine.MonoBehaviour instance)
    {
        SRDebugUtil.Assert(condition:  condition, message:  message, instance:  instance);
    }

}
