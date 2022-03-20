using UnityEngine;
public class HintMeterHandler : HintFeatureHandler
{
    // Fields
    private static HintMeterHandler _Instance;
    private int progress;
    public System.Action<int> hintMeterUpdate;
    
    // Properties
    public static HintMeterHandler Instance { get; }
    public int progressTowardsFreeHint { get; set; }
    public int freeHintsRemaining { get; set; }
    private bool hasSeenSuperHintFtux { get; set; }
    public override bool freeHintEligable { get; }
    public override bool hasFreeHintsRemaining { get; }
    
    // Methods
    public static HintMeterHandler get_Instance()
    {
    
    }
    public int get_progressTowardsFreeHint()
    {
        return CPlayerPrefs.GetInt(key:  -1204954560, defaultValue:  0);
    }
    public void set_progressTowardsFreeHint(int value)
    {
        CPlayerPrefs.SetInt(key:  -1204954560, val:  value);
    }
    public int get_freeHintsRemaining()
    {
        return CPlayerPrefs.GetInt(key:  -1204730448, defaultValue:  0);
    }
    public void set_freeHintsRemaining(int value)
    {
        CPlayerPrefs.SetInt(key:  -1204730448, val:  value);
    }
    private bool get_hasSeenSuperHintFtux()
    {
        return CPlayerPrefs.GetBool(key:  -1204506352, defaultValue:  false);
    }
    private void set_hasSeenSuperHintFtux(bool value)
    {
        CPlayerPrefs.SetBool(key:  -1204506352, value:  value);
    }
    private void Awake()
    {
        HintMeterHandler._Instance = this;
    }
    public override void OnLevelStarted()
    {
        int val_1 = this.freeHintsRemaining;
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.DoFreeHints();
    }
    public override bool get_freeHintEligable()
    {
        return false;
    }
    public override void OnHintUsed(bool freeHint)
    {
        var val_21;
        var val_22;
        if((CPlayerPrefs.HasKey(key:  -1204954560)) != true)
        {
                val_21 = 1152921504901095424;
            val_22 = 1152921511135858672;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2060922896) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_7 = Localization.Localize(key:  -1203946112, defaultValue:  -1203946256, useSingularKey:  false);
            val_21 = "hintmeter_tooltip";
            public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.SetPopup(message:  -1203946112, interactablePopup:  false);
        }
        
        }
        
        }
        
        int val_8 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.progressTowardsFreeHint;
        val_8.progressTowardsFreeHint = val_8 + 1;
        int val_10 = val_8.progressTowardsFreeHint;
        if((val_10 == 3) && (val_10.hasSeenSuperHintFtux != true))
        {
                val_21 = 1152921504901095424;
            val_22 = 1152921511135858672;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2060922896) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_17 = Localization.Localize(key:  -1203945888, defaultValue:  -1203946000, useSingularKey:  false);
            val_21 = "hintmeterfull_tooltip";
            public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.SetPopup(message:  -1203945888, interactablePopup:  false);
        }
        
        }
        
            public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.hasSeenSuperHintFtux = true;
        }
        
        int val_18 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.progressTowardsFreeHint;
        if(val_18 == 4)
        {
                val_18.progressTowardsFreeHint = 0;
            GameEcon val_19 = App.getGameEcon;
            this.freeHintsRemaining = 68;
            this.Invoke(methodName:  -1203945776, time:  null);
        }
        
        if(this.hintMeterUpdate == 0)
        {
                return;
        }
        
        this.hintMeterUpdate.Invoke(obj:  this.progressTowardsFreeHint);
    }
    public override void OnMyFreeHintUsed()
    {
        this.progressTowardsFreeHint = 0;
    }
    public override bool get_hasFreeHintsRemaining()
    {
        return true;
    }
    private void DoFreeHints()
    {
        System.Func<LineWord, System.Boolean> val_24;
        System.Func<Cell, System.Boolean> val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_30;
        val_24 = 1152921504901095424;
        val_25 = 1152921511135858672;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = 1152921504765685760;
        val_27 = 0;
        if((-2060922896) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = 0;
            val_26 = 1152921504765685760;
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_26 = 1152921504765685760;
        }
        
        }
        
        if(freeHintsRemaining < 1)
        {
                return;
        }
        
        do
        {
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.ToggleInteractable(state:  false);
        }
        
            WordRegion val_8 = WordRegion.instance;
            if(0 == 0)
        {
                return;
        }
        
            WordRegion val_10 = WordRegion.instance;
            val_28 = null;
            val_28 = null;
            val_24 = HintMeterHandler.<>c.<>9__22_0;
            if(val_24 == 0)
        {
                val_24 = null;
            val_24 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  HintMeterHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3091365808));
            HintMeterHandler.<>c.<>9__22_0 = val_24;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Where<System.Object>(source:  0, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
            if(0 == 0)
        {
                return;
        }
        
            int val_14 = UnityEngine.Random.Range(min:  0, max:  0);
            if(0 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_24 = 0;
            val_24 = val_24 + (val_14 << 2);
            val_30 = null;
            val_30 = null;
            val_25 = HintMeterHandler.<>c.<>9__22_1;
            if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  HintMeterHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3091366832));
            HintMeterHandler.<>c.<>9__22_1 = val_25;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_16 = System.Linq.Enumerable.Where<System.Object>(source:  (0 + (val_14) << 2) + 16 + 20, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<System.Object>(source:  (0 + (val_14) << 2) + 16 + 20);
            val_24 = (0 + (val_14) << 2) + 16 + 20;
            if(((0 + (val_14) << 2) + 16 + 20 + 12) == 0)
        {
                return;
        }
        
            int val_18 = UnityEngine.Random.Range(min:  0, max:  (0 + (val_14) << 2) + 16 + 20 + 12);
            if(((0 + (val_14) << 2) + 16 + 20 + 12) <= val_18)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_25 = (0 + (val_14) << 2) + 16 + 20 + 8;
            val_25 = val_25 + (val_18 << 2);
            val_24 = mem[((0 + (val_14) << 2) + 16 + 20 + 8 + (val_18) << 2) + 16];
            val_24 = ((0 + (val_14) << 2) + 16 + 20 + 8 + (val_18) << 2) + 16;
            WordRegion val_19 = WordRegion.instance;
            val_25 = 0;
            int val_20 = this.freeHintsRemaining;
            val_20.freeHintsRemaining = val_20 - 1;
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.ToggleInteractable(state:  true);
        }
        
        }
        while((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.freeHintsRemaining) > 0);
    
    }
    public HintMeterHandler()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
