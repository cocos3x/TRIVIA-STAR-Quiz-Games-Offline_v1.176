using UnityEngine;
public class SRDebugger_Instantiator : MonoSingleton<SRDebugger_Instantiator>
{
    // Fields
    private static bool hasInited;
    private UnityEngine.KeyCode screenshot;
    private System.Collections.Generic.List<UnityEngine.Texture2D> wastedMemory;
    
    // Methods
    private void Start()
    {
        var val_44;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        val_44 = null;
        val_44 = null;
        if(SRDebugger_Instantiator.hasInited == true)
        {
                return;
        }
        
        SRDebugger_Instantiator.hasInited = true;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_9;
        }
        
        SRDebug.Init();
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
        this.SetDragThresholdByDPI();
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        AppConfigs val_4 = App.Configuration;
        SRDebugger.InfoEntry val_5 = SRDebugger.InfoEntry.Create(name:  -800141568, value:  0, isPrivate:  false);
        var val_45 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        var val_44 = 0;
        label_17:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_16;
        }
        
        val_44 = val_44 + 1;
        if(((uint)val_44 & 65535) < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_47 = 0;
        goto label_18;
        label_9:
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -800116592);
        return;
        label_16:
        var val_7 = mem[1179403735] + 0;
        val_45 = val_45 + (((mem[1179403735] + 0) + 4) << 3);
        val_47 = val_45 + 244;
        label_18:
        SRDebugger.Services.IDebugService val_8 = SRDebug.Instance;
        AppConfigs val_9 = App.Configuration;
        SRDebugger.InfoEntry val_10 = SRDebugger.InfoEntry.Create(name:  -800141392, value:  6, isPrivate:  false);
        var val_47 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_24;
        }
        
        var val_46 = 0;
        label_26:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_25;
        }
        
        val_46 = val_46 + 1;
        if(((uint)val_46 & 65535) < mem[1179403825])
        {
            goto label_26;
        }
        
        label_24:
        val_48 = 0;
        goto label_27;
        label_25:
        var val_11 = mem[1179403735] + 0;
        val_47 = val_47 + (((mem[1179403735] + 0) + 4) << 3);
        val_48 = val_47 + 244;
        label_27:
        SRDebugger.Services.IDebugService val_12 = SRDebug.Instance;
        AppConfigs val_13 = App.Configuration;
        string val_14 = 0.Environment;
        SRDebugger.InfoEntry val_15 = SRDebugger.InfoEntry.Create(name:  -800141312, value:  0, isPrivate:  false);
        var val_49 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_31;
        }
        
        var val_48 = 0;
        label_33:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_32;
        }
        
        val_48 = val_48 + 1;
        if(((uint)val_48 & 65535) < mem[1179403825])
        {
            goto label_33;
        }
        
        label_31:
        val_49 = 0;
        goto label_34;
        label_32:
        var val_16 = mem[1179403735] + 0;
        val_49 = val_49 + (((mem[1179403735] + 0) + 4) << 3);
        val_49 = val_49 + 244;
        label_34:
        SRDebugger.Services.IDebugService val_17 = SRDebug.Instance;
        AppConfigs val_18 = App.Configuration;
        SRDebugger.InfoEntry val_19 = SRDebugger.InfoEntry.Create(name:  -800141232, value:  4096, isPrivate:  false);
        var val_51 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_38;
        }
        
        var val_50 = 0;
        label_40:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_39;
        }
        
        val_50 = val_50 + 1;
        if(((uint)val_50 & 65535) < mem[1179403825])
        {
            goto label_40;
        }
        
        label_38:
        val_50 = 0;
        goto label_41;
        label_39:
        var val_20 = mem[1179403735] + 0;
        val_51 = val_51 + (((mem[1179403735] + 0) + 4) << 3);
        val_50 = val_51 + 244;
        label_41:
        SRDebugger.Services.IDebugService val_21 = SRDebug.Instance;
        string val_22 = DeviceIdPlugin.GetClientVersion();
        SRDebugger.InfoEntry val_23 = SRDebugger.InfoEntry.Create(name:  -800141152, value:  0, isPrivate:  false);
        var val_53 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_45;
        }
        
        var val_52 = 0;
        label_47:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_46;
        }
        
        val_52 = val_52 + 1;
        if(((uint)val_52 & 65535) < mem[1179403825])
        {
            goto label_47;
        }
        
        label_45:
        val_51 = 0;
        goto label_48;
        label_46:
        var val_24 = mem[1179403735] + 0;
        val_53 = val_53 + (((mem[1179403735] + 0) + 4) << 3);
        val_51 = val_53 + 244;
        label_48:
        SRDebugger.Services.IDebugService val_25 = SRDebug.Instance;
        Player val_26 = App.Player;
        SRDebugger.InfoEntry val_27 = SRDebugger.InfoEntry.Create(name:  -1988577776, value:  33449456, isPrivate:  false);
        var val_55 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_51;
        }
        
        var val_54 = 0;
        label_53:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_52;
        }
        
        val_54 = val_54 + 1;
        if(((uint)val_54 & 65535) < mem[1179403825])
        {
            goto label_53;
        }
        
        label_51:
        val_52 = 0;
        goto label_54;
        label_52:
        var val_28 = mem[1179403735] + 0;
        val_55 = val_55 + (((mem[1179403735] + 0) + 4) << 3);
        val_52 = val_55 + 244;
        label_54:
        SRDebugger.Services.IDebugService val_29 = SRDebug.Instance;
        Player val_30 = App.Player;
        SRDebugger.InfoEntry val_31 = SRDebugger.InfoEntry.Create(name:  -800141072, value:  9904128, isPrivate:  false);
        var val_57 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_57;
        }
        
        var val_56 = 0;
        label_59:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_58;
        }
        
        val_56 = val_56 + 1;
        if(((uint)val_56 & 65535) < mem[1179403825])
        {
            goto label_59;
        }
        
        label_57:
        val_53 = 0;
        goto label_60;
        label_58:
        var val_32 = mem[1179403735] + 0;
        val_57 = val_57 + (((mem[1179403735] + 0) + 4) << 3);
        val_53 = val_57 + 244;
        label_60:
        SRDebugger.Services.IDebugService val_33 = SRDebug.Instance;
        string val_34 = this.GetGitlog();
        SRDebugger.InfoEntry val_35 = SRDebugger.InfoEntry.Create(name:  -800140960, value:  0, isPrivate:  false);
        var val_59 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_62;
        }
        
        var val_58 = 0;
        label_64:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_63;
        }
        
        val_58 = val_58 + 1;
        if(((uint)val_58 & 65535) < mem[1179403825])
        {
            goto label_64;
        }
        
        label_62:
        val_54 = 0;
        goto label_65;
        label_63:
        var val_36 = mem[1179403735] + 0;
        val_59 = val_59 + (((mem[1179403735] + 0) + 4) << 3);
        val_54 = val_59 + 244;
        label_65:
        SRDebugger.Services.IDebugService val_37 = SRDebug.Instance;
        SRDebugger.InfoEntry val_38 = SRDebugger.InfoEntry.Create(name:  -800140864, value:  -800140768, isPrivate:  false);
        var val_61 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_67;
        }
        
        var val_60 = 0;
        label_69:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_68;
        }
        
        val_60 = val_60 + 1;
        if(((uint)val_60 & 65535) < mem[1179403825])
        {
            goto label_69;
        }
        
        label_67:
        val_55 = 0;
        goto label_70;
        label_68:
        var val_39 = mem[1179403735] + 0;
        val_61 = val_61 + (((mem[1179403735] + 0) + 4) << 3);
        val_55 = val_61 + 244;
        label_70:
        SRDebugger.Services.IDebugService val_40 = SRDebug.Instance;
        string val_41 = Facebook.Unity.FacebookSdkVersion.Build;
        SRDebugger.InfoEntry val_42 = SRDebugger.InfoEntry.Create(name:  -1988335216, value:  0, isPrivate:  false);
        var val_63 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_72;
        }
        
        var val_62 = 0;
        label_74:
        val_46 = mem[mem[1179403735] + 0];
        val_46 = mem[1179403735] + 0;
        if(val_46 == null)
        {
            goto label_73;
        }
        
        val_62 = val_62 + 1;
        if(((uint)val_62 & 65535) < mem[1179403825])
        {
            goto label_74;
        }
        
        label_72:
        val_56 = 0;
        return;
        label_73:
        var val_43 = mem[1179403735] + 0;
        val_63 = val_63 + (((mem[1179403735] + 0) + 4) << 3);
        val_56 = val_63 + 244;
    }
    private void LateUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  this.screenshot)) == false)
        {
                return;
        }
        
        SRDebugger_Instantiator.SaveScreenshot(superSize:  1);
    }
    public static void SaveScreenshot(int superSize = 1)
    {
        AppConfigs val_1 = App.Configuration;
        System.DateTime val_2 = System.DateTime.Now;
        string val_5 = System.String.Format(format:  -799908400, arg0:  9904128);
        string val_6 = -799908272(-799908272) + 2621443 + 1359327184 + -799908400(-799908400);
        UnityEngine.ScreenCapture.CaptureScreenshot(filename:  -799908272, superSize:  superSize);
        string val_7 = -799908176(-799908176) + -799908272(-799908272);
        UnityEngine.Debug.LogWarning(message:  -799908176);
    }
    private void SetDragThresholdByDPI()
    {
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.EventSystems.EventSystem val_2 = UnityEngine.EventSystems.EventSystem.current;
        float val_3 = UnityEngine.Screen.dpi;
        float val_5 = 52f;
        val_5 = 0 * val_5;
        val_5 = val_5 / 160f;
        mem[28] = UnityEngine.Mathf.Max(a:  52, b:  val_5);
    }
    private string GetGitlog()
    {
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -842597888);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -842597744, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_4 = Replace(oldValue:  1269544832, newValue:  1145000912);
        return 1145000912 + 179232768;
    }
    private System.Collections.IEnumerator BloatTheMemory()
    {
        SRDebugger_Instantiator.<BloatTheMemory>d__8 val_1 = new SRDebugger_Instantiator.<BloatTheMemory>d__8(<>1__state:  0);
        typeof(SRDebugger_Instantiator.<BloatTheMemory>d__8).__il2cppRuntimeField_10 = this;
    }
    public void StartBloatTheMemory()
    {
        this.CancelInvoke();
        System.Collections.IEnumerator val_1 = this.BloatTheMemory();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -799436064);
    }
    public void StartSendingAllNofis()
    {
        this.SendAllNotifsDelayed();
    }
    private void SendAllNotifsDelayed()
    {
        bool val_3;
        var val_7;
        var val_8;
        var val_9;
        WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  -799236064, QAHACK_Force:  true);
        WGGenericNotificationsManager.SendDailyChallengeMorningReminder(hour:  0, QAHACK_Force:  true);
        WGGenericNotificationsManager.SendDailyChallengeEveningReminder(hour:  0, QAHACK_Force:  true);
        WGGenericNotificationsManager.SendPostAdNotification(QAHACK_Force:  true);
        WGGenericNotificationsManager.SendDailyBonusNotification(QAHACK_Force:  true);
        WGGenericNotificationsManager.SendEngagementNotifications(QAHACK_Force:  true);
        var val_7 = 26045255;
        val_7 = 9580532 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        if(App.game == 16)
        {
                BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            val_8 = null;
            val_8 = null;
            System.Nullable<System.TimeSpan> val_2 = new System.Nullable<System.TimeSpan>(value:  new System.TimeSpan() {_ticks = 1152921510235795136});
            0.SendLivesFullNotification(timeFromNow:  new System.Nullable<System.TimeSpan>() {HasValue = val_3});
            val_7 = null;
        }
        
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(App.game != 17)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.Hack_SendExtraLifeNotif();
    }
    public string GetLPNsLog()
    {
        string val_4;
        var val_6;
        val_6 = null;
        val_6 = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        System.Text.StringBuilder val_5 = AppendLine(value:  val_4);
        goto label_6;
        label_4:
        Dispose();
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator ExitApp(int waitSeconds = 3)
    {
        SRDebugger_Instantiator.<ExitApp>d__13 val_1 = new SRDebugger_Instantiator.<ExitApp>d__13(<>1__state:  0);
        typeof(SRDebugger_Instantiator.<ExitApp>d__13).__il2cppRuntimeField_10 = waitSeconds;
    }
    public void StartExitApp(int waitSeconds = 3)
    {
        DebugMessageDisplay.DisplayMessage(msgTxt:  -798899984, displayTime:  null);
        System.Collections.IEnumerator val_1 = ExitApp(waitSeconds:  3);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -798899984);
    }
    public string getPlayerAllInfoString()
    {
        string val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        PopulatePlayerAllInfoDict(playerALLInfoDynamicHUD:  78753792);
        Dictionary.KeyCollection<TKey, TValue> val_2 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = val_5;
        typeof(System.String[]).__il2cppRuntimeField_18 = ": ";
        string val_6 = Item[val_5];
        typeof(System.String[]).__il2cppRuntimeField_1C = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\n";
        string val_7 = +477709520;
        goto label_21;
        label_3:
        Dispose();
    }
    private void PopulatePlayerAllInfoDict(System.Collections.Generic.Dictionary<string, string> playerALLInfoDynamicHUD)
    {
        float val_50;
        string val_51;
        var val_52;
        val_50 = 0;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(286846976)});
        System.Reflection.PropertyInfo[] val_2 = GetProperties();
        label_106:
        if((Player.__il2cppRuntimeField_byval_arg.Equals(value:  -798671728)) == true)
        {
            goto label_10;
        }
        
        Player val_4 = App.Player;
        Player val_5 = App.Player;
        string val_6 = Player.__il2cppRuntimeField_byval_arg + 1269544832;
        string val_8 = Player.__il2cppRuntimeField_byval_arg + 1269544832;
        if((playerALLInfoDynamicHUD.ContainsKey(key:  Player.__il2cppRuntimeField_byval_arg)) == false)
        {
            goto label_20;
        }
        
        Player val_10 = App.Player;
        string val_11 = PrettyPrint.printJSON(obj:  Player.__il2cppRuntimeField_byval_arg, types:  false, singleLineOutput:  false);
        val_50 = val_50;
        label_46:
        playerALLInfoDynamicHUD.set_Item(key:  Player.__il2cppRuntimeField_byval_arg, value:  Player.__il2cppRuntimeField_byval_arg);
        goto label_128;
        label_129:
        if((playerALLInfoDynamicHUD == 0) || ((System.Reflection.PropertyInfo.op_Inequality(left:  Player.__il2cppRuntimeField_byval_arg, right:  0)) == false))
        {
            goto label_128;
        }
        
        Player val_14 = App.Player;
        if(0 == 0)
        {
            goto label_128;
        }
        
        Player val_16 = App.Player;
        if((playerALLInfoDynamicHUD.ContainsKey(key:  Player.__il2cppRuntimeField_byval_arg)) == false)
        {
            goto label_42;
        }
        
        Player val_19 = App.Player;
        goto label_46;
        label_20:
        Player val_20 = App.Player;
        string val_21 = PrettyPrint.printJSON(obj:  Player.__il2cppRuntimeField_byval_arg, types:  false, singleLineOutput:  false);
        val_50 = val_50;
        label_119:
        playerALLInfoDynamicHUD.Add(key:  Player.__il2cppRuntimeField_byval_arg, value:  Player.__il2cppRuntimeField_byval_arg);
        goto label_128;
        label_86:
        Player val_24 = App.Player;
        string val_25 = PlayerProperties.__il2cppRuntimeField_byval_arg + 1269544832;
        string val_27 = PlayerProperties.__il2cppRuntimeField_byval_arg + 1269544832;
        val_51 = PlayerProperties.__il2cppRuntimeField_byval_arg;
        val_52 = null;
        if((playerALLInfoDynamicHUD.ContainsKey(key:  PlayerProperties.__il2cppRuntimeField_byval_arg)) != true)
        {
                Player val_28 = App.Player;
            string val_29 = PrettyPrint.printJSON(obj:  PlayerProperties.__il2cppRuntimeField_byval_arg, types:  false, singleLineOutput:  false);
            playerALLInfoDynamicHUD.Add(key:  val_51, value:  PlayerProperties.__il2cppRuntimeField_byval_arg);
        }
        else
        {
                Player val_34 = App.Player;
            string val_35 = PrettyPrint.printJSON(obj:  PlayerProperties.__il2cppRuntimeField_byval_arg, types:  false, singleLineOutput:  false);
            playerALLInfoDynamicHUD.set_Item(key:  null, value:  PlayerProperties.__il2cppRuntimeField_byval_arg);
        }
        
         =  + 1;
        goto label_86;
        label_128:
         =  + 1;
        goto label_106;
        label_42:
        Player val_43 = App.Player;
        goto label_119;
        label_126:
        if(MoveNext() == false)
        {
            goto label_120;
        }
        
        object val_46 = Current;
        if((playerALLInfoDynamicHUD.ContainsKey(key:  Player.__il2cppRuntimeField_byval_arg)) == false)
        {
            goto label_122;
        }
        
        playerALLInfoDynamicHUD.set_Item(key:  Player.__il2cppRuntimeField_byval_arg, value:  -798655592);
        goto label_126;
        label_122:
        playerALLInfoDynamicHUD.Add(key:  Player.__il2cppRuntimeField_byval_arg, value:  -798655592);
        goto label_126;
        label_120:
        Dispose();
        if(1 == 1)
        {
            goto label_129;
        }
        
        goto label_128;
    }
    public string getQueuedWindowsString()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return DebugQueuedWindows();
        }
        
        return DebugQueuedWindows();
    }
    public string getAdsInfoWindowString()
    {
        bool val_6 = static_value_021FB5C6;
        if(val_6 != true)
        {
                val_6 = true;
        }
        
        string val_1 = this.ScreenInfo();
        string val_2 = 1098586544 + 1 + 1269544832;
        string val_3 = AdsVideos();
        string val_4 = 1098586544 + 1098586544 + 1269544832;
        string val_5 = 1098586544 + -798438416(-798438416) + 1269544832;
        return 1098586544 + -798438240(-798438240) + 1269544832;
    }
    private string VideoAdInfo()
    {
    
    }
    private string AdInfo()
    {
    
    }
    private string ScreenInfo()
    {
        string val_2 = UnityEngine.Screen.width.ToString();
        typeof(System.String[]).__il2cppRuntimeField_10 = ;
        typeof(System.String[]).__il2cppRuntimeField_14 = "x";
        string val_4 = UnityEngine.Screen.height.ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = ;
        typeof(System.String[]).__il2cppRuntimeField_1C = " <color=#999999>AR: ";
        float val_9 = (float)UnityEngine.Screen.width;
        val_9 = val_9 / (float)UnityEngine.Screen.height;
        string val_7 = val_9.ToString(format:  -798101952);
        typeof(System.String[]).__il2cppRuntimeField_20 = ;
        typeof(System.String[]).__il2cppRuntimeField_24 = "</color>";
        string val_8 = +477709520;
    }
    private string AdsVideos()
    {
        string val_6;
        var val_12;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = Status(_type:  1);
        Dictionary.KeyCollection<TKey, TValue> val_3 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_30:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = "\n";
        typeof(System.String[]).__il2cppRuntimeField_18 = val_6;
        typeof(System.String[]).__il2cppRuntimeField_1C = ": ";
        string val_7 = Item[val_6];
        if((System.String.IsNullOrEmpty(value:  -1987886336)) != false)
        {
                val_12 = "Working correctly";
        }
        else
        {
                string val_9 = Item[val_6];
            val_12 = public static PluginObserverManager MonoSingletonSelfGenerating<PluginObserverManager>::get_Instance();
        }
        
        typeof(System.String[]).__il2cppRuntimeField_20 = val_12;
        typeof(System.String[]).__il2cppRuntimeField_24 = "\n";
        string val_10 = +477709520;
        goto label_30;
        label_6:
        Dispose();
        string val_11 = -797989760(-797989760) + 1098586544;
    }
    public string getDataInDBEvents()
    {
        var val_8;
        var val_9;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<TrackedEvent>> val_10;
        var val_12;
        val_8 = "";
        var val_8 = 26042952;
        val_8 = 9589664 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = LogStash.stashes;
        Dictionary.Enumerator<TKey, TValue> val_1 = 0.GetEnumerator();
        goto label_7;
        label_13:
        string val_2 = R6.ToUpper();
        string val_3 = 1098586544 + -797875600(-797875600) + R6 + -797875424(-797875424);
        val_10 = val_8;
        val_12 = 0;
        goto label_9;
        label_12:
        if(val_8 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = 0;
        val_9 = val_9 + 0;
        string val_4 = System.String.Format(format:  -797875520, arg0:  (0 + 0) + 16);
        string val_5 = 1098586544 + -797875520(-797875520);
        val_12 = 1;
        val_10 = val_10;
        label_9:
        if(val_12 < 0)
        {
            goto label_12;
        }
        
        val_8 = val_10;
        label_7:
        if(0.MoveNext() == true)
        {
            goto label_13;
        }
        
        0.Dispose();
        string val_7 = -797874320(-797874320) + 1098586544;
    }
    public string GetAmpFeatureGlobals()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        AmplitudePluginHelper.InjectFeatureGlobals(eventName:  -797762208, globals:  78753792);
        return PrettyPrint.printJSON(obj:  78753792, types:  false, singleLineOutput:  false);
    }
    public string GetGameLevelInfo()
    {
        GameBehavior val_2 = App.getBehavior;
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    public string GetTRVCategoriesInfo()
    {
        GameBehavior val_2 = App.getBehavior;
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    public string GetLevelsSkippedInfo()
    {
        object val_19;
        string val_27;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<SkippedLevel> val_3 = DebugLevelsToSkip;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = DebugCurrentLevelSkipStatus;
        System.Text.StringBuilder val_6 = AppendLine(value:  -797426096);
        Player val_7 = App.Player;
        System.Text.StringBuilder val_8 = AppendFormat(format:  -797425984, arg0:  13152256);
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_10 = AppendLine(value:  public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_28);
            System.Text.StringBuilder val_11 = AppendLine(value:  -797425872);
        }
        else
        {
                System.Text.StringBuilder val_12 = AppendLine(value:  public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_28);
            System.Text.StringBuilder val_13 = AppendLine(value:  -797425872);
        }
        
        System.Text.StringBuilder val_14 = AppendLine(value:  -797425760);
        System.Text.StringBuilder val_15 = AppendFormat(format:  -797425648, arg0:  13152256);
        Dictionary.Enumerator<TKey, TValue> val_16 = GetEnumerator();
        label_20:
        if(0.MoveNext() == false)
        {
            goto label_16;
        }
        
        System.Text.StringBuilder val_20 = AppendFormat(format:  1468099328, arg0:  0, arg1:  val_19);
        goto label_20;
        label_16:
        0.Dispose();
        System.Text.StringBuilder val_21 = AppendLine(value:  -797425872);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_22 = AppendLine(value:  System.String.alignConst);
        }
        else
        {
                System.Text.StringBuilder val_23 = AppendLine(value:  System.String.alignConst);
        }
        
        System.Text.StringBuilder val_24 = AppendLine(value:  -797425504);
        List.Enumerator<T> val_25 = GetEnumerator();
        label_28:
        if(MoveNext() == false)
        {
            goto label_25;
        }
        
        string val_28 = val_27.ToDebugString();
        System.Text.StringBuilder val_29 = AppendLine(value:  val_27);
        goto label_28;
        label_25:
        Dispose();
        if(val_1 != 0)
        {
                return;
        }
    
    }
    public string GetGameLevelTrackingInfo()
    {
        int val_26;
        var val_27;
        var val_28;
        var val_29;
        val_26 = System.String.alignConst;
        val_27 = 9592604 + 26033183;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        if(App.game != 1)
        {
                if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
            val_29 = null;
            val_29 = null;
            if(App.game != 4)
        {
                return;
        }
        
        }
        
        val_27 = 1152921504885600256;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                return;
        }
        
        MainController val_3 = MainController.instance;
        string val_4 = 0.ToString();
        string val_5 = System.String.Format(format:  -797310320, arg0:  -797310192, arg1:  -797297140, arg2:  1113431872);
        string val_6 = val_26 + -797310320(-797310320);
        MainController val_7 = MainController.instance;
        string val_8 = 0.ToString();
        string val_9 = System.String.Format(format:  -797310080, arg0:  -797310192, arg1:  -797297140, arg2:  1113431872);
        string val_10 = val_26 + -797310080(-797310080);
        MainController val_11 = MainController.instance;
        string val_12 = 4096.ToString();
        string val_13 = System.String.Format(format:  -797309952, arg0:  -797310192, arg1:  -797297140, arg2:  1113431872);
        string val_14 = val_26 + -797309952(-797309952);
        MainController val_15 = MainController.instance;
        val_27 = 0;
        string val_16 = 0.ToString();
        string val_17 = System.String.Format(format:  -797309824, arg0:  -797309696, arg1:  -797297140, arg2:  1113431872);
        string val_18 = val_26 + -797309824(-797309824);
        MainController val_19 = MainController.instance;
        string val_20 = System.String.Format(format:  -797309472, arg0:  -797309584, arg1:  0, arg2:  1113431872);
        string val_21 = val_26 + -797309472(-797309472);
        MainController val_22 = MainController.instance;
        string val_23 = 33446072.ToString();
        string val_24 = System.String.Format(format:  -797309344, arg0:  -797309216, arg1:  -797297140, arg2:  1113431872);
        string val_25 = val_26 + -797309344(-797309344);
        val_26 = val_26;
    }
    public string GetKnobsInfo()
    {
        var val_2;
        var val_2 = 26033603;
        val_2 = 9593812 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = App.storageManager.getRawKnobsResponse();
        return System.String.alignConst + App.storageManager;
    }
    public string GetWordsInfo()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public string GetAdsInfo()
    {
        var val_39;
        var val_40;
        var val_41;
        val_40 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 == 0)
        {
                val_41 = "No AdsUIController instance present in scene";
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                val_41 = "No ApplovinMax instance present in scene";
            return;
        }
        
        if(AdsUIController.AdsAllowed == true)
        {
                "<b>State:</b> No Ads\n" = "<b>State:</b> Ads will show \n";
        }
        
        string val_6 = System.String.alignConst + -796972784(-796972784);
        string val_8 = AdsManager.isInPurchaseCooldown.ToString();
        string val_9 = System.String.Format(format:  -796972544, arg0:  -796959353);
        string val_10 = System.String.alignConst + -796972544(-796972544);
        string val_12 = AdsManager.isInVideoCooldown.ToString();
        string val_13 = System.String.Format(format:  -796972400, arg0:  -796959353);
        string val_14 = System.String.alignConst + -796972400(-796972400);
        Player val_15 = App.Player;
        string val_17 = 0.networkPurchaserExcludedFromAds.ToString();
        string val_18 = System.String.Format(format:  -796972272, arg0:  -796959353);
        string val_19 = System.String.alignConst + -796972272(-796972272);
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_21 = System.String.alignConst + -796972128(-796972128);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_23 = BannerAdsBlockedByUI;
        string val_24 = System.String.Format(format:  -796972016, arg0:  8945664);
        string val_25 = System.String.alignConst + -796972016(-796972016);
        typeof(System.Object[]).__il2cppRuntimeField_10 = System.String.alignConst;
        typeof(System.Object[]).__il2cppRuntimeField_14 = "Ads UI height: ";
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_27 = GetBannerAdHeight();
        string val_28 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        typeof(System.Object[]).__il2cppRuntimeField_1C = "\nAds UI canvas height: ";
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_30 = GetBannerAdCanvasHeight();
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        val_40 = "\n";
        typeof(System.Object[]).__il2cppRuntimeField_24 = "\n";
        val_39 = 0;
        string val_31 = +472754880;
        string val_32 = ToString();
        string val_33 = 472754880 + -796971648(-796971648) + -796959352(-796959352) + 1269544832;
        string val_34 = 472754880 + -796971536(-796971536);
        twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_37 = IsVideoAvailable().ToString();
        string val_38 = 472754880 + -796971408(-796971408) + -796959353(-796959353) + 1269544832;
    }
    public string GetAdsEventsString()
    {
        string val_8;
        var val_10;
        var val_11;
        var val_12;
        string val_13;
        val_10 = 1152921511026388688;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_11 = 1152921504765685760;
        if(2124574416 == 0)
        {
                val_12 = "No AdsManager instance present in scene";
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                val_12 = "No ApplovinMax instance present in scene";
            return;
        }
        
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_11 = 1152921510891363008;
        val_10 = "\n";
        label_18:
        val_13 = System.String.alignConst;
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        string val_9 = val_13 + val_8 + 1269544832;
        goto label_18;
        label_17:
        Dispose();
    }
    public string GetPiggyBankInfo()
    {
        var val_44;
        var val_45;
        var val_46;
        val_44 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_44 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_44 == 1)
        {
                val_44 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_44 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -796747136, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_2 = 1098586544 + -796747136(-796747136);
        string val_3 = PiggyBankHandler.HackNextAvailableDate();
        string val_4 = System.String.Format(format:  -796747008, arg0:  0);
        string val_5 = 1098586544 + -796747008(-796747008);
        string val_6 = System.String.Format(format:  -796746880, arg0:  8945664);
        string val_7 = 1098586544 + -796746880(-796746880);
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -796746720, arg0:  9904128);
        string val_10 = 1098586544 + -796746720(-796746720);
        Player val_11 = App.Player;
        var val_12 = 0 + 60;
        string val_13 = System.String.Format(format:  -796746592, arg0:  10170368);
        string val_14 = 1098586544 + -796746592(-796746592);
        Player val_15 = App.Player;
        string val_16 = System.String.Format(format:  -796746480, arg0:  9904128);
        string val_17 = 1098586544 + -796746480(-796746480);
        if(PiggyBankHandler.iapHigh != null)
        {
                if(PiggyBankHandler.iapHigh == null)
        {
            goto label_16;
        }
        
        }
        
        label_20:
        label_38:
        string val_18 = 1098586544 + -796746352(-796746352);
        return;
        label_16:
        if(PiggyBankHandler.iapHigh == null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_19:
        val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_45 == 1)
        {
                val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_19 = System.String.Format(format:  -796746016, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_20 = 1098586544 + -796746016(-796746016);
        string val_21 = System.String.Format(format:  -796745888, arg0:  13152256);
        string val_22 = 1098586544 + -796745888(-796745888);
        string val_23 = System.String.Format(format:  -796745760, arg0:  13152256);
        string val_24 = 1098586544 + -796745760(-796745760);
        string val_25 = System.String.Format(format:  -796745648, arg0:  8945664);
        string val_26 = 1098586544 + -796745648(-796745648);
        string val_27 = System.String.Format(format:  -796745536, arg0:  9904128);
        string val_28 = 1098586544 + -796745536(-796745536);
        val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_46 == 1)
        {
                val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_29 = System.String.Format(format:  -796745424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_30 = 1098586544 + -796745424(-796745424);
        string val_31 = System.String.Format(format:  -796745312, arg0:  PiggyBankHandler.iapHigh + 148);
        string val_32 = 1098586544 + -796745312(-796745312);
        string val_33 = System.String.Format(format:  -796745200, arg0:  PiggyBankHandler.iapHigh + 152);
        string val_34 = 1098586544 + -796745200(-796745200);
        string val_35 = System.String.Format(format:  -796745072, arg0:  10170368);
        string val_36 = 1098586544 + -796745072(-796745072);
        string val_37 = System.String.Format(format:  -796744960, arg0:  13152256);
        string val_38 = 1098586544 + -796744960(-796744960);
        string val_39 = PiggyBankHandler.iapHigh.PricePurchaseString;
        string val_40 = System.String.Format(format:  -796744848, arg0:  PiggyBankHandler.iapHigh);
        string val_41 = 1098586544 + -796744848(-796744848);
        string val_42 = System.String.Format(format:  -796744752, arg0:  PiggyBankHandler.iapHigh + 176);
        string val_43 = 1098586544 + -796744752(-796744752);
        string val_44 = System.String.Format(format:  -796744640, arg0:  13152256);
        goto label_38;
    }
    public string GetPiggyBankV2Info()
    {
        var val_44;
        var val_45;
        var val_46;
        val_44 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_44 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_44 == 1)
        {
                val_44 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_44 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -796747136, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_2 = 1098586544 + -796747136(-796747136);
        string val_3 = PiggyBankV2Handler.HackNextAvailableDate();
        string val_4 = System.String.Format(format:  -796747008, arg0:  0);
        string val_5 = 1098586544 + -796747008(-796747008);
        string val_6 = System.String.Format(format:  -796746880, arg0:  8945664);
        string val_7 = 1098586544 + -796746880(-796746880);
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -796746720, arg0:  9904128);
        string val_10 = 1098586544 + -796746720(-796746720);
        Player val_11 = App.Player;
        var val_12 = 0 + 60;
        string val_13 = System.String.Format(format:  -796746592, arg0:  10170368);
        string val_14 = 1098586544 + -796746592(-796746592);
        Player val_15 = App.Player;
        string val_16 = System.String.Format(format:  -796746480, arg0:  9904128);
        string val_17 = 1098586544 + -796746480(-796746480);
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                if(PiggyBankV2Handler.minDowngradeTier == 0)
        {
            goto label_16;
        }
        
        }
        
        label_20:
        label_40:
        string val_18 = 1098586544 + -796746352(-796746352);
        return;
        label_16:
        if(PiggyBankV2Handler.minDowngradeTier == 0)
        {
            goto label_19;
        }
        
        goto label_20;
        label_19:
        val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_45 == 1)
        {
                val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_19 = System.String.Format(format:  -796746016, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_20 = 1098586544 + -796746016(-796746016);
        string val_21 = System.String.Format(format:  -796632528, arg0:  13152256);
        string val_22 = 1098586544 + -796632528(-796632528);
        decimal val_23 = BankAmountCurrent;
        string val_24 = System.String.Format(format:  -796632400, arg0:  10170368);
        string val_25 = 1098586544 + -796632400(-796632400);
        int val_26 = PiggyBankV2Handler.minDowngradeTier + 96;
        string val_27 = System.String.Format(format:  -796632272, arg0:  10170368);
        string val_28 = 1098586544 + -796632272(-796632272);
        val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_46 == 1)
        {
                val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_29 = System.String.Format(format:  -796745424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_30 = 1098586544 + -796745424(-796745424);
        string val_31 = System.String.Format(format:  -796745200, arg0:  PiggyBankV2Handler.minDowngradeTier + 92);
        string val_32 = 1098586544 + -796745200(-796745200);
        string val_33 = PiggyBankV2Handler.minDowngradeTier.PricePurchaseString;
        string val_34 = System.String.Format(format:  -796744848, arg0:  PiggyBankV2Handler.minDowngradeTier);
        string val_35 = 1098586544 + -796744848(-796744848);
        Player val_36 = App.Player;
        string val_37 = System.String.Format(format:  -796632160, arg0:  9904128);
        string val_38 = 1098586544 + -796632160(-796632160);
        System.DateTime val_39 = HackLongTimePurchaseDate();
        string val_42 = System.String.Format(format:  -796632032, arg0:  9904128);
        string val_43 = 1098586544 + -796632032(-796632032);
        string val_44 = System.String.Format(format:  -796631904, arg0:  PiggyBankV2Handler.minDowngradeTier + 148);
        goto label_40;
    }
    public string GetTrackingInfo()
    {
        Player val_2 = App.Player;
        string val_3 = System.String.Format(format:  -796519792, arg0:  13152256);
        System.Text.StringBuilder val_4 = AppendLine(value:  -796519792);
        Player val_5 = App.Player;
        string val_6 = System.String.Format(format:  -796519664, arg0:  13152256);
        System.Text.StringBuilder val_7 = AppendLine(value:  -796519664);
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -796519536, arg0:  13152256);
        System.Text.StringBuilder val_10 = AppendLine(value:  -796519536);
        Player val_11 = App.Player;
        string val_12 = System.String.Format(format:  -796519408, arg0:  13152256);
        System.Text.StringBuilder val_13 = AppendLine(value:  -796519408);
        Player val_14 = App.Player;
        string val_15 = System.String.Format(format:  -796519280, arg0:  15282176);
        System.Text.StringBuilder val_16 = AppendLine(value:  -796519280);
        Player val_17 = App.Player;
        string val_18 = System.String.Format(format:  -796519152, arg0:  13152256);
        if(new System.Text.StringBuilder() != 0)
        {
                System.Text.StringBuilder val_19 = AppendLine(value:  -796519152);
            return;
        }
        
        System.Text.StringBuilder val_20 = AppendLine(value:  -796519152);
    }
    public string GetAddedCoinsTrace()
    {
        string val_5;
        Player val_2 = App.Player;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        System.Text.StringBuilder val_6 = AppendLine(value:  val_5);
        goto label_7;
        label_5:
        Dispose();
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    public string GetAddedNonCoinsTrace()
    {
        string val_5;
        Player val_2 = App.Player;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        System.Text.StringBuilder val_6 = AppendLine(value:  val_5);
        goto label_7;
        label_5:
        Dispose();
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    public string GetInfinityModeInfo()
    {
        var val_4;
        var val_5;
        string val_1 = System.String.alignConst + -796183040(-796183040);
        var val_4 = 26029469;
        val_4 = 9603148 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        string val_2 = System.String.alignConst + -796182880(-796182880) + WADataParser.Debug_RanOutWhenTranslating + 1269544832;
        val_5 = null;
        val_5 = null;
        string val_3 = System.String.alignConst + -796182768(-796182768) + WADataParser.Debug_FinishedContent + 1269544832;
    }
    public string GetWaterfallSaleInfo()
    {
        var val_24;
        var val_34;
        ulong val_37;
        var val_40;
        var val_67;
        var val_68;
        ulong val_70;
        var val_73;
        var val_89;
        var val_90;
        val_89 = 1152921504901095424;
        val_90 = 1152921512364436848;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-832344720) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_C.ToString();
        string val_5 = System.String.Format(format:  -796070528, arg0:  -797310192, arg1:  -796056249, arg2:  1113431872);
        string val_6 = System.String.alignConst + -796070528(-796070528);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_1C.ToString();
        string val_9 = System.String.Format(format:  -796070416, arg0:  -797310192, arg1:  -796056249, arg2:  1113431872);
        string val_10 = System.String.alignConst + -796070416(-796070416);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_12 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_14.ToString();
        string val_13 = System.String.Format(format:  -796070288, arg0:  -797310192, arg1:  -796056256, arg2:  1113431872);
        string val_14 = System.String.alignConst + -796070288(-796070288);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_16 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_38.ToString();
        string val_17 = System.String.Format(format:  -796070176, arg0:  -797310192, arg1:  -796056249, arg2:  1113431872);
        string val_18 = System.String.alignConst + -796070176(-796070176);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_20 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_10.ToString();
        string val_21 = System.String.Format(format:  -796070032, arg0:  -797310192, arg1:  -796056256, arg2:  1113431872);
        string val_22 = System.String.alignConst + -796070032(-796070032);
        System.DateTime val_23 = ServerHandler.ServerTime;
        string val_26 = val_24.ToString();
        string val_27 = System.String.Format(format:  -796069920, arg0:  -796069808, arg1:  -796056264, arg2:  1113431872);
        string val_28 = System.String.alignConst + -796069920(-796069920);
        string val_30 = 0.ToBinary().ToString();
        string val_31 = UnityEngine.PlayerPrefs.GetString(key:  -796069696, defaultValue:  -796056272);
        long val_32 = System.Int64.Parse(s:  -796069696);
        System.DateTime val_33 = System.DateTime.FromBinary(dateData:  1152921512400725280);
        System.DateTime val_36 = ServerHandler.ServerTime;
        System.TimeSpan val_39 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512400725264}, d2:  new System.DateTime() {dateData = val_37});
        string val_42 = val_34.ToString();
        string val_43 = System.String.Format(format:  -796069584, arg0:  -796069808, arg1:  -796056224, arg2:  1113431872);
        string val_44 = System.String.alignConst + -796069584(-796069584);
        string val_45 = val_40.ToString();
        string val_46 = System.String.Format(format:  -796069456, arg0:  -797309216, arg1:  -796056232, arg2:  1113431872);
        string val_47 = System.String.alignConst + -796069456(-796069456);
        Player val_48 = App.Player;
        string val_49 = 168.ToString();
        string val_50 = System.String.Format(format:  -796069328, arg0:  -796069808, arg1:  168, arg2:  1113431872);
        string val_51 = System.String.alignConst + -796069328(-796069328);
        Player val_52 = App.Player;
        int val_53 = val_34.CompareTo(value:  new System.DateTime() {dateData = 1152921512400712240});
        val_53 = val_53 >> 31;
        string val_54 = val_53.ToString();
        string val_55 = System.String.Format(format:  -796069200, arg0:  -797310192, arg1:  -796056249, arg2:  1113431872);
        string val_56 = System.String.alignConst + -796069200(-796069200);
        twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_59 = QAHACK_CurrentInterval.ToString();
        string val_60 = System.String.Format(format:  -796069072, arg0:  -796068912, arg1:  -796056256, arg2:  1113431872);
        string val_61 = System.String.alignConst + -796069072(-796069072);
        string val_63 = 0.ToBinary().ToString();
        string val_64 = UnityEngine.PlayerPrefs.GetString(key:  -796068800, defaultValue:  -796056272);
        long val_65 = System.Int64.Parse(s:  -796068800);
        System.DateTime val_66 = System.DateTime.FromBinary(dateData:  1152921512400725256);
        val_90 = val_68;
        System.DateTime val_69 = ServerHandler.ServerTime;
        System.TimeSpan val_72 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512400725240}, d2:  new System.DateTime() {dateData = val_70});
        string val_75 = val_67.ToString();
        string val_76 = System.String.Format(format:  -796068688, arg0:  -796069808, arg1:  -796056240, arg2:  1113431872);
        string val_77 = System.String.alignConst + -796068688(-796068688);
        string val_78 = val_73.ToString();
        string val_79 = System.String.Format(format:  -796068560, arg0:  -797309216, arg1:  -796056248, arg2:  1113431872);
        string val_80 = System.String.alignConst + -796068560(-796068560);
        twelvegigs.Autopilot.AutopilotManager val_81 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_89 = 0;
        string val_82 = public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_1E.ToString();
        string val_83 = System.String.Format(format:  -796068432, arg0:  -796068912, arg1:  -796056249, arg2:  1113431872);
        string val_84 = System.String.alignConst + -796068432(-796068432);
        twelvegigs.Autopilot.AutopilotManager val_85 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_86 = QAHACK_CurrentShowLogic;
        string val_87 = System.String.Format(format:  -796068304, arg0:  -796069808, arg1:  -832344720, arg2:  1113431872);
        string val_88 = System.String.alignConst + -796068304(-796068304);
    }
    public string GetPuzzlePoolInfo()
    {
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
                return;
        }
        
        string val_1 = PuzzleCollectionHandler.CurrentPuzzleName;
        string val_2 = System.String.Format(format:  -795956176, arg0:  -795956032, arg1:  0, arg2:  1113431872);
        string val_3 = System.String.alignConst + -795956176(-795956176);
        string val_4 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.GetCompletedPuzzles();
        string val_5 = System.String.Format(format:  -795955920, arg0:  -795955776, arg1:  PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED, arg2:  1113431872);
        string val_6 = System.String.alignConst + -795955920(-795955920);
        string val_7 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.GetAllPuzzles();
        string val_8 = System.String.Format(format:  -795955664, arg0:  -797310192, arg1:  PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED, arg2:  1113431872);
        return System.String.alignConst + -795955664(-795955664);
    }
    public string getLeaguesTraceString()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_3 = 26026147;
        val_3 = 9606472 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        T[] val_1 = SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs.ToArray();
        val_4 = 0;
        val_5 = "";
        goto label_7;
        label_10:
        string val_2 = 1098586544 + R6 + 0(R6 + 0) + 1269544832;
        val_4 = 1;
        val_5 = val_5;
        label_7:
        if(val_4 < (SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs + 12))
        {
            goto label_10;
        }
    
    }
    public string GetDailyChallengeLevelInfo()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return Hack_GetLevelInfo();
        }
        
        return Hack_GetLevelInfo();
    }
    public string GetDailyChallengeTileInfo()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return Hack_GetTileInfo();
        }
        
        return Hack_GetTileInfo();
    }
    public string GetIQGameplayInfo()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-795506352) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordIQManagerGameplay MonoSingleton<WordIQManagerGameplay>::get_Instance()) != 0)
        {
                return DebugGameplayLogic();
        }
        
        return DebugGameplayLogic();
    }
    public string GetIQMathsInfo()
    {
        var val_4;
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-933718832) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_4 = 26025052;
            val_4 = 9607568 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_4 = null;
            val_4 = null;
            return;
        }
        
        val_5 = "uninitialized.";
    }
    public string GetIQPopulatedWordHistory()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-933718832) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 1152921512263062764;
            return;
        }
        
        val_4 = "uninitialized.";
    }
    public string GetIQActualWordHistory()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-933718832) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 1152921512263062768;
            return;
        }
        
        val_4 = "uninitialized.";
    }
    public string GetFeaturedOfferLog()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-795057232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 1152921512401724356;
            return;
        }
        
        val_4 = "uninitialized.";
    }
    public string GetWADPetsInfo()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1929661328) == 0)
        {
                return;
        }
        
        System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
        System.Collections.Generic.List<WADPets.WADPet> val_4 = WADPetsManager.GetAllPetsCollection();
        List.Enumerator<T> val_5 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_13 = val_7 + 8;
        val_13 = val_13 + 8;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        string val_9 = val_7.IsActive().ToString();
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        string val_10 = System.String.Format(format:  -794944080, args:  472754880);
        System.Text.StringBuilder val_11 = AppendLine();
        System.Text.StringBuilder val_12 = AppendLine(value:  -794944080);
        goto label_27;
        label_8:
        Dispose();
    }
    public string GetPrizeBalloonInfo()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1084053440) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance()) != 0)
        {
                return GetEligibilityInfo();
        }
        
        return GetEligibilityInfo();
    }
    public SRDebugger_Instantiator()
    {
        this.screenshot = 293;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.wastedMemory = null;
    }
    private static SRDebugger_Instantiator()
    {
    
    }

}
