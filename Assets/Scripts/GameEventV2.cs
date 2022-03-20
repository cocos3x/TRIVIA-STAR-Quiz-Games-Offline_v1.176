using UnityEngine;
public class GameEventV2
{
    // Fields
    public int serverTimestamp;
    public System.DateTime lastTimestamp;
    public System.DateTime timeStart;
    public System.DateTime timeEnd;
    public System.DateTime timeExpire;
    public int id;
    public string name;
    public string type;
    public bool masterEnable;
    public bool isDownloaded;
    private bool <inExpireInterval>k__BackingField;
    private string dlcJson;
    public string eventDataJson;
    public System.Collections.Generic.Dictionary<string, object> eventData;
    public int minPlayerLevel;
    public UnityEngine.AssetBundle downloadedBundle;
    
    // Properties
    public bool inExpireInterval { get; set; }
    
    // Methods
    public bool get_inExpireInterval()
    {
        return (bool)this.<inExpireInterval>k__BackingField;
    }
    private void set_inExpireInterval(bool value)
    {
        this.<inExpireInterval>k__BackingField = value;
    }
    public void init(System.Collections.IDictionary desc)
    {
        System.DateTime val_6;
        System.DateTime val_11;
        var val_17;
        var val_18;
        string val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_17 = 0;
        val_17 = val_17 + 1;
        val_18 = desc;
        val_19 = desc;
        this.id = System.Int32.Parse(s:  val_19);
        this.update(data:  desc);
        val_17 = 0;
        val_17 = val_17 + 1;
        val_20 = desc;
        if(desc == 0)
        {
                System.DateTime val_4 = DateTimeCheat.UtcNow;
            this.timeStart = val_6;
        }
        
        val_17 = 0;
        val_17 = val_17 + 1;
        val_21 = desc;
        if(desc == 0)
        {
                System.DateTime val_8 = DateTimeCheat.UtcNow;
            System.DateTime val_9 = AddDays(value:  null);
            this.timeEnd = val_11;
        }
        
        val_17 = 0;
        val_17 = val_17 + 1;
        val_22 = desc;
        if(desc == 0)
        {
                desc = this.timeEnd;
            this.timeExpire = desc;
        }
        
        val_17 = 0;
        val_17 = val_17 + 1;
        val_23 = desc;
        if(desc == 0)
        {
                desc = true;
            this.masterEnable = desc;
        }
        
        val_24 = "data";
        var val_17 = 0;
        val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = (uint)val_17 & 65535;
        val_25 = desc;
        if(desc != 0)
        {
                val_24 = "data";
            val_17 = 0;
            val_17 = val_17 + 1;
            val_26 = desc;
            if(desc != 0)
        {
                val_27 = 0;
            object val_16 = MiniJSON.Json.Deserialize(json:  mem[1152921511810537060]);
            if(mem[1152921511810537060] != 0)
        {
                val_17 = mem[mem[1152921511810537060] + 180];
            val_17 = mem[1152921511810537060] + 180;
            if(((mem[1152921511810537060] + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                mem[1152921511810537060] = 0;
        }
        
            val_27 = mem[1152921511810537060];
        }
        
            mem[1152921511810537064] = val_27;
        }
        
        }
        
        this.CheckDownloadDLC();
    }
    public void update(System.Collections.IDictionary data)
    {
        System.DateTime val_4;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
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
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_2 = ServerTime;
        this.lastTimestamp = val_4;
        var val_38 = 0;
        val_38 = val_38 + 1;
        val_38 = data;
        if(data != 0)
        {
                var val_39 = 0;
            val_39 = val_39 + 1;
            val_39 = data;
            mem[1152921511810657384] = System.Int32.Parse(s:  data);
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        val_40 = data;
        if(data != 0)
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_41 = data;
            int val_10 = System.Int32.Parse(s:  data);
            System.DateTime val_11 = AddSeconds(value:  null);
            mem[1152921511810657400] = val_4;
        }
        
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_42 = data;
        if(data != 0)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            val_43 = data;
            int val_14 = System.Int32.Parse(s:  data);
            System.DateTime val_15 = AddSeconds(value:  null);
            mem[1152921511810657408] = val_4;
        }
        
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_44 = data;
        if(data != 0)
        {
                var val_45 = 0;
            val_45 = val_45 + 1;
            val_45 = data;
            int val_18 = System.Int32.Parse(s:  data);
            System.DateTime val_19 = AddSeconds(value:  null);
            mem[1152921511810657416] = val_4;
        }
        
        var val_46 = 0;
        val_46 = val_46 + 1;
        val_46 = data;
        if(data != 0)
        {
                var val_47 = 0;
            val_47 = val_47 + 1;
            val_47 = data;
            mem[1152921511810657432] = data;
        }
        
        var val_48 = 0;
        val_48 = val_48 + 1;
        val_48 = data;
        if(data != 0)
        {
                var val_49 = 0;
            val_49 = val_49 + 1;
            val_49 = data;
            mem[1152921511810657428] = data;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        val_50 = data;
        if(data != 0)
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_51 = data;
            mem[1152921511810657436] = System.Boolean.Parse(value:  data);
        }
        
        var val_52 = 0;
        val_52 = val_52 + 1;
        val_52 = data;
        if(data != 0)
        {
                var val_53 = 0;
            val_53 = val_53 + 1;
            val_53 = data;
            if(data != 0)
        {
                var val_54 = 0;
            val_54 = val_54 + 1;
            val_54 = data;
            mem[1152921511810657440] = data;
        }
        
        }
        
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_55 = data;
        if(data != 0)
        {
                var val_56 = 0;
            val_56 = val_56 + 1;
            val_56 = data;
            mem[1152921511810657438] = System.Boolean.Parse(value:  data);
        }
        
        var val_57 = 0;
        val_57 = val_57 + 1;
        val_57 = data;
        if(data != 0)
        {
                var val_58 = 0;
            val_58 = val_58 + 1;
            val_58 = data;
            if(data != 0)
        {
                var val_59 = 0;
            val_59 = val_59 + 1;
            val_59 = data;
            mem[1152921511810657444] = data;
            val_60 = 0;
            object val_36 = MiniJSON.Json.Deserialize(json:  data);
            if(data != 0)
        {
                if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_60 = data;
        }
        
            mem[1152921511810657448] = val_60;
        }
        
        }
        
        var val_60 = 0;
        val_61 = 0;
        val_60 = val_60 + 1;
        val_62 = data;
        if(data != 0)
        {
                var val_61 = 0;
            val_61 = val_61 + 1;
        }
    
    }
    public System.Collections.Generic.Dictionary<string, object> Serialize()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1386032096, value:  13152256);
        string val_2 = this.lastTimestamp.ToString();
        Add(key:  -1386032016, value:  this.lastTimestamp);
        string val_3 = this.timeStart.ToString();
        Add(key:  -1386031936, value:  this.timeStart);
        string val_4 = this.timeEnd.ToString();
        Add(key:  -1386031856, value:  this.timeEnd);
        string val_5 = this.timeExpire.ToString();
        Add(key:  -1386031776, value:  this.timeExpire);
        Add(key:  1624646480, value:  13152256);
        Add(key:  -1386027600, value:  this.name);
        Add(key:  1383185776, value:  this.type);
        string val_6 = this.masterEnable.ToString();
        Add(key:  1657996528, value:  this.masterEnable);
        Add(key:  -1386148384, value:  this.dlcJson);
        Add(key:  -1386015232, value:  this.eventDataJson);
        Add(key:  -1386015152, value:  13152256);
    }
    public void Deserialize(System.Collections.IDictionary data)
    {
        var val_8;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
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
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_33 = data;
        if(data != 0)
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            val_34 = data;
            mem[1152921511810922984] = System.Int32.Parse(s:  data);
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_35 = data;
        if(data != 0)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            val_36 = data;
            System.DateTime val_6 = System.DateTime.Parse(s:  -1385870640);
            mem[1152921511810922992] = val_8;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_37 = data;
        if(data != 0)
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_38 = data;
            System.DateTime val_11 = System.DateTime.Parse(s:  -1385870640);
            mem[1152921511810923000] = val_8;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_39 = data;
        if(data != 0)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_40 = data;
            System.DateTime val_14 = System.DateTime.Parse(s:  -1385870640);
            mem[1152921511810923008] = val_8;
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_41 = data;
        if(data != 0)
        {
                var val_42 = 0;
            val_42 = val_42 + 1;
            val_42 = data;
            System.DateTime val_17 = System.DateTime.Parse(s:  -1385870640);
            mem[1152921511810923016] = val_8;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_43 = data;
        if(data != 0)
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_44 = data;
            mem[1152921511810923024] = System.Int32.Parse(s:  data);
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        val_45 = data;
        if(data != 0)
        {
                var val_46 = 0;
            val_46 = val_46 + 1;
            val_46 = data;
            mem[1152921511810923028] = data;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        val_47 = data;
        if(data != 0)
        {
                var val_48 = 0;
            val_48 = val_48 + 1;
            val_48 = data;
            mem[1152921511810923032] = data;
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        val_49 = data;
        if(data != 0)
        {
                var val_50 = 0;
            val_50 = val_50 + 1;
            val_50 = data;
            mem[1152921511810923036] = System.Boolean.Parse(value:  data);
        }
        
        var val_51 = 0;
        val_51 = val_51 + 1;
        val_51 = data;
        if(data != 0)
        {
                var val_52 = 0;
            val_52 = val_52 + 1;
            val_52 = data;
            mem[1152921511810923040] = data;
        }
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        val_53 = data;
        if(data != 0)
        {
                var val_54 = 0;
            val_54 = val_54 + 1;
            val_54 = data;
            mem[1152921511810923044] = data;
        }
        
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_55 = data;
        if(data != 0)
        {
                var val_56 = 0;
            val_56 = val_56 + 1;
        }
    
    }
    public GameEventV2.Phase GetPhase()
    {
        var val_13 = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((this.timeStart.CompareTo(value:  new System.DateTime())) > 0)
        {
                return;
        }
        
        val_13 = 0;
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        if((this.timeEnd.CompareTo(value:  new System.DateTime())) > 0)
        {
                return;
        }
        
        val_13 = 0;
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        if((this.timeEnd.CompareTo(value:  new System.DateTime())) <= 1)
        {
            goto label_9;
        }
        
        label_15:
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        int val_10 = this.timeExpire.CompareTo(value:  new System.DateTime());
        val_10 = 4 & (val_10 >> 29);
        return;
        label_9:
        System.DateTime val_11 = DateTimeCheat.UtcNow;
        if((this.timeExpire.CompareTo(value:  new System.DateTime())) <= 0)
        {
            goto label_15;
        }
    
    }
    private void CheckDownloadDLC()
    {
        if((System.String.IsNullOrEmpty(value:  this.dlcJson)) != false)
        {
                this.isDownloaded = true;
            return;
        }
        
        if(this.isDownloaded == true)
        {
                return;
        }
        
        mem2[0] = 0;
        UnityEngine.Debug.LogError(message:  -1385650400);
    }
    public void OnDownloaded(UnityEngine.AssetBundle downloadedAssetBundle)
    {
        this.isDownloaded = true;
        this.downloadedBundle = downloadedAssetBundle;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1385530016);
    }
    public GameEventV2()
    {
        this.name = "";
        this.type = "";
        this.dlcJson = "";
        this.eventDataJson = "";
    }

}
