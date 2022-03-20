using UnityEngine;
public class TRVCrazyCategoriesEventHandler : WGEventHandler
{
    // Fields
    private static TRVCrazyCategoriesEventHandler _Instance;
    public const string EVENT_ID = "CrazyCategories";
    public const string EVENT_TRACKING_ID = "Crazy Categories Event";
    private string bonusCategory;
    public int multiplier;
    
    // Properties
    public static TRVCrazyCategoriesEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public string getBonusCategory { get; }
    private static int LastProgressTimestampPref { get; set; }
    
    // Methods
    public static TRVCrazyCategoriesEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public string get_getBonusCategory()
    {
    
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -427572432, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -427572432, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512769465432] = eventV2;
        this.ParseEventData(eventData:  eventV2.eventData);
        TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID = this;
    }
    public override void OnGameSceneBegan()
    {
        if((CPlayerPrefs.GetInt(key:  -427219952, defaultValue:  0)) == (R6 + 48))
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        CPlayerPrefs.SetInt(key:  -427219952, val:  -427194816);
        CPlayerPrefs.Save();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -427106704, defaultValue:  -427106816, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -427106704, defaultValue:  -427106816, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -427106704, defaultValue:  -427106816, useSingularKey:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void UpdateProgress()
    {
        TRVCrazyCategoriesEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override void OnLevelCompleteRewarded()
    {
        if(TRVCrazyCategoriesEventHandler.BonusStarsEligable() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -426312352, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AwardStar(earnedAmount:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 64, source:  -426312352, subSource:  null, additionalParam:  null);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        string val_3 = R4.Item[R5];
    }
    public static void RollBonusCategory(System.Collections.Generic.List<string> chosenCategories)
    {
        var val_3;
        var val_4;
        var val_3 = 23365451;
        val_3 = 12264288 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        if(chosenCategories != 0)
        {
                val_3 = chosenCategories;
            val_4 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_3 = 12;
            val_4 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_3 <= val_4)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (val_4 << 2);
        TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID.__unknownFiledOffset_10 = (0 + (val_2) << 2) + 16;
    }
    public static bool BonusStarsEligable()
    {
        var val_3 = 23365835;
        val_3 = 12263904 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return false;
        }
        
        Phase val_1 = TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID.m_stringLength.GetPhase();
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID.m_stringLength != 2)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                return System.String.op_Equality(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8, b:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16);
        }
        
        return System.String.op_Equality(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8, b:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16);
    }
    public int bonusStars(int stars)
    {
        return (int)stars;
    }
    public TRVCrazyCategoriesEventHandler()
    {
        this.multiplier = 2;
    }

}
