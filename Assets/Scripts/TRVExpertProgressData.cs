using UnityEngine;
public class TRVExpertProgressData
{
    // Fields
    private string <name>k__BackingField;
    private int <cardsOwned>k__BackingField;
    private System.DateTime <lastHelpUsed>k__BackingField;
    private System.Collections.Generic.List<TRVCategoryProficiencies> <proficiencies>k__BackingField;
    private bool <unlocked>k__BackingField;
    
    // Properties
    public string name { get; set; }
    public int cardsOwned { get; set; }
    public System.DateTime lastHelpUsed { get; set; }
    public System.Collections.Generic.List<TRVCategoryProficiencies> proficiencies { get; set; }
    public bool unlocked { get; set; }
    public int level { get; }
    public int maxLevel { get; }
    
    // Methods
    public string get_name()
    {
    
    }
    private void set_name(string value)
    {
        this.<name>k__BackingField = value;
    }
    public int get_cardsOwned()
    {
        return (int)this.<cardsOwned>k__BackingField;
    }
    public void set_cardsOwned(int value)
    {
        this.<cardsOwned>k__BackingField = value;
    }
    public System.DateTime get_lastHelpUsed()
    {
        this = R1 + 16;
        return new System.DateTime() {dateData = 1152921512592654352};
    }
    public void set_lastHelpUsed(System.DateTime value)
    {
        this.<lastHelpUsed>k__BackingField = new System.DateTime();
        mem[1152921512592766372] = R3;
    }
    public System.Collections.Generic.List<TRVCategoryProficiencies> get_proficiencies()
    {
    
    }
    private void set_proficiencies(System.Collections.Generic.List<TRVCategoryProficiencies> value)
    {
        this.<proficiencies>k__BackingField = value;
    }
    public bool get_unlocked()
    {
        return (bool)this.<unlocked>k__BackingField;
    }
    private void set_unlocked(bool value)
    {
        this.<unlocked>k__BackingField = value;
    }
    public int get_level()
    {
        var val_4;
        if( == 0)
        {
                val_4 = 0;
            UnityEngine.Debug.LogError(message:  -603458736);
            return (int)val_4;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        val_4 = 0;
        goto label_5;
        label_7:
        val_4 = (val_2 + 20) + val_4;
        label_5:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        Dispose();
        return (int)val_4;
    }
    public int get_maxLevel()
    {
        var val_4;
        if( == 0)
        {
                val_4 = 0;
            UnityEngine.Debug.LogError(message:  -603458736);
            return (int)val_4;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        val_4 = 0;
        goto label_5;
        label_7:
        val_4 = (val_2 + 16) + val_4;
        label_5:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        Dispose();
        return (int)val_4;
    }
    public void SetupNewExpert(TRVExpert me, bool autoUnlock = False)
    {
        var val_3;
        var val_5;
        var val_7;
        this.<name>k__BackingField = me.expertName;
        val_5 = null;
        val_5 = null;
        this.<lastHelpUsed>k__BackingField = System.DateTime.MinValue;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<proficiencies>k__BackingField = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        goto label_5;
        label_8:
        if(val_3 != 0)
        {
                val_7 = mem[val_3 + 12];
            val_7 = val_3 + 12;
        }
        else
        {
                val_7 = 0;
        }
        
        mem2[0] = val_7;
        label_5:
        if(MoveNext() == true)
        {
            goto label_8;
        }
        
        Dispose();
        this.<proficiencies>k__BackingField.AddRange(collection:  me.myProfs);
        this.<unlocked>k__BackingField = autoUnlock;
    }
    public void UpgradeExpert()
    {
        var val_6;
        var val_7;
        System.Func<TRVCategoryProficiencies, System.Boolean> val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_6 = this;
        if((this.<unlocked>k__BackingField) == false)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_7 = null;
        val_7 = null;
        val_9 = TRVExpertProgressData.<>c.<>9__25_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVExpertProgressData.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3691906192));
            TRVExpertProgressData.<>c.<>9__25_0 = val_9;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  this.<proficiencies>k__BackingField, predicate:  7720960);
        if(null == 0)
        {
            goto label_7;
        }
        
        AddRange(collection:  this.<proficiencies>k__BackingField);
        val_10 = null;
        val_11 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        goto label_8;
        label_1:
        val_12 = (this.<cardsOwned>k__BackingField) - 1;
        this.<unlocked>k__BackingField = true;
        goto label_9;
        label_7:
        AddRange(collection:  this.<proficiencies>k__BackingField);
        val_10 = 12;
        val_11 = UnityEngine.Random.Range(min:  0, max:  0);
        label_8:
        if(val_10 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16];
        val_6 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16;
        if(val_6 != 0)
        {
                val_13 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16 + 20];
            val_13 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16 + 20;
        }
        else
        {
                val_6 = 20;
            val_13 = 1;
        }
        
        val_12 = 2;
        label_9:
        mem[20] = val_12;
    }
    public bool AdviceAvailable()
    {
        ulong val_2;
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512593850560}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_9 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getExpertCooldown;
        val_9 = val_9 * 3600;
        if((public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C) < 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void Deserialize(object incData)
    {
        string val_21;
        string val_25;
        string val_28;
        val_25 = incData;
        object val_1 = MiniJSON.Json.Deserialize(json:  val_25);
        if(val_25 != 0)
        {
                val_25 = val_25;
        }
        
        UnityEngine.Debug.LogError(message:  -602826864);
        return;
        label_35:
        if(MoveNext() == false)
        {
            goto label_28;
        }
        
        val_28 = 0;
        if(val_21 != 0)
        {
                if(val_21 != null)
        {
            
        }
        else
        {
                val_28 = val_21;
        }
        
        }
        
        TRVCategoryProficiencies val_22 = new TRVCategoryProficiencies();
        if((Deserialize(data:  val_28)) == false)
        {
            goto label_35;
        }
        
        this.<proficiencies>k__BackingField.Add(item:  351862784);
        goto label_35;
        label_28:
        Dispose();
    }
    public string Serialize()
    {
        twelvegigs.sweepstakes.Distribution val_6;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1386027600, value:  this.<name>k__BackingField);
        Add(key:  -1649936592, value:  8945664);
        Add(key:  -602826656, value:  13152256);
        string val_2 = this.<lastHelpUsed>k__BackingField.ToString();
        Add(key:  -602826736, value:  -602682064);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_4 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        string val_7 = val_6.Serialize();
        Add(item:  val_6);
        goto label_9;
        label_6:
        Dispose();
        Add(key:  -602826576, value:  80883712);
        string val_8 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public TRVExpertProgressData()
    {
    
    }

}
