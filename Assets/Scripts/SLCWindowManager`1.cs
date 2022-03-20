using UnityEngine;
public class SLCWindowManager<T> : MonoSingleton<T>
{
    // Fields
    public static string UGUI_Monolith_Window_Close;
    private static UnityEngine.Camera m_gameplayCamera;
    protected static UnityEngine.Camera m_monolithPopupCamera;
    private PrefabsFromFolder prefabsFromFolder;
    public WGWindowBackgroundHandler backgroundHandler;
    private System.Collections.Generic.Queue<UnityEngine.GameObject> uguiWindowQueue;
    private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> windows;
    private UnityEngine.GameObject currentWindow;
    private SLCWindowSetting currentWindowSetting;
    private UnityEngine.Coroutine waitingForGeneration;
    public UnityEngine.Events.UnityEvent onWindowClosed;
    public OnWindowOpenedEvent onWindowOpened;
    private UnityEngine.GameObject gc_window;
    private string debugQueue;
    private UnityEngine.GameObject[] debugQueueArray;
    public const string color_screen = "#F37CBE";
    protected const string color_show_window = "#E973EE";
    protected const string color_activating = "#E9991D";
    protected const string color_enqueue = "#23D5F5";
    protected const string color_on_window_closed = "#D7F377";
    protected const string color_show_available_popups = "#99BBCC";
    private string debugOps;
    
    // Properties
    protected virtual System.Type myWindowType { get; }
    public static UnityEngine.Camera gameplayCamera { get; }
    public static UnityEngine.Camera monolithPopupCamera { get; }
    public UnityEngine.GameObject CurrentWindow { get; }
    
    // Methods
    protected virtual System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(379019264)});
    }
    public static UnityEngine.Camera get_gameplayCamera()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) == 0)
        {
                UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_4 == 1)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = 0;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public static UnityEngine.Camera get_monolithPopupCamera()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 8) == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_3 = transform;
            object val_4 = GetComponentInChildren<System.Object>();
            val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_6 == 1)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        }
        
        val_7 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_7 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_7 == 1)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_7 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public override void InitMonoSingleton()
    {
        var val_3;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        0.AddObserver(observer:  -206261872, name:  __RuntimeMethodHiddenParam + 12 + 96 + 92);
        UnityEngine.Camera val_2 = UnityEngine.Camera.main;
        mem2[0] = 0;
    }
    public UnityEngine.GameObject get_CurrentWindow()
    {
    
    }
    public bool HasQueuedWindows()
    {
        if(__RuntimeMethodHiddenParam > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int GetActiveAndQueuedWindowCount()
    {
        if(this != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public void ShowWindow()
    {
        var val_10;
        var val_12;
        if(mem[35648721] < 1)
        {
                return;
        }
        
        object val_1 = static_value_021FF4BD.Peek();
        mem[1152921512990971180] = 35648701;
        val_10 = 35648701;
        if(static_value_021FF4BD == 0)
        {
                return;
        }
        
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -205810416, method:  __RuntimeMethodHiddenParam + 12 + 96 + 12);
        DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1041865114, ignoreTimeScale:  false);
        object val_5 = GetComponent<System.Object>();
        mem[1152921512990971184] = null;
        object val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 8.GetComponent<System.Object>();
        __RuntimeMethodHiddenParam + 12 + 96 + 8.Setup(settings:  190734336);
        string val_7 = __RuntimeMethodHiddenParam + 12 + 96 + 8.name;
        string val_8 = -205835632(-205835632) + __RuntimeMethodHiddenParam + 12 + 96 + 8(__RuntimeMethodHiddenParam + 12 + 96 + 8);
        if(this != 0)
        {
                val_12 = 0;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 8) != 0)
        {
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12) == 6)
        {
                val_12 = 1;
        }
        else
        {
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12) == 7)
        {
                val_12 = 1;
        }
        
        }
        
        }
        
            __RuntimeMethodHiddenParam + 12 + 96 + 8.Invoke(arg0:  true);
        }
        
        this.HandleWindowShowing(setting:  190734336);
    }
    private void OnWGWindowClosed(Notification n)
    {
        var val_7;
        var val_8;
        System.Type val_9;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = n;
        System.Type val_1 = n.sender.GetType();
        val_9 = n.sender;
        if((System.Type.op_Inequality(left:  val_9, right:  -205684912)) == true)
        {
                return;
        }
        
        string val_3 = n.sender.name;
        string val_4 = -205710128(-205710128) + n.sender;
        if(this < 1)
        {
                return;
        }
        
        object val_5 = n.sender.Dequeue();
        mem[1152921512991096684] = 0;
        n.sender.Invoke();
        if(this != 0)
        {
            
        }
        else
        {
                this.CloseBackgrounds();
        }
    
    }
    public void CloseCurrentWindow()
    {
        if(static_value_021FF4BF == 0)
        {
                return;
        }
        
        SLCWindow.CloseWindow(window:  R4 + 28, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public T ShowUGUIMonolith<T>(bool showNext = False)
    {
        float val_14;
        var val_15;
        System.Collections.Generic.List<ZooTile> val_16;
        var val_17;
        val_14 = showNext;
        val_15 = this;
        if((-205442096) == 0)
        {
                System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 8});
            typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 24 + 8;
            val_15 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  -205472624, args:  472754880);
            return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        val_16 = val_15;
        if((__RuntimeMethodHiddenParam.Contains(item:  -205442096)) == true)
        {
            goto label_30;
        }
        
        if(val_14 == false)
        {
            goto label_18;
        }
        
        T[] val_5 = __RuntimeMethodHiddenParam.ToArray();
        val_16 = null;
        val_16 = new System.Collections.Generic.List<ZooTile>(collection:  __RuntimeMethodHiddenParam);
        bool val_7 = UnityEngine.Object.op_Equality(x:  __RuntimeMethodHiddenParam, y:  0);
        UnityEngine.GameObject val_8 = this.gameObject;
        if(val_7 == false)
        {
                0 = 1;
        }
        
        if(val_7 == true)
        {
                0 = 0;
        }
        
        Insert(index:  0, item:  -205442096);
        this.Clear();
        val_17 = 0;
        val_14 = 1152921512991314256;
        if(val_16 != 0)
        {
            goto label_30;
        }
        
        goto label_30;
        label_18:
        UnityEngine.GameObject val_9 = this.gameObject;
        string val_10 = this.name;
        string val_11 = -205466288(-205466288) + -205442096(-205442096);
        UnityEngine.GameObject val_12 = this.gameObject;
        val_16 = val_15;
        this.Enqueue(item:  -205442096);
        label_30:
        if(0 != (-205442096))
        {
                return;
        }
    
    }
    public T GetWindow<T>()
    {
        var val_33;
        var val_34;
        var val_35;
        WordPets.WPTPetTile val_36;
        UnityEngine.Object val_37;
        var val_38;
        val_33 = this;
        val_34 = __RuntimeMethodHiddenParam;
        val_35 = 1152921504623353856;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        if((R6.ContainsKey(key:  __RuntimeMethodHiddenParam + 24)) == false)
        {
            goto label_5;
        }
        
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        string val_4 = R6.Item[__RuntimeMethodHiddenParam + 24];
        mem[1152921512991452848] = R6;
        if(R6 == 0)
        {
            goto label_12;
        }
        
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
            goto __RuntimeMethodHiddenParam + 24 + 4;
        }
        
        goto __RuntimeMethodHiddenParam + 24 + 4;
        label_12:
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = SB + 24});
        bool val_7 = SL + 24.Remove(key:  SB + 24);
        label_5:
        val_37 = SL + 12;
        val_38 = 1152921504765685760;
        if(val_37 == 0)
        {
                System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = SB + 24});
            typeof(System.Object[]).__il2cppRuntimeField_10 = SB + 24;
            val_37 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  -205353072, args:  472754880);
        }
        else
        {
                UnityEngine.GameObject val_10 = val_37.gameObject;
            object val_11 = val_37.GetComponent<System.Object>();
            if(val_37 != 0)
        {
                UnityEngine.GameObject val_13 = val_37.gameObject;
            object val_14 = val_37.GetComponent<System.Object>();
            System.Type val_15 = val_37.GetType();
            if((System.Type.op_Inequality(left:  val_37, right:  SL)) != false)
        {
                UnityEngine.GameObject val_17 = val_37.gameObject;
            string val_18 = val_37.name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_37;
            UnityEngine.GameObject val_19 = val_37.gameObject;
            object val_20 = val_37.GetComponent<System.Object>();
            System.Type val_21 = val_37.GetType();
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_37;
            typeof(System.Object[]).__il2cppRuntimeField_18 = SL;
            UnityEngine.Debug.LogWarningFormat(format:  -205352896, args:  472754880);
            UnityEngine.GameObject val_22 = val_37.gameObject;
            val_38 = 1152921504765685760;
            val_35 = 1152921504623353856;
            object val_23 = val_37.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  val_37);
        }
        
        }
        
            UnityEngine.GameObject val_24 = val_37.gameObject;
            UnityEngine.Component val_25 = val_37.GetComponent(type:  SL);
            if(val_37 == 0)
        {
                UnityEngine.GameObject val_27 = val_37.gameObject;
            UnityEngine.Component val_28 = val_37.AddComponent(componentType:  SL);
        }
        
            System.Type val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = SB + 24});
            UnityEngine.GameObject val_30 = val_37.gameObject;
            val_36 = val_37;
            SL + 24.Add(key:  SB + 24, value:  val_36);
        }
        
        var val_31 = FP - 28;
    }
    public bool ShowingWindow<T>()
    {
        if(static_value_02200687 == 0)
        {
                return false;
        }
        
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        string val_3 = this.name;
        return System.String.op_Equality(a:  __RuntimeMethodHiddenParam + 24, b:  -205216768);
    }
    public SLCWindowSetting GetCurrentWindowSetting()
    {
    
    }
    protected virtual void WindowStateChanged(bool anyActiveOrQueuedWindows)
    {
    
    }
    public void CloseAllWindows()
    {
        if(mem[35648724] >= 1)
        {
                static_value_021FF4C0.Clear();
        }
        
        bool val_1 = UnityEngine.Object.op_Inequality(x:  static_value_021FF4C0, y:  0);
        this.CloseBackgrounds();
    }
    public string DebugQueuedWindows()
    {
        var val_8;
        var val_9;
        mem[1152921512992013428] = "SLCWindowManager Queued Windows:<color=#B5DB11>\n";
        T[] val_1 = static_value_021FF4C1.ToArray();
        mem[1152921512992013432] = 35648705;
        val_8 = 35648705;
        val_9 = 0;
        goto label_2;
        label_7:
        var val_2 = R6 + 0;
        string val_3 = (R6 + 0) + 16.name;
        string val_4 = static_value_021FF4C1 + (R6 + 0) + 16((R6 + 0) + 16) + 1269544832;
        mem[1152921512992013428] = val_8;
        val_9 = 1;
        label_2:
        if(val_9 < mem[35648717])
        {
            goto label_7;
        }
        
        SceneType val_5 = SceneDictator.GetActiveSceneType();
        string val_6 = System.String.Format(format:  -204792592, arg0:  -204792432, arg1:  379232256);
        typeof(System.String[]).__il2cppRuntimeField_10 = "<color={0}>Current Screen Id: {1}</color>\n";
        typeof(System.String[]).__il2cppRuntimeField_14 = " ";
        typeof(System.String[]).__il2cppRuntimeField_18 = " ";
        typeof(System.String[]).__il2cppRuntimeField_1C = "</color>";
        typeof(System.String[]).__il2cppRuntimeField_20 = this;
        typeof(System.String[]).__il2cppRuntimeField_24 = "\n\n\n</size>{end of log}\n\n\n";
        string val_7 = +477709520;
    }
    public string DebugOperations()
    {
    
    }
    public void AddOp(string info, string hexColor)
    {
        var val_6;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_6 = 0;
        if(val_6.CompanyDevice() == false)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.time;
        string val_4 = System.String.Format(format:  -204560000, arg0:  hexColor, arg1:  15282176, arg2:  info);
        string val_5 = null + -204560000(-204560000);
        mem[1152921512992245756] = val_6;
    }
    public void ClearOps()
    {
        mem[1152921512992366092] = "\n-= operations history =-<size=9>";
    }
    public SLCWindowManager<T>()
    {
        var val_5;
        var val_6;
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        mem[1152921512992479076] = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        mem[1152921512992479080] = null;
        mem[1152921512992479096] = new UnityEngine.Events.UnityEvent();
        mem[1152921512992479100] = new OnWindowOpenedEvent();
        mem[1152921512992479108] = "";
        mem[1152921512992479116] = "\n-= operations history =-<size=9>";
        val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
        val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
        val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        }
        
        if((val_6 & 512) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 4 + 116) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        }
        
        }
    
    }
    private static SLCWindowManager<T>()
    {
        mem2[0] = "OnWGWindowClosed";
    }
    private void <ShowWindow>b__23_0()
    {
        R4.SetActive(value:  true);
    }

}
