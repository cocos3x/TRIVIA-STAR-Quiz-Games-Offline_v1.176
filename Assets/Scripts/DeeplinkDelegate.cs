using UnityEngine;
public class DeeplinkDelegate : MonoSingleton<DeeplinkDelegate>
{
    // Fields
    private DeeplinkComponent deeplinkComponent;
    private bool isAsyncing;
    private System.Action sceneLoadedCallBack;
    private bool isShowingAward;
    
    // Properties
    public DeeplinkComponent DeeplinkComponent { get; set; }
    
    // Methods
    public DeeplinkComponent get_DeeplinkComponent()
    {
    
    }
    public void set_DeeplinkComponent(DeeplinkComponent value)
    {
        this.deeplinkComponent = value;
    }
    public override void InitMonoSingleton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1919869136);
        UnityEngine.GameObject val_2 = this.gameObject;
        this.name = -1919894368;
        Player val_3 = App.Player;
        if(2621448.ShouldShowGdprConsent() != false)
        {
                NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1919869136, name:  -1919894256);
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_6 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1919869136, method:  new IntPtr(2375073136));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void GDPRConsented()
    {
        this.QueryDeeplinkComponent();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if(this.sceneLoadedCallBack == 0)
        {
                return;
        }
        
        this.sceneLoadedCallBack.Invoke();
        this.sceneLoadedCallBack = 0;
    }
    private void OnDestroy()
    {
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  R4, name:  -1919540752);
    }
    private void Start()
    {
        this.QueryDeeplinkComponent();
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus == true)
        {
                return;
        }
        
        this.QueryDeeplinkComponent();
    }
    public void QueryDeeplinkComponent()
    {
        if(this.isAsyncing == true)
        {
                return;
        }
        
        mem2[0] = 1;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action val_2 = new System.Action(object:  R4, method:  new IntPtr(2375762656));
        Async(callback:  7454720, when:  null);
    }
    private void DoDeeplinkLogic()
    {
        float val_42;
        float val_43;
        var val_44;
        DeeplinkComponent val_46;
        var val_47;
        mem[1152921511277725936] = 0;
        if(this.deeplinkComponent.mustUpdate != false)
        {
                this.deeplinkComponent.mustUpdate = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_3 = DeeplinkDelegate.GetStoreURL();
            Setup(url:  2119322896, mustUpdate:  true);
            return;
        }
        
        val_42 = "";
        val_43 = "";
        if(this.deeplinkComponent.HasNotificationType != false)
        {
                string val_5 = this.deeplinkComponent.NotificationType;
            val_44 = this.deeplinkComponent;
        }
        else
        {
                val_44 = "";
        }
        
        if(this.deeplinkComponent.DequeueDeeplinkAction() == false)
        {
            goto label_13;
        }
        
        if(this.deeplinkComponent.HasNotificationType == false)
        {
            goto label_15;
        }
        
        string val_8 = this.deeplinkComponent.NotificationType;
        val_44 = this.deeplinkComponent;
        goto label_17;
        label_13:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleNoDeeplinkMinigame();
        goto label_21;
        label_15:
        val_44 = "";
        label_17:
        this.sceneLoadedCallBack = 0;
        this.deeplinkComponent.TrackDeeplinkParsed();
        if(this.deeplinkComponent.HasHelpshift != false)
        {
                WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ShowSupport(prefillText:  1098586544);
        }
        
        if(this.deeplinkComponent.HasLobby != false)
        {
                GameBehavior val_13 = App.getBehavior;
        }
        
        if(this.deeplinkComponent.HasOpenUrl != false)
        {
                string val_15 = this.deeplinkComponent.OpenUrl;
            UnityEngine.Application.OpenURL(url:  this.deeplinkComponent);
            this.deeplinkComponent.OpenUrl = null;
        }
        
        if(this.deeplinkComponent.HasNoAds != false)
        {
                if(this.deeplinkComponent.NoAdsDuration >= 1)
        {
                int val_18 = this.deeplinkComponent.NoAdsDuration;
            AdsManager.AddNoAdsCooldown(seconds:  null);
        }
        else
        {
                Player val_19 = App.Player;
            0.RemovedAds = true;
        }
        
        }
        
        if((this.deeplinkComponent.HasCurrentReward != false) && (this.isShowingAward != true))
        {
                System.Collections.IEnumerator val_21 = this.ShowAward();
            UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  -1919055648);
        }
        
        val_46 = this.deeplinkComponent;
        if(this.deeplinkComponent.HasDailyChallenge == true)
        {
                val_43 = "Daily_Challenge";
        }
        
        if(val_46.HasHint != false)
        {
                val_42 = 1152921504894173184;
            val_47 = null;
            val_43 = "Show_Hint";
            val_47 = null;
            val_46 = DeeplinkDelegate.<>c.<>9__13_0;
            if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Action(object:  DeeplinkDelegate.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2375885200));
            DeeplinkDelegate.<>c.<>9__13_0 = val_46;
        }
        
            this.sceneLoadedCallBack = val_46;
        }
        
        if(this.deeplinkComponent.HasInviteCode != false)
        {
                val_43 = "Invite_Code";
            string val_27 = this.deeplinkComponent.InviteCode;
            WGInviteManager.SafeSaveAndSend(installCodeParam:  this.deeplinkComponent);
        }
        
        if(this.deeplinkComponent.HasChallengeFriendCode != false)
        {
                val_42 = 1152921504901095424;
            val_43 = "Friend_Challenge";
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_46 = public static ChallengeFriendController MonoSingleton<ChallengeFriendController>::get_Instance();
            if((-1919080864) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_46 = public static ChallengeFriendController MonoSingleton<ChallengeFriendController>::get_Instance();
            string val_32 = this.deeplinkComponent.ChallengeFriendCode;
            HandleLinkerAppDeeplink(linkerUrlDataSerialized:  this.deeplinkComponent);
        }
        
        }
        
        if(this.deeplinkComponent.HasScene != false)
        {
                val_43 = "Load_Scene";
            System.Collections.IEnumerator val_34 = DelayedShowScene();
            UnityEngine.Coroutine val_35 = this.StartCoroutine(routine:  "Load_Scene");
        }
        else
        {
                if(this.deeplinkComponent.HasMiniGame != false)
        {
                val_43 = "Load_Minigame";
            twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleDeeplinkIntoMinigame(minigame:  this.deeplinkComponent.MiniGame);
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleNoDeeplinkMinigame();
        }
        
        }
        
        if(this.deeplinkComponent.HasForestNews != false)
        {
                WordForest.RaidAttackManager.HandleDeeplinkShowNews();
        }
        
        if(this.deeplinkComponent.HasPiggyBankRaid != false)
        {
                PiggyBankRaidEventHandler.HandleDeeplinkShowRaid();
        }
        
        this.deeplinkComponent.Consumed = true;
        label_21:
        TrackingComponent.TrackSession(sessionEnded:  false, quitButton:  false);
        TrackingComponent.TrackLogin(fromDeeplink:  -1919080976, notificationType:  1098586544);
    }
    private System.Collections.IEnumerator DelayedShowScene()
    {
        object val_1 = new System.Object();
        typeof(DeeplinkDelegate.<DelayedShowScene>d__14).__il2cppRuntimeField_8 = 0;
    }
    private System.Collections.IEnumerator ShowAward()
    {
        object val_1 = new System.Object();
        typeof(DeeplinkDelegate.<ShowAward>d__16).__il2cppRuntimeField_8 = 0;
        typeof(DeeplinkDelegate.<ShowAward>d__16).__il2cppRuntimeField_10 = this;
    }
    private static string GetStoreURL()
    {
        var val_2;
        var val_2 = 26851939;
        val_2 = 8775476 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        twelvegigs.storage.JsonDictionary val_1 = getUpdatePromptConfiguration();
        if(App.storageManager.knobsModel != 0)
        {
                return getString(key:  -1981328896, defaultValue:  1098586544);
        }
        
        return getString(key:  -1981328896, defaultValue:  1098586544);
    }
    public DeeplinkDelegate()
    {
    
    }

}
