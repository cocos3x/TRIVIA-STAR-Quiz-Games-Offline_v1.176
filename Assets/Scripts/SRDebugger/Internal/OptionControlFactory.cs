using UnityEngine;

namespace SRDebugger.Internal
{
    public static class OptionControlFactory
    {
        // Fields
        private static System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl> _dataControlPrefabs;
        private static SRDebugger.UI.Controls.Data.ActionControl _actionControlPrefab;
        
        // Methods
        public static SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            var val_10;
            var val_11;
            if(SRDebugger.Internal.OptionControlFactory._dataControlPrefabs == 0)
            {
                    T[] val_1 = UnityEngine.Resources.LoadAll<System.Object>(path:  494173520);
                SRDebugger.Internal.OptionControlFactory._dataControlPrefabs = "SRDebugger/UI/Prefabs/Options";
            }
            
            if(SRDebugger.Internal.OptionControlFactory._actionControlPrefab == 0)
            {
                    T[] val_3 = UnityEngine.Resources.LoadAll<System.Object>(path:  494173520);
                object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  494173520);
                val_10 = null;
                SRDebugger.Internal.OptionControlFactory._actionControlPrefab = "SRDebugger/UI/Prefabs/Options";
            }
            else
            {
                    val_10 = 1152921505028038748;
            }
            
            val_11 = 0;
            if(494173520 == 0)
            {
                    val_11 = 0;
                UnityEngine.Debug.LogError(message:  494175696);
            }
            
            if((from.<Property>k__BackingField) != 0)
            {
                    SRDebugger.UI.Controls.DataBoundControl val_6 = SRDebugger.Internal.OptionControlFactory.CreateDataControl(from:  from, categoryPrefix:  categoryPrefix);
                return;
            }
            
            if((from.<Method>k__BackingField) != 0)
            {
                    SRDebugger.UI.Controls.Data.ActionControl val_7 = SRDebugger.Internal.OptionControlFactory.CreateActionControl(from:  from, categoryPrefix:  null);
                return;
            }
            
            System.Exception val_8 = new System.Exception(message:  494184064);
        }
        private static SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            UnityEngine.Object val_3;
            string val_4;
            UnityEngine.RectTransform val_1 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  SRDebugger.Internal.OptionControlFactory._actionControlPrefab);
            val_3 = SRDebugger.Internal.OptionControlFactory._actionControlPrefab;
            if(val_3 == 0)
            {
                    val_3 = 0;
                UnityEngine.Debug.LogWarning(message:  494322864);
                return;
            }
            
            if(from != 0)
            {
                    val_4 = from.<Name>k__BackingField;
            }
            else
            {
                    val_4 = 0;
            }
            
            if(val_3 != 0)
            {
                    val_3.SetMethod(methodName:  null, method:  from.<Method>k__BackingField);
            }
            else
            {
                    val_3.SetMethod(methodName:  null, method:  from.<Method>k__BackingField);
            }
            
            SRDebugger.Internal.OptionControlFactory._actionControlPrefab.__unknownFiledOffset_2C = from;
        }
        private static SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            string val_11;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_12;
            var val_13;
            val_11 = categoryPrefix;
            object val_1 = new System.Object();
            typeof(OptionControlFactory.<>c__DisplayClass4_0).__il2cppRuntimeField_8 = from;
            val_12 = null;
            val_12 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  421244928, method:  new IntPtr(494467840));
            object val_3 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  SRDebugger.Internal.OptionControlFactory._dataControlPrefabs, predicate:  7720960);
            if(SRDebugger.Internal.OptionControlFactory._dataControlPrefabs == 0)
            {
                    System.Type val_5 = from + 24.PropertyType;
                typeof(System.Object[]).__il2cppRuntimeField_10 = from + 24;
                val_13 = 0;
                string val_6 = SRF.SRFStringExtensions.Fmt(formatString:  494470912, args:  472754880);
                UnityEngine.Debug.LogWarning(message:  494470912);
                return;
            }
            
            UnityEngine.RectTransform val_7 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  SRDebugger.Internal.OptionControlFactory._dataControlPrefabs);
            val_12 = mem[from + 8];
            val_12 = from + 8;
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    if((val_12.StartsWith(value:  val_11)) != false)
            {
                    string val_10 = val_12.Substring(startIndex:  categoryPrefix.m_stringLength);
                val_12 = val_12;
            }
            
            }
            
            SRDebugger.Internal.OptionControlFactory._dataControlPrefabs.Bind(propertyName:  val_12, prop:  from + 24);
            val_11 = typeof(OptionControlFactory.<>c__DisplayClass4_0).__il2cppRuntimeField_8;
            SRDebugger.Internal.OptionControlFactory._dataControlPrefabs.__unknownFiledOffset_2C = val_11;
            val_13 = SRDebugger.Internal.OptionControlFactory._dataControlPrefabs;
        }
    
    }

}
