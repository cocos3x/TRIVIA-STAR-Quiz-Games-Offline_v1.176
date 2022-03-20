using UnityEngine;
public class SeasonPassProgression : EventProgression
{
    // Fields
    private const string SeasonPassPrefKey = "SEASON_PASS_PROGRESSION";
    public int currentEventId;
    public int initLevel;
    public int currentTier;
    public bool hasPass;
    public System.Collections.Generic.List<int> freeAwardsCollected;
    public System.Collections.Generic.List<int> passAwardsCollected;
    
    // Properties
    public int CurrentChestTier { get; }
    
    // Methods
    public int get_CurrentChestTier()
    {
        int val_1 = UnityEngine.Mathf.Max(a:  0, b:  this.currentTier);
        val_1 = (val_1 >> 2) + (val_1 >> 31);
        return UnityEngine.Mathf.Min(a:  2, b:  UnityEngine.Mathf.FloorToInt(f:  (float)val_1));
    }
    public void InitEvent(int eventId, int playerLevel)
    {
        this.currentEventId = eventId;
        this.initLevel = playerLevel;
        this.hasPass = false;
        this.freeAwardsCollected.Clear();
        this.passAwardsCollected.Clear();
    }
    public override void LoadFromJSON()
    {
        var val_21;
        System.Collections.Generic.List<System.Int32> val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_21 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1044383024)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1044383024, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1044383024);
        if("SEASON_PASS_PROGRESSION" != 0)
        {
                if(null != null)
        {
                "SEASON_PASS_PROGRESSION" = 0;
        }
        
            val_21 = "SEASON_PASS_PROGRESSION";
        }
        
        string val_4 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
        UnityEngine.Debug.Log(message:  0);
        string val_5 = val_21.Item[-1044382896];
        bool val_7 = System.Int32.TryParse(s:  null, result: out  this.currentEventId);
        string val_8 = val_21.Item[-1044382800];
        bool val_10 = System.Int32.TryParse(s:  null, result: out  this.initLevel);
        string val_11 = val_21.Item[-1044382704];
        bool val_13 = System.Int32.TryParse(s:  null, result: out  this.currentTier);
        string val_14 = val_21.Item[-1044382608];
        val_22 = val_21;
        val_23 = 0;
        bool val_16 = System.Boolean.TryParse(value:  null, result: out  this.hasPass);
        string val_17 = val_21.Item[-1044382512];
        if(val_21 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_21 = 0;
        }
        
            val_23 = val_21;
        }
        
        val_24 = 0;
        goto label_21;
        label_26:
        val_22 = this.freeAwardsCollected;
        if(val_21 <= val_24)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = 0;
        val_21 = val_21 + 0;
        val_22.Add(item:  System.Int32.Parse(s:  (0 + 0) + 16));
        val_24 = 1;
        label_21:
        if(val_24 < 0)
        {
            goto label_26;
        }
        
        string val_19 = val_21.Item[-1044378320];
        val_25 = 0;
        val_26 = 0;
        if(val_21 == 0)
        {
            goto label_30;
        }
        
        val_26 = 0;
        val_22 = mem[1179403827];
        if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_21 = 0;
        }
        
        val_26 = val_21;
        goto label_30;
        label_35:
        if(val_21 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = 0;
        val_22 = val_22 + 0;
        val_22 = System.Int32.Parse(s:  (0 + 0) + 16);
        this.passAwardsCollected.Add(item:  val_22);
        val_25 = 1;
        label_30:
        if(val_25 < 0)
        {
            goto label_35;
        }
    
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1044382896, value:  13152256);
        Add(key:  -1044382800, value:  13152256);
        Add(key:  -1044382704, value:  13152256);
        Add(key:  -1044382608, value:  8945664);
        Add(key:  -1044382512, value:  this.freeAwardsCollected);
        Add(key:  -1044378320, value:  this.passAwardsCollected);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1044383024, value:  78753792);
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -1044383024);
    }
    public long EncodeProgression(bool pass)
    {
        int val_4;
        if(pass == true)
        {
                24 = 28;
        }
        
        System.Collections.BitArray val_1 = new System.Collections.BitArray(length:  31, defaultValue:  false);
        List.Enumerator<T> val_2 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 > 30)
        {
            goto label_5;
        }
        
        set_Item(index:  val_4, value:  true);
        goto label_5;
        label_2:
        Dispose();
        CopyTo(array:  475101376, index:  0);
        return (long)System.BitConverter.ToInt64(value:  475101376, startIndex:  0);
    }
    public void DecodeProgression(bool pass, string progression)
    {
        bool val_2 = System.Int64.TryParse(s:  progression, result: out  long val_1 = 3251090168);
        long val_3 = this.EncodeProgression(pass:  pass);
        val_3 = 0 - val_3;
        UnityEngine.Debug.LogError(message:  -1043889264);
    }
    public SeasonPassProgression()
    {
        this.freeAwardsCollected = new System.Collections.Generic.List<System.Int32>();
        this.passAwardsCollected = new System.Collections.Generic.List<System.Int32>();
    }

}
