using UnityEngine;
public class FPHGameplayState
{
    // Fields
    private FPHLevelObject <levelData>k__BackingField;
    private int <levelIndex>k__BackingField;
    private int <removesUsed>k__BackingField;
    public System.Collections.Generic.List<char> lettersPowerupRemoved;
    public int starsEarned;
    private int <hintsUsed>k__BackingField;
    private int <tokensRemaining>k__BackingField;
    public int eventReward;
    public int retryAttempts;
    private System.Collections.Generic.List<object> tokenTransactionsMade;
    private System.Collections.Generic.List<object> gemTransactionsMade;
    public System.Collections.Generic.List<char> lettersPurchased;
    public char currentTutorialLetter;
    public int trackingLevel;
    public System.Collections.Generic.Dictionary<string, object> associatedEvents;
    public int consonantsPurchased;
    public int vowelsPurchased;
    public System.Collections.Generic.List<FPHLetterSlotState> phraseSlotState;
    public System.Collections.Generic.List<char> phraseSlotDisplayValue;
    public string phraseSlotCorrectValue;
    private string _phraseSlotCorrectValueNormalizedNotSerialized;
    public FPHChestType chestType;
    public int rewardMultiplier;
    public bool hasCollectedChest;
    
    // Properties
    public FPHLevelObject levelData { get; set; }
    public int levelIndex { get; set; }
    public int removesUsed { get; set; }
    public int hintsUsed { get; set; }
    public int tokensRemaining { get; set; }
    public string phraseSlotCorrectValueNormalized { get; }
    
