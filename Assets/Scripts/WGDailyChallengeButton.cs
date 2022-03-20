using UnityEngine;
public class WGDailyChallengeButton : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton Button_DailyChallenge;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Image iconImage;
    private UnityEngine.GameObject checkMark;
    private UnityEngine.Sprite sunIcon;
    private UnityEngine.Sprite moonIcon;
    private const string DAILY_CHALLENGE = "DAILY CHALLENGE";
    private bool inRequest;
    
    // Methods
    private void Awake()
    {
        var val_13;
        System.Action<Result> val_14;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -106400304, name:  -106451056);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -106400304, name:  1799422256);
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  -106400304, method:  new IntPtr(4188520464));
        this.Button_DailyChallenge.OnConnectionClick = null;
        string val_4 = Localization.Localize(key:  -1431416672, defaultValue:  -233820192, useSingularKey:  false);
        val_13 = 1152921504901201920;
        val_14 = 1152921511097403152;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2099378416) == 0)
        {
            goto label_11;
        }
        
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_14 = null;
        val_14 = new System.Action<Result>(object:  -106400304, method:  new IntPtr(4188525584));
        System.Delegate val_9 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_13 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_13 != 0)
        {
                if(val_13 == null)
        {
            goto label_17;
        }
        
        }
        
        val_13 = 0;
        label_17:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_13;
        label_11:
        if(this.iconImage != 0)
        {
                UnityEngine.GameObject val_11 = this.iconImage.gameObject;
            this.iconImage.SetActive(value:  false);
        }
        
        if(this.checkMark == 0)
        {
                return;
        }
        
        this.checkMark.SetActive(value:  false);
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.UpdateState();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -106263728);
    }
    private System.Collections.IEnumerator UpdateState()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeButton.<UpdateState>d__10).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeButton.<UpdateState>d__10).__il2cppRuntimeField_10 = this;
    }
    private void OnDestroy()
    {
        var val_10;
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
            goto label_4;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_4 = new System.Action<Result>(object:  -106038704, method:  new IntPtr(4188525584));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_10 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_10;
        }
        
        }
        
        val_10 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_10;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_9 = new System.Action<System.Boolean>(object:  -106038704, method:  new IntPtr(4188903568));
        UnregisterRequestCallback(callback:  7401472);
    }
    private void OnSceneLoaded(SceneType scene)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(scene != 1)
        {
                return;
        }
        
        if(this.activeSelf == false)
        {
                return;
        }
        
        this.UpdateButtonState();
    }
    private void OnClick_DailyChallenge()
    {
        if(this.inRequest == true)
        {
                return;
        }
        
        mem2[0] = 1;
        R4 + 12.WaitingStatus(waiting:  true);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(4188903568));
        RequestServerUpdate(callback:  7401472);
    }
    private void OnComplete(bool success)
    {
        var val_5;
        var val_6;
        FeatureAccessPoints val_7;
        this.inRequest = false;
        this.Button_DailyChallenge.WaitingStatus(waiting:  false);
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_2;
        }
        
        val_5 = 1152921504895770624;
        var val_5 = 28827463;
        val_5 = 6798328 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_7 = 5;
        goto label_6;
        label_2:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_7;
        }
        
        val_5 = 1152921504895770624;
        var val_6 = 28827351;
        val_6 = 6798440 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_7 = 8;
        label_6:
        AmplitudePluginHelper.lastFeatureAccessPoint = val_7;
        label_7:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnDailyChallengeDataUpdate()
    {
        this.UpdateButtonState();
    }
    private void UpdateButtonState()
    {
        var val_15;
        UnityEngine.Sprite val_16;
        UnityEngine.GameObject val_17;
        var val_18;
        val_15 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
            goto label_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(FeatureAvailable == false)
        {
            goto label_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CurrentLanguageSupported() == false)
        {
            goto label_13;
        }
        
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_14;
        }
        
        val_16 = this.sunIcon;
        this.iconImage.sprite = val_16;
        UnityEngine.GameObject val_8 = this.iconImage.gameObject;
        this.iconImage.SetActive(value:  true);
        val_17 = this.checkMark;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20];
        val_18 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20;
        goto label_22;
        label_13:
        UnityEngine.GameObject val_10 = this.Button_DailyChallenge.gameObject;
        this.Button_DailyChallenge.SetActive(value:  false);
        return;
        label_14:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_25;
        }
        
        val_16 = this.moonIcon;
        this.iconImage.sprite = val_16;
        UnityEngine.GameObject val_12 = this.iconImage.gameObject;
        this.iconImage.SetActive(value:  true);
        val_17 = this.checkMark;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24];
        val_18 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24;
        label_22:
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24 + 13) != 0)
        {
                val_15 = 1;
        }
        
        val_17.SetActive(value:  true);
        label_25:
        string val_14 = Localization.Localize(key:  -1431416672, defaultValue:  -233820192, useSingularKey:  false);
        if(this.buttonText == 0)
        {
            
        }
    
    }
    private string GetTimeStringToNextChallenge()
    {
        System.TimeSpan val_1 = WGDailyChallengeManagerHelper.GetTimeSpanToNextChallenge();
        string val_3 = ???.Hours.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_10 = ;
        typeof(System.String[]).__il2cppRuntimeField_14 = ":";
        string val_5 = ???.Minutes.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_18 = ;
        typeof(System.String[]).__il2cppRuntimeField_1C = ":";
        string val_7 = ???.Seconds.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_20 = ;
        string val_8 = +477709520;
    }
    private void OnLocalize()
    {
        this.UpdateButtonState();
    }
    public WGDailyChallengeButton()
    {
    
    }
    private void <Awake>b__8_0(bool success)
    {
        this.OnClick_DailyChallenge();
    }

}
