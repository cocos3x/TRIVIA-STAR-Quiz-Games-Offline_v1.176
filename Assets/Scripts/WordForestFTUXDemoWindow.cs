using UnityEngine;
public class WordForestFTUXDemoWindow : WordAddictFTUXDemoWindow
{
    // Fields
    private int ftuxWordsCompleted;
    
    // Methods
    protected override UnityEngine.RectTransform GetMaskWordRegion(int stepNum)
    {
        var val_4;
        if(stepNum == 2)
        {
            goto label_1;
        }
        
        if(stepNum != 1)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  "en", b:  1800251696)) == false)
        {
            goto label_4;
        }
        
        val_4 = 1152921512828867240;
        return;
        label_1:
        label_4:
        val_4 = 1152921512828867232;
    }
    protected override UnityEngine.RectTransform GetMaskPan(int stepNum)
    {
        var val_4;
        if(stepNum == 2)
        {
            goto label_1;
        }
        
        if(stepNum != 1)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  "en", b:  1800251696)) == false)
        {
            goto label_4;
        }
        
        val_4 = 1152921512828979244;
        return;
        label_1:
        label_4:
        val_4 = 1152921512828979236;
    }
    protected override void UpdateState(string word)
    {
        int val_3 = this.ftuxWordsCompleted;
        val_3 = val_3 + 1;
        this.ftuxWordsCompleted = val_3;
        if(val_3 == 2)
        {
                mem[1152921512829095444] = 4;
        }
        else
        {
                if(val_3 == 1)
        {
                string val_1 = word.ToUpper();
            if((System.String.op_Equality(a:  word, b:  -367710256)) != false)
        {
                return;
        }
        
        }
        
        }
        
        this.UpdateState(word:  word);
    }
    protected override void Progress()
    {
        float val_9;
        var val_12;
        float val_19;
        var val_39;
        var val_40;
        var val_42;
        System.Predicate<LetterTile> val_43;
        var val_44;
        System.Predicate<LetterTile> val_46;
        var val_47;
        System.Predicate<LetterTile> val_49;
        if((System.String.op_Inequality(a:  "en", b:  1800251696)) != false)
        {
                this.Progress();
            return;
        }
        
        MainController val_2 = MainController.instance;
        if(0 != 0)
        {
                MainController val_4 = MainController.instance;
            if(3 != 0)
        {
                3 = 5;
            mem[1152921512829216740] = 3;
        }
        
        }
        
        WordRegion val_5 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_7 = static_value_00280017 + 8 + 16.transform;
        if((static_value_00280017 + 8 + 16) != null)
        {
                val_39 = 0;
        }
        
        UnityEngine.Vector2 val_8 = sizeDelta;
        var val_39 = val_9;
        UnityEngine.Transform val_10 = 0.transform;
        UnityEngine.Vector3 val_11 = localScale;
        val_39 = val_39 * val_12;
        if((-367576940) == 2)
        {
            goto label_26;
        }
        
        if((-367576940) != 1)
        {
            goto label_27;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        0.SetActive(value:  DisplaySkipTutorial);
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_15 = static_value_00280017 + 8 + 16.transform;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_16 = static_value_00280017 + 8 + 20.transform;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_17 = static_value_00280017 + 8 + 24.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = static_value_00280017 + 8 + 16;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = static_value_00280017 + 8 + 20;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = static_value_00280017 + 8 + 24;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_1C = this;
        ShowOverlay(contentToOverlay:  -2028557104);
        UnityEngine.Vector3 val_18 = position;
        this.position = new UnityEngine.Vector3();
        if(this == 0)
        {
            goto label_66;
        }
        
        this.sizeDelta = new UnityEngine.Vector2() {x = val_9, y = val_19};
        goto label_67;
        label_26:
        0.SetActive(value:  false);
        NotificationCenter val_20 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -367564880, aName:  -2084758544);
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_21 = 2621443.transform;
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_22 = 1.transform;
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_23 = 0.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = 2621443;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = 1;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = 0;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_1C = this;
        ShowOverlay(contentToOverlay:  -2028557104);
        UnityEngine.Vector3 val_24 = position;
        this.position = new UnityEngine.Vector3();
        if(this == 0)
        {
            goto label_106;
        }
        
        this.sizeDelta = new UnityEngine.Vector2() {x = val_9, y = val_19};
        goto label_107;
        label_27:
        UnityEngine.Transform val_25 = 0.transform;
        int val_26 = DG.Tweening.ShortcutExtensions.DOKill(target:  0, complete:  false);
        UnityEngine.GameObject val_27 = 0.gameObject;
        0.SetActive(value:  false);
        0.Clear();
        mem[1152921512829216736] = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  -367594080, value:  1);
        bool val_28 = PrefsSerializationManager.SavePlayerPrefs();
        this.CloseWindow();
        goto label_114;
        label_66:
        0.sizeDelta = new UnityEngine.Vector2() {x = val_9, y = val_19};
        label_67:
        UnityEngine.GameObject val_29 = this.gameObject;
        this.SetActive(value:  true);
        GameBehavior val_30 = App.getBehavior;
        string val_31 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  1800251696)) != false)
        {
                val_40 = null;
            val_40 = null;
            val_42 = Pan.tappingAllowed + 48;
            val_43 = WordForestFTUXDemoWindow.<>c.<>9__4_0;
            if(val_43 == 0)
        {
                val_43 = null;
            val_43 = new System.Predicate<ZooTile>(object:  WordForestFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3927373296));
            val_42 = Pan.tappingAllowed + 48;
            WordForestFTUXDemoWindow.<>c.<>9__4_0 = val_43;
        }
        
            int val_34 = val_42.FindIndex(match:  8040448);
            val_44 = null;
            val_44 = null;
            val_46 = WordForestFTUXDemoWindow.<>c.<>9__4_1;
            if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Predicate<ZooTile>(object:  WordForestFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3927376368));
            val_42 = Pan.tappingAllowed + 48;
            WordForestFTUXDemoWindow.<>c.<>9__4_1 = val_46;
        }
        
            int val_36 = val_42.FindIndex(match:  8040448);
            val_47 = null;
            val_47 = null;
            val_49 = WordForestFTUXDemoWindow.<>c.<>9__4_2;
            if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Predicate<ZooTile>(object:  WordForestFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3927377392));
            val_42 = Pan.tappingAllowed + 48;
            WordForestFTUXDemoWindow.<>c.<>9__4_2 = val_49;
        }
        
            int val_38 = val_42.FindIndex(match:  8040448);
        }
    
    }
    public WordForestFTUXDemoWindow()
    {
    
    }

}
