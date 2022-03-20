using UnityEngine;
public class DifficultySettingManagerGameplay : MonoSingleton<DifficultySettingManagerGameplay>
{
    // Fields
    public bool ShouldShowGoldenApplesBonus;
    public int GoldenApplesAward;
    private GameLevel currentPlayingLevel;
    
    // Properties
    public static bool IsPlayingDifficultLevel { get; }
    public static int ApplesFromDifficulty { get; }
    
    // Methods
    public static bool get_IsPlayingDifficultLevel()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-1436585440) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static DifficultySettingManagerGameplay MonoSingleton<DifficultySettingManagerGameplay>::get_Instance().__il2cppRuntimeField_14 + 16) != 0)
        {
                val_5 = 1;
        }
        
        return true;
    }
    public static int get_ApplesFromDifficulty()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-1436585440) == 0)
        {
                return (int)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static DifficultySettingManagerGameplay MonoSingleton<DifficultySettingManagerGameplay>::get_Instance().__il2cppRuntimeField_14 + 20];
        val_5 = public static DifficultySettingManagerGameplay MonoSingleton<DifficultySettingManagerGameplay>::get_Instance().__il2cppRuntimeField_14 + 20;
        return (int)val_5;
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1436335392, method:  new IntPtr(2858606880));
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
    public void AwardExtraApples(int earnedAmount)
    {
        if(this.currentPlayingLevel.isChallengingLevel == true)
        {
                this.currentPlayingLevel.isChallengingLevel = this.currentPlayingLevel.goldenApplesExtraDifficulty;
            earnedAmount = this.currentPlayingLevel.isChallengingLevel + earnedAmount;
            this.currentPlayingLevel.goldenApplesExtraDifficulty = earnedAmount;
        }
    
    }
    private void OnSceneLoaded(SceneType sceneType)
    {
        if(sceneType != 2)
        {
                return;
        }
        
        35630983 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1436097056, method:  new IntPtr(2858844192));
        0.addOnLevelLoadedAction(callback:  7401472);
        WordRegion val_5 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1436097056, method:  new IntPtr(2858845216));
        0.addOnLevelCompleteAction(callback:  7401472);
    }
    private void OnLevelLoaded(GameLevel level)
    {
        var val_11;
        this.ShouldShowGoldenApplesBonus = false;
        this.currentPlayingLevel = level;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.currentPlayingLevel.isChallengingLevel != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = (public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 16 + 9) >> 5;
        }
        else
        {
                val_11 = 0;
        }
        
        mem2[0] = val_11;
        if(this.currentPlayingLevel.isChallengingLevel != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10.SaveToJSON();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowTooltip();
        }
        
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        if(0 != 104)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOnPromptLevel();
    }
    private void OnLevelComplete(GameLevel level)
    {
        GameLevel val_4 = 35630985;
        if(GoldenMultiplierManager.IsAvaialable == true)
        {
                return;
        }
        
        val_4 = this.currentPlayingLevel;
        if(this.currentPlayingLevel.goldenApplesExtraDifficulty == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = mem[public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 16];
        val_4 = public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 16;
        val_4 = this.currentPlayingLevel;
        if(this.currentPlayingLevel.isChallengingLevel == false)
        {
                return;
        }
        
        val_4 = this.currentPlayingLevel.goldenApplesExtraDifficulty;
        this.ShouldShowGoldenApplesBonus = true;
        level.goldenApplesExtraDifficulty = val_4;
        this.GoldenApplesAward = val_4;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void OnDestroy()
    {
        var val_5;
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -1435697568, method:  new IntPtr(2858606880));
        System.Delegate val_4 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_5 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_9;
        }
        
        }
        
        val_5 = 0;
        label_9:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_5;
    }
    public DifficultySettingManagerGameplay()
    {
    
    }

}
