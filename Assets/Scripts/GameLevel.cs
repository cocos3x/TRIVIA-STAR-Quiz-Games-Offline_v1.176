using UnityEngine;
[Serializable]
public class GameLevel
{
    // Fields
    public System.Collections.Generic.List<string> levelProgress;
    public int playerLevel;
    public bool isChallengingLevel;
    public int goldenApplesExtraDifficulty;
    public int goldenApplesStreaks;
    public int goldenApplesStreaksSubBonus;
    public int goldenApplesExtraWords;
    public int goldenApplesExtraWordsSubBonus;
    public int highestWordStreak;
    public bool completed;
    public string word;
    public string answers;
    public string extraWords;
    private string lvlName;
    public int levelIndex;
    public string language;
    public int actualWordCount;
    public string coords;
    public string gridSize;
    public string availExtraReq;
    public int extraWordsNeeded;
    public string extraRequiredWords;
    public System.Collections.Generic.List<string> commonW;
    public System.Collections.Generic.List<string> uncommonW;
    public System.Collections.Generic.List<string> rareW;
    public System.Collections.Generic.List<string> rwdBase;
    public System.Collections.Generic.List<string> rwdExp1;
    public System.Collections.Generic.List<string> rwdExp2;
    public System.Collections.Generic.List<string> rwdExp3;
    public System.Collections.Generic.List<string> rwdExp4;
    public string challengeWord;
    public float avgCompletionTime;
    
    // Properties
    public string levelName { get; set; }
    
