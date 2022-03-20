using UnityEngine;
public class WGScreenshotButton : MyButton
{
    // Methods
    private void Awake()
    {
        var val_4;
        object val_1 = this.GetComponent<System.Object>();
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  42997264, method:  new IntPtr(42972240));
        System.Delegate val_3 = System.Delegate.Combine(a:  R6, b:  7401472);
        val_4 = R6;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        mem[1152921513239779132] = val_4;
    }
    private void HandleConnectionClick(bool result)
    {
        var val_11;
        System.Action val_13;
        var val_14;
        var val_15;
        if(result != false)
        {
                WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_11 = null;
            val_11 = null;
            val_13 = WGScreenshotButton.<>c.<>9__1_0;
            if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Action(object:  WGScreenshotButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(43086288));
            WGScreenshotButton.<>c.<>9__1_0 = val_13;
        }
        
            public static WGScreenshotter MonoSingletonSelfGenerating<WGScreenshotter>::get_Instance().__il2cppRuntimeField_10 = val_13;
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Collections.IEnumerator val_4 = TakeScreenshot(postToFacebook:  false);
            UnityEngine.Coroutine val_5 = StartCoroutine(routine:  43085264);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_8 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_9 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_10 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_14 = null;
        val_14 = null;
        val_15 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        if(val_15 == 0)
        {
                val_15 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        }
        
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public WGScreenshotButton()
    {
    
    }

}
