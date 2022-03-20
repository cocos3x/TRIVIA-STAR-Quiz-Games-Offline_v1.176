using UnityEngine;
public class WGTaskController : MonoSingleton<WGTaskController>
{
    // Fields
    private System.Collections.Generic.Dictionary<string, int> unlockableFeatures;
    private int highestLevelRequiredTask;
    private System.Collections.Generic.List<string> seenTasks;
    private bool hasInit;
    
    // Properties
    private int unlockLevel { get; }
    public bool isRelevent { get; }
    
    // Methods
    private int get_unlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 1144;
        }
        
        return 1144;
    }
    public bool get_isRelevent()
    {
        var val_7;
        var val_8;
        if(this.hasInit == false)
        {
                this.hasInit = this;
            this.Init();
        }
        
        if(this.unlockLevel >= 0)
        {
                val_7 = 0;
            GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
            if(0 != 1)
        {
                return (bool)val_7;
        }
        
            val_7 = 0;
            Player val_3 = App.Player;
            val_8 = 0;
            if(val_8 < this.unlockLevel)
        {
                return (bool)val_7;
        }
        
            val_7 = 0;
            Player val_5 = App.Player;
            val_8 = 0;
            if(val_8 >= this.highestLevelRequiredTask)
        {
                return (bool)val_7;
        }
        
            System.Collections.Generic.List<System.String> val_7 = this.seenTasks;
            val_7 = val_7 - this.unlockableFeatures.Count;
            if(this.unlockableFeatures != 0)
        {
                val_7 = 1;
        }
        
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private void Start()
    {
        this.Init();
    }
    private void Init()
    {
        var val_5;
        var val_6;
        if(this.hasInit == true)
        {
                return;
        }
        
        bool val_1 = CPlayerPrefs.HasKey(key:  -1146860048);
        if(val_1 != false)
        {
                val_5 = 0;
            string val_2 = CPlayerPrefs.GetString(key:  -1146860048, defaultValue:  -2141227328);
            object val_3 = MiniJSON.Json.Deserialize(json:  -1146860048);
            if("seenTasks" != 0)
        {
                if(null != null)
        {
                "seenTasks" = 0;
        }
        
            val_5 = "seenTasks";
        }
        
            val_6 = R4;
            mem2[0] = val_5;
        }
        else
        {
                val_6 = R4;
            val_5 = mem[R4 + 20];
            val_5 = R4 + 20;
        }
        
        if(val_5 != 0)
        {
                val_1 = mem[R4 + 20 + 12];
            val_1 = R4 + 20 + 12;
        }
        
        if(val_1 == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem2[0] = null;
        }
        
        R4.PopulateEventUnlocks();
        mem2[0] = 1;
    }
    public string getNextUnlockableEvent()
    {
        var val_6;
        int val_7;
        var val_8;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32> val_10;
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_14;
        val_7 = System.String.alignConst;
        if(this.isRelevent == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = WGTaskController.<>c.<>9__10_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(object:  WGTaskController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3148223440));
            WGTaskController.<>c.<>9__10_0 = val_10;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>, System.Int32>(source:  this.unlockableFeatures, keySelector:  7720960);
        val_12 = null;
        val_12 = null;
        val_14 = WGTaskController.<>c.<>9__10_1;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  WGTaskController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3148226512));
            WGTaskController.<>c.<>9__10_1 = val_14;
        }
        
        System.Collections.Generic.KeyValuePair<System.Object, System.Int32> val_5 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -1146725744, predicate:  this.unlockableFeatures);
        val_7 = val_6;
    }
    public int getNextUnlockLevel()
    {
        string val_7;
        var val_8;
        goto label_0;
        label_12:
        this.PopulateEventUnlocks();
        string val_1 = this.getNextUnlockableEvent();
        val_7 = this;
        if((this.unlockableFeatures.ContainsKey(key:  -1146581232)) == false)
        {
                return (int)val_8;
        }
        
        val_8 = this.unlockableFeatures.Item[-1146581232];
        Player val_4 = App.Player;
        if(0 != val_8)
        {
                return (int)val_8;
        }
        
        this.seenTasks.Add(item:  -1146581232);
        string val_5 = MiniJSON.Json.Serialize(obj:  this.seenTasks);
        val_7 = this.seenTasks;
        CPlayerPrefs.SetString(key:  -1146860048, val:  val_7);
        CPlayerPrefs.Save();
        label_0:
        val_8 = 0;
        if(this.isRelevent == true)
        {
            goto label_12;
        }
        
        return (int)val_8;
    }
    private void PopulateEventUnlocks()
    {
        int val_31;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32> val_32;
        var val_33;
        var val_34;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.unlockableFeatures = null;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1146476848) != 0)
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 != 0)
        {
                GameEcon val_5 = App.getGameEcon;
            this.unlockableFeatures.Add(key:  -1146471728, value:  1092);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) != 0)
        {
                GameBehavior val_8 = App.getBehavior;
            if(0 != 0)
        {
                GameEcon val_9 = App.getGameEcon;
            this.unlockableFeatures.Add(key:  -1535358816, value:  983057);
        }
        
        }
        
        GameBehavior val_10 = App.getBehavior;
        if(0 != 0)
        {
                GameBehavior val_11 = App.getBehavior;
            this.unlockableFeatures.Add(key:  -1146463440, value:  0);
        }
        
        val_32 = 1152921504901201920;
        val_33 = 1152921511095702560;
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_14 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(featureEnabled != false)
        {
                WordPets.WPTDataParser val_16 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            this.unlockableFeatures.Add(key:  -1146459248, value:  public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_1C);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1937797680) != 0)
        {
                GameEcon val_19 = App.getGameEcon;
            val_32 = 5614709;
            this.unlockableFeatures.Add(key:  -1146455072, value:  5614709);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) != 0)
        {
                GameEcon val_22 = App.getGameEcon;
            if(786450 >= 1)
        {
                GameEcon val_23 = App.getGameEcon;
            val_32 = 786450;
            this.unlockableFeatures.Add(key:  -1146450880, value:  786450);
        }
        
        }
        
        GameBehavior val_24 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2102212592) != 0)
        {
                GameEcon val_27 = App.getGameEcon;
            val_32 = 1179681;
            this.unlockableFeatures.Add(key:  -2100063088, value:  1179681);
        }
        
        }
        
        if(this.unlockableFeatures.Count < 1)
        {
                return;
        }
        
        val_34 = null;
        val_34 = null;
        val_32 = WGTaskController.<>c.<>9__12_0;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(object:  WGTaskController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3148528800));
            WGTaskController.<>c.<>9__12_0 = val_32;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int32> val_30 = MoreLinq.MaxBy<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(source:  -1146424496, selector:  this.unlockableFeatures);
        this.highestLevelRequiredTask = val_31;
    }
    public WGTaskController()
    {
    
    }

}
