using UnityEngine;
public class TRVQuestionComplete : MonoBehaviour
{
    // Fields
    public static int lastLevelShownAnim;
    private UnityEngine.UI.Button nextQuestionButton;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button gemButton;
    private UnityEngine.UI.Button freeCoinButton;
    private UnityEngine.UI.Button buyExtraLifeButton;
    private UnityEngine.UI.Button endQuizButton;
    private UnityEngine.UI.Button howToPlayButton;
    private UnityEngine.UI.Button removeAdsButton;
    private UnityEngine.UI.Button expertsButton;
    private TournamentsButton tournamentsButton;
    private UnityEngine.UI.Text playButtonText;
    private UnityEngine.UI.Text levelProgressText;
    private UnityEngine.UI.Text extraLifeCostText;
    private System.Collections.Generic.List<TRVQuizProgressIcon> progressIcons;
    private TRVExtraLifeButton extraLifeButton;
    private UnityEngine.Transform quizProgressParent;
    private UnityEngine.Transform quizLevelDisplay;
    private TRVQuizProgressIcon progressIconPrefab;
    private UnityEngine.UI.VerticalLayoutGroup parentLayoutGroup;
    private UnityEngine.ParticleSystem quizCompleteParticle;
    private SLC.Social.Leagues.LeaguesEntryButton entryButton;
    private UnityEngine.UI.Image chestImage;
    private UnityEngine.Sprite bronzeChest;
    private UnityEngine.Sprite silverChest;
    private UnityEngine.Sprite goldenChest;
    private UnityEngine.UI.Text coinRewardText;
    private UnityEngine.GameObject upgradeArrow;
    private UnityEngine.GameObject threeQuestionSpacing;
    
