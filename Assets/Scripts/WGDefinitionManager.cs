using UnityEngine;
public class WGDefinitionManager : MonoSingletonSelfGenerating<WGDefinitionManager>
{
    // Fields
    private bool currentlyRequesting;
    private string currentlyRequestedWord;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> storedWords;
    private const string definitionDirectory = "/Definitions.def";
    private const char dictionaryKeySplitter = '\x3a';
    
    // Properties
    private bool hasSeenDefFtux { get; set; }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> getStoredWords { get; }
    
    // Methods
    private bool get_hasSeenDefFtux()
    {
        return CPlayerPrefs.GetBool(key:  -61321952, defaultValue:  false);
    }
    private void set_hasSeenDefFtux(bool value)
    {
        CPlayerPrefs.SetBool(key:  -61321952, value:  value);
    }
    private void Awake()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -61072832, method:  new IntPtr(4233869440));
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
    private void OnSceneLoaded(SceneType sceneType)
    {
        var val_7 = 35631385;
        if(this.hasSeenDefFtux == false)
        {
            goto label_1;
        }
        
        GameEcon val_2 = App.getGameEcon;
        val_7 = 0;
        if(sceneType != 2)
        {
                return;
        }
        
        if(18 < 1)
        {
            goto label_6;
        }
        
        return;
        label_1:
        if(sceneType != 2)
        {
                return;
        }
        
        label_6:
        val_7 = 1152921504886931456;
        WordRegion val_3 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_5 = WordRegion.instance;
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_6 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -60955712, method:  new IntPtr(4233986560));
        0.addOnValidWordSubmittedAction(callback:  7507968);
    }
    public void displayDefinition(string word, bool flyout = False)
    {
        var val_10;
        var val_11;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_12;
        var val_13;
        var val_14;
        val_10 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        val_11 = 0;
        string val_2 = val_11.GetCurrentLanguage();
        if((System.String.op_Inequality(a:  null, b:  1800251696)) == true)
        {
                return;
        }
        
        if(this.storedWords == 0)
        {
                this.PopulateStoredWords();
        }
        
        if((0.ContainsKey(key:  word)) != false)
        {
                val_12 = this.storedWords;
            if(val_12 == 0)
        {
                this.PopulateStoredWords();
            val_12 = this.storedWords;
            if(val_12 == 0)
        {
                val_12 = 0;
        }
        
        }
        
            string val_5 = val_12.Item[word];
            this.GotDefintion(def:  0, flyout:  false);
        }
        else
        {
                if(this.currentlyRequesting == true)
        {
                return;
        }
        
            mem2[0] = ???;
            GameBehavior val_6 = App.getBehavior;
            val_11 = 0;
            mem2[0] = 1;
            R5.RequestWord(word:  R4);
        }
        
        Player val_8 = App.Player;
        val_13 = 2621448;
        if(val_13 != 0)
        {
                val_14 = 23;
        }
        else
        {
                val_13 = 232;
            val_14 = 0;
        }
        
        mem[232] = 1;
    }
    private void RequestWord(string word)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -60678464, method:  new IntPtr(4234262784));
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -60678464, method:  new IntPtr(4234263808));
        GetWordDefinition(word:  word, callback:  7401472, onFailure:  7401472);
    }
    public void RequestWordVaidator(string word, System.Action<System.Collections.Generic.Dictionary<string, object>> callback, System.Action<System.Collections.Generic.Dictionary<string, object>> failure)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GetWordDefinition(word:  word, callback:  callback, onFailure:  failure);
    }
    private void StoreNewDef(System.Collections.Generic.Dictionary<string, object> callbackData)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.currentlyRequesting = false;
        object val_2 = callbackData.Item[1633187840];
        if((0.ContainsKey(key:  -954929024)) != false)
        {
                string val_4 = 0.Item[-954929024];
            string val_5 = 0.ToUpper();
            0.set_Item(key:  -954929024, value:  0);
        }
        
        string val_6 = 0.Item[-954929024];
        this.StoreWord(word:  null, wordData:  0);
        string val_7 = 0.Item[-954929024];
        string val_8 = 0.ToLower();
        string val_9 = this.currentlyRequestedWord.ToLower();
        bool val_10 = System.String.op_Equality(a:  null, b:  this.currentlyRequestedWord);
        if(val_10 == false)
        {
                return;
        }
        
        val_10.GotDefintion(def:  0, flyout:  false);
    }
    private void OnRequestFailure(System.Collections.Generic.Dictionary<string, object> failureData)
    {
        this.currentlyRequesting = false;
        if((System.String.op_Inequality(a:  this.currentlyRequestedWord, b:  System.String.alignConst)) == false)
        {
                return;
        }
        
        mem2[0] = R5 + 92;
        GameBehavior val_2 = App.getBehavior;
        0.OnFailure();
    }
    public void StopWaitingForRequest()
    {
        this.currentlyRequesting = false;
        this.currentlyRequestedWord = System.String.alignConst;
    }
    private void GotDefintion(System.Collections.Generic.Dictionary<string, object> def, bool flyout = False)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> get_getStoredWords()
    {
        if(this.storedWords != 0)
        {
                return;
        }
        
        R4.PopulateStoredWords();
    }
    public void StoreWord(string word, System.Collections.Generic.Dictionary<string, object> wordData)
    {
        if((this.storedWords.ContainsKey(key:  word)) != false)
        {
                return;
        }
        
        this.storedWords.Add(key:  word, value:  wordData);
        string val_2 = UnityEngine.Application.persistentDataPath;
        string val_3 = null + -59824256(-59824256);
        System.IO.FileInfo val_4 = new System.IO.FileInfo(fileName:  null);
        System.IO.DirectoryInfo val_5 = Directory;
        Create();
        string val_6 = System.Environment.NewLine;
        string val_7 = MiniJSON.Json.Serialize(obj:  wordData);
        string val_8 = null + word + 1269544640 + wordData;
        System.IO.File.AppendAllText(path:  null, contents:  null);
    }
    private void PopulateStoredWords()
    {
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        mem[1152921513137109828] = null;
        string val_2 = UnityEngine.Application.persistentDataPath;
        string val_3 = null + -59824256(-59824256);
        if((System.IO.File.Exists(path:  null)) == false)
        {
                return;
        }
        
        System.String[] val_5 = System.IO.File.ReadAllLines(path:  null);
        val_11 = 5;
        goto label_2;
        label_13:
        int val_6 = 1.IndexOf(value:  ':');
        string val_7 = 1.Substring(startIndex:  0, length:  val_6);
        val_12 = 1;
        string val_9 = val_12.Substring(startIndex:  val_6 + 1);
        object val_10 = MiniJSON.Json.Deserialize(json:  1);
        val_13 = 0;
        if(val_12 != 0)
        {
                val_12 = 0;
            if(((-2065588224 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_12 = 0;
        }
        
            val_13 = val_12;
        }
        
        Add(key:  1, value:  0);
        val_11 = 6;
        label_2:
        if(2 < 0)
        {
            goto label_13;
        }
    
    }
    private void OnValidWordSubmitted(string validWord, bool isExtra)
    {
        GameEcon val_1 = App.getGameEcon;
        if(18 < 1)
        {
                return;
        }
        
        Player val_2 = App.Player;
        GameEcon val_3 = App.getGameEcon;
        1152921504892043264 = 0;
        if(0 < 18)
        {
                return;
        }
        
        if(isExtra == true)
        {
                return;
        }
        
        bool val_4 = UnityEngine.Object.op_Equality(x:  ExtraWord.GAMETYPE_CATEGORY_LEVELS, y:  0);
        if(val_4 == true)
        {
                return;
        }
        
        if(val_4.hasSeenDefFtux != false)
        {
                return;
        }
        
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.DisplayDefinitionFlyout();
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.hasSeenDefFtux = true;
        CPlayerPrefs.Save();
    }
    public WGDefinitionManager()
    {
        this.currentlyRequestedWord = System.String.alignConst;
    }

}
