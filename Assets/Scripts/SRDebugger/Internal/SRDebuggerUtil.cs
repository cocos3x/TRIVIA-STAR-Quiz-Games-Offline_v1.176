using UnityEngine;

namespace SRDebugger.Internal
{
    public static class SRDebuggerUtil
    {
        // Properties
        public static bool IsMobilePlatform { get; }
        
        // Methods
        public static bool get_IsMobilePlatform()
        {
            if(UnityEngine.Application.isMobilePlatform != false)
            {
                    return true;
            }
            
            var val_3 = 0;
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            val_3 = val_3 - 18;
            if(val_3 < 3)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool EnsureEventSystemExists()
        {
            var val_9 = 0;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(184 == 0)
            {
                    return (bool)val_9;
            }
            
            val_9 = 0;
            UnityEngine.EventSystems.EventSystem val_2 = UnityEngine.EventSystems.EventSystem.current;
            if(0 != 0)
            {
                    return (bool)val_9;
            }
            
            object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
            if(1636743952 != 0)
            {
                    UnityEngine.GameObject val_6 = gameObject;
                if(activeSelf != false)
            {
                    val_9 = 0;
                if(enabled == true)
            {
                    return (bool)val_9;
            }
            
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  497568912);
            SRDebugger.Internal.SRDebuggerUtil.CreateDefaultEventSystem();
            val_9 = 1;
            return (bool)val_9;
        }
        public static void CreateDefaultEventSystem()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  1636744976);
            if(null != 0)
            {
                    object val_2 = AddComponent<System.Object>();
            }
            else
            {
                    object val_3 = AddComponent<System.Object>();
            }
            
            object val_4 = AddComponent<System.Object>();
        }
        public static System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> ScanForOptions(object obj)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_17 = 0;
            System.Type val_2 = obj.GetType();
            object val_17 = obj;
            val_17 = val_17 + 16;
            goto label_3;
            label_27:
            object val_3 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  (obj + 16) + 0);
            if(((obj + 16) + 0) != 0)
            {
                    string val_4 = (obj + 16) + 0.Category;
                val_18 = (obj + 16) + 0;
            }
            else
            {
                    val_18 = "Default";
            }
            
            object val_5 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  (obj + 16) + 0);
            if(((obj + 16) + 0) == 0)
            {
                    (obj + 16) + 0 + 8 = 0;
            }
            
            object val_6 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  (obj + 16) + 0);
            if(((obj + 16) + 0) == 0)
            {
                goto label_7;
            }
            
            if(((obj + 16) + 0) == 0)
            {
                goto label_24;
            }
            
            val_19 = mem[(obj + 16) + 0 + 8];
            val_19 = (obj + 16) + 0 + 8;
            goto label_9;
            label_7:
            val_19 = (obj + 16) + 0;
            label_9:
            if(((obj + 16) + 0.IsStatic) != true)
            {
                    System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(21884928)});
                if(((System.Type.op_Inequality(left:  (obj + 16) + 0, right:  21884928)) != true) && (((obj + 16) + 0 + 12) == 0))
            {
                    object val_11 = null;
                val_20 = val_11;
                val_11 = new System.Object();
                typeof(SRDebugger.Internal.OptionDefinition).__il2cppRuntimeField_8 = val_19;
                typeof(SRDebugger.Internal.OptionDefinition).__il2cppRuntimeField_C = val_18;
                typeof(SRDebugger.Internal.OptionDefinition).__il2cppRuntimeField_10 = (obj + 16) + 0 + 8;
                typeof(SRDebugger.Internal.OptionDefinition).__il2cppRuntimeField_14 = new SRF.Helpers.MethodReference(target:  obj, method:  (obj + 16) + 0);
                Add(item:  421298176);
            }
            
            }
            
            label_24:
            val_17 = 1;
            label_3:
            if(val_17 < (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
            {
                goto label_27;
            }
        
        }
        public static string GetNumberString(int value, int max, string exceedsMaxString)
        {
            if(value >= max)
            {
                    return;
            }
            
            string val_1 = value.ToString();
        }
        public static void ConfigureCanvas(UnityEngine.Canvas canvas)
        {
            var val_3;
            var val_4;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(52 == 0)
            {
                    return;
            }
            
            SRDebugger.Services.IDebugCameraService val_2 = SRDebugger.Internal.Service.DebugCamera;
            var val_5 = 6;
            if(308 == 0)
            {
                goto label_4;
            }
            
            var val_4 = 0;
            label_6:
            val_3 = 0;
            if(1179403647 == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            if(val_3 < 308)
            {
                goto label_6;
            }
            
            label_4:
            val_4 = 52;
            goto label_7;
            label_5:
            var val_3 = 0 + 0;
            val_5 = val_5 + (((0 + 0) + 4) << 3);
            val_4 = val_5 + 188;
            label_7:
            if(canvas != 0)
            {
                    canvas.worldCamera = 52;
            }
            else
            {
                    0.worldCamera = 52;
            }
            
            canvas.renderMode = 1;
        }
    
    }

}