    // Methods
    private void OnEnable()
    {
        System.Action<System.Boolean> val_28;
        var val_29;
        System.Action val_31;
        System.Action<System.Boolean> val_32;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -456261152, method:  new IntPtr(3838592032));
        this.nextQuestionButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -456261152, method:  new IntPtr(3838592032));
        this.endQuizButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -456261152, method:  new IntPtr(3838609440));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -456261152, method:  new IntPtr(3838618656));
        this.gemButton.m_OnClick.AddListener(call:  162246656);
        if(this.tournamentsButton == 0)
        {
            goto label_11;
        }
        
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -456261152, method:  new IntPtr(3838631968));
        System.Delegate val_7 = System.Delegate.Combine(a:  this.tournamentsButton.ExternalClickCallback, b:  7401472);
        val_28 = this.tournamentsButton.ExternalClickCallback;
        if(val_28 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_28 = 0;
        label_15:
        this.tournamentsButton.ExternalClickCallback = val_28;
        label_11:
        this.Setup();
        twelvegigs.Autopilot.WUTAutopilotGameplay val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -456261152);
        this.alpha = null;
        System.Collections.IEnumerator val_9 = this.redraw();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -456261152);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_12 = App.Player;
        GameEcon val_13 = App.getGameEcon;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  5614709)) != false)
        {
                System.Action val_15 = new System.Action(object:  -456261152, method:  new IntPtr(3838637088));
            this.entryButton.onLeaguesEntryAction = null;
            val_29 = null;
            val_29 = null;
            val_31 = TRVQuestionComplete.<>c.<>9__29_1;
            if(val_31 == 0)
        {
                val_31 = null;
            val_31 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3838642208));
            TRVQuestionComplete.<>c.<>9__29_1 = val_31;
        }
        
            this.entryButton.onExitLeaguesAction = val_31;
        }
        
        System.Action<System.Boolean> val_18 = new System.Action<System.Boolean>(object:  -456261152, method:  new IntPtr(3838663712));
        System.Delegate val_19 = System.Delegate.Combine(a:  this.extraLifeButton.ExtraLifeStateChange, b:  7401472);
        val_32 = this.extraLifeButton.ExtraLifeStateChange;
        if(val_32 != 0)
        {
                if(null == null)
        {
            goto label_45;
        }
        
        }
        
        val_32 = 0;
        label_45:
        this.extraLifeButton.ExtraLifeStateChange = val_32;
        Player val_20 = App.Player;
        WordForest.WFOGameEcon val_21 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916272])) != false)
        {
                UnityEngine.GameObject val_23 = this.upgradeArrow.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.upgradeArrow.SetActive(value:  AnyExpertReadyToUpgrade());
            UnityEngine.Events.UnityAction val_26 = new UnityEngine.Events.UnityAction(object:  -456261152, method:  new IntPtr(3838677024));
            this.expertsButton.m_OnClick.AddListener(call:  162246656);
            return;
        }
        
        UnityEngine.GameObject val_27 = this.expertsButton.gameObject;
        this.expertsButton.SetActive(value:  false);
    }
    public void Setup()
    {
        float val_58;
        float val_59;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        val_58 = 1152921504901095424;
        val_59 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.SetChestSprite();
        int val_2 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswers;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlayingChallenge != false)
        {
                string val_5 = System.Environment.NewLine;
            string val_6 = System.String.Format(format:  -456078944, arg0:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8, arg1:  0);
            if(this.levelProgressText != 0)
        {
            goto label_34;
        }
        
        }
        else
        {
                string val_7 = Localization.Localize(key:  -2116031904, defaultValue:  -2116031984, useSingularKey:  false);
            string val_8 = System.Environment.NewLine;
            string val_9 = System.String.Format(format:  -1183154368, arg0:  -2116031904, arg1:  0, arg2:  13152256);
            val_59 = 1152921511548963376;
        }
        
        label_34:
        WordForest.WFOGameEcon val_15 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_17 = mem[1152921512476916292] + 12.GetQuizBaseReward().ToString();
        this.PopulateQuizProgressIcons();
        this.InformQuizProgressIcons();
        UnityEngine.GameObject val_18 = this.extraLifeButton.gameObject;
        this.extraLifeButton.SetActive(value:  true);
        UnityEngine.GameObject val_19 = this.freeCoinButton.gameObject;
        WordPets.WPTDataParser val_20 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        this.freeCoinButton.SetActive(value:  VideoEnabledAndUnlocked());
        UnityEngine.GameObject val_22 = this.buyExtraLifeButton.gameObject;
        this.buyExtraLifeButton.SetActive(value:  false);
        UnityEngine.GameObject val_23 = this.endQuizButton.gameObject;
        this.endQuizButton.SetActive(value:  false);
        UnityEngine.GameObject val_24 = this.nextQuestionButton.gameObject;
        this.nextQuestionButton.SetActive(value:  false);
        UnityEngine.GameObject val_25 = this.removeAdsButton.gameObject;
        this.removeAdsButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.IsPlaying()) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  1, trackIndex:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_63 = 0;
        int val_30 = getQuizLength;
        System.Collections.Generic.List<TRVQuestionHistory> val_31 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswerData;
        int val_32 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswers;
        int val_33 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswers;
        val_63 = mem[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 40];
        val_63 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 40;
        val_58 = 1152921504901095424;
        val_59 = 1152921511548963376;
        if(val_63 == 0)
        {
                val_64 = mem[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 24 + 12];
            val_64 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 24 + 12;
            val_65 = val_64;
             =  - 1;
            if( <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        }
        
        val_66 = "NEXT QUESTION";
        val_67 = "next_question_upper";
        string val_40 = Localization.Localize(key:  -456012592, defaultValue:  -456012688, useSingularKey:  false);
        UnityEngine.GameObject val_41 = this.nextQuestionButton.gameObject;
        val_68 = 1;
        this.nextQuestionButton.SetActive(value:  true);
        this.freeCoinButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_42 = new UnityEngine.Events.UnityAction(object:  -455890080, method:  new IntPtr(3838979392));
        this.freeCoinButton.m_OnClick.AddListener(call:  162246656);
        ButtonClickedEvent val_43 = this.extraLifeButton.onClick;
        this.extraLifeButton.RemoveAllListeners();
        ButtonClickedEvent val_44 = this.extraLifeButton.onClick;
        UnityEngine.Events.UnityAction val_45 = new UnityEngine.Events.UnityAction(object:  -455890080, method:  new IntPtr(3838988608));
        this.extraLifeButton.AddListener(call:  162246656);
        this.howToPlayButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_46 = new UnityEngine.Events.UnityAction(object:  -455890080, method:  new IntPtr(3839006016));
        this.howToPlayButton.m_OnClick.AddListener(call:  162246656);
        this.removeAdsButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_47 = new UnityEngine.Events.UnityAction(object:  -455890080, method:  new IntPtr(3839023424));
        this.removeAdsButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_48 = this.extraLifeCostText.gameObject;
        twelvegigs.Autopilot.AutopilotManager val_49 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.extraLifeCostText.SetActive(value:  freeLifeAvailable ^ 1);
        WordForest.WFOGameEcon val_52 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_53 = ToString();
        this.SetupRemoveAdsButton();
        if(this.threeQuestionSpacing == 0)
        {
                return;
        }
        
        this.threeQuestionSpacing.SetActive(value:  ((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 12 - 3)) >> 5);
    }
    private System.Collections.IEnumerator redraw()
    {
        object val_1 = new System.Object();
        typeof(TRVQuestionComplete.<redraw>d__31).__il2cppRuntimeField_8 = 0;
        typeof(TRVQuestionComplete.<redraw>d__31).__il2cppRuntimeField_10 = this;
    }
    private void SetupRemoveAdsButton()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 < 786450)
        {
            goto label_5;
        }
        
        Player val_3 = App.Player;
        if(0.RemovedAds == false)
        {
            goto label_9;
        }
        
        label_5:
        UnityEngine.GameObject val_5 = this.howToPlayButton.gameObject;
        this.howToPlayButton.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.removeAdsButton.gameObject;
        this.removeAdsButton.SetActive(value:  false);
        return;
        label_9:
        UnityEngine.GameObject val_7 = this.removeAdsButton.gameObject;
        this.removeAdsButton.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.howToPlayButton.gameObject;
        this.howToPlayButton.SetActive(value:  false);
        UnityEngine.GameObject val_9 = this.removeAdsButton.gameObject;
        UnityEngine.Transform val_10 = this.removeAdsButton.transform;
        UnityEngine.GameObject val_11 = this.howToPlayButton.gameObject;
        UnityEngine.Transform val_12 = this.howToPlayButton.transform;
        UnityEngine.Vector3 val_13 = position;
        this.removeAdsButton.position = new UnityEngine.Vector3();
    }
    private void OnClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ConcludeQuestionComplete();
        this.Close();
    }
    public void OnClickHome()
    {
        var val_4;
        System.Action val_6;
        GameBehavior val_1 = App.getBehavior;
        val_4 = null;
        val_4 = null;
        val_6 = TRVQuestionComplete.<>c.<>9__34_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3839714208));
            TRVQuestionComplete.<>c.<>9__34_0 = val_6;
        }
        
        mem[96] = val_6;
        this.Close();
    }
    private void OnClickCoinBalance()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 23593433;
        val_5 = 12032628 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 87;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = TRVQuestionComplete.<>c.<>9__35_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3839827232));
            TRVQuestionComplete.<>c.<>9__35_0 = val_8;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void OnClickGemBalance()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_6 = 23592701;
        val_6 = 12033360 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 87;
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = TRVQuestionComplete.<>c.<>9__36_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3839940256));
            TRVQuestionComplete.<>c.<>9__36_0 = val_9;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void OnClickExpertsButton()
    {
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = TRVQuestionComplete.<>c.<>9__37_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3840053280));
            TRVQuestionComplete.<>c.<>9__37_0 = val_8;
        }
        
        mem[20] = val_8;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void OnClickRemoveAds()
    {
        var val_7;
        var val_8;
        System.Action val_10;
        var val_7 = 23591457;
        val_7 = 12034604 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        PurchaseProxy.currentPurchasePoint = 90;
        GameBehavior val_1 = App.getBehavior;
        WGAdsControlPopup val_3 = 0.InitEntryTag(tag:  30);
        object val_4 = 0.GetComponent<System.Object>();
        val_8 = null;
        val_8 = null;
        val_10 = TRVQuestionComplete.<>c.<>9__38_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3840166304));
            TRVQuestionComplete.<>c.<>9__38_0 = val_10;
        }
        
        mem[20] = val_10;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void OnClickExtraLife()
    {
        var val_8;
        System.Action val_10;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916280] == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                0.Init(rewardedPopup:  true, tag:  45);
        }
        else
        {
                0.Init(rewardedPopup:  true, tag:  45);
        }
        
        object val_4 = 0.GetComponent<System.Object>();
        val_8 = null;
        val_8 = null;
        val_10 = TRVQuestionComplete.<>c.<>9__39_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3840279328));
            TRVQuestionComplete.<>c.<>9__39_0 = val_10;
        }
        
        mem[20] = val_10;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -454662944, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickWatchVideo()
    {
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = TRVQuestionComplete.<>c.<>9__40_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3840392352));
            TRVQuestionComplete.<>c.<>9__40_0 = val_8;
        }
        
        mem[20] = val_8;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void OnClickHowToPlay()
    {
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = TRVQuestionComplete.<>c.<>9__41_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3840506544));
            TRVQuestionComplete.<>c.<>9__41_0 = val_8;
        }
        
        mem[20] = val_8;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        this.Close();
    }
    private void PopulateQuizProgressIcons()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.progressIcons = null;
        val_5 = 0;
        this.quizLevelDisplay.SetSiblingIndex(index:  2);
    }
    private void InformQuizProgressIcons()
    {
        float val_7;
        var val_8;
        bool val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.progressIcons == 0)
        {
                return;
        }
        
        val_7 = 0;
        val_8 = 4;
        goto label_8;
        label_32:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.Generic.List<TRVQuestionHistory> val_2 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswerData;
        System.Collections.Generic.List<TRVQuestionHistory> val_3 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswerData;
        System.Collections.Generic.List<TRVQuestionHistory> val_4 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswerData;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.Generic.List<TRVQuestionHistory> val_5 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswerData;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_9 = (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8) >> 5;
        3.673424E-39f.SetupIcon(history:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8 + 16, firstQuestion:  val_9, highlightMe:  false);
        val_7 = val_7;
        val_8 = 5;
        label_8:
        if((val_8 - 4) < (3.673424E-39f))
        {
            goto label_32;
        }
    
    }
    private void SetChestSprite()
    {
        UnityEngine.UI.Image val_3;
        UnityEngine.Sprite val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 52) != 0)
        {
                return;
        }
        
        val_3 = mem[R4 + 96];
        val_3 = R4 + 96;
        val_4 = mem[R4 + 100];
        val_4 = R4 + 100;
        sprite = ;
    }
    private void Close()
    {
        TRVExtraLifeButton val_7;
        System.Action<System.Boolean> val_8;
        System.Action<System.Boolean> val_9;
        System.Action<System.Boolean> val_10;
        val_7 = this.extraLifeButton;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -453865872, method:  new IntPtr(3838663712));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.extraLifeButton.ExtraLifeStateChange, value:  7401472);
        val_9 = this.extraLifeButton.ExtraLifeStateChange;
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_9 = 0;
        label_4:
        this.extraLifeButton.ExtraLifeStateChange = val_9;
        if(this.tournamentsButton == 0)
        {
            goto label_7;
        }
        
        val_7 = this.tournamentsButton;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -453865872, method:  new IntPtr(3838631968));
        System.Delegate val_5 = System.Delegate.Remove(source:  this.tournamentsButton.ExternalClickCallback, value:  7401472);
        val_10 = this.tournamentsButton.ExternalClickCallback;
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_10 = 0;
        label_11:
        this.tournamentsButton.ExternalClickCallback = val_10;
        label_7:
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  -453865872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void RedrawExtraLife(bool available)
    {
        this.Setup();
    }
    private void OnTournamentsClicked(bool isConnected)
    {
        var val_14;
        System.Action val_16;
        var val_17;
        System.Action val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        var val_21;
        if(isConnected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_2 = App.getBehavior;
            object val_4 = 0.GetComponent<System.Object>();
            val_14 = null;
            val_14 = null;
            val_16 = TRVQuestionComplete.<>c.<>9__47_0;
            if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Action(object:  TRVQuestionComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3841321904));
            TRVQuestionComplete.<>c.<>9__47_0 = val_16;
        }
        
            mem[20] = val_16;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
            this.Close();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = PlaceGameObject<System.Object>(loc:  0);
        val_17 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_18 = 0;
        UnityEngine.GameObject val_9 = this.tournamentsButton.gameObject;
        val_19 = this.tournamentsButton;
        val_20 = "tournament_connection";
        val_21 = "Internet connection required. Please check your connection and try again!";
        string val_13 = Localization.Localize(key:  -509555936, defaultValue:  -1671479392, useSingularKey:  false);
        ShowToolTip(objToToolTip:  null, text:  -509555936, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
    }
    public TRVQuestionComplete()
    {
    
    }
    private static TRVQuestionComplete()
    {
        TRVQuestionComplete.lastLevelShownAnim = 0;
    }
    private void <OnEnable>b__29_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -453267984, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