    // Methods
    public FPHLevelObject get_levelData()
    {
    
    }
    public void set_levelData(FPHLevelObject value)
    {
        this.<levelData>k__BackingField = value;
    }
    public int get_levelIndex()
    {
        return (int)this.<levelIndex>k__BackingField;
    }
    public void set_levelIndex(int value)
    {
        this.<levelIndex>k__BackingField = value;
    }
    public int get_removesUsed()
    {
        return (int)this.<removesUsed>k__BackingField;
    }
    public void set_removesUsed(int value)
    {
        this.<removesUsed>k__BackingField = value;
    }
    public int get_hintsUsed()
    {
        return (int)this.<hintsUsed>k__BackingField;
    }
    public void set_hintsUsed(int value)
    {
        this.<hintsUsed>k__BackingField = value;
    }
    public int get_tokensRemaining()
    {
        return (int)this.<tokensRemaining>k__BackingField;
    }
    public void set_tokensRemaining(int value)
    {
        this.<tokensRemaining>k__BackingField = value;
    }
    public string get_phraseSlotCorrectValueNormalized()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this._phraseSlotCorrectValueNormalizedNotSerialized);
        if(val_1 == false)
        {
                return;
        }
        
        string val_2 = val_1.RemoveDiacritics(s:  this.phraseSlotCorrectValue);
        this._phraseSlotCorrectValueNormalizedNotSerialized = val_1;
        string val_3 = val_1.ReplaceSpecialCharacters(s:  val_1);
        this._phraseSlotCorrectValueNormalizedNotSerialized = val_1;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this._phraseSlotCorrectValueNormalizedNotSerialized;
        UnityEngine.Debug.LogErrorFormat(format:  -1640873200, args:  472754880);
    }
    private string RemoveDiacritics(string s)
    {
        var val_6;
        System.Text.StringBuilder val_1 = null;
        val_6 = 0;
        val_1 = new System.Text.StringBuilder();
        string val_2 = s.Normalize(normalizationForm:  2);
        goto label_2;
        label_8:
        char val_3 = s.Chars[0];
        System.Globalization.UnicodeCategory val_4 = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch:  val_3);
        if(val_3 != '')
        {
                System.Text.StringBuilder val_5 = Append(value:  val_3);
        }
        
        val_6 = 1;
        label_2:
        int val_6 = s.m_stringLength;
        val_6 = val_6 - 1;
        if(val_6 <= val_6)
        {
            goto label_8;
        }
        
        if(val_1 == 0)
        {
            
        }
    
    }
    private string ReplaceSpecialCharacters(string s)
    {
        if(s != null)
        {
                return s.Replace(oldValue:  -1640616240, newValue:  -1640616320);
        }
        
        return s.Replace(oldValue:  -1640616240, newValue:  -1640616320);
    }
    public string GetCurrentDisplayString()
    {
        var val_3;
        System.Text.StringBuilder val_1 = null;
        val_3 = 0;
        val_1 = new System.Text.StringBuilder();
        goto label_1;
        label_6:
        if(val_1 <= val_3)
        {
                char val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 16;
        System.Text.StringBuilder val_2 = Append(value:  val_3);
        val_3 = 1;
        label_1:
        if(val_3 < val_1)
        {
            goto label_6;
        }
        
        if(val_1 == 0)
        {
            
        }
    
    }
    public bool IsCurrentDisplayCorrectAnswer()
    {
        string val_1 = this.GetCurrentDisplayString();
        return System.String.op_Equality(a:  -1640343584, b:  this.phraseSlotCorrectValue);
    }
    public int GetTotalCoinReward()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return (int)this.<tokensRemaining>k__BackingField;
        }
        
        return (int)this.<tokensRemaining>k__BackingField;
    }
    public int GetTotalStarReward()
    {
        return (int)this.rewardMultiplier;
    }
    public static bool Deserialize(string dataString, ref FPHGameplayState stateToLoad)
    {
        char val_16;
        string val_83;
        var val_84;
        WordPets.WordPetType val_85;
        object val_1 = MiniJSON.Json.Deserialize(json:  dataString);
        val_83 = dataString;
        if(dataString != null)
        {
            
        }
        else
        {
                object val_2 = MiniJSON.Json.Deserialize(json:  val_83);
            if(val_83 != null)
        {
                val_83 = val_83;
        }
        
            UnityEngine.Debug.LogError(message:  -1640019376);
            return false;
        }
        
        if((val_83.ContainsKey(key:  -1640019264)) == false)
        {
                return false;
        }
        
        string val_4 = val_83.Item[-1640019264];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_5 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640019184)) == false)
        {
                return false;
        }
        
        string val_8 = val_83.Item[-1640019184];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_9 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640019104)) == false)
        {
                return false;
        }
        
        string val_12 = val_83.Item[-1640019104];
        if((val_83 == null) || (stateToLoad == 0))
        {
            goto label_20;
        }
        
        System.Collections.Generic.List<System.Char> val_13 = new System.Collections.Generic.List<System.Char>();
        lettersPowerupRemoved = null;
        List.Enumerator<T> val_14 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_21;
        }
        
        stateToLoad.lettersPowerupRemoved.Add(item:  val_16);
        goto label_27;
        label_21:
        Dispose();
        label_20:
        if((val_83.ContainsKey(key:  -1640019008)) == false)
        {
                return false;
        }
        
        string val_18 = val_83.Item[-1640019008];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_19 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018928)) == false)
        {
                return false;
        }
        
        string val_22 = val_83.Item[-1640018928];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_23 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018848)) == false)
        {
                return false;
        }
        
        string val_26 = val_83.Item[-1640018848];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_27 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018768)) == false)
        {
                return false;
        }
        
        string val_30 = val_83.Item[-1640018768];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_31 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018672)) == false)
        {
                return false;
        }
        
        string val_34 = val_83.Item[-1640018672];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_35 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018592)) == false)
        {
                return false;
        }
        
        if(stateToLoad != 0)
        {
                string val_38 = val_83.Item[-1640018592];
            if(val_83 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_83 = 0;
        }
        
        }
        
            tokenTransactionsMade = val_83;
            if(stateToLoad.tokenTransactionsMade == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_39 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            tokenTransactionsMade = null;
        }
        
        }
        
        if((val_83.ContainsKey(key:  -1640018496)) == false)
        {
                return false;
        }
        
        if(stateToLoad != 0)
        {
                string val_41 = val_83.Item[-1640018496];
            if(val_83 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_83 = 0;
        }
        
        }
        
            gemTransactionsMade = val_83;
            if(stateToLoad.gemTransactionsMade == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_42 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            gemTransactionsMade = null;
        }
        
        }
        
        if((val_83.ContainsKey(key:  -1640018416)) == false)
        {
                return false;
        }
        
        if(stateToLoad == 0)
        {
            goto label_63;
        }
        
        string val_44 = val_83.Item[-1640018416];
        if(val_83 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_83 = 0;
        }
        
        }
        
        System.Collections.Generic.List<System.Char> val_45 = new System.Collections.Generic.List<System.Char>();
        lettersPurchased = null;
        if((val_83 == 0) || (0 < 1))
        {
            goto label_63;
        }
        
        List.Enumerator<T> val_46 = GetEnumerator();
        label_70:
        if(MoveNext() == false)
        {
            goto label_64;
        }
        
        stateToLoad.lettersPurchased.Add(item:  System.Char.Parse(s:  val_16));
        goto label_70;
        label_64:
        Dispose();
        label_63:
        if((val_83.ContainsKey(key:  -1640018320)) == false)
        {
                return false;
        }
        
        string val_50 = val_83.Item[-1640018320];
        if((System.Char.TryParse(s:  val_83, result: out  char val_51 = '羒')) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018224)) == false)
        {
                return false;
        }
        
        string val_54 = val_83.Item[-1640018224];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_55 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018144)) == false)
        {
                return false;
        }
        
        string val_58 = val_83.Item[-1640018144];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_59 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018048)) == false)
        {
                return false;
        }
        
        string val_62 = val_83.Item[-1640018048];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_63 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640018048)) == false)
        {
                return false;
        }
        
        string val_66 = val_83.Item[-1640018048];
        if((System.Int32.TryParse(s:  val_83, result: out  int val_67 = -1640005740)) == false)
        {
                return false;
        }
        
        if((val_83.ContainsKey(key:  -1640017952)) == false)
        {
                return false;
        }
        
        if(stateToLoad != 0)
        {
                string val_70 = val_83.Item[-1640017952];
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_71 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        
        label_120:
        if((val_83.ContainsKey(key:  -1640017872)) == false)
        {
                return false;
        }
        
        if(stateToLoad == 0)
        {
            goto label_99;
        }
        
        string val_73 = val_83.Item[-1640017872];
        val_84 = 0;
        if(val_83 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_83 = 0;
        }
        
            val_84 = val_83;
        }
        
        System.Collections.Generic.List<System.Char> val_74 = new System.Collections.Generic.List<System.Char>();
        phraseSlotDisplayValue = null;
        if((val_84 == 0) || (0 < 1))
        {
            goto label_99;
        }
        
        List.Enumerator<T> val_75 = GetEnumerator();
        label_106:
        if(MoveNext() == false)
        {
            goto label_100;
        }
        
        stateToLoad.phraseSlotDisplayValue.Add(item:  System.Char.Parse(s:  val_16));
        goto label_106;
        label_100:
        Dispose();
        if(0 == 1)
        {
                return false;
        }
        
        if(1349 != 1349)
        {
                return false;
        }
        
        label_99:
        if((val_83.ContainsKey(key:  -1640017776)) == false)
        {
                return false;
        }
        
        if(stateToLoad == 0)
        {
                return false;
        }
        
        string val_79 = val_83.Item[-1640017776];
        phraseSlotCorrectValue = val_83;
        return false;
        label_118:
        if(MoveNext() == false)
        {
            goto label_113;
        }
        
        val_85 = 0;
        Add(item:  null);
        goto label_118;
        label_113:
        Dispose();
        phraseSlotState = ;
        goto label_120;
    }
    public string Serialize()
    {
        int val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1640019264, value:  13152256);
        Add(key:  -1640019184, value:  13152256);
        Add(key:  -1640019104, value:  this.lettersPowerupRemoved);
        Add(key:  -1640019008, value:  13152256);
        Add(key:  -1640018928, value:  13152256);
        Add(key:  -1640018848, value:  13152256);
        Add(key:  -1640018768, value:  13152256);
        Add(key:  -1640018672, value:  13152256);
        Add(key:  -1640018592, value:  this.tokenTransactionsMade);
        Add(key:  -1640018496, value:  this.gemTransactionsMade);
        Add(key:  -1640018416, value:  this.lettersPurchased);
        Add(key:  -1640018320, value:  9158656);
        Add(key:  -1640018224, value:  13152256);
        Add(key:  -1640018144, value:  13152256);
        Add(key:  -1640018048, value:  13152256);
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_19:
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        Add(item:  val_5);
        goto label_19;
        label_17:
        Dispose();
        Add(key:  -1640017952, value:  80883712);
        Add(key:  -1640017872, value:  this.phraseSlotDisplayValue);
        Add(key:  -1640017776, value:  this.phraseSlotCorrectValue);
        string val_6 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public FPHGameplayState()
    {
        this.lettersPowerupRemoved = new System.Collections.Generic.List<System.Char>();
        this.tokenTransactionsMade = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.gemTransactionsMade = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.currentTutorialLetter = 32;
        this.lettersPurchased = new System.Collections.Generic.List<System.Char>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.associatedEvents = null;
        System.Collections.Generic.List<WordPets.WordPetType> val_6 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.phraseSlotState = null;
        this.rewardMultiplier = 1;
        this.phraseSlotDisplayValue = new System.Collections.Generic.List<System.Char>();
    }

}