    // Methods
    public System.Collections.Generic.List<string> GetLevelProgress()
    {
        System.Collections.Generic.IEnumerable<TSource> val_1 = System.Linq.Enumerable.Skip<System.Object>(source:  this.levelProgress, count:  1);
        return System.Linq.Enumerable.ToList<System.Object>(source:  this.levelProgress);
    }
    public string get_levelName()
    {
    
    }
    public void set_levelName(string value)
    {
        this.lvlName = value;
        if((System.String.IsNullOrEmpty(value:  value)) == true)
        {
                return;
        }
        
        bool val_3 = System.Int32.TryParse(s:  R4, result: out  R5 + 64);
    }
    private System.Collections.Generic.List<string> GetShuffledWords(string inputStr)
    {
        var val_8;
        var val_9;
        val_8 = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_9 = "";
        goto label_1;
        label_8:
        string val_3 = inputStr.Chars[0].ToString();
        if((System.String.op_Equality(a:  -2086346774, b:  -2100450224)) != false)
        {
                Add(item:  1098586544);
            val_9 = "";
        }
        else
        {
                string val_6 = inputStr.Chars[0].ToString();
            string val_7 = 1098586544 + -2086346774(-2086346774);
            val_9 = val_9;
            int val_8 = inputStr.m_stringLength;
            val_8 = val_8 - 1;
            if(val_8 == val_8)
        {
                Add(item:  1098586544);
        }
        
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < inputStr.m_stringLength)
        {
            goto label_8;
        }
        
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.word;
        typeof(System.Object[]).__il2cppRuntimeField_14 = this.answers;
        typeof(System.Object[]).__il2cppRuntimeField_18 = this.extraWords;
        typeof(System.Object[]).__il2cppRuntimeField_1C = this.lvlName;
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.coords;
        typeof(System.Object[]).__il2cppRuntimeField_24 = this.gridSize;
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.language;
        typeof(System.Object[]).__il2cppRuntimeField_2C = null;
        string val_1 = MiniJSON.Json.Serialize(obj:  this.levelProgress);
        typeof(System.Object[]).__il2cppRuntimeField_30 = this.levelProgress;
        typeof(System.Object[]).__il2cppRuntimeField_34 = null;
        typeof(System.Object[]).__il2cppRuntimeField_38 = null;
        int val_3 = this.goldenApplesExtraDifficulty;
        val_3 = this.goldenApplesExtraWords + val_3;
        val_3 = val_3 + this.goldenApplesStreaks;
        typeof(System.Object[]).__il2cppRuntimeField_3C = null;
        typeof(System.Object[]).__il2cppRuntimeField_40 = this.availExtraReq;
        typeof(System.Object[]).__il2cppRuntimeField_44 = null;
        string val_2 = System.String.Format(format:  -2086205776, args:  472754880);
    }
    public void SetupActualWords(int maxAnswersWordCount)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        string val_1 = this.answers.TrimEnd(trimChars:  478563824);
        this.answers = this.answers;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        string val_2 = this.extraWords.TrimEnd(trimChars:  478563824);
        this.extraWords = this.extraWords;
    }
    public void MoveExtraWordsToAllWords()
    {
        string val_1 = this.answers + -2100450224(-2100450224);
        this.answers = this.answers;
        string val_2 = this.answers + this.extraWords;
        this.answers = this.answers;
        this.extraWords = "";
    }
    public void WordRemovalWithUncommonWords(int maxCount = 24, int removePercent = 20, bool removePlurals = True, System.Collections.Generic.List<string> rareWords, System.Collections.Generic.List<string> uncommonWords)
    {
        string val_16;
        var val_49;
        int val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        goto label_1;
        label_6:
        if(this.word.Chars[0] != ('|'))
        {
                string val_3 = this.word.Chars[0].ToString();
            string val_4 = 1098586544 + -2085749702(-2085749702);
        }
        
        label_1:
        if(1 < this.word.m_stringLength)
        {
            goto label_6;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_5 = this.answers.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_6 = new System.Collections.Generic.List<ZooTile>(collection:  this.answers);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(this.extraWords != null)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_8 = this.extraWords.Split(separator:  478563824);
            AddRange(collection:  this.extraWords);
        }
        
        if(null != 0)
        {
            
        }
        
        int val_9 = 0 * removePercent;
        val_9 = (val_9 >> 5) + (val_9 >> 31);
        int val_51 = maxCount;
        val_51 = 0 - val_51;
        int val_11 = UnityEngine.Mathf.Max(a:  val_9, b:  val_51);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_12 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(new RandomSet() != 0)
        {
                typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            add(item:  2, weight:  null);
            add(item:  3, weight:  null);
            add(item:  4, weight:  null);
            add(item:  5, weight:  null);
            add(item:  6, weight:  null);
        }
        else
        {
                mem[8] = 1;
            add(item:  2, weight:  null);
            add(item:  3, weight:  null);
            add(item:  4, weight:  null);
            add(item:  5, weight:  null);
            add(item:  6, weight:  null);
        }
        
        add(item:  7, weight:  null);
        List.Enumerator<T> val_14 = GetEnumerator();
        label_29:
        if(MoveNext() == false)
        {
            goto label_21;
        }
        
        if((ContainsKey(key:  val_16 + 8)) == false)
        {
            goto label_24;
        }
        
        set_Item(key:  val_16 + 8, value:  (Item[val_16 + 8]) + 1);
        goto label_29;
        label_24:
        Add(key:  val_16 + 8, value:  1);
        goto label_29;
        label_21:
        Dispose();
        val_49 = 1152921511111016832;
        val_50 = val_11;
        val_51 = 1152921511111015808;
        if(((ContainsKey(key:  3)) != false) && (val_50 > Item[3]))
        {
                if((-1) >= 0)
        {
                do
        {
            if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((System.String.op_Inequality(a:  List<T>.__il2cppRuntimeField_C, b:  1098586544)) != false)
        {
                if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((uncommonWords.Contains(item:  List<T>.__il2cppRuntimeField_C)) != true)
        {
                if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Add(item:  List<T>.__il2cppRuntimeField_C);
            RemoveAt(index:  -1);
            int val_52 = val_11;
            val_52 = val_52 - 1;
        }
        
        }
        
            var val_25 = 3 - 1;
        }
        while((3 - 5) > 1);
        
        }
        
            bool val_26 = Remove(key:  3);
            val_49 = 1152921511111016832;
            val_50 = val_52;
            val_51 = 1152921511111015808;
        }
        
        var val_53 = 2;
        do
        {
            if((ContainsKey(key:  2)) != true)
        {
                use(item:  2);
        }
        
            val_53 = val_53 + 1;
        }
        while(val_53 != 8);
        
        if(val_50 < 1)
        {
            goto label_81;
        }
        
        var val_54 = 0;
        label_82:
        label_75:
        val_54 = val_54 + 1;
        val_52 = 0;
        goto label_56;
        label_59:
        val_52 = 1;
        label_56:
        int val_28 = roll(unweighted:  false);
        if(val_52 <= 99)
        {
                if(Item[val_28] == 1)
        {
            goto label_59;
        }
        
        }
        
        val_53 = 0;
        null = new RandomSet();
        goto label_60;
        label_67:
        if(0 <= val_53)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        add(item:  0, weight:  null);
        val_53 = 1;
        label_60:
        if(val_53 < 0)
        {
            goto label_67;
        }
        
        int val_31 = roll(unweighted:  false);
        if(0 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.String.op_Equality(a:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_31) << 2) + 16, b:  1098586544)) == true)
        {
            goto label_71;
        }
        
        if(0 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((uncommonWords.Contains(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_31) << 2) + 16)) == false)
        {
            goto label_74;
        }
        
        label_71:
        if(val_54 <= 99)
        {
            goto label_75;
        }
        
        goto label_81;
        label_74:
        if(0 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_31) << 2) + 16);
        RemoveAt(index:  val_31);
        if(null != 0)
        {
                val_54 = Item[val_28];
        }
        else
        {
                val_54 = Item[val_28];
        }
        
        set_Item(key:  val_28, value:  val_54 - 1);
        if(val_54 > 99)
        {
            goto label_81;
        }
        
        int val_37 = val_50 - 1;
        if(val_50 >= 2)
        {
            goto label_82;
        }
        
        label_81:
        List.Enumerator<T> val_39 = GetEnumerator();
        label_91:
        if(MoveNext() == false)
        {
            goto label_84;
        }
        
        if(rareWords != 0)
        {
                if((rareWords.Contains(item:  val_16)) == true)
        {
            goto label_91;
        }
        
        }
        
        if(Length >= 1)
        {
                System.Text.StringBuilder val_43 = Append(value:  -2100450224);
        }
        
        System.Text.StringBuilder val_44 = Append(value:  val_16);
        goto label_91;
        label_84:
        Dispose();
        this.answers = new System.Text.StringBuilder();
        val_55 = val_7;
        if(val_55 == 0)
        {
                val_55 = val_7;
        }
        
        List.Enumerator<T> val_46 = GetEnumerator();
        label_99:
        if(MoveNext() == false)
        {
            goto label_94;
        }
        
        if(Length >= 1)
        {
                System.Text.StringBuilder val_49 = Append(value:  -2100450224);
        }
        
        System.Text.StringBuilder val_50 = Append(value:  val_16);
        goto label_99;
        label_94:
        Dispose();
        this.extraWords = new System.Text.StringBuilder();
        this.WordRemoval(maxCount:  maxCount, removePercent:  removePercent, removePlurals:  false, rareWords:  rareWords);
    }
    public void WordRemoval(int maxCount = 24, int removePercent = 20, bool removePlurals = True, System.Collections.Generic.List<string> rareWords)
    {
        string val_17;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        val_47 = 0;
        goto label_1;
        label_6:
        if(this.word.Chars[0] != ('|'))
        {
                string val_3 = this.word.Chars[0].ToString();
            string val_4 = 1098586544 + -2085588550(-2085588550);
        }
        
        val_47 = 1;
        label_1:
        if(val_47 < this.word.m_stringLength)
        {
            goto label_6;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_5 = this.answers.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_6 = new System.Collections.Generic.List<ZooTile>(collection:  this.answers);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(mem[1152921511111205112] != 0)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_8 = mem[1152921511111205112].Split(separator:  478563824);
            AddRange(collection:  mem[1152921511111205112]);
        }
        
        if(null != 0)
        {
                val_49 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        }
        else
        {
                val_49 = 0;
            val_48 = 0;
        }
        
        int val_9 = val_49 * removePercent;
        val_9 = (val_9 >> 5) + (val_9 >> 31);
        int val_12 = UnityEngine.Mathf.Max(a:  val_9, b:  val_48 - maxCount);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_13 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(new RandomSet() != 0)
        {
                typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            add(item:  2, weight:  null);
            add(item:  3, weight:  null);
            add(item:  4, weight:  null);
            add(item:  5, weight:  null);
            add(item:  6, weight:  null);
        }
        else
        {
                mem[8] = 1;
            add(item:  2, weight:  null);
            add(item:  3, weight:  null);
            add(item:  4, weight:  null);
            add(item:  5, weight:  null);
            add(item:  6, weight:  null);
        }
        
        add(item:  7, weight:  null);
        List.Enumerator<T> val_15 = GetEnumerator();
        label_29:
        if(MoveNext() == false)
        {
            goto label_21;
        }
        
        if((ContainsKey(key:  val_17 + 8)) == false)
        {
            goto label_24;
        }
        
        set_Item(key:  val_17 + 8, value:  (Item[val_17 + 8]) + 1);
        goto label_29;
        label_24:
        Add(key:  val_17 + 8, value:  1);
        goto label_29;
        label_21:
        Dispose();
        if(((ContainsKey(key:  3)) != false) && (val_12 > Item[3]))
        {
                if((-1) >= 0)
        {
                do
        {
            if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((System.String.op_Inequality(a:  List<T>.__il2cppRuntimeField_C, b:  1098586544)) != false)
        {
                if(0 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Add(item:  List<T>.__il2cppRuntimeField_C);
            RemoveAt(index:  -1);
            int val_49 = val_12;
            val_49 = val_49 - 1;
        }
        
            var val_25 = 3 - 1;
        }
        while((3 - 5) > 1);
        
        }
        
            bool val_26 = Remove(key:  3);
        }
        
        var val_50 = 2;
        do
        {
            if((ContainsKey(key:  2)) != true)
        {
                use(item:  2);
        }
        
            val_50 = val_50 + 1;
        }
        while(val_50 != 8);
        
        goto label_69;
        label_74:
        if(val_49 <= 0)
        {
            goto label_51;
        }
        
        val_50 = val_50 + 1;
        val_50 = 0;
        goto label_54;
        label_57:
        val_50 = 1;
        label_54:
        int val_28 = roll(unweighted:  false);
        if(val_50 <= 99)
        {
                if(Item[val_28] == 1)
        {
            goto label_57;
        }
        
        }
        
        val_51 = 0;
        null = new RandomSet();
        goto label_58;
        label_65:
        if(0 <= val_51)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        add(item:  0, weight:  null);
        val_51 = 1;
        label_58:
        if(val_51 < 0)
        {
            goto label_65;
        }
        
        int val_31 = roll(unweighted:  false);
        if(0 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.String.op_Equality(a:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_31) << 2) + 16, b:  1098586544)) != true)
        {
                if(0 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_31) << 2) + 16);
            RemoveAt(index:  val_31);
            if(null != 0)
        {
                val_52 = Item[val_28];
        }
        else
        {
                val_52 = Item[val_28];
        }
        
            int val_51 = val_49;
            val_51 = val_51 - 1;
            set_Item(key:  val_28, value:  val_52 - 1);
        }
        
        label_69:
        if(val_50 <= 99)
        {
            goto label_74;
        }
        
        label_51:
        List.Enumerator<T> val_37 = GetEnumerator();
        label_83:
        if(MoveNext() == false)
        {
            goto label_76;
        }
        
        if(rareWords != 0)
        {
                if((rareWords.Contains(item:  val_17)) == true)
        {
            goto label_83;
        }
        
        }
        
        if(Length >= 1)
        {
                System.Text.StringBuilder val_41 = Append(value:  -2100450224);
        }
        
        System.Text.StringBuilder val_42 = Append(value:  val_17);
        goto label_83;
        label_76:
        Dispose();
        this.answers = new System.Text.StringBuilder();
        val_53 = val_7;
        if(val_53 == 0)
        {
                val_53 = val_7;
        }
        
        List.Enumerator<T> val_44 = GetEnumerator();
        label_91:
        if(MoveNext() == false)
        {
            goto label_86;
        }
        
        if(Length >= 1)
        {
                System.Text.StringBuilder val_47 = Append(value:  -2100450224);
        }
        
        System.Text.StringBuilder val_48 = Append(value:  val_17);
        goto label_91;
        label_86:
        Dispose();
        mem[1152921511111205112] = new System.Text.StringBuilder();
    }
    public string ToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -2085463936, value:  this.word);
        Add(key:  -2085459760, value:  this.answers);
        Add(key:  -2085455568, value:  this.extraWords);
        Add(key:  -2085451376, value:  this.lvlName);
        Add(key:  -2085451280, value:  13152256);
        Add(key:  -2085447088, value:  this.coords);
        Add(key:  -2085442912, value:  this.gridSize);
        Add(key:  -2085442816, value:  8945664);
        Add(key:  -2085438624, value:  this.availExtraReq);
        Add(key:  -2085438528, value:  15282176);
        Add(key:  -2085434320, value:  this.levelProgress);
        Add(key:  -2085434224, value:  13152256);
        Add(key:  -2085434128, value:  8945664);
        Add(key:  -2085434016, value:  13152256);
        Add(key:  -2085433888, value:  13152256);
        Add(key:  -2085433776, value:  13152256);
        Add(key:  -2085433664, value:  13152256);
        Add(key:  -2085433552, value:  13152256);
        Add(key:  -2085433440, value:  13152256);
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        this.language = 0;
        Add(key:  -2085433328, value:  0);
        string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public void FromJSON(string jsonString)
    {
        string val_36;
        string val_61;
        var val_62;
        val_61 = jsonString;
        object val_1 = MiniJSON.Json.Deserialize(json:  val_61);
        val_62 = 1152921510392296080;
        if((0.ContainsKey(key:  -2085463936)) != false)
        {
                string val_3 = 0.Item[-2085463936];
            this.word = 0;
        }
        
        if((0.ContainsKey(key:  -2085459760)) != false)
        {
                string val_5 = 0.Item[-2085459760];
            this.answers = 0;
        }
        
        if((0.ContainsKey(key:  -2085455568)) != false)
        {
                val_61 = 1152921510385703632;
            string val_7 = 0.Item[-2085455568];
            if(0 != 0)
        {
                string val_8 = 0.Item[-2085455568];
            this.extraWords = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -2085451376)) != false)
        {
                string val_10 = 0.Item[-2085451376];
            this.levelName = null;
        }
        
        if((0.ContainsKey(key:  -2085451280)) != false)
        {
                string val_12 = 0.Item[-2085451280];
            this.playerLevel = System.Int32.Parse(s:  null, style:  511);
        }
        
        if((0.ContainsKey(key:  -2085447088)) != false)
        {
                val_61 = 1152921510385703632;
            string val_15 = 0.Item[-2085447088];
            if(0 != 0)
        {
                string val_16 = 0.Item[-2085447088];
            this.coords = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -2085442912)) != false)
        {
                val_61 = 1152921510385703632;
            string val_18 = 0.Item[-2085442912];
            if(0 != 0)
        {
                string val_19 = 0.Item[-2085442912];
            this.gridSize = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -2085442816)) != false)
        {
                string val_21 = 0.Item[-2085442816];
            val_61 = 0;
            this.completed = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -2085438624)) != false)
        {
                val_61 = 1152921510385703632;
            string val_24 = 0.Item[-2085438624];
            if(0 != 0)
        {
                string val_25 = 0.Item[-2085438624];
            this.availExtraReq = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -2085438528)) != false)
        {
                string val_27 = 0.Item[-2085438528];
            float val_28 = System.Single.Parse(s:  null, style:  511);
            this.avgCompletionTime = 0;
        }
        
        if((0.ContainsKey(key:  -2085433328)) != false)
        {
                string val_30 = 0.Item[-2085433328];
            this.language = 0;
        }
        
        if((0.ContainsKey(key:  -2085434320)) == false)
        {
            goto label_71;
        }
        
        string val_32 = 0.Item[-2085434320];
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_33 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.levelProgress = null;
        val_61 = 0;
        List.Enumerator<T> val_34 = GetEnumerator();
        label_69:
        if(MoveNext() == false)
        {
            goto label_66;
        }
        
        this.levelProgress.Add(item:  val_36);
        goto label_69;
        label_66:
        Dispose();
        val_62 = 1152921510392296080;
        if((0.ContainsKey(key:  -2085434224)) != false)
        {
                string val_38 = 0.Item[-2085434224];
            this.actualWordCount = System.Int32.Parse(s:  null);
        }
        
        label_71:
        if((0.ContainsKey(key:  -2085434128)) != false)
        {
                string val_41 = 0.Item[-2085434128];
            this.isChallengingLevel = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -2085434016)) != false)
        {
                string val_44 = 0.Item[-2085434016];
            this.goldenApplesExtraDifficulty = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -2085433888)) != false)
        {
                string val_47 = 0.Item[-2085433888];
            this.goldenApplesStreaks = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -2085433776)) != false)
        {
                string val_50 = 0.Item[-2085433776];
            this.goldenApplesStreaksSubBonus = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -2085433664)) != false)
        {
                string val_53 = 0.Item[-2085433664];
            this.goldenApplesExtraWords = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -2085433552)) != false)
        {
                string val_56 = 0.Item[-2085433552];
            this.goldenApplesExtraWordsSubBonus = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -2085433440)) == false)
        {
                return;
        }
        
        string val_59 = 0.Item[-2085433440];
        this.highestWordStreak = System.Int32.Parse(s:  null);
    }
    public string Serialize()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_2 = Append(value:  this.word);
        }
        else
        {
                System.Text.StringBuilder val_3 = Append(value:  this.word);
        }
        
        System.Text.StringBuilder val_4 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_5 = Append(value:  this.answers);
        }
        else
        {
                System.Text.StringBuilder val_6 = Append(value:  this.answers);
        }
        
        System.Text.StringBuilder val_7 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_8 = Append(value:  this.extraWords);
        }
        else
        {
                System.Text.StringBuilder val_9 = Append(value:  this.extraWords);
        }
        
        System.Text.StringBuilder val_10 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_11 = Append(value:  this.lvlName);
        }
        else
        {
                System.Text.StringBuilder val_12 = Append(value:  this.lvlName);
        }
        
        System.Text.StringBuilder val_13 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_14 = Append(value:  this.coords);
        }
        else
        {
                System.Text.StringBuilder val_15 = Append(value:  this.coords);
        }
        
        System.Text.StringBuilder val_16 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_17 = Append(value:  this.gridSize);
        }
        else
        {
                System.Text.StringBuilder val_18 = Append(value:  this.gridSize);
        }
        
        System.Text.StringBuilder val_19 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_20 = Append(value:  this.availExtraReq);
        }
        else
        {
                System.Text.StringBuilder val_21 = Append(value:  this.availExtraReq);
        }
        
        System.Text.StringBuilder val_22 = Append(value:  1726048032);
        GameBehavior val_23 = App.getBehavior;
        string val_24 = 0.GetCurrentLanguage();
        this.language = 0;
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_25 = Append(value:  null);
        }
        else
        {
                System.Text.StringBuilder val_26 = Append(value:  null);
        }
        
        System.Text.StringBuilder val_27 = Append(value:  1726048032);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_28 = Append(value:  null);
        }
        else
        {
                System.Text.StringBuilder val_29 = Append(value:  null);
        }
    
    }
    public static GameLevel Deserialize(string data)
    {
        var val_8;
        char val_9;
        var val_10;
        if(data == null)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((System.String.op_Equality(a:  data, b:  1098586544)) == true)
        {
                return;
        }
        
        GameLevel val_2 = null;
        val_8 = val_2;
        val_2 = new GameLevel();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 35;
        System.String[] val_3 = data.Split(separator:  478563824);
        typeof(GameLevel).__il2cppRuntimeField_30 = null;
        typeof(GameLevel).__il2cppRuntimeField_34 = data.m_firstChar;
        typeof(GameLevel).__il2cppRuntimeField_38 = data.m_firstChar;
        levelName = null;
        typeof(GameLevel).__il2cppRuntimeField_4C = data.m_firstChar;
        typeof(GameLevel).__il2cppRuntimeField_50 = data.m_firstChar;
        if(6 >= val_9)
        {
            goto label_13;
        }
        
        val_10 = 6 + 1;
        typeof(GameLevel).__il2cppRuntimeField_44 = data + 28;
        val_9 = data.m_firstChar;
        goto label_15;
        label_1:
        val_8 = 0;
        return;
        label_13:
        val_10 = 6;
        label_15:
        if(val_10 >= val_9)
        {
                return;
        }
        
        bool val_7 = System.Single.TryParse(s:  data + 28, result: out  float val_6 = 6.562416E-29f);
    }
    public GameLevel()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.levelProgress = null;
        this.challengeWord = "";
        this.extraRequiredWords = "";
    }

}
