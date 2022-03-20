using UnityEngine;
public class LightningLevelsUIController : MonoSingleton<LightningLevelsUIController>
{
    // Fields
    protected UnityEngine.GameObject lightningEventButtonPrefab;
    protected UnityEngine.Transform eventButton;
    protected UnityEngine.GameObject lightningEffectsPrefab;
    private UnityEngine.Transform lightningEffectsParent;
    private UnityEngine.Transform mainLayout;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button menuButton;
    private UnityEngine.UI.Button petsButton;
    protected FrameSkipper frameSkipper;
    protected WGLightningProgressPopup lightningStrikeFlyout;
    protected bool closedPreviousFlyout;
    protected LightningEvents thisEvent;
    protected System.Collections.Generic.List<UnityEngine.GameObject> lightningEffects;
    protected bool isTimerPaused;
    protected bool isAppPaused;
    private WGEventButtonProgressLightningLevels eventProgressUI;
    private LightningCountdownButton <lightningEventButton>k__BackingField;
    
    // Properties
    public bool IsTimerPaused { get; }
    public WGEventButtonProgressLightningLevels EventProgressUI { get; }
    public LightningCountdownButton lightningEventButton { get; set; }
    private bool useRevisedUX { get; }
    
    // Methods
    public bool get_IsTimerPaused()
    {
        return (bool)this.isTimerPaused;
    }
    public WGEventButtonProgressLightningLevels get_EventProgressUI()
    {
        var val_4;
        WGEventButtonProgressLightningLevels val_5;
        if(this.eventProgressUI == 0)
        {
                MainController val_2 = MainController.instance;
            val_4 = 256;
            val_5 = 0;
            WGEventButtonV2 val_3 = val_4.GetEventButton(eventId:  -1266462304);
            if(val_4 != 0)
        {
                val_4 = 1;
        }
        
            this.eventProgressUI = val_5;
            return;
        }
        
        val_5 = this.eventProgressUI;
    }
    public LightningCountdownButton get_lightningEventButton()
    {
    
    }
    public void set_lightningEventButton(LightningCountdownButton value)
    {
        this.<lightningEventButton>k__BackingField = value;
    }
    private bool get_useRevisedUX()
    {
        var val_1;
        var val_1 = 26266163;
        val_1 = 9359624 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        GameNames val_2 = App.game;
        val_2 = val_2 - 18;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public override void InitMonoSingleton()
    {
        UnityEngine.Events.UnityAction val_10;
        var val_10 = 26268379;
        val_10 = 9359804 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        this.thisEvent = 1;
        UnityEngine.Transform val_1 = this.transform;
        twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -1175019008);
        this.frameSkipper = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.storeButton)) != false)
        {
                val_10 = null;
            val_10 = new UnityEngine.Events.UnityAction(object:  -1175019008, method:  new IntPtr(3119898576));
            this.storeButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.menuButton)) != false)
        {
                val_10 = null;
            val_10 = new UnityEngine.Events.UnityAction(object:  -1175019008, method:  new IntPtr(3119898576));
            this.menuButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.petsButton)) != false)
        {
                val_10 = null;
            val_10 = new UnityEngine.Events.UnityAction(object:  -1175019008, method:  new IntPtr(3119898576));
            this.petsButton.m_OnClick.AddListener(call:  162246656);
        }
        
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1175019008, name:  -1175043120);
    }
    protected void OnApplicationQuit()
    {
        var val_4;
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        val_4 = 35628183;
        val_5 = 1152921504932298752;
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(this.isAppPaused == true)
        {
                return;
        }
        
        if(R6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((R7 + 92) == 0)
        {
            
        }
    
    }
    protected void OnApplicationFocus(bool focus)
    {
        LightningLevelsEventHandler val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField.InExpireInterval()) != false)
        {
                this.ResetAll();
            return;
        }
        
        val_4 = LightningLevelsEventHandler.<Instance>k__BackingField;
        if(val_4 != 0)
        {
                val_4 = focus ^ 1;
            this.isAppPaused = val_4;
        }
    
    }
    protected void OnApplicationPause(bool pause)
    {
        LightningLevelsEventHandler val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField.InExpireInterval()) != false)
        {
                this.ResetAll();
            return;
        }
        
        val_4 = LightningLevelsEventHandler.<Instance>k__BackingField;
        if(val_4 != 0)
        {
                this.isAppPaused = pause;
        }
        
        if(pause != true)
        {
                return;
        }
        
        if(this.isTimerPaused == true)
        {
                return;
        }
        
        this.isTimerPaused = true;
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    public virtual void ShowLightningEffects(bool isFTUX = False)
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.<lightningEventButton>k__BackingField, y:  0);
        if(val_1 != false)
        {
                if(val_1.useRevisedUX != true)
        {
                UnityEngine.Transform val_3 = this.eventButton.parent;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.lightningEventButtonPrefab, parent:  this.eventButton);
            object val_5 = this.lightningEventButtonPrefab.GetComponent<System.Object>();
            this.<lightningEventButton>k__BackingField = this.lightningEventButtonPrefab;
        }
        
        }
        
        if(this.lightningEventButtonPrefab.useRevisedUX == false)
        {
            goto label_9;
        }
        
        WGEventButtonProgressLightningLevels val_7 = this.EventProgressUI;
        this.lightningEventButtonPrefab.alpha = null;
        this.UpdateTimertext();
        if(isFTUX == true)
        {
            goto label_16;
        }
        
        goto label_16;
        label_9:
        twelvegigs.Autopilot.WUTAutopilotGameplay val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.eventButton);
        this.eventButton.alpha = null;
        if(isFTUX != false)
        {
                this.UpdateTimertext();
        }
        else
        {
                this.ShowLightningStrikeFlyout();
        }
        
        label_16:
        System.Action val_9 = new System.Action(object:  -1174508544, method:  typeof(LightningLevelsUIController).__il2cppRuntimeField_110);
        this.frameSkipper.updateLogic = null;
        this.UpdateWordRegionLightningEffects();
    }
    public virtual void DestroyLightningEffects()
    {
        UnityEngine.Object val_9;
        if((UnityEngine.Object.op_Implicit(exists:  this.frameSkipper)) != false)
        {
                this.frameSkipper.updateLogic = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.<lightningEventButton>k__BackingField)) != false)
        {
                UnityEngine.GameObject val_3 = this.<lightningEventButton>k__BackingField.gameObject;
            UnityEngine.Object.Destroy(obj:  this.<lightningEventButton>k__BackingField);
        }
        
        if((this.<lightningEventButton>k__BackingField.useRevisedUX) != true)
        {
                object val_5 = this.eventButton.GetComponent<System.Object>();
            if(this.eventButton != 0)
        {
                this.eventButton.alpha = null;
        }
        
        }
        
        if(this.lightningEffects == 0)
        {
            goto label_24;
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        UnityEngine.Object.Destroy(obj:  val_9);
        goto label_21;
        label_18:
        Dispose();
        if(this.lightningStrikeFlyout != 0)
        {
                if(this.closedPreviousFlyout != true)
        {
                this.lightningStrikeFlyout.ClosePopup();
            this.lightningStrikeFlyout = 0;
        }
        
            this.closedPreviousFlyout = false;
        }
        
        label_24:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.lightningEffects = null;
    }
    protected void ShowLightningStrikeFlyout()
    {
        if((this.lightningStrikeFlyout != 0) && (this.closedPreviousFlyout != true))
        {
                this.lightningStrikeFlyout.ClosePopup();
            this.closedPreviousFlyout = true;
        }
        
        GameBehavior val_2 = App.getBehavior;
        this.lightningStrikeFlyout = 0;
        0.Setup(e:  this.thisEvent);
        goto typeof(LightningLevelsUIController).__il2cppRuntimeField_104;
    }
    protected virtual void ShowFTUX()
    {
        if(this.useRevisedUX != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
            WGEventButtonProgressLightningLevels val_5 = this.EventProgressUI;
            UnityEngine.Transform val_6 = this.transform;
            ShowFTUX(eventButton:  -1174042496, onClose:  0);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.Transform val_9 = this.<lightningEventButton>k__BackingField.transform;
        System.Action val_10 = new System.Action(object:  -1174042496, method:  new IntPtr(3120899776));
        ShowFTUX(eventButton:  this.<lightningEventButton>k__BackingField, mainLayout:  this.mainLayout, onClose:  7454720);
    }
    protected virtual void PlayLightningSFX()
    {
        null = null;
        MonoSingleton<T>.searchedFailed + 12.PlayGameSpecificSound(id:  -1173946304, randomIndex:  false, vol:  null);
    }
    protected virtual void UpdateTimer()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_20 = this;
        val_21 = 9366644 + 26261539;
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = 1152921504932298752;
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            goto typeof(LightningLevelsUIController).__il2cppRuntimeField_F4;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField.InExpireInterval()) != false)
        {
                this.ResetAll();
            return;
        }
        
        if(this.useRevisedUX != true)
        {
                twelvegigs.Autopilot.WUTAutopilotGameplay val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  R4 + 16);
            R4 + 16.alpha = null;
        }
        
        if(R6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((R7 + 92.HasValidQueuedWindows()) == true)
        {
            goto label_40;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_23 = 1152921504765685760;
        if((-1261410688) != 0)
        {
            goto label_40;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1173834192) != 0)
        {
            goto label_40;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_10 = UnityEngine.Object.op_Inequality(x:  -1508394992, y:  0);
        if(val_10 == false)
        {
                val_10 = mem[R4 + 65];
            val_10 = R4 + 65;
        }
        
        if(val_10 == 0)
        {
            goto label_23;
        }
        
        label_40:
        if((R4 + 64) == 0)
        {
                mem2[0] = 1;
            if(R6 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        if((R7 + 92.useRevisedUX) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_24 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            val_25 = 1152921512022948400;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_24 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            val_25 = 1152921512022949424;
        }
        
        object val_15 = GetWindow<System.Object>();
        R4.ShowOrHideLightningEffects(show:  isActiveAndEnabled);
        return;
        label_23:
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1173831120) != 0)
        {
            goto label_40;
        }
        
        if((R4 + 64) != 0)
        {
                mem2[0] = 0;
            if(R6 == 0)
        {
                mem2[0] = 1;
        }
        
            R4.ShowOrHideLightningEffects(show:  true);
        }
        
        R4.UpdateWordRegionLightningEffects();
        R4.UpdateTimertext();
    }
    protected void UpdateTimertext()
    {
        int val_1;
        var val_9;
        var val_9 = 26265275;
        val_9 = 9362908 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if(val_1.useRevisedUX != true)
        {
                val_1 = val_1.Minutes;
            int val_5 = val_1.Seconds;
            string val_6 = System.String.Format(format:  -1173714000, arg0:  13152256, arg1:  13152256);
            var val_10 = 26262591;
            val_10 = 9363196 + val_10;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            if(App.__il2cppRuntimeField_cctor_finished != 0)
        {
                App.game - 18 = 50;
        }
        
            this.<lightningEventButton>k__BackingField.SetupCountdownText(text:  -1173714000, size:  50);
        }
        
        double val_8 = val_1.TotalSeconds;
    }
    private void ResetAll()
    {
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    private void OnInAppPurchaseStarted()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                return;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField.InExpireInterval()) != false)
        {
                this.ResetAll();
            return;
        }
        
        this.isTimerPaused = true;
        this.isAppPaused = true;
    }
    private void ShowOrHideLightningEffects(bool show)
    {
        UnityEngine.GameObject val_1 = this.lightningEffectsParent.gameObject;
        this.lightningEffectsParent.SetActive(value:  show);
    }
    private void HideLightningEffects()
    {
        this.ShowOrHideLightningEffects(show:  false);
    }
    private void UpdateWordRegionLightningEffects()
    {
        twelvegigs.sweepstakes.Distribution val_11;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  -1173141616);
        object val_2 = GetComponent<System.Object>();
        GetWorldCorners(fourCornersArray:  533912224);
        UnityEngine.Vector3[].__il2cppRuntimeField_element_class = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 + UnityEngine.Vector3[].__il2cppRuntimeField_element_class;
        var val_15 = 0;
        Il2CppClass* val_3 = UnityEngine.Vector3[].__il2cppRuntimeField_element_class * 0.5f;
        do
        {
            UnityEngine.Vector3[].__il2cppRuntimeField_element_class = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 - val_3;
            Il2CppType val_4 = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg * 37f;
            UnityEngine.Vector3 val_5;
            UnityEngine.Vector3[].__il2cppRuntimeField_element_class = UnityEngine.Vector3[].__il2cppRuntimeField_element_class * 10f;
            val_4 = val_4 / 40f;
            UnityEngine.Vector3[].__il2cppRuntimeField_element_class = UnityEngine.Vector3[].__il2cppRuntimeField_element_class / 11f;
            UnityEngine.Vector3[].__il2cppRuntimeField_element_class = val_3 + UnityEngine.Vector3[].__il2cppRuntimeField_element_class;
            val_5 = new UnityEngine.Vector3(x:  UnityEngine.Vector3[].__il2cppRuntimeField_element_class, y:  null, z:  val_4);
            val_15 = val_15 + 1;
        }
        while(val_15 != 4);
        
        float val_16 = 0f;
        do
        {
            val_16 = val_16 + 1;
            var val_18 = 0;
            if(val_15 != 4)
        {
                val_16 - 3 = val_16;
        }
        
            val_16 = (val_16 - 3) + ((val_16 - 3) << 1);
            val_16 = 1152921505140759216 + (val_16 << 2);
            val_16 = val_16 + 4;
            float val_8 = val_16 + 0;
            val_8 = 1152921505140759216 + (val_8 << 2);
            float val_10 = val_8 + 8;
            val_8 = val_8 + 4;
            do
        {
            if(mem[1152921512023665112].childCount > 19)
        {
                if((mem[1152921512023665148] + 12) <= (0 + val_18))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_17 = mem[1152921512023665148] + 8;
            val_17 = val_17 + 16;
            val_11 = mem[(mem[1152921512023665148] + 8 + 16) + 0];
            val_11 = (mem[1152921512023665148] + 8 + 16) + 0;
        }
        else
        {
                object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921512023665108], parent:  mem[1152921512023665112]);
            val_11 = mem[1152921512023665108];
            mem[1152921512023665148].Add(item:  val_11);
        }
        
            if((val_16 & (~2147483649)) == 2)
        {
                val_14 = mem[((1152921505140759216 + (((0 + 1) + ((0 + 1)) << 1)) << 2) + 4)];
            val_14 = val_16;
            val_15 = mem[(1152921505140759216 + (((0 + 1) + ((0 + 1)) << 1)) << 2)];
            val_15 = val_16;
            val_16 = val_8;
            val_17 = val_8;
            val_18 = val_10;
        }
        else
        {
                val_14 = mem[((1152921505140759216 + ((0 + 0)) << 2) + 4)];
            val_14 = val_8;
            val_15 = mem[(1152921505140759216 + ((0 + 0)) << 2)];
            val_15 = val_8;
            val_16 = val_16;
            val_17 = val_16;
            val_18 = val_16 + 8;
        }
        
            object val_14 = val_11.GetComponent<System.Object>();
            val_11.Setup(start:  new UnityEngine.Vector3() {x = val_15, y = val_14, z = val_10}, end:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            val_18 = val_18 + 1;
        }
        while(val_18 != 5);
        
        }
        while(val_16 != 4);
    
    }
    public LightningLevelsUIController()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.lightningEffects = null;
    }

}
