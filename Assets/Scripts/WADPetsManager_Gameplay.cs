using UnityEngine;
public class WADPetsManager_Gameplay : MonoSingleton<WADPetsManager_Gameplay>
{
    // Methods
    private void OnSceneLoaded(SceneType sceneType)
    {
        if(sceneType != 2)
        {
                return;
        }
        
        35639888 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -964185392, method:  new IntPtr(3330756880));
        0.addOnLevelCompleteAction(callback:  7401472);
    }
    private void OnSceneUnloaded(SceneType sceneType)
    {
    
    }
    private void OnLevelComplete(GameLevel level)
    {
        GameLevel val_12 = level;
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  2);
        if((2 != 0) && (2.IsActive() != false))
        {
                val_12 = level.goldenApplesStreaks;
            float val_3 = WADPetsManager.GetLevelCurveModifier(ability:  2);
            float val_12 = (float)val_12;
            val_12 = 2 * val_12;
            int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_12);
            mem[30] = (float)val_4;
            if(val_4 >= 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            val_12 = 0;
            System.Collections.Hashtable val_7 = new System.Collections.Hashtable();
            if(NotificationCenter.__il2cppRuntimeField_cctor_finished == 0)
        {
                -D16 = -(-D16);
        }
        
            val_12.PostNotification(aSender:  -963944768, aName:  -963968912, aData:  75878400);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResetPetStats();
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SaveLevelTrackingInfo();
    }
    private void OnPetAlphabetTileSpawned()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        WADPets.WADPet val_2 = WADPetsManager.GetPetByAbility(ability:  3);
        if(3.IsActive() == false)
        {
                return;
        }
        
        if(0 != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = GetWindow<System.Object>();
        if(isActiveAndEnabled != false)
        {
                AddPetAlphabetTileFtux(pet:  R4);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
        WADPets.WADPet val_9 = WADPetsManager.GetPetByAbility(ability:  3);
        AddPetAlphabetTileFtux(pet:  3);
    }
    private void OnAlphabetTileCollected()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Tracking_GainedBonusAlphabetTile();
    }
    private void OnVideoResponse(Notification notif)
    {
        if(notif != 0)
        {
                true = notif.data;
        }
        
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        WADPets.WADPet val_3 = WADPetsManager.GetPetByAbility(ability:  4);
        if(4 == 0)
        {
                return;
        }
        
        if(4.IsActive() == false)
        {
                return;
        }
        
        float val_5 = WADPetsManager.GetLevelCurveModifier(ability:  4);
        mem2[0] = 4;
    }
    public override void InitMonoSingleton()
    {
        var val_8;
        var val_9;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -963464000, method:  new IntPtr(3331477248));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_6;
        }
        
        }
        
        val_8 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -963464000, method:  new IntPtr(3331478272));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_10;
        }
        
        }
        
        val_9 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_9;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -963464000, name:  2128120864);
    }
    private void Start()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -963349952, method:  new IntPtr(3331591296));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_7C, b:  7454720);
        val_10 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_7C;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_11;
        }
        
        }
        
        val_10 = 0;
        label_11:
        public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_7C = val_10;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_7 = new System.Action(object:  -963349952, method:  new IntPtr(3331592320));
        System.Delegate val_8 = System.Delegate.Combine(a:  public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_74, b:  7454720);
        val_11 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_74;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_15;
        }
        
        }
        
        val_11 = 0;
        label_15:
        public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_74 = val_11;
    }
    private void TrackFreeHints()
    {
        Prefs.UsedHint(free:  true);
    }
    public WADPetsManager_Gameplay()
    {
    
    }

}
