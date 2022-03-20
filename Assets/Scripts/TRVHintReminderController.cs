using UnityEngine;
public class TRVHintReminderController : MonoSingleton<TRVHintReminderController>
{
    // Fields
    private const string numShownLookupKey = "hintReminderNum";
    
    // Properties
    private int lastLevelSeen { get; set; }
    private int numTimesSeen { get; set; }
    
    // Methods
    private int get_lastLevelSeen()
    {
        return CPlayerPrefs.GetInt(key:  -517632144, defaultValue:  0);
    }
    private void set_lastLevelSeen(int value)
    {
        CPlayerPrefs.SetInt(key:  -517632144, val:  value);
    }
    private int get_numTimesSeen()
    {
        return CPlayerPrefs.GetInt(key:  -517408032, defaultValue:  0);
    }
    private void set_numTimesSeen(int value)
    {
        CPlayerPrefs.SetInt(key:  -517408032, val:  value);
    }
    private void OnEnable()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916224] == false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -517158896, method:  new IntPtr(3777783376));
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
    }
    private void OnSceneChanged(UnityEngine.SceneManagement.Scene outgoingScene, UnityEngine.SceneManagement.Scene incomingScene)
    {
        var val_8;
        System.Action<twelvegigs.storage.JsonDictionary> val_9;
        var val_10;
        val_8 = 1152921504892043264;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916224] == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        val_8 = 1152921504901095424;
        val_9 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = null;
        val_9 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -517044848, method:  new IntPtr(3777896400));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_18, b:  7401472);
        val_10 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_18;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_20;
        }
        
        }
        
        val_10 = 0;
        label_20:
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_18 = val_10;
    }
    private void OnQuestionBegin(TRVQuizProgress prog)
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = 35629684;
        if(this.CheckValid() == false)
        {
                return;
        }
        
        val_12 = 1152921504967548928;
        val_13 = 8077008 + 27552730;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(TRVMainController.noAnswerSelectedCharacter != null)
        {
                return;
        }
        
        val_13 = 1152921512476914864;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_12 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        if(numTimesSeen >= mem[1152921512476916232])
        {
                return;
        }
        
        Player val_4 = App.Player;
        val_12 = this.lastLevelSeen;
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_13 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        if((0 - val_12) < mem[1152921512476916228])
        {
                return;
        }
        
        this.ShowPopup();
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.InjectTrackingInfo(key:  -1206761120, value:  8945664);
        int val_9 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.numTimesSeen;
        val_9.numTimesSeen = val_9 + 1;
        Player val_11 = App.Player;
        this.lastLevelSeen = 0;
        CPlayerPrefs.Save();
    }
    private void ShowPopup()
    {
        twelvegigs.sweepstakes.Distribution val_25;
        var val_35;
        var val_36;
        var val_37;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                val_35 = null;
            val_35 = null;
            if(TRVMainController.QAHACK_HURRY == true)
        {
                return;
        }
        
        }
        
        GameBehavior val_3 = App.getBehavior;
        UnityEngine.Transform val_5 = 0.transform;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVPowerupButton> val_7 = getPowerupButtons;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_8 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_8 + 16.transform;
        UnityEngine.Vector3 val_9 = position;
        0.position = new UnityEngine.Vector3();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_11 = new UnityEngine.Color(r:  val_9.x, g:  val_9.y, b:  val_9.z, a:  null);
        System.Nullable<UnityEngine.Color> val_12 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_12.HasValue}, fadeInDuration:  val_9.x, fadeOutDuration:  val_9.y);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_18 = 0.gameObject;
        UnityEngine.Transform val_19 = 0.transform;
        Add(item:  0);
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVPowerupButton> val_21 = getPowerupButtons;
        List.Enumerator<T> val_22 = GetEnumerator();
        label_49:
        label_46:
        if(MoveNext() == false)
        {
            goto label_31;
        }
        
        object val_24 = new System.Object();
        if(val_24 != 0)
        {
                val_36 = 1152921504965951496;
            typeof(TRVHintReminderController.<>c__DisplayClass10_0).__il2cppRuntimeField_C = this;
            typeof(TRVHintReminderController.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = val_25;
        }
        else
        {
                mem[12] = this;
            val_36 = 8;
            mem[8] = val_25;
        }
        
        mem2[0] = 1;
        mem[8].UpdateButton();
        mem2[0] = new System.Action(object:  359104512, method:  new IntPtr(3778133712));
        UnityEngine.Transform val_27 = mem[8].transform;
        Add(item:  mem[8]);
        val_37 = mem[8];
        if(val_37 == 0)
        {
            goto label_46;
        }
        
        if(val_24 == 0)
        {
                val_37 = mem[8];
            if(val_37 == 0)
        {
                val_37 = 0;
        }
        
        }
        
        UnityEngine.Transform val_28 = val_37.transform;
        goto label_49;
        label_31:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_30 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        UnityEngine.Transform val_31 = 0.transform;
        UnityEngine.Transform val_32 = 0.transform;
        UnityEngine.Vector3 val_33 = val_12.HasValue.position;
        0.position = new UnityEngine.Vector3() {x = val_12.HasValue};
        twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimer();
    }
    private void OnReminderHintUsed(TRVPowerupButton pressedButton)
    {
        UnityEngine.Object val_6;
        System.Action val_16;
        if(new System.Object() != 0)
        {
                typeof(TRVHintReminderController.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVHintReminderController.<>c__DisplayClass11_0).__il2cppRuntimeField_C = pressedButton;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVPowerupButton> val_3 = getPowerupButtons;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_30:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_10 = public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
            if((public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                val_16 = null;
            val_16 = new System.Action(object:  359157760, method:  new IntPtr(3778253904));
            typeof(TRVHintReminderController.<>c__DisplayClass11_0).__il2cppRuntimeField_10 = val_16;
            mem2[0] = val_16;
        }
        
            mem2[0] = 1;
        }
        
        if(val_6 == (typeof(TRVHintReminderController.<>c__DisplayClass11_0).__il2cppRuntimeField_C))
        {
            goto label_30;
        }
        
        val_6.UpdateButton();
        goto label_30;
        label_7:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_15 = new System.Action(object:  359157760, method:  new IntPtr(3778254928));
        CloseOverlay(forceImmediate:  true, onClosed:  7454720);
    }
    private bool CheckValid()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916224] == false)
        {
                return false;
        }
        
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        bool val_4 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916220]);
        if(val_4 == false)
        {
                return false;
        }
        
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(val_4.numTimesSeen < mem[1152921512476916232])
        {
                0 = 1;
        }
        
        return true;
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -516459248, method:  new IntPtr(3777783376));
        UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  162459648);
    }
    public TRVHintReminderController()
    {
    
    }

}
