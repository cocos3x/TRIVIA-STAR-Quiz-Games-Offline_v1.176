using UnityEngine;
public class WordIQManagerUI : MonoSingleton<WordIQManagerUI>
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<WordIQCellOverlay>> NewWordCellsDict;
    private System.Collections.Generic.Dictionary<string, LineWord> NewWordLines;
    private float _IQPointsAtStartOfLevel;
    private IQGains _IQPointsGainedLastLevel;
    private System.Collections.Generic.List<string> _NewWordsFoundLastLevel;
    
    // Properties
    public UnityEngine.Sprite MilestoneColorableSprite { get; }
    public UnityEngine.Sprite MilestoneMasterSprite { get; }
    private WordIQCellOverlay NewWordCellPrefab { get; }
    private WordIQLineAnim NewWordNewAnimPrefab { get; }
    private WordIQLineAnim NewWordAnsweredAnimPrefab { get; }
    public float IQPointsAtStartOfLevel { get; }
    public IQGains IQPointsGainedLastLevel { get; }
    public System.Collections.Generic.List<string> NewWordsFoundLastLevel { get; }
    
    // Methods
    public static string FormatPoints(float iqPoints)
    {
        float val_3 = 0 * 100f;
        val_3 = val_3 / 100f;
        string val_2 = val_3.ToString(format:  -916940624);
    }
    public UnityEngine.Sprite get_MilestoneColorableSprite()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = mem[public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 212];
        val_6 = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 212;
    }
    public UnityEngine.Sprite get_MilestoneMasterSprite()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = mem[public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 216];
        val_6 = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 216;
    }
    private WordIQCellOverlay get_NewWordCellPrefab()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = mem[public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 196];
        val_6 = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 196;
    }
    private WordIQLineAnim get_NewWordNewAnimPrefab()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = mem[public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 200];
        val_6 = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 200;
    }
    private WordIQLineAnim get_NewWordAnsweredAnimPrefab()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10.WordIQNewWordAnswered;
    }
    public float get_IQPointsAtStartOfLevel()
    {
        return (float)S0;
    }
    public IQGains get_IQPointsGainedLastLevel()
    {
    
    }
    public System.Collections.Generic.List<string> get_NewWordsFoundLastLevel()
    {
    
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -915891136, method:  new IntPtr(3379051136));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public void OnDestroy()
    {
        var val_6;
        System.Action<Result> val_7;
        var val_8;
        val_6 = 1152921504901201920;
        val_7 = 1152921511097403152;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2099378416)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_7 = null;
        val_7 = new System.Action<Result>(object:  -915779136, method:  new IntPtr(3379051136));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    public void PrepNewLevel()
    {
        this.NewWordCellsDict.Clear();
        this.NewWordLines.Clear();
    }
    public void DisplayNewWordsInLevel(System.Collections.Generic.List<string> newWords, bool showNewTag)
    {
        LineWord val_6;
        UnityEngine.Transform val_11;
        WordIQCellOverlay val_1 = NewWordCellPrefab;
        if((-915535504) == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_32:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((newWords.Contains(item:  val_6 + 12)) == false)
        {
            goto label_32;
        }
        
        this.NewWordLines.Add(key:  val_6 + 12, value:  val_6);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_9 = GetEnumerator();
        label_25:
        bool val_10 = MoveNext();
        if(val_10 == false)
        {
            goto label_14;
        }
        
        WordIQCellOverlay val_12 = val_10.NewWordCellPrefab;
        UnityEngine.Transform val_13 = val_11.transform;
        object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  val_10, parent:  val_11);
        UnityEngine.Transform val_15 = val_10.transform;
        val_10.SetSiblingIndex(index:  1);
        val_10.SetParentCell(parentCell:  val_11);
        UnityEngine.GameObject val_16 = val_10.gameObject;
        val_10.SetActive(value:  val_10 >> 5);
        Add(item:  val_10);
        goto label_25;
        label_14:
        var val_18 = 0;
        val_18 = val_18 + 1;
        mem2[0] = 205;
        Dispose();
        var val_20 = val_18;
        if(val_20 != 1)
        {
                if(val_20 > 1)
        {
                0 = 1;
        }
        
            var val_19 = -915535504 + ((0 + 1)) << 2;
            val_19 = val_19 - 205;
            val_19 = val_19 >> 5;
            val_19 = 1 & val_19;
            val_20 = val_20 - val_19;
        }
        
        mem[1152921512281258188].Add(key:  val_6 + 12, value:  80883712);
        if(showNewTag == false)
        {
            goto label_32;
        }
        
        this.PlayNewAnim(line:  val_6);
        goto label_32;
        label_8:
        Dispose();
    }
    public void NewWordFound(string word, bool isExtra)
    {
        var val_6;
        bool val_8 = isExtra;
        if(val_8 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowIQWord(word:  word);
            return;
        }
        
        val_8 = this.NewWordCellsDict;
        if((val_8.ContainsKey(key:  word)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WordIQCellOverlay> val_3 = this.NewWordCellsDict.Item[word];
        List.Enumerator<T> val_4 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        val_6.PlayFoundAnimation();
        goto label_12;
        label_10:
        Dispose();
        val_8 = this.NewWordLines;
        LineWord val_7 = val_8.Item[word];
        this.PlayAnsweredAnim(line:  val_8);
    }
    public void WordHint(string word, int hintIndex, bool isFree, bool isPickerHint)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<WordIQCellOverlay>> val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance();
        if((IsNewWord(word:  word)) == false)
        {
                return;
        }
        
        val_8 = this.NewWordCellsDict;
        if((val_8.ContainsKey(key:  word)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WordIQCellOverlay> val_6 = this.NewWordCellsDict.Item[word];
        if(this.NewWordCellsDict <= hintIndex)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (hintIndex << 2);
        UnityEngine.GameObject val_7 = (0 + (hintIndex) << 2) + 16.gameObject;
        (0 + (hintIndex) << 2) + 16.SetActive(value:  false);
    }
    public void HandleLevelCompleted(float iqPointsTotal, IQGains iqPointsGainedLastLevel, System.Collections.Generic.List<string> newWordsFoundLastLevel)
    {
        string val_7;
        var val_8;
        var val_9;
        float val_1 = newWordsFoundLastLevel.Total;
        System.Collections.Generic.List<System.String> val_7 = newWordsFoundLastLevel;
        this._IQPointsGainedLastLevel = newWordsFoundLastLevel;
        this._NewWordsFoundLastLevel = R3;
        val_7 = iqPointsGainedLastLevel - val_7;
        this._IQPointsAtStartOfLevel = val_7;
        val_7 = 1152921512263062736;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((GetMilestone(iqPoints:  val_7)) == PlayerMilestone)
        {
                return;
        }
        
        var val_8 = 24064238;
        val_8 = 11561300 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_7 = Events.IQ_MILESTONE;
        string val_6 = System.String.Format(format:  -1645101696, arg0:  val_7, arg1:  13152256);
        App.trackerManager.track(eventName:  -1645101696);
    }
    private void OnSceneLoaded(SceneType sceneType)
    {
        if(sceneType != 2)
        {
                return;
        }
        
        35636575 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_4 = new System.Action<System.String, System.Int32, System.Boolean, System.Boolean>(object:  -914981184, method:  new IntPtr(3379960064));
        0.addOnHintedUsedAction(callback:  7614464);
    }
    private UnityEngine.Vector3 GetMidpoint(LineWord line)
    {
        var val_4;
        var val_9;
        float val_20;
        var val_21;
        var val_22;
        val_20 = 0f;
        val_21 = 0;
        val_22 = 0;
        goto label_0;
        label_11:
        UnityEngine.Transform val_1 = this.GetChild(index:  0);
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Transform val_5 = R2.transform;
        UnityEngine.Transform val_6 = R2.GetChild(index:  0);
        UnityEngine.Transform val_7 = R2.transform;
        val_22 = val_22 + val_4;
        UnityEngine.Vector3 val_8 = localPosition;
        val_21 = 1;
        val_20 = val_20 + val_9;
        label_0:
        UnityEngine.Transform val_10 = R2.transform;
        UnityEngine.Transform val_12 = R2.transform;
        if(val_21 < R2.childCount)
        {
            goto label_11;
        }
        
        UnityEngine.Transform val_14 = R2.transform;
        val_22 = val_22 / (float)R2.childCount;
        val_20 = val_20 / (float)R2.childCount;
        UnityEngine.Transform val_16 = R2.transform;
        UnityEngine.Vector3 val_17 = localPosition;
        this = 0;
        mem[1152921512281920580] = 0;
        mem[1152921512281920584] = 0;
        this = new UnityEngine.Vector3(x:  val_17.x, y:  val_17.y, z:  val_17.z);
        return new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    private void PlayNewAnim(LineWord line)
    {
        float val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_1 = GetMidpoint(line:  line);
        WordIQLineAnim val_5 = NewWordNewAnimPrefab;
        UnityEngine.Transform val_6 = line.transform;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -914751820, parent:  line);
        UnityEngine.Transform val_8 = transform;
        localPosition = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4};
    }
    private void PlayAnsweredAnim(LineWord line)
    {
        float val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_1 = GetMidpoint(line:  line);
        WordIQLineAnim val_5 = NewWordAnsweredAnimPrefab;
        UnityEngine.Transform val_6 = line.transform;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -914631628, parent:  line);
        UnityEngine.Transform val_8 = transform;
        localPosition = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4};
    }
    public WordIQManagerUI()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.NewWordCellsDict = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.NewWordLines = null;
    }

}
