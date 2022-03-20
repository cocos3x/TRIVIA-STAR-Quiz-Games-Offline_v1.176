using UnityEngine;
public class WGChallengeProgressDisplay : MonoBehaviour
{
    // Fields
    private WGChallengeDefinition.PerChallengeInfo myInfo;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Text buttonCoinValueText;
    private UnityEngine.UI.Image challengeImage;
    private UnityEngine.UI.Image progressBar;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Text challengeNameText;
    private UnityEngine.GameObject fillBarParentObject;
    private bool inRequest;
    private UGUINetworkedButton challenge_Button;
    private UnityEngine.Transform parentPopup;
    
    // Properties
    public ChallengeType getType { get; }
    public UnityEngine.UI.Button getButton { get; }
    
    // Methods
    public ChallengeType get_getType()
    {
        if(this.myInfo != 0)
        {
                return;
        }
    
    }
    public UnityEngine.UI.Button get_getButton()
    {
    
    }
    public void Init(ChallengeTask myDatas, UnityEngine.Transform myPopup, WGChallengeDefinition.PerChallengeInfo incInfo)
    {
        WGChallengeDefinition.PerChallengeInfo val_27;
        UGUINetworkedButton val_28;
        var val_29;
        System.Action<System.Boolean> val_30;
        var val_31;
        this.parentPopup = myPopup;
        this.myInfo = incInfo;
        UnityEngine.GameObject val_1 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  myDatas.isComplete());
        this.fillBarParentObject.SetActive(value:  myDatas.isComplete() ^ 1);
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_6 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_20.ToString();
        this.challengeImage.sprite = this.myInfo.image;
        val_27 = this.myInfo;
        if(this.myInfo != 0)
        {
            goto label_12;
        }
        
        val_27 = this.myInfo;
        if(val_27 == 0)
        {
            goto label_13;
        }
        
        label_12:
        string val_7 = Localization.Localize(key:  this.myInfo.displayNameLocKey, defaultValue:  this.myInfo.displayName, useSingularKey:  false);
        this.progressBar.fillAmount = myDatas.getPercent();
        string val_9 = System.String.Format(format:  1629069648, arg0:  10170368, arg1:  10170368);
        UnityEngine.GameObject val_10 = this.challenge_Button.gameObject;
        val_28 = this.challenge_Button;
        if(this.myInfo.usesButton == true)
        {
                val_29 = 1;
        }
        
        val_28.SetActive(value:  true);
        if(myDatas.id == 3)
        {
                UnityEngine.GameObject val_11 = this.challenge_Button.gameObject;
            this.challenge_Button.SetActive(value:  false);
            val_28 = 1152921504901095424;
            val_29 = 1152921511080275808;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(FeatureAvailable == false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2116505760) == 0)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
        {
                return;
        }
        
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != true)
        {
                if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
                return;
        }
        
        }
        
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_22 = this.challenge_Button.gameObject;
            this.challenge_Button.SetActive(value:  true);
        }
        
            if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_25 = this.challenge_Button.gameObject;
            this.challenge_Button.SetActive(value:  true);
        }
        
            val_28 = this.challenge_Button;
            val_30 = null;
            val_31 = 1152921511601942112;
        }
        else
        {
                if(myDatas.subject != 5)
        {
                if(myDatas.subject != 4)
        {
                return;
        }
        
            val_28 = this.challenge_Button;
            val_30 = null;
            val_31 = 1152921511601951328;
        }
        else
        {
                val_28 = this.challenge_Button;
            val_30 = null;
            val_31 = 1152921511601956448;
        }
        
        }
        
        val_30 = new System.Action<System.Boolean>(object:  -1594800096, method:  new IntPtr(2700142176));
        this.challenge_Button.OnConnectionClick = val_30;
        return;
        label_13:
    }
    private void OnDailyChallengePressed(bool connected)
    {
        if(connected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(FeatureAvailable == false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2116505760) == 0)
        {
                return;
        }
        
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
            if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.inRequest == true)
        {
                return;
        }
        
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_11 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(2700357600));
            R7.RequestServerUpdate(callback:  7401472);
            return;
        }
        
        this.ShowInternetConnection();
    }
    private void OnTwitterButtonPressed(bool connected)
    {
        if(connected != false)
        {
                AppConfigs val_1 = App.Configuration;
            AppConfigs val_2 = App.Configuration;
            twelvegigs.plugins.SharePlugin.ShareTwitter(message:  486549504, url:  872742914);
            TrackingComponent.CurrentIntent = 9;
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnTweetSent();
        }
        
            object val_6 = this.parentPopup.GetComponent<System.Object>();
            this.parentPopup.SetupUI();
            return;
        }
        
        this.ShowInternetConnection();
    }
    private void OnShareButtonPressed(bool connected)
    {
        if(connected != false)
        {
                WGInvite val_1 = WGInviteManager.ShowInvitePopup(status:  0);
            UnityEngine.GameObject val_2 = this.parentPopup.gameObject;
            SLCWindow.CloseWindow(window:  this.parentPopup, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        this.ShowInternetConnection();
    }
    private void ShowInternetConnection()
    {
        var val_8;
        WGChallengeProgressDisplay val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_8 = null;
        val_9 = this;
        val_11 = WGChallengeProgressDisplay.<>c.<>9__19_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  WGChallengeProgressDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2700712032));
            WGChallengeProgressDisplay.<>c.<>9__19_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        UnityEngine.GameObject val_7 = mem[1152921511602551380].gameObject;
        SLCWindow.CloseWindow(window:  mem[1152921511602551380], setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnComplete(bool success)
    {
        this.inRequest = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_3 = this.parentPopup.gameObject;
        SLCWindow.CloseWindow(window:  this.parentPopup, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGChallengeProgressDisplay()
    {
    
    }

}
