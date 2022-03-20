using UnityEngine;
public class WGChallengeController : MonoSingletonSelfGenerating<WGChallengeController>
{
    // Fields
    private bool initialized;
    private string prefkey;
    private System.Collections.Generic.List<ChallengeTask> taskList;
    private const string initialReqLookup = "init";
    private const string incrementLookup = "inc";
    private const string maxRequirementLookup = "max";
    private bool gotKnobs;
    private int _unlockLevel;
    private int _challengeReward;
    private int _flyoutFrequency;
    public System.Action<bool, ChallengeType> onAnyChallengeProgress;
    private System.Collections.Generic.Dictionary<ChallengeType, System.Collections.Generic.Dictionary<string, object>> goalKnobData;
    
    // Properties
    public bool Initialized { get; }
    public System.Collections.Generic.List<ChallengeTask> getAllTasks { get; }
    public int unlockLevel { get; }
    public int challengeReward { get; }
    public bool featureEnabled { get; }
    public bool shouldShowProgressPopup { get; }
    
    // Methods
    public bool get_Initialized()
    {
        return (bool)this.initialized;
    }
    public System.Collections.Generic.List<ChallengeTask> get_getAllTasks()
    {
    
    }
    public int get_unlockLevel()
    {
        return (int)this._unlockLevel;
    }
    public int get_challengeReward()
    {
        return (int)this._challengeReward;
    }
    public bool get_featureEnabled()
    {
        if(this._unlockLevel < 0)
        {
                return false;
        }
        
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public bool get_shouldShowProgressPopup()
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_6 = 0;
        if(0 == 0)
        {
                return (bool)val_6;
        }
        
        val_6 = 0;
        Player val_2 = App.Player;
        val_7 = 0;
        if(val_7 < this._unlockLevel)
        {
                return (bool)val_6;
        }
        
        Player val_3 = App.Player;
        val_7 = 0;
        val_6 = 0;
        int val_4 = CPlayerPrefs.GetInt(key:  -1606586000, defaultValue:  0);
        val_4 = this._flyoutFrequency + val_4;
        if(val_7 < val_4)
        {
                return (bool)val_6;
        }
        
        Player val_5 = App.Player;
        CPlayerPrefs.SetInt(key:  -1606586000, val:  0);
        val_6 = 1;
        return (bool)val_6;
    }
    private void Awake()
    {
        System.Delegate val_6;
        System.Delegate val_7;
        System.Action<System.Boolean, collectResultStatus> val_1 = new System.Action<System.Boolean, collectResultStatus>(object:  -1606443648, method:  new IntPtr(2688497504));
        val_6 = this.onAnyChallengeProgress;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_6, b:  7507968);
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_6 = 0;
        label_2:
        this.onAnyChallengeProgress = val_6;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1606443648, name:  -1606468768);
        System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  -1606443648, method:  new IntPtr(2688498624));
        val_7 = GoldenApplesManager.OnAppleAwarded;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_7, b:  7401472);
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_7 = 0;
        label_7:
        GoldenApplesManager.OnAppleAwarded = val_7;
    }
    private void Start()
    {
        System.Delegate val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1606351552) == 0)
        {
            goto label_5;
        }
        
        System.Action val_3 = new System.Action(object:  -1606325504, method:  new IntPtr(2688616768));
        val_5 = WGInviteManager.onInviteSent;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_5, b:  7454720);
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_5 = 0;
        label_7:
        WGInviteManager.onInviteSent = val_5;
        label_5:
        this.init();
    }
    private void OnApplicationPause(bool paused)
    {
        this.storeData();
    }
    public void CheckSceneLoading()
    {
        var val_16;
        System.Func<ChallengeTask, System.Boolean> val_18;
        if(this.featureEnabled == false)
        {
                return;
        }
        
        this.storeData();
        Player val_2 = App.Player;
        if(0 < this._unlockLevel)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) != false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = WGChallengeController.<>c.<>9__27_0;
        if(val_18 == 0)
        {
                val_18 = null;
            val_18 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGChallengeController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2688846912));
            WGChallengeController.<>c.<>9__27_0 = val_18;
        }
        
        if((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  this.taskList, predicate:  7720960)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_11 = ShowUGUIMonolith<System.Object>(showNext:  false);
            PlayCompleteFlyout();
            Player val_12 = App.Player;
            CPlayerPrefs.SetInt(key:  -1606586000, val:  0);
            return;
        }
        
        if(this.shouldShowProgressPopup == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_15 = ShowUGUIMonolith<System.Object>(showNext:  false);
        PlayProgressFlyout();
    }
    private void OnProgress(bool completed, ChallengeType type)
    {
        bool val_1 = this.featureEnabled;
        if(completed != true)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        MainController val_10 = MainController.instance;
        if(0 != 0)
        {
                MainController val_12 = MainController.instance;
            if(3 != 0)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_14 = ShowUGUIMonolith<System.Object>(showNext:  false);
        PlayCompleteFlyout();
    }
    private void init()
    {
        var val_9;
        WGChallengeController val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = this;
        if(this.initialized == true)
        {
                return;
        }
        
        this.ParseKnobs();
        Player val_1 = App.Player;
        val_13 = "";
        bool val_2 = System.String.op_Equality(a:  null, b:  1098586544);
        if(val_2 == true)
        {
                val_2 = val_11;
            this.CreateOrUpdatePlayer();
        }
        
        Player val_3 = App.Player;
        if((System.String.op_Inequality(a:  null, b:  1098586544)) == false)
        {
            goto label_8;
        }
        
        Player val_5 = App.Player;
        val_14 = 0;
        object val_6 = MiniJSON.Json.Deserialize(json:  null);
        val_13 = 0;
        if(val_13 != 0)
        {
                val_14 = 0;
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        val_12 = 1152921504912437248;
        label_23:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        val_15 = 0;
        if(val_9 != 0)
        {
                val_15 = val_9;
            if(val_9 == 0)
        {
                val_15 = 0;
        }
        
        }
        
        ChallengeTask val_10 = new ChallengeTask();
        deserialize(data:  0);
        mem[1152921511590926612].Add(item:  305590272);
        goto label_23;
        label_18:
        Dispose();
        val_11 = val_11;
        this.CreateOrUpdatePlayer();
        label_8:
        this.initialized = true;
    }
    private void CreateOrUpdatePlayer()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        WGChallengeController.<>c val_53;
        System.Func<ChallengeTask, System.Boolean> val_54;
        var val_55;
        System.Func<ChallengeTask, System.Boolean> val_57;
        var val_58;
        System.Func<ChallengeTask, System.Boolean> val_60;
        var val_61;
        System.Func<ChallengeTask, System.Boolean> val_63;
        var val_64;
        System.Func<ChallengeTask, System.Boolean> val_66;
        if(this.gotKnobs == false)
        {
                this.gotKnobs = this;
            this.ParseKnobs();
        }
        
        if((WGChallengeController.<>c.<>9__30_0) == 0)
        {
                val_53 = WGChallengeController.<>c.<>9;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_1 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  val_53, method:  new IntPtr(2689208512));
            WGChallengeController.<>c.<>9__30_0 = null;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.goalKnobData.Item[0];
            string val_4 = this.goalKnobData.Item[-1890606496];
            string val_5 = this.goalKnobData.ToString();
            int val_6 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_7 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_12 = this.addChallenge(subject:  0, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        val_54 = WGChallengeController.<>c.<>9__30_1;
        if(val_54 == 0)
        {
                val_53 = WGChallengeController.<>c.<>9;
            val_54 = null;
            val_54 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  val_53, method:  new IntPtr(2689219776));
            WGChallengeController.<>c.<>9__30_1 = val_54;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = this.goalKnobData.Item[1];
            string val_16 = this.goalKnobData.Item[-1890606496];
            string val_17 = this.goalKnobData.ToString();
            int val_18 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_19 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_20 = this.addChallenge(subject:  1, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        val_55 = null;
        val_55 = null;
        val_57 = WGChallengeController.<>c.<>9__30_2;
        if(val_57 == 0)
        {
                val_57 = null;
            val_57 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGChallengeController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2689228992));
            WGChallengeController.<>c.<>9__30_2 = val_57;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_23 = this.goalKnobData.Item[2];
            string val_24 = this.goalKnobData.Item[-1890606496];
            string val_25 = this.goalKnobData.ToString();
            int val_26 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_27 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_28 = this.addChallenge(subject:  2, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        val_58 = null;
        val_58 = null;
        val_60 = WGChallengeController.<>c.<>9__30_3;
        if(val_60 == 0)
        {
                val_60 = null;
            val_60 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGChallengeController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2689238208));
            WGChallengeController.<>c.<>9__30_3 = val_60;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_31 = this.goalKnobData.Item[3];
            string val_32 = this.goalKnobData.Item[-1890606496];
            string val_33 = this.goalKnobData.ToString();
            int val_34 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_35 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_36 = this.addChallenge(subject:  3, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        val_61 = null;
        val_61 = null;
        val_63 = WGChallengeController.<>c.<>9__30_4;
        if(val_63 == 0)
        {
                val_63 = null;
            val_63 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGChallengeController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2689247424));
            WGChallengeController.<>c.<>9__30_4 = val_63;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_39 = this.goalKnobData.Item[4];
            string val_40 = this.goalKnobData.Item[-1890606496];
            string val_41 = this.goalKnobData.ToString();
            int val_42 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_43 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_44 = this.addChallenge(subject:  4, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        val_64 = null;
        val_64 = null;
        val_66 = WGChallengeController.<>c.<>9__30_5;
        if(val_66 == 0)
        {
                val_66 = null;
            val_66 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGChallengeController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2689256640));
            WGChallengeController.<>c.<>9__30_5 = val_66;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.taskList, predicate:  7720960)) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_47 = this.goalKnobData.Item[5];
            string val_48 = this.goalKnobData.Item[-1890606496];
            string val_49 = this.goalKnobData.ToString();
            int val_50 = System.Int32.Parse(s:  this.goalKnobData);
            decimal val_51 = System.Decimal.op_Implicit(value:  -1605689492);
            int val_52 = this.addChallenge(subject:  5, target:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        }
        
        if(val_52 != R8)
        {
                val_52 = this;
            this.storeData();
        }
    
    }
    private void ParseKnobs()
    {
        var val_38;
        if(this.gotKnobs == true)
        {
                return;
        }
        
        this.gotKnobs = true;
        GameEcon val_1 = App.getGameEcon;
        if(5701821 == 0)
        {
                return;
        }
        
        GameEcon val_2 = App.getGameEcon;
        if((5701821.ContainsKey(key:  -1605532096)) != false)
        {
                GameEcon val_4 = App.getGameEcon;
            string val_5 = 5701821.Item[-1605532096];
            val_38 = "Error Parsing all goal knobs, defaulting to econ values";
        }
        else
        {
                val_38 = "no goal data found in challenge knobs";
        }
        
        UnityEngine.Debug.LogWarning(message:  -1605531824);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        GameEcon val_7 = App.getGameEcon;
        Add(key:  -1890606496, value:  13152256);
        GameEcon val_8 = App.getGameEcon;
        Add(key:  -1605531680, value:  13152256);
        GameEcon val_9 = App.getGameEcon;
        Add(key:  -1605531600, value:  13152256);
        this.goalKnobData.set_Item(key:  0, value:  78753792);
        GameEcon val_10 = App.getGameEcon;
        if((5701821.ContainsKey(key:  -1605526400)) == false)
        {
            goto label_34;
        }
        
        GameEcon val_12 = App.getGameEcon;
        string val_13 = 5701821.Item[-1605526400];
        if((System.Int32.TryParse(s:  5701821, result: out  this._challengeReward)) == true)
        {
            goto label_40;
        }
        
        label_34:
        UnityEngine.Debug.LogError(message:  -1605526320);
        label_40:
        GameEcon val_16 = App.getGameEcon;
        if((5701821.ContainsKey(key:  -1640018224)) == false)
        {
            goto label_47;
        }
        
        GameEcon val_18 = App.getGameEcon;
        string val_19 = 5701821.Item[-1640018224];
        if((System.Int32.TryParse(s:  5701821, result: out  this._unlockLevel)) == true)
        {
            goto label_53;
        }
        
        label_47:
        UnityEngine.Debug.LogError(message:  -1605526176);
        label_53:
        GameEcon val_22 = App.getGameEcon;
        if((5701821.ContainsKey(key:  -1605526032)) != false)
        {
                GameEcon val_24 = App.getGameEcon;
            string val_25 = 5701821.Item[-1605526032];
            if((System.Int32.TryParse(s:  5701821, result: out  this._flyoutFrequency)) == true)
        {
                return;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  -1605525936);
    }
    private void CheckAndSetKnobDictionary(System.Collections.Generic.Dictionary<string, object> datas, ChallengeType cType)
    {
        if(((datas.ContainsKey(key:  -1605531680)) != false) && ((datas.ContainsKey(key:  -1890606496)) != false))
        {
                if((datas.ContainsKey(key:  -1605531600)) != false)
        {
                this.goalKnobData.set_Item(key:  cType, value:  datas);
            return;
        }
        
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_4 = -1605397008(-1605397008) + 305537024;
        UnityEngine.Debug.LogError(message:  -1605397008);
    }
    public void resetData()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  this.prefkey);
        this.taskList.Clear();
        this.initialized = false;
        this.init();
    }
    public void storeData()
    {
        twelvegigs.sweepstakes.Distribution val_5;
        if(this.initialized == false)
        {
                return;
        }
        
        if(this.featureEnabled == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = val_5.serialize();
        Add(item:  val_5);
        goto label_7;
        label_4:
        Dispose();
        string val_7 = MiniJSON.Json.Serialize(obj:  80883712);
        Player val_8 = App.Player;
        mem[232] = null;
    }
    public int addChallenge(ChallengeType subject, decimal target)
    {
        var val_7;
        ChallengeTask val_1 = new ChallengeTask();
        if(val_1 != 0)
        {
                val_7 = val_1;
            typeof(ChallengeTask).__il2cppRuntimeField_8 = subject;
            ChallengeTask.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = subject;
        }
        else
        {
                val_7 = 8;
            mem[8] = subject;
            mem[12] = subject;
        }
        
        typeof(ChallengeTask).__il2cppRuntimeField_2C = target.mid;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.goalKnobData.Item[subject];
        if((this.goalKnobData.ContainsKey(key:  -1605011680)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = this.goalKnobData.Item[subject];
            if((this.goalKnobData.ContainsKey(key:  -1605007504)) != false)
        {
                System.DateTime val_6 = DateTimeCheat.UtcNow;
            typeof(ChallengeTask).__il2cppRuntimeField_30 = ???;
        }
        
        }
        
        this.taskList.Add(item:  305590272);
        return (int)val_7;
    }
    public void OnDataReady()
    {
    
    }
    public void removeChallenge(int id)
    {
        ChallengeTask val_1 = this.getChallenge(id:  id);
        this.removeChallenge(ct:  -1604738944);
    }
    public void removeChallenge(ChallengeTask ct)
    {
        if(ct == 0)
        {
                return;
        }
        
        bool val_1 = this.taskList.Remove(item:  ct);
    }
    public ChallengeTask getChallenge(int id)
    {
        var val_3;
        var val_4;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_4 = val_3;
        if((val_3 + 8) != id)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        Dispose();
    }
    public float getChallengePercent(int id)
    {
        ChallengeTask val_1 = this.getChallenge(id:  id);
        if(this == 0)
        {
                return (float)S0;
        }
        
        return this.getPercent();
    }
    public bool isChallengeComplete(int id)
    {
        ChallengeTask val_1 = this.getChallenge(id:  id);
        if(this == 0)
        {
                return false;
        }
        
        return this.isComplete();
    }
    public void CompleteChallenge(int id)
    {
        ChallengeTask val_1 = this.getChallenge(id:  id);
        if(this == 0)
        {
                return;
        }
        
        35626934 = 0;
        bool val_2 = this.gainProgress(amt:  new System.Decimal() {flags = mem[this._challengeReward + (0)], hi = mem[this._challengeReward + (4)], lo = mem[this._challengeReward + (8)], mid = this.goalKnobData});
        if(this.onAnyChallengeProgress == 0)
        {
                return;
        }
        
        this.onAnyChallengeProgress.Invoke(arg1:  true, arg2:  this.initialized);
    }
    private void gainProgress(ChallengeType t, decimal amt)
    {
        var val_5;
        int val_9;
        int val_10;
        Player val_1 = App.Player;
        if(0 < this._unlockLevel)
        {
                return;
        }
        
        if(this.featureEnabled == false)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_9 = val_5;
        if((val_5 + 12) != t)
        {
            goto label_13;
        }
        
        bool val_6 = val_9.gainProgress(amt:  new System.Decimal() {flags = amt.flags, hi = amt.hi, lo = amt.lo, mid = amt.mid});
        if(this.onAnyChallengeProgress == 0)
        {
            goto label_13;
        }
        
        var val_7 = val_9 + 24;
        val_9 = val_9 + 36;
        val_10 = mem[(val_5 + 24) + (4)];
        val_9 = mem[(val_5 + 24) + (0)];
        this.onAnyChallengeProgress.Invoke(arg1:  System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_5 + 16, hi = val_5 + 20, lo = val_9, mid = val_10}, d2:  new System.Decimal() {flags = mem[(val_5 + 24) + (8)], hi = mem[(val_5 + 36) + (0)], lo = mem[(val_5 + 36) + (4)], mid = mem[(val_5 + 36) + (8)]}), arg2:  t);
        goto label_13;
        label_7:
        Dispose();
    }
    private void clearProgress(ChallengeType t)
    {
        var val_2;
        List.Enumerator<T> val_1 = GetEnumerator();
        goto label_4;
        label_5:
        if((val_2 + 12) == t)
        {
                var val_3 = val_2 + 16;
        }
        
        label_4:
        if(MoveNext() == true)
        {
            goto label_5;
        }
        
        Dispose();
    }
    public void debugMakeComplete(int id)
    {
        ChallengeTask val_1 = this.getChallenge(id:  id);
        this.debugMakeComplete(ct:  -1603758976);
    }
    public void debugMakeComplete(ChallengeTask ct)
    {
        decimal val_2;
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        if(ct == 0)
        {
                return;
        }
        
        val_2 = ct.progress;
        val_6 = mem[ct + 16 + (4)];
        val_5 = mem[ct + 16 + (12)];
        val_3 = val_6;
        val_4 = mem[ct + 16 + (8)];
        val_2 = val_2;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_2, hi = val_3, lo = val_4, mid = val_5}, d2:  new System.Decimal() {flags = ct + 16 + 16, hi = ct + 16 + 20, lo = ct + 16 + 24, mid = ct + 16 + 28})) == false)
        {
                return;
        }
    
    }
    public bool CheckChallengeAvailable(ChallengeType cType)
    {
        if(cType == 5)
        {
                return this.twitterPostAvailable();
        }
        
        if(cType != 4)
        {
                this = 1;
            return (bool)this;
        }
        
        return this.friendInviteAvailable();
    }
    private bool friendInviteAvailable()
    {
        ulong val_4;
        ulong val_16;
        var val_27;
        var val_28;
        val_27 = 0;
        if(WGInviteManager.IsEnabled == false)
        {
                return (bool)val_27;
        }
        
        ChallengeTask val_2 = this.getChallenge(id:  4);
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        val_27 = 0;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = R7})) == true)
        {
                return (bool)val_27;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = this.goalKnobData.Item[4];
        val_28 = 1152921510392296080;
        if((this.goalKnobData.ContainsKey(key:  -1605011680)) == false)
        {
                return (bool)val_27;
        }
        
        val_28 = "d";
        if((this.goalKnobData.ContainsKey(key:  -1605007504)) == false)
        {
                return (bool)val_27;
        }
        
        string val_10 = this.goalKnobData.Item[-1605011680];
        string val_11 = this.goalKnobData.ToString();
        if((System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_12 = -1603414328)) != false)
        {
                System.DateTime val_14 = DateTimeCheat.UtcNow;
            System.DateTime val_15 = AddDays(value:  null);
            val_27 = 1;
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_16})) == true)
        {
                return (bool)val_27;
        }
        
            string val_19 = this.goalKnobData.Item[-1605007504];
            string val_20 = this.goalKnobData.ToString();
            if((System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_21 = -1603414332)) != false)
        {
                val_27 = 0;
            System.DateTime val_23 = DateTimeCheat.UtcNow;
            System.DateTime val_24 = AddDays(value:  null);
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_16})) == false)
        {
                return (bool)val_27;
        }
        
            System.DateTime val_26 = DateTimeCheat.UtcNow;
            val_27 = 1;
            mem[1152921511593379328] = val_4;
            return (bool)val_27;
        }
        
        }
        
        val_27 = 0;
        UnityEngine.Debug.LogError(message:  -1603426496);
        return (bool)val_27;
    }
    private bool twitterPostAvailable()
    {
        ulong val_3;
        ulong val_15;
        var val_26;
        var val_27;
        ChallengeTask val_1 = this.getChallenge(id:  5);
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        val_27 = 0;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = R7})) == true)
        {
                return (bool)val_27;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = this.goalKnobData.Item[5];
        val_26 = 1152921510392296080;
        if((this.goalKnobData.ContainsKey(key:  -1605011680)) == false)
        {
                return (bool)val_27;
        }
        
        val_26 = "d";
        if((this.goalKnobData.ContainsKey(key:  -1605007504)) == false)
        {
                return (bool)val_27;
        }
        
        string val_9 = this.goalKnobData.Item[-1605011680];
        string val_10 = this.goalKnobData.ToString();
        if((System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_11 = -1603294136)) != false)
        {
                System.DateTime val_13 = DateTimeCheat.UtcNow;
            System.DateTime val_14 = AddDays(value:  null);
            val_27 = 1;
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = val_15})) == true)
        {
                return (bool)val_27;
        }
        
            string val_18 = this.goalKnobData.Item[-1605007504];
            string val_19 = this.goalKnobData.ToString();
            if((System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_20 = -1603294140)) != false)
        {
                val_27 = 0;
            System.DateTime val_22 = DateTimeCheat.UtcNow;
            System.DateTime val_23 = AddDays(value:  null);
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = val_15})) == false)
        {
                return (bool)val_27;
        }
        
            System.DateTime val_25 = DateTimeCheat.UtcNow;
            val_27 = 1;
            mem[1152921511593499520] = val_3;
            return (bool)val_27;
        }
        
        }
        
        val_27 = 0;
        UnityEngine.Debug.LogError(message:  -1603426496);
        return (bool)val_27;
    }
    public bool TryCompleteChallenge(ChallengeType chalToComplete)
    {
        int val_21;
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        int val_29;
        int val_29;
        var val_30;
        var val_31;
        var val_32;
        val_29 = chalToComplete;
        ChallengeTask val_1 = this.getChallenge(id:  val_29);
        if(this == 0)
        {
            goto label_1;
        }
        
        val_30 = 0;
        if(this.isComplete() == false)
        {
                return (bool)val_30;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.goalKnobData.Item[val_29];
        if(this.goalKnobData == 0)
        {
            goto label_4;
        }
        
        string val_4 = this.goalKnobData.Item[-1605531680];
        string val_5 = this.goalKnobData.ToString();
        int val_6 = System.Int32.Parse(s:  this.goalKnobData);
        string val_7 = this.goalKnobData.Item[-1605531600];
        string val_8 = this.goalKnobData.ToString();
        int val_9 = System.Int32.Parse(s:  this.goalKnobData);
        if(val_29 > 5)
        {
            goto label_7;
        }
        
        var val_10 = 6716688 + (6716688 + (chalToComplete) << 2);
        if(val_29 == 5)
        {
                6716688 = 6716688 & 2691809872;
            6716688 = 6716688 & (((this.goalKnobData) << (32-6716688 + (chalToComplete) << 2)) | ((this.goalKnobData) << 6716688 + (chalToComplete) << 2));
            6716688 = 6716688 & (-200394678);
            6716688 = 6716688 & ((IP) << public System.String System.Object::ToString());
            6716688 = 6716688 & (((((((6716688 & 2691809872) & ((this.goalKnobData) << (32-6716688 + (chalToComplete) << 2)) | ((this.goalKnobData) << 6716688 + (chalToComplete) << 2)) & -200394678) & (IP) << public System.String Syste) << (32-public System.String System.Object::ToString())) | ((((((6716688 & 2691809872) & ((this.goalKnobData) << (32-6716688 + (chalToComplete) << 2)) | ((this.goalKnobData) << 6716688 + (chalToComplete) << 2)) & -200394678) & (IP) << public System.String Syste) << public System.String System.Object::ToString()));
            6716688 = 6716688 & (this.goalKnobData >> 5);
        }
        
        Player val_11 = App.Player;
        val_31 = 2621448;
        if(val_31 == 0)
        {
            goto label_11;
        }
        
        val_32 = 35143948;
        goto label_46;
        label_1:
        val_30 = 0;
        return (bool)val_30;
        label_4:
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        val_30 = 0;
        string val_12 = -1603181808(-1603181808) + 305537024 + -1603181696(-1603181696);
        UnityEngine.Debug.LogError(message:  -1603181808);
        return (bool)val_30;
        label_7:
        UnityEngine.Debug.Log(message:  -1603181584);
        goto label_21;
        label_11:
        val_31 = 236;
        label_46:
        mem[252] =  + 1;
        label_21:
        decimal val_19 = System.Decimal.op_Implicit(value:  -1603169480);
        decimal val_20 = System.Decimal.op_Implicit(value:  -1603169496);
        this.Complete(currentIncrement:  new System.Decimal() {mid = val_22}, currentMax:  new System.Decimal() {flags = val_21, hi = val_25, lo = val_24, mid = val_23});
        Player val_26 = App.Player;
        decimal val_27 = System.Decimal.op_Implicit(value:  -1603169512);
        string val_28 = val_27.flags.getChallengeTrackingID(cType:  null);
        val_29 = val_27.flags;
        val_30 = 1;
        0.AddCredits(amount:  new System.Decimal() {mid = val_29}, source:  val_29, subSource:  0, externalParams:  0, doTrack:  true);
        this.storeData();
        return (bool)val_30;
    }
    public void OnSecondaryCurrencyGained(int numGained)
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        decimal val_1 = System.Decimal.op_Implicit(value:  -1603049272);
        this.gainProgress(t:  1, amt:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = val_2});
    }
    public void OnDailyChallengeComplete()
    {
        null = null;
        this.gainProgress(t:  3, amt:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
    }
    public void OnAnyHintUsed()
    {
        null = null;
        this.gainProgress(t:  2, amt:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
    }
    public void OnExtraWordFound()
    {
        null = null;
        this.gainProgress(t:  0, amt:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
    }
    public void OnInviteSent()
    {
        var val_15;
        var val_16;
        if(this.friendInviteAvailable() == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        this.gainProgress(t:  4, amt:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        if((this.isChallengeComplete(id:  4)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.goalKnobData.Item[4];
        if((this.goalKnobData.ContainsKey(key:  -1605007504)) != false)
        {
                string val_5 = this.goalKnobData.Item[-1605007504];
            string val_6 = this.goalKnobData.ToString();
            bool val_8 = System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_7 = -1602597164);
        }
        
        ChallengeTask val_9 = this.getChallenge(id:  4);
        System.DateTime val_10 = DateTimeCheat.UtcNow;
        System.DateTime val_13 = AddDays(value:  null);
        mem[1152921511594196480] = val_15;
    }
    public void OnTweetSent()
    {
        var val_15;
        var val_16;
        if(this.twitterPostAvailable() == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        this.gainProgress(t:  5, amt:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        if((this.isChallengeComplete(id:  5)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.goalKnobData.Item[5];
        if((this.goalKnobData.ContainsKey(key:  -1605007504)) != false)
        {
                string val_5 = this.goalKnobData.Item[-1605007504];
            string val_6 = this.goalKnobData.ToString();
            bool val_8 = System.Int32.TryParse(s:  this.goalKnobData, result: out  int val_7 = -1602476972);
        }
        
        ChallengeTask val_9 = this.getChallenge(id:  5);
        System.DateTime val_10 = DateTimeCheat.UtcNow;
        System.DateTime val_13 = AddDays(value:  null);
        mem[1152921511594316672] = val_15;
    }
    public string getChallengeTrackingID(ChallengeType cType)
    {
        var val_3;
        if(cType <= 5)
        {
                var val_1 = 6718016 + (6718016 + (cType) << 2);
            if(cType == 5)
        {
                6718016 = 6718016 & ((R8) << 6718016);
            6718016 = R8 * 6718016;
            6718016 = 6718016 & (cType >> 1);
            mem2[0] = ((R8 * (6718016 & (R8) << 6718016)) & (cType) >> 1) + ((R8 * (6718016 & (R8) << 6718016)) & (cType) >> 1);
            mem2[0] = ((R8 * (6718016 & (R8) << 6718016)) & (cType) >> 1) + ((R8 * (6718016 & (R8) << 6718016)) & (cType) >> 1) + IP;
        }
        
            val_3 = "Extra Words";
            return;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_2 = -1602368752(-1602368752) + 305537024;
    }
    public WGChallengeController()
    {
        this.prefkey = "ChallengeTrackerData";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.taskList = null;
        this._unlockLevel = 25;
        this._challengeReward = 25;
        this._flyoutFrequency = 7;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_2 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  -1602249808);
        }
        else
        {
                Add(key:  -1890606496, value:  -1602249808);
        }
        
        Add(key:  -1605531680, value:  1701898768);
        Add(key:  -1605531600, value:  -1830317488);
        Add(key:  0, value:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  -1830317168);
        }
        else
        {
                Add(key:  -1890606496, value:  -1830317168);
        }
        
        Add(key:  -1605531680, value:  1633189168);
        Add(key:  -1605531600, value:  -1602248704);
        Add(key:  2, value:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  -1830317488);
        }
        else
        {
                Add(key:  -1890606496, value:  -1830317488);
        }
        
        Add(key:  -1605531680, value:  -1602248624);
        Add(key:  -1605531600, value:  -1602248544);
        Add(key:  1, value:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        else
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        
        Add(key:  -1605531680, value:  1633189168);
        Add(key:  -1605531600, value:  -1830317088);
        Add(key:  3, value:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        else
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        
        Add(key:  -1605531680, value:  1633189168);
        Add(key:  -1605531600, value:  -1830317088);
        Add(key:  4, value:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        else
        {
                Add(key:  -1890606496, value:  1633189168);
        }
        
        Add(key:  -1605531680, value:  1633189168);
        Add(key:  -1605531600, value:  -1830317088);
        Add(key:  5, value:  78753792);
        this.goalKnobData = null;
    }

}
