using UnityEngine;
public class WGFTUXManager : MonoSingleton<WGFTUXManager>
{
    // Fields
    private const string FTUX_SKIP_PROMPTED = "Ftux_Skip_Prompted";
    public twelvegigs.storage.JsonDictionary gameplayKnobs;
    public FTUXDemoWindow currDemoWindow;
    public System.Action<int> SkipToLevelCallback;
    public System.Action SkipTutorialCallback;
    
    // Properties
    public static int FTUX_LEVEL_LIMIT { get; }
    public static bool CanShow { get; }
    public static bool IsShowing { get; }
    private static bool timeToShow { get; }
    private static bool isEnabled { get; }
    public bool DisplaySkipTutorial { get; }
    public bool DisplayAdvancedPlayerPopup { get; }
    public int AdvancedPlayerLevelSkip { get; }
    public int SkipTutorialLevel { get; }
    public int DisplayAdvancedPlayerLevel { get; }
    public int DisplayTutorialSkipLevel { get; }
    public int ReviewPromptLevel { get; }
    
    // Methods
    public static int get_FTUX_LEVEL_LIMIT()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static bool get_CanShow()
    {
        bool val_1 = WGFTUXManager.timeToShow;
        if(val_1 == false)
        {
                val_1 = 0;
            return (bool)val_1;
        }
        
        return WGFTUXManager.isEnabled;
    }
    public static bool get_IsShowing()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2120738704 == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return UnityEngine.Object.op_Inequality(x:  public static WGFTUXManager MonoSingleton<WGFTUXManager>::get_Instance().__il2cppRuntimeField_10, y:  0);
    }
    private static bool get_timeToShow()
    {
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        val_12 = 0;
        if(0 > WGFTUXManager.FTUX_LEVEL_LIMIT)
        {
                return (bool)val_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2116505760)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = 0;
            if(PlayingChallenge == true)
        {
                return (bool)val_12;
        }
        
        }
        
        val_12 = 0;
        SceneType val_7 = SceneDictator.GetActiveSceneType();
        if(0 != 2)
        {
                return (bool)val_12;
        }
        
        val_12 = 1;
        if(WordGameEventsController.EventsEnabled == false)
        {
                return (bool)val_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = ActivelyPlayingEventGameMode() ^ 1;
        return (bool)val_12;
    }
    private static bool get_isEnabled()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return true;
        }
        
        return true;
    }
    public bool get_DisplaySkipTutorial()
    {
        var val_3;
        GameBehavior val_1 = App.getBehavior;
        val_3 = 0;
        if(0 == 0)
        {
                return (bool)val_3;
        }
        
        if(this.gameplayKnobs != 0)
        {
            goto label_6;
        }
        
        this.LoadKnobs(forceRefresh:  false);
        if(this.gameplayKnobs == 0)
        {
            goto label_7;
        }
        
        label_6:
        val_3 = 1;
        if((this.gameplayKnobs.Contains(key:  -42687248)) == false)
        {
                return (bool)val_3;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getBool(key:  -42687248);
        }
        
        return this.gameplayKnobs.getBool(key:  -42687248);
        label_7:
        val_3 = 1;
        return (bool)val_3;
    }
    public bool get_DisplayAdvancedPlayerPopup()
    {
        var val_3;
        if(this.gameplayKnobs != 0)
        {
            goto label_1;
        }
        
        this.LoadKnobs(forceRefresh:  false);
        if(this.gameplayKnobs == 0)
        {
            goto label_2;
        }
        
        label_1:
        val_3 = 1;
        if((this.gameplayKnobs.Contains(key:  -42550576)) == false)
        {
                return true;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getBool(key:  -42550576);
        }
        
        return this.gameplayKnobs.getBool(key:  -42550576);
        label_2:
        AppConfigs val_2 = App.Configuration;
        if(6 != 0)
        {
                val_3 = 1;
        }
        
        return true;
    }
    public int get_AdvancedPlayerLevelSkip()
    {
        var val_3;
        if(this.gameplayKnobs != 0)
        {
            goto label_1;
        }
        
        this.LoadKnobs(forceRefresh:  false);
        if(this.gameplayKnobs == 0)
        {
            goto label_2;
        }
        
        label_1:
        val_3 = 50;
        if((this.gameplayKnobs.Contains(key:  -42413920)) == false)
        {
                return (int)val_3;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getInt(key:  -42413920, defaultValue:  0);
        }
        
        return this.gameplayKnobs.getInt(key:  -42413920, defaultValue:  0);
        label_2:
        AppConfigs val_2 = App.Configuration;
        val_3 = 8;
        return (int)val_3;
    }
    public int get_SkipTutorialLevel()
    {
        if(this.gameplayKnobs == 0)
        {
                this.LoadKnobs(forceRefresh:  false);
            if(this.gameplayKnobs == 0)
        {
                return 3;
        }
        
        }
        
        if((this.gameplayKnobs.Contains(key:  -42277248)) == false)
        {
                return 3;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getInt(key:  -42277248, defaultValue:  0);
        }
        
        return this.gameplayKnobs.getInt(key:  -42277248, defaultValue:  0);
    }
    public int get_DisplayAdvancedPlayerLevel()
    {
        var val_3;
        if(this.gameplayKnobs != 0)
        {
            goto label_1;
        }
        
        this.LoadKnobs(forceRefresh:  false);
        if(this.gameplayKnobs == 0)
        {
            goto label_2;
        }
        
        label_1:
        val_3 = 3;
        if((this.gameplayKnobs.Contains(key:  -42140576)) == false)
        {
                return (int)val_3;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getInt(key:  -42140576, defaultValue:  0);
        }
        
        return this.gameplayKnobs.getInt(key:  -42140576, defaultValue:  0);
        label_2:
        AppConfigs val_2 = App.Configuration;
        val_3 = 16;
        return (int)val_3;
    }
    public int get_DisplayTutorialSkipLevel()
    {
        if(this.gameplayKnobs == 0)
        {
                this.LoadKnobs(forceRefresh:  false);
            if(this.gameplayKnobs == 0)
        {
                return 1;
        }
        
        }
        
        if((this.gameplayKnobs.Contains(key:  -42003904)) == false)
        {
                return 1;
        }
        
        if(this.gameplayKnobs != 0)
        {
                return this.gameplayKnobs.getInt(key:  -42003904, defaultValue:  0);
        }
        
        return this.gameplayKnobs.getInt(key:  -42003904, defaultValue:  0);
    }
    public int get_ReviewPromptLevel()
    {
        var val_3;
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        val_3 = null;
        val_3 = null;
        string val_3 = WGReviewManager.GOOGLE_API_REVIEW_PREF;
        val_3 = val_3 + static_value_00280078;
        return (int)val_3;
    }
    private void LoadKnobs(bool forceRefresh = False)
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 35628108;
        if(forceRefresh != true)
        {
                if(this.gameplayKnobs != 0)
        {
                return;
        }
        
        }
        
        GameEcon val_1 = App.getGameEcon;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 0.GetGameplayKnobs();
        if(0 == 0)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_3 = 0.Keys;
        val_8 = 0;
        if(val_8.Count < 1)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_5 = null;
        val_8 = val_5;
        val_5 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  0);
        mem2[0] = val_8;
    }
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -41619216, name:  -1898880160);
    }
    private void OnServerSync()
    {
        this.LoadKnobs(forceRefresh:  true);
    }
    public void OnMainControllerLoaded()
    {
        if(WGFTUXManager.timeToShow != false)
        {
                if(WGFTUXManager.isEnabled != false)
        {
                System.Collections.IEnumerator val_3 = this.wait_ShowFTUX();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -41395216);
            return;
        }
        
        }
        
        if(WGFTUXManager.timeToShow == false)
        {
                return;
        }
        
        if(WGFTUXManager.isEnabled == true)
        {
                return;
        }
        
        Player val_7 = App.Player;
    }
    public void SkipToLevel(int level)
    {
        if(this.SkipToLevelCallback == 0)
        {
                return;
        }
        
        this.SkipToLevelCallback.Invoke(obj:  level);
    }
    public void SkipTutorial()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.SkipToLevel(level:  SkipTutorialLevel);
        Player val_3 = App.Player;
        Player val_4 = App.Player;
        2621448.Save(writePrefs:  true);
        if(this.SkipTutorialCallback == 0)
        {
                return;
        }
        
        this.SkipTutorialCallback.Invoke();
    }
    public bool CheckAvailable()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        SceneType val_2 = SceneDictator.GetActiveSceneType();
        if(0 != 2)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(ActivelyPlayingEventGameMode() == true)
        {
                return false;
        }
        
        GameBehavior val_7 = App.getBehavior;
        if(0 != this.DisplayAdvancedPlayerLevel)
        {
                return false;
        }
        
        return this.DisplayAdvancedPlayerPopup;
    }
    public void ShowAdvancedPlayerPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -40954832, defaultValue:  0)) > 0)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -40954832, value:  1);
        if(this.CheckAvailable() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowFTUX()
    {
        System.Collections.IEnumerator val_1 = this.wait_ShowFTUX();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -40817696);
    }
    private System.Collections.IEnumerator wait_ShowFTUX()
    {
        object val_1 = new System.Object();
        typeof(WGFTUXManager.<wait_ShowFTUX>d__38).__il2cppRuntimeField_8 = 0;
        typeof(WGFTUXManager.<wait_ShowFTUX>d__38).__il2cppRuntimeField_10 = this;
    }
    public WGFTUXManager()
    {
    
    }

}
