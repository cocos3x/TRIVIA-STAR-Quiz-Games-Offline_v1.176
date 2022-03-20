using UnityEngine;
public class PrefabLoader : MonoBehaviour
{
    // Fields
    private static bool themed;
    private static Themes themeType;
    private static string gc_type_to_string;
    
    // Methods
    public static T LoadPrefab<T>(string featureName)
    {
        var val_28;
        var val_29;
        var val_30;
        var val_32;
        string val_33;
        var val_34;
        UnityEngine.Object val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        PrefabLoader.CheckTheme();
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        PrefabLoader.gc_type_to_string = __RuntimeMethodHiddenParam + 24;
        if((PrefabLoader.gc_type_to_string.Contains(value:  1297836480)) != false)
        {
                val_28 = null;
            val_28 = null;
            if(PrefabLoader.gc_type_to_string != null)
        {
                val_29 = PrefabLoader.gc_type_to_string.LastIndexOf(value:  1297836480);
        }
        else
        {
                val_29 = 0.LastIndexOf(value:  1297836480);
        }
        
            string val_6 = PrefabLoader.gc_type_to_string.Remove(startIndex:  0, count:  val_29 + 1);
            PrefabLoader.gc_type_to_string = PrefabLoader.gc_type_to_string;
        }
        
        string val_7 = -2017394896(-2017394896) + featureName;
        val_30 = null;
        if(("Prefabs/") != 0)
        {
                "" = "Prefabs/";
        }
        
        val_30 = null;
        if(PrefabLoader.themed != false)
        {
                string val_8 = null.ToString();
            val_32 = "";
            string val_9 = -2017394896(-2017394896) + 1115175264 + -2017381136(-2017381136) + 1115175264;
        }
        else
        {
                val_32 = "";
            string val_10 = -2017394896(-2017394896) + 1115175264;
        }
        
        val_33 = val_32;
        val_34 = null;
        val_34 = null;
        string val_11 = -2017394896(-2017394896) + PrefabLoader.gc_type_to_string;
        UnityEngine.Texture val_12 = WGResources.Load<UnityEngine.Texture>(fileName:  -2017394896, extension:  -2017393776, errorLog:  true);
        val_35 = val_33;
        if((-2017394896) == 0)
        {
                val_36 = null;
            if(UnityEngine.Application.isEditor != false)
        {
                val_37 = null;
            string val_16 = -2017393680(-2017393680) + -2017394896(-2017394896) + PrefabLoader.gc_type_to_string;
            UnityEngine.Debug.LogError(message:  -2017393680);
        }
        else
        {
                val_38 = null;
            string val_17 = -2017393680(-2017393680) + -2017394896(-2017394896) + PrefabLoader.gc_type_to_string;
            UnityEngine.Debug.LogWarning(message:  -2017393680);
        }
        
            val_39 = null;
            val_39 = null;
            if((PrefabLoader.themed != false) && (PrefabLoader.themeType != 1))
        {
                string val_18 = null.ToString();
            string val_19 = featureName + 1115175264 + -2017381136(-2017381136) + 1115175264;
            val_33 = featureName;
            val_41 = null;
            if(UnityEngine.Application.isEditor != false)
        {
                val_42 = null;
            string val_22 = -2017393504(-2017393504) + val_33 + PrefabLoader.gc_type_to_string;
            UnityEngine.Debug.LogError(message:  -2017393504);
        }
        else
        {
                val_43 = null;
            string val_23 = -2017393296(-2017393296) + val_33 + PrefabLoader.gc_type_to_string;
            UnityEngine.Debug.LogWarning(message:  -2017393296);
        }
        
            val_44 = null;
            val_44 = null;
            string val_24 = val_33 + PrefabLoader.gc_type_to_string;
            UnityEngine.Texture val_25 = WGResources.Load<UnityEngine.Texture>(fileName:  val_33, extension:  -2017393776, errorLog:  true);
            val_35 = val_33;
        }
        
            if(val_35 == 0)
        {
                val_45 = null;
            val_45 = null;
            val_46 = 0;
            string val_27 = -2017393680(-2017393680) + val_33 + PrefabLoader.gc_type_to_string;
            UnityEngine.Debug.LogError(message:  -2017393680);
            return;
        }
        
        }
        
        val_46 = val_35;
    }
    public static UnityEngine.GameObject LoadPrefab(string featureName, string prefabName)
    {
        var val_18;
        var val_20;
        string val_21;
        UnityEngine.Object val_22;
        var val_23;
        PrefabLoader.CheckTheme();
        string val_1 = -2017394896(-2017394896) + featureName;
        val_18 = null;
        if(("Prefabs/") != 0)
        {
                "" = "Prefabs/";
        }
        
        val_18 = null;
        if(PrefabLoader.themed != false)
        {
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            PrefabLoader.themeType = ;
            val_20 = "";
            string val_2 = -2017394896(-2017394896) + 1115175264 + 346484736 + 1115175264;
        }
        else
        {
                val_20 = "";
            string val_3 = -2017394896(-2017394896) + 1115175264;
        }
        
        val_21 = val_20;
        string val_4 = -2017394896(-2017394896) + prefabName;
        UnityEngine.Texture val_5 = WGResources.Load<UnityEngine.Texture>(fileName:  -2017394896, extension:  -2017393776, errorLog:  true);
        val_22 = val_20;
        if((-2017394896) != 0)
        {
                return;
        }
        
        string val_8 = -2017393680(-2017393680) + -2017394896(-2017394896) + prefabName;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.LogError(message:  -2017393680);
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  -2017393680);
        }
        
        val_23 = null;
        val_23 = null;
        if((PrefabLoader.themed != false) && (PrefabLoader.themeType != 1))
        {
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_10 = featureName + 1115175264 + 346484736 + 1115175264;
            val_21 = featureName;
            if(UnityEngine.Application.isEditor != false)
        {
                string val_12 = -2017393504(-2017393504) + val_21 + prefabName;
            UnityEngine.Debug.LogError(message:  -2017393504);
        }
        else
        {
                string val_13 = -2017393296(-2017393296) + val_21 + prefabName;
            UnityEngine.Debug.LogWarning(message:  -2017393296);
        }
        
            string val_14 = val_21 + prefabName;
            UnityEngine.Texture val_15 = WGResources.Load<UnityEngine.Texture>(fileName:  val_21, extension:  -2017393776, errorLog:  true);
            val_22 = val_21;
        }
        
        if(val_22 != 0)
        {
                return;
        }
        
        val_22 = 0;
        string val_17 = -2017393680(-2017393680) + val_21 + prefabName;
        UnityEngine.Debug.LogError(message:  -2017393680);
    }
    private static void CheckTheme()
    {
        var val_6;
        bool val_8;
        var val_9;
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 == 0)
        {
            goto label_10;
        }
        
        AppConfigs val_3 = App.Configuration;
        if(0 == 0)
        {
            goto label_10;
        }
        
        ThemesHandler val_4 = App.ThemesHandler;
        val_6 = null;
        val_6 = null;
        PrefabLoader.themeType = static_value_0028000F;
        if(PrefabLoader.themeType != 0)
        {
                static_value_0028000F = 1;
        }
        
        if(PrefabLoader.themeType == 0)
        {
                val_8 = 0;
        }
        
        goto label_19;
        label_10:
        val_9 = null;
        val_9 = null;
        val_8 = false;
        label_19:
        PrefabLoader.themed = val_8;
    }
    public PrefabLoader()
    {
    
    }
    private static PrefabLoader()
    {
    
    }

}
