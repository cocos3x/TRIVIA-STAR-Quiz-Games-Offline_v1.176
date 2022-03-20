using UnityEngine;
public class TRVExtraLifePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject rewardedVideoPopup;
    private UnityEngine.GameObject basicPopup;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button OGContinueButton;
    private UnityEngine.UI.Button getFreeLivesButton;
    private UnityEngine.UI.Text infoText;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Text extraLifeQuantityText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text OGinfoText;
    private UGUINetworkedButton extraLifeRewardedButton;
    private bool init;
    private HeyZapAdTag myTag;
    
    // Properties
    private int videosWatched { get; set; }
    
    // Methods
    private int get_videosWatched()
    {
        return CPlayerPrefs.GetInt(key:  -525258288, defaultValue:  0);
    }
    private void set_videosWatched(int value)
    {
        CPlayerPrefs.SetInt(key:  -525258288, val:  value);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -524968768, method:  new IntPtr(3769941280));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -524968768, method:  new IntPtr(3769941280));
        this.OGContinueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -524968768, method:  new IntPtr(3769958688));
        this.getFreeLivesButton.m_OnClick.AddListener(call:  162246656);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -524968768, name:  2128120864);
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -524968768, method:  new IntPtr(3769963808));
        this.extraLifeRewardedButton.OnConnectionClick = null;
        string val_6 = Localization.Localize(key:  1098586544, defaultValue:  -524998368, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -524993904, defaultValue:  -524994160, useSingularKey:  false);
        WordForest.WFOGameEcon val_8 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_9 = System.String.Format(format:  -524993904, arg0:  13152256);
        this.UpdatePopup();
        UnityEngine.GameObject val_10 = this.gameObject;
        UnityEngine.UI.LayoutElement val_11 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -524968768);
        System.Action val_12 = new System.Action(object:  -524968768, method:  new IntPtr(3769973504));
        if(this != 0)
        {
                this.OGContinueButton = null;
        }
        else
        {
                mem[24] = null;
        }
        
        this.continueButton = 10;
    }
    public void Init(bool rewardedPopup, HeyZapAdTag tag)
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = 35629619;
        if(this.myTag == 0)
        {
                this.myTag = tag;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        if(VideoAdsAllowed == false)
        {
            goto label_8;
        }
        
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_12 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        if(mem[1152921512476916280] == false)
        {
            goto label_8;
        }
        
        this.rewardedVideoPopup.SetActive(value:  rewardedPopup);
        this.basicPopup.SetActive(value:  rewardedPopup ^ 1);
        UnityEngine.GameObject val_5 = this.getFreeLivesButton.gameObject;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = 0;
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable()) == 0)
        {
                WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_12 = VideoEnabledAndUnlocked();
        }
        
        val_13 = val_12;
        goto label_21;
        label_8:
        this.rewardedVideoPopup.SetActive(value:  false);
        this.basicPopup.SetActive(value:  true);
        UnityEngine.GameObject val_10 = this.getFreeLivesButton.gameObject;
        val_13 = 0;
        label_21:
        this.getFreeLivesButton.SetActive(value:  false);
        this.init = true;
    }
    public void OnFreeHintClick(bool result)
    {
        var val_15;
        int val_16;
        TRVExtraLifePopup val_17;
        TRVExtraLifePopup val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        if(result == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowIncentivizedVideo(tag:  this.myTag, adCapExempt:  false)) == false)
        {
            goto label_5;
        }
        
        return;
        label_1:
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_15 = 0;
        if(val_15 == 0)
        {
                val_15 = 0;
        }
        
        val_15.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_16}, collectType:  "credits");
        val_20 = this;
        string val_8 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        val_21 = 0;
        goto label_24;
        label_5:
        GameBehavior val_9 = App.getBehavior;
        string val_11 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_12 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_20 = null;
        string val_13 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_22 = null;
        val_23 = "no_videos_explanation";
        val_24 = 0;
        val_16 = System.Decimal.MinusOne;
        if( == 0)
        {
                val_24 = 0;
        }
        
        val_24.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  val_20, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_16}, collectType:  "credits");
        val_17 = this;
        string val_14 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        val_21 = 1;
        label_24:
        mem[1152921512672143348].interactable = true;
    }
    private void OnContinueClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -524522176, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnGetLivesClicked()
    {
        this.rewardedVideoPopup.SetActive(value:  true);
        this.basicPopup.SetActive(value:  false);
    }
    private void OnVideoResponse(Notification notif)
    {
        var val_19;
        float val_20;
        float val_21;
        var val_22;
        var val_23;
        decimal val_24;
        val_19 = this;
        string val_1 = notif.data.ToString();
        bool val_2 = System.Boolean.Parse(value:  notif.data);
        if(val_2 == false)
        {
            goto label_6;
        }
        
        int val_3 = val_2.videosWatched;
        val_3.videosWatched = val_3 + 1;
        val_20 = 1152921504892043264;
        val_21 = 1152921512476914864;
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(val_3.videosWatched >= mem[1152921512476916236])
        {
            goto label_10;
        }
        
        CPlayerPrefs.Save();
        goto label_13;
        label_6:
        GameBehavior val_7 = App.getBehavior;
        string val_9 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        val_21 = "unavailable_upper";
        string val_10 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_11 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_22 = "no_videos_explanation";
        val_23 = 0;
        val_24 = System.Decimal.MinusOne;
        if(val_23 == 0)
        {
                val_23 = 0;
        }
        
        val_23.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_24}, collectType:  "credits");
        return;
        label_10:
        mem[1152921512476916236].videosWatched = 0;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.AddFreeLife(addExtraLife:  false);
        Player val_13 = App.Player;
        val_24 = this.myTag;
        val_22 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        0.TrackNonCoinReward(source:  289402880, subSource:  null, rewardType:  -524297600, rewardAmount:  "1", additionalParams:  0);
        GameBehavior val_14 = App.getBehavior;
        label_13:
        this.UpdateTimerText();
        this.UpdatePopup();
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordForest.WFOGameEcon val_18 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable()) < mem[1152921512476916276])
        {
                return;
        }
        
        this.OnContinueClicked();
    }
    private void UpdatePopup()
    {
        var val_13;
        string val_1 = Localization.Localize(key:  -524176288, defaultValue:  -524176176, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -524167728, defaultValue:  -524167840, useSingularKey:  false);
        int val_3 = videosWatched;
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_5 = System.String.Format(format:  -524167728, arg0:  13152256, arg1:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable().ToString();
        val_13;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordForest.WFOGameEcon val_11 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable()) < mem[1152921512476916276])
        {
                return;
        }
        
        string val_12 = Localization.Localize(key:  -524163424, defaultValue:  -524163536, useSingularKey:  false);
        val_13 = "max_lives_reached_upper";
        this.extraLifeRewardedButton.interactable = false;
    }
    private void UpdateTimerText()
    {
        ulong val_11;
        long val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.freeLifeAvailable) != false)
        {
                UnityEngine.GameObject val_3 = this.timerText.gameObject;
            this.timerText.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.gameObject;
            UnityEngine.UI.LayoutElement val_5 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -523994208);
            this.enabled = false;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_7 = freeLifeAvailableAt;
        System.DateTime val_8 = ServerHandler.ServerTime;
        System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512672775320}, d2:  new System.DateTime() {dateData = val_11});
        string val_16 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_14}, formatted:  true);
        string val_17 = Localization.Localize(key:  -524018528, defaultValue:  -524018416, useSingularKey:  false);
        string val_18 = System.String.Format(format:  -524018304, arg0:  val_14, arg1:  -524018528);
        if(this.timerText != 0)
        {
                return;
        }
    
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -523878112, name:  2128120864);
    }
    public TRVExtraLifePopup()
    {
    
    }

}
