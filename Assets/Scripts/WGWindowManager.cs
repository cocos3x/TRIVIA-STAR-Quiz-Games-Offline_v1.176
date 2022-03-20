using UnityEngine;
public class WGWindowManager : SLCWindowManager<WGWindowManager>
{
    // Fields
    private UnityEngine.Coroutine waitingForGeneration;
    
    // Properties
    protected override System.Type myWindowType { get; }
    private bool surpressPopups { get; }
    
    // Methods
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(395206656)});
    }
    private bool get_surpressPopups()
    {
        return false;
    }
    public override void InitMonoSingleton()
    {
        var val_8;
        var val_9;
        var val_10;
        this.InitMonoSingleton();
        UnityEngine.Transform val_1 = this.transform;
        object val_2 = this.GetComponentInChildren<System.Object>();
        val_8 = null;
        val_8 = null;
        SLCWindowManager<T>.color_show_available_popups.__il2cppRuntimeField_8 = this;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  85272176, name:  -2005054624);
        val_9 = null;
        val_9 = null;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  85272176, method:  new IntPtr(85246128));
        WordApp.DeferredGameUIReadyEvent.AddListener(call:  162246656);
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  85272176, method:  new IntPtr(85247152));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_10 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_15;
        }
        
        }
        
        val_10 = 0;
        label_15:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_10;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        this.HandleApplicationPause(paused:  pauseStatus);
    }
    private void OnApplicationFocus(bool focus)
    {
        focus = focus ^ 1;
        this.HandleApplicationPause(paused:  focus);
    }
    private void HandleApplicationPause(bool paused)
    {
        var val_1;
        if(paused != false)
        {
                return;
        }
        
        var val_1 = 29569552;
        val_1 = 6056236 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(TrackingComponent.lastIntent != 0)
        {
                return;
        }
        
        R4.ShowAvailablePopups(fromMinimize:  true, entry:  85584176);
    }
    private void OnWordAppUIReady()
    {
        this.ShowAvailablePopups(fromMinimize:  false, entry:  85696288);
    }
    private void OnFacebookPluginUpdate()
    {
    
    }
    private void OnScreenChanged(SceneType type)
    {
        var val_9;
        if(this.waitingForGeneration != 0)
        {
                this.StopCoroutine(routine:  this.waitingForGeneration);
            this.waitingForGeneration = 0;
        }
        
        WordRegion val_1 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_3 = WordRegion.instance;
            System.Action val_4 = new System.Action(object:  85953728, method:  new IntPtr(85928592));
            0.addOnLevelLoadCompleteAction(callback:  7454720);
            return;
        }
        
        if(type == 2)
        {
                GameBehavior val_5 = App.getBehavior;
            val_9 = 0;
            if(val_9 != 0)
        {
                System.Collections.IEnumerator val_6 = this.WaitingForGeneration();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  85953728);
            this.waitingForGeneration = this;
            return;
        }
        
        }
        
        GameBehavior val_8 = App.getBehavior;
        val_9 = 0;
        if(val_9 == 0)
        {
                return;
        }
        
        this.ShowAvailablePopups(fromMinimize:  false, entry:  85929616);
    }
    private System.Collections.IEnumerator WaitingForGeneration()
    {
        object val_1 = new System.Object();
        typeof(WGWindowManager.<WaitingForGeneration>d__12).__il2cppRuntimeField_8 = 0;
        typeof(WGWindowManager.<WaitingForGeneration>d__12).__il2cppRuntimeField_10 = this;
    }
    private void onWordRegionLoaded()
    {
        this.ShowAvailablePopups(fromMinimize:  false, entry:  85929616);
    }
    public void ShowAvailablePopups(bool fromMinimize = False, string entry = "")
    {
        var val_70;
        var val_70 = 29569289;
        val_70 = 6056500 + val_70;
        if(val_70 == 0)
        {
                mem2[0] = 1;
        }
        
        val_70 = null;
        val_70 = null;
        if(WordApp.deferredEventHasFired == false)
        {
            goto label_6;
        }
        
        string val_1 = System.String.Format(format:  86278016, arg0:  entry);
        this.AddOp(info:  86278016, hexColor:  86278176);
        Player val_2 = App.Player;
        if(2621448.ShouldShowGdprConsent() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(27620000 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldShowNotif() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_11 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        }
        
        GameBehavior val_12 = App.getBehavior;
        if(0 != 0)
        {
                GameBehavior val_13 = App.getBehavior;
            GameEcon val_14 = App.getGameEcon;
            if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  381)) != false)
        {
                Player val_16 = App.Player;
            if((System.String.op_Equality(a:  static_value_002800C0, b:  -1927030208)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_19 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1146476848) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CheckAvailable() != false)
        {
                GameBehavior val_24 = App.getBehavior;
            if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TryShowDailyBonus();
        }
        
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1671729424) != 0)
        {
                GameBehavior val_28 = App.getBehavior;
            if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_30 = ShowTournamentResults();
        }
        
        }
        
        GameBehavior val_31 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1448559232) != 0)
        {
                if(SceneDictator.IsInGameScene() == false)
        {
            goto label_90;
        }
        
        }
        
        }
        
        GameBehavior val_35 = App.getBehavior;
        if((0 != 0) && (SceneDictator.IsInGameScene() != false))
        {
                twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_38 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameplayTutorial();
            return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_41 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
            goto label_122;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((canCollectSubscription(subPackage:  0)) == true)
        {
            goto label_118;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_45 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((canCollectSubscription(subPackage:  1)) == false)
        {
            goto label_122;
        }
        
        label_118:
        twelvegigs.Autopilot.AutopilotManager val_47 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_48 = ShowUGUIMonolith<System.Object>(showNext:  false);
        label_122:
        if((SceneDictator.IsInGameScene() == false) || (Alphabet2Manager.IsAvailable == false))
        {
            goto label_150;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_51 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(canAddGameplayTile == false)
        {
            goto label_150;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_53 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsCollectionBoxFull() == false)
        {
            goto label_139;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_55 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_56 = ShowUGUIMonolith<System.Object>(showNext:  false);
        goto label_150;
        label_90:
        twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TryShowLobbyTutorial();
        return;
        label_139:
        twelvegigs.Autopilot.AutopilotManager val_58 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(ShouldShowFTUX() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_60 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_61 = ShowUGUIMonolith<System.Object>(showNext:  false);
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_24 = 0;
        }
        
        label_150:
        twelvegigs.Autopilot.AutopilotManager val_62 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(33337520 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_64 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CheckAvailable() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_66 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_67 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        }
        
        if(WGInviteManager.CanShowFTUX() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_69 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowFTUX();
        }
    
    }
    private bool ShowHintTutorial()
    {
        var val_61;
        GameBehavior val_1 = App.getBehavior;
        if((0 == 0) || (WGHintButtonDemoPopup.CheckAvailable() == false))
        {
            goto label_8;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            goto label_13;
        }
        
        GameBehavior val_4 = App.getBehavior;
        GameBehavior val_5 = App.getBehavior;
        if(0 != 0)
        {
            goto label_152;
        }
        
        GameBehavior val_6 = App.getBehavior;
        string val_8 = Localization.Localize(key:  86399488, defaultValue:  86399616, useSingularKey:  false);
        string val_9 = Localization.Localize(key:  86399808, defaultValue:  86399904, useSingularKey:  false);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_12 = HintButtonGroup;
        Add(item:  2124183120);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_14 = ShuffleButtonGroup;
        Add(item:  2124183120);
        label_162:
        0.Setup(description:  86399488, buttonText:  86399808, featureTargets:  80883712);
        goto label_32;
        label_8:
        GameBehavior val_15 = App.getBehavior;
        if(0 == 0)
        {
            goto label_51;
        }
        
        GameBehavior val_16 = App.getBehavior;
        if(0 == 0)
        {
            goto label_51;
        }
        
        GameBehavior val_17 = App.getBehavior;
        GameEcon val_18 = App.getGameEcon;
        if(((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  18)) == false) || (Prefs.HasUsedHintMega == true))
        {
            goto label_51;
        }
        
        GameBehavior val_21 = App.getBehavior;
        if(0 == 0)
        {
            goto label_56;
        }
        
        label_51:
        GameBehavior val_22 = App.getBehavior;
        if(0 == 0)
        {
            goto label_86;
        }
        
        GameBehavior val_23 = App.getBehavior;
        if(0 == 0)
        {
            goto label_86;
        }
        
        GameBehavior val_24 = App.getBehavior;
        GameBehavior val_25 = App.getBehavior;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == false)
        {
            goto label_75;
        }
        
        GameBehavior val_27 = App.getBehavior;
        GameBehavior val_28 = App.getBehavior;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == true)
        {
            goto label_84;
        }
        
        label_75:
        if((WADPetsManager.GetUnlockedPetByAbility(ability:  1)) == false)
        {
            goto label_86;
        }
        
        label_84:
        if(Prefs.HasUsedHintPicker == true)
        {
            goto label_86;
        }
        
        GameBehavior val_32 = App.getBehavior;
        if(0 == 0)
        {
            goto label_91;
        }
        
        label_86:
        twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
            goto label_106;
        }
        
        GameBehavior val_35 = App.getBehavior;
        if(0 == 0)
        {
            goto label_106;
        }
        
        GameBehavior val_36 = App.getBehavior;
        if(0 != 0)
        {
            goto label_106;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(TryShowFtux() == true)
        {
            goto label_152;
        }
        
        label_106:
        twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1929661328) == 0)
        {
            goto label_115;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_41 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CheckFTUX() == true)
        {
            goto label_152;
        }
        
        label_115:
        twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(((-372701824) == 0) || (SceneDictator.IsInGameScene() == false))
        {
            goto label_152;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_46 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance()) != 0)
        {
                return CheckAndShowForestPopup();
        }
        
        return CheckAndShowForestPopup();
        label_13:
        twelvegigs.Autopilot.AutopilotManager val_47 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_48 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_49 = GetComponent<System.Object>();
        val_61 = null;
        val_61 = null;
        if((WGWindowManager.<>c.<>9__15_0) != 0)
        {
            goto label_140;
        }
        
        System.Action val_50 = new System.Action(object:  WGWindowManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(86401008));
        WGWindowManager.<>c.<>9__15_0 = null;
        goto label_140;
        label_91:
        GameBehavior val_51 = App.getBehavior;
        if(0 == 0)
        {
            goto label_145;
        }
        
        GameBehavior val_53 = App.getBehavior;
        GameBehavior val_54 = App.getBehavior;
        if(0 != 0)
        {
            goto label_152;
        }
        
        GameBehavior val_55 = App.getBehavior;
        string val_57 = Localization.Localize(key:  86402032, defaultValue:  86402144, useSingularKey:  false);
        string val_58 = Localization.Localize(key:  86399808, defaultValue:  86399904, useSingularKey:  false);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_59 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_60 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Add(item:  public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C);
        if(0 != 0)
        {
            goto label_162;
        }
        
        goto label_162;
    }
    protected override void WindowStateChanged(bool anyActiveOrQueuedWindows)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnWindowStateChanged(anyActiveWindows:  anyActiveOrQueuedWindows);
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<Result> val_7;
        var val_8;
        val_6 = 1152921504901201920;
        val_7 = 1152921511097403152;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2099378416)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_7 = null;
        val_7 = new System.Action<Result>(object:  86650304, method:  new IntPtr(85247152));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    public static UnityEngine.Camera GetCameraByTransform(UnityEngine.Transform obTranform)
    {
        if(obTranform != 0)
        {
                return obTranform.GetComponentInParent<System.Object>();
        }
        
        return obTranform.GetComponentInParent<System.Object>();
    }
    public static UnityEngine.Vector3 GetWorldPosInSelCamera(UnityEngine.Transform selfTransform, UnityEngine.Transform targetTransform)
    {
        float val_5;
        float val_6;
        float val_8;
        float val_9;
        UnityEngine.Camera val_1 = WGWindowManager.GetCameraByTransform(obTranform:  targetTransform);
        UnityEngine.Camera val_2 = WGWindowManager.GetCameraByTransform(obTranform:  R2);
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_7 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = R2, y = val_5, z = val_6});
        UnityEngine.Vector3 val_11 = selfTransform.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = targetTransform, y = val_8, z = val_9});
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public WGWindowManager()
    {
    
    }

}
