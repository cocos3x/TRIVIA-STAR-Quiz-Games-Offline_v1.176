using UnityEngine;
public class WFOLevelClearPopup : WGLevelClearPopup
{
    // Fields
    private UnityEngine.CanvasGroup topBarCanvasGroup;
    private UnityEngine.UI.Button buttonStore;
    private WordForest.WFOShieldStatView statViewShield;
    private UnityEngine.CanvasGroup secondaryBarAcornsCanvasGroup;
    private UnityEngine.UI.Text secondaryBarAcornsLabel;
    private UnityEngine.UI.Text secondaryBarAcornMultiplierLabel;
    private UnityEngine.CanvasGroup bottomRowCanvasGroup;
    private UnityEngine.CanvasGroup containerTotalAcornsEarned;
    private UnityEngine.UI.Text labelTotalAcornsEarned;
    private UnityEngine.UI.Button buttonForests;
    private UnityEngine.CanvasGroup badgeForests;
    private UnityEngine.GameObject forestTooltip;
    private UnityEngine.UI.Text buttonForestsText;
    private UnityEngine.UI.Text badgeLabelForests;
    private UnityEngine.UI.Image imageTreesLeft;
    private UnityEngine.UI.Image imageTreesRight;
    private UnityEngine.CanvasGroup progressBarRootCanvasGroup;
    private UnityEngine.CanvasGroup progressBarCanvasGroup;
    private UnityEngine.Transform progressBarRays;
    private UnityEngine.Transform progressBarGiftBox;
    private EventButtonPanel eventProgressPanel;
    private EventButtonPanel eventButtonPanel;
    protected CurrencyParticles acornFlyParticles;
    private UnityEngine.UI.Text buttonContinueText;
    private UnityEngine.UI.Button buttonCollect;
    private SLC.Social.Leagues.LeaguesEntryButton buttonLeagues;
    private UnityEngine.UI.Text levelClearText;
    private UnityEngine.Transform titleTopper;
    private UnityEngine.Transform titleFrame;
    private bool startAnimsPlayed;
    
    // Properties
    private bool IsAcornSufficientToGrowForest { get; }
    public EventButtonPanel EventButtonPanel { get; }
    
    // Methods
    private bool get_IsAcornSufficientToGrowForest()
    {
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(4 >= CurrentGrowthCost)
        {
                0 = 1;
        }
        
        return true;
    }
    public EventButtonPanel get_EventButtonPanel()
    {
    
    }
    protected override void Start()
    {
        System.Action val_10;
        UnityEngine.Events.UnityAction val_11;
        System.Action val_12;
        System.Action val_13;
        this.Start();
        if(this.buttonLeagues == 0)
        {
            goto label_3;
        }
        
        System.Action val_2 = new System.Action(object:  R6, method:  new IntPtr(3921955600));
        System.Delegate val_3 = System.Delegate.Combine(a:  this.buttonLeagues.onLeaguesEntryAction, b:  7454720);
        val_10 = this.buttonLeagues.onLeaguesEntryAction;
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_10 = 0;
        label_7:
        this.buttonLeagues.onLeaguesEntryAction = val_10;
        val_12 = null;
        val_12 = new System.Action(object:  R6, method:  new IntPtr(3921964816));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.buttonLeagues.onExitLeaguesAction, b:  7454720);
        val_13 = this.buttonLeagues.onExitLeaguesAction;
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_13 = 0;
        label_11:
        this.buttonLeagues.onExitLeaguesAction = val_13;
        label_3:
        if(this.buttonStore != 0)
        {
                this.buttonStore.m_OnClick.RemoveAllListeners();
            val_11 = null;
            val_11 = new UnityEngine.Events.UnityAction(object:  7454720, method:  new IntPtr(3921986320));
            this.buttonStore.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.statViewShield == 0)
        {
                return;
        }
        
        this.statViewShield.button.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  162246656, method:  new IntPtr(3922016016));
        this.statViewShield.button.m_OnClick.AddListener(call:  162246656);
    }
    protected override void UpdateUI()
    {
        float val_62;
        bool val_69;
        var val_70;
        WFOLevelClearPopup val_71;
        var val_72;
        var val_73;
        bool val_74;
        var val_75;
        float val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        float val_81;
        float val_82;
        float val_83;
        static_value_021FACEA.blocksRaycasts = false;
        static_value_021FACEA.SetActive(value:  false);
        val_69 = 0;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -372672480, method:  new IntPtr(3922206864));
        this.buttonForests.m_OnClick.AddListener(call:  162246656);
        if(this.buttonForests.m_OnClick.IsAcornSufficientToGrowForest != false)
        {
                val_69 = WordForest.WFOForestManager.IsFeatureUnlocked;
        }
        
        this.buttonForests.interactable = val_69;
        if(WordForest.WFOForestManager.IsFeatureUnlocked != true)
        {
                if(this.buttonForestsText != 0)
        {
                WordForest.WFOGameEcon val_6 = WordForest.WFOGameEcon.Instance;
            string val_7 = System.String.Format(format:  -372747120, arg0:  13152256);
        }
        
        }
        
        UnityEngine.GameObject val_8 = this.badgeForests.gameObject;
        this.badgeForests.SetActive(value:  false);
        this.eventButtonPanel.rootCanvasGroup.alpha = null;
        this.eventProgressPanel.rootCanvasGroup.alpha = null;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_11 = this.buttonCollect.gameObject;
        if(PlayingChallenge != false)
        {
                this.buttonCollect.SetActive(value:  true);
            UnityEngine.GameObject val_12 = this.buttonForests.gameObject;
            this.buttonForests.SetActive(value:  false);
            UnityEngine.GameObject val_13 = this.buttonForests.gameObject;
            this.buttonForests.SetActive(value:  false);
        }
        else
        {
                this.buttonCollect.SetActive(value:  false);
            UnityEngine.GameObject val_14 = this.buttonForests.gameObject;
            this.buttonForests.SetActive(value:  true);
            UnityEngine.GameObject val_15 = this.buttonForests.gameObject;
            this.buttonForests.SetActive(value:  true);
            Player val_16 = App.Player;
            if((ChapterBookLogic.ShowChapterComplete(playerLevel:  0)) != false)
        {
                val_70 = "collect_upper";
            string val_18 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        }
        else
        {
                Player val_19 = App.Player;
            val_70 = "LEVEL {0}";
            string val_20 = System.String.Format(format:  2127161280, arg0:  13152256);
        }
        
        }
        
        Player val_21 = App.Player;
        string val_22 = System.String.Format(format:  -372706032, arg0:  13152256);
        int val_23 = 0 - 2;
        int val_24 = ChapterBookLogic.GetLevelsPerChapter(playerLevel:  val_23);
        "LEVEL {0} COMPLETE!".__il2cppRuntimeField_C = (float)val_24;
        val_24.current = (float)ChapterBookLogic.GetLevelWithinChapter(playerLevel:  val_23);
        if(val_24 > 0)
        {
                val_24.current = (float)ChapterBookLogic.GetLevelWithinChapter(playerLevel:  -1);
        }
        
        if(val_23 == 0)
        {
                -D16 = -(-D16);
        }
        
        string val_27 = System.String.Format(format:  -1322846112, arg0:  13152256, arg1:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_29 = public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance().__il2cppRuntimeField_1C.ToString();
        twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_31 = System.String.Format(format:  -588332288, arg0:  13152256);
        this.HideOfferButtons();
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CanShowPostLevelOffer() == false)
        {
            goto label_105;
        }
        
        WordPets.WPTDataParser val_34 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached == true)
        {
            goto label_105;
        }
        
        val_71 = mem[1152921512824109168];
        if(val_71 == 0)
        {
                val_71 = this;
            mem[1152921512824109168] = val_71;
        }
        
        if(val_71 == 3)
        {
            goto label_75;
        }
        
        if((val_71 != 1) || (mem[1152921512824109132] == 0))
        {
            goto label_105;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_38 = App.getBehavior;
        if((CanShowPostLevelRewardedVideo(playerLevel:  -1)) == false)
        {
            goto label_105;
        }
        
        val_72 = mem[1152921512824109132];
        goto label_88;
        label_75:
        if(mem[1152921512824109140] == 0)
        {
            goto label_105;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_41 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_42 = App.getBehavior;
        if((CanShowPostLevelAdsControlOffer(playerLevel:  -1)) == false)
        {
            goto label_105;
        }
        
        var val_70 = 27261777;
        val_70 = 8365648 + val_70;
        if(val_70 == 0)
        {
                mem2[0] = 1;
        }
        
        val_73 = null;
        val_73 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
            goto label_105;
        }
        
        NotificationCenter val_44 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -372672480, name:  2128120864);
        string val_45 = Localization.Localize(key:  -372696592, defaultValue:  -372696704, useSingularKey:  false);
        GameEcon val_46 = App.getGameEcon;
        string val_47 = System.String.Format(format:  -372696592, arg0:  13152256);
        val_72 = mem[1152921512824109140];
        label_88:
        UnityEngine.GameObject val_48 = val_72.gameObject;
        val_72.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_49 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SawPostLevelOffer();
        label_105:
        UnityEngine.GameObject val_50 = mem[1152921512824109132].gameObject;
        val_74 = 1;
        if(mem[1152921512824109132].activeInHierarchy != true)
        {
                UnityEngine.GameObject val_52 = mem[1152921512824109136].gameObject;
            if(mem[1152921512824109136].activeInHierarchy != true)
        {
                UnityEngine.GameObject val_54 = mem[1152921512824109140].gameObject;
            val_74 = mem[1152921512824109140].activeInHierarchy;
        }
        
        }
        
        mem[1152921512824109160].SetActive(value:  val_74);
        val_75 = 0;
        if(mem[1152921512824109160].activeInHierarchy != false)
        {
            
        }
        else
        {
            
        }
        
        UnityEngine.Vector2 val_57 = new UnityEngine.Vector2(x:  (0 - 2) + 12, y:  null);
        val_76 = val_57.x;
        if(mem[1152921512824109160].activeInHierarchy == true)
        {
                0.6f = 1061997773;
        }
        
        val_77 = 0;
        UnityEngine.Transform val_59 = mem[1152921512824109120].transform;
        if(mem[1152921512824109120] != 0)
        {
                if(mem[1152921512824109120] != null)
        {
                val_77 = 0;
        }
        else
        {
                val_77 = mem[1152921512824109120];
        }
        
        }
        
        val_77.sizeDelta = new UnityEngine.Vector2() {x = val_76, y = val_57.y};
        val_78 = 0;
        UnityEngine.Transform val_60 = mem[1152921512824109132].transform;
        if(mem[1152921512824109132] != 0)
        {
                if(mem[1152921512824109132] != null)
        {
                val_78 = 0;
        }
        else
        {
                val_78 = mem[1152921512824109132];
        }
        
        }
        
        val_78.sizeDelta = new UnityEngine.Vector2() {x = val_76, y = val_57.y};
        val_79 = mem[mem[1152921512824109120] + 152];
        val_79 = mem[1152921512824109120] + 152;
        if(val_79 != 0)
        {
            
        }
        
        val_79 = 0;
        val_79.pixelsPerUnitMultiplier = 0.8f;
        val_80 = mem[mem[1152921512824109132] + 152];
        val_80 = mem[1152921512824109132] + 152;
        if(val_80 != 0)
        {
            
        }
        
        val_80 = 0;
        val_80.pixelsPerUnitMultiplier = 0.8f;
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.zero;
        val_81 = val_57.x;
        val_82 = val_57.y;
        val_83 = val_62;
        mem[1152921512824109288].localScale = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_62};
        mem[1152921512824109284].localScale = new UnityEngine.Vector3() {x = val_81, y = val_82, z = val_83};
        UnityEngine.Transform val_63 = mem[1152921512824109204].transform;
        UnityEngine.Vector3 val_64 = UnityEngine.Vector3.zero;
        mem[1152921512824109204].localScale = new UnityEngine.Vector3() {x = (0 - 2) + 12};
        UnityEngine.Transform val_65 = this.buttonForests.transform;
        UnityEngine.Vector3 val_66 = UnityEngine.Vector3.zero;
        this.buttonForests.localScale = new UnityEngine.Vector3() {x = public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance().__il2cppRuntimeField_20};
        UnityEngine.Transform val_67 = mem[1152921512824109232].transform;
        UnityEngine.Transform val_68 = mem[1152921512824109236].transform;
        UnityEngine.Vector3 val_69 = new UnityEngine.Vector3(x:  val_66.x, y:  val_66.y, z:  val_66.z);
        mem[1152921512824109236].localScale = new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z};
        mem[1152921512824109232].localScale = new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z};
    }
    public override void PlayStartAnims()
    {
        if(this.startAnimsPlayed != false)
        {
                return;
        }
        
        this.startAnimsPlayed = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.titleTopper, endValue:  null, duration:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.titleTopper, ease:  27);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.titleTopper);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.titleFrame, endValue:  null, duration:  null);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.titleFrame, ease:  27);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.titleFrame);
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_11 = this.containerTotalAcornsEarned.transform;
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.containerTotalAcornsEarned, endValue:  null, duration:  null);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.containerTotalAcornsEarned, ease:  27);
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.containerTotalAcornsEarned);
        UnityEngine.Transform val_15 = this.buttonForests.transform;
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.buttonForests, endValue:  null, duration:  null);
        object val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.buttonForests, ease:  27);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1036831949);
        UnityEngine.Transform val_19 = this.imageTreesLeft.transform;
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.imageTreesLeft, endValue:  null, duration:  null);
        object val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.imageTreesLeft, ease:  27);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1050253722);
        UnityEngine.Transform val_23 = this.imageTreesLeft.transform;
        DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.imageTreesLeft, endValue:  null, duration:  null);
        object val_25 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.imageTreesLeft, ease:  1);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1050253722);
        UnityEngine.Transform val_27 = this.imageTreesRight.transform;
        DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.imageTreesRight, endValue:  null, duration:  null);
        object val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.imageTreesRight, ease:  27);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1056964608);
        UnityEngine.Transform val_31 = this.imageTreesRight.transform;
        DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.imageTreesRight, endValue:  null, duration:  null);
        object val_33 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.imageTreesRight, ease:  1);
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1056964608);
        DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
        twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                this.buttonCollect.interactable = true;
            DG.Tweening.Tweener val_38 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.buttonCollect, endValue:  null, duration:  null);
            DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.buttonCollect, endValue:  null, duration:  null);
            return;
        }
        
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.TweenCallback val_41 = new DG.Tweening.TweenCallback(object:  -372452960, method:  new IntPtr(3922489312));
        object val_42 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void PlayAcornsCreditAnimation()
    {
        float val_49;
        var val_50;
        DG.Tweening.TweenCallback val_51;
        DG.Tweening.TweenCallback val_52;
        var val_53;
        object val_1 = new System.Object();
        typeof(WFOLevelClearPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C = this;
        UnityEngine.GameObject val_2 = this.secondaryBarAcornsCanvasGroup.gameObject;
        this.acornFlyParticles.SetOrigin(originObject:  this.secondaryBarAcornsCanvasGroup);
        UnityEngine.Transform val_3 = this.containerTotalAcornsEarned.transform;
        UnityEngine.Vector3 val_4 = position;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.acornFlyParticles.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance().__il2cppRuntimeField_28, animateStatView:  false);
        typeof(WFOLevelClearPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = 0;
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_7 = this.secondaryBarAcornsCanvasGroup.transform;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.secondaryBarAcornsCanvasGroup, endValue:  val_4.x, duration:  val_4.y);
        val_49 = 1152921509932985248;
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.secondaryBarAcornsCanvasGroup, ease:  21);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  0);
        UnityEngine.Transform val_11 = this.secondaryBarAcornsCanvasGroup.transform;
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.secondaryBarAcornsCanvasGroup, endValue:  val_4.x, duration:  val_4.y);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.secondaryBarAcornsCanvasGroup, ease:  21);
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1053609165);
        DG.Tweening.Core.DOGetter<System.Int32> val_15 = new DG.Tweening.Core.DOGetter<System.Int32>(object:  368209920, method:  new IntPtr(3922663776));
        DG.Tweening.Core.DOSetter<System.Int32> val_16 = new DG.Tweening.Core.DOSetter<System.Int32>(object:  368209920, method:  new IntPtr(3922664800));
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DG.Tweening.Tweener val_18 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance().__il2cppRuntimeField_28, duration:  val_4.x);
        val_50 = 1152921504797581312;
        val_51 = null;
        val_51 = new DG.Tweening.TweenCallback(object:  368209920, method:  new IntPtr(3922665824));
        object val_20 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198828032, action:  190734336);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1063675494);
        UnityEngine.Transform val_22 = this.containerTotalAcornsEarned.transform;
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.containerTotalAcornsEarned, endValue:  val_4.x, duration:  val_4.y);
        object val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.containerTotalAcornsEarned, ease:  21);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1063675494);
        UnityEngine.Transform val_26 = this.containerTotalAcornsEarned.transform;
        DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.containerTotalAcornsEarned, endValue:  val_4.x, duration:  val_4.y);
        object val_28 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.containerTotalAcornsEarned, ease:  21);
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1067030937);
        twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_31 = AffordableGrowthStages;
        if(val_31.IsAcornSufficientToGrowForest != false)
        {
                if((val_31 >= 1) && (WordForest.WFOForestManager.IsFeatureUnlocked != false))
        {
                this.badgeForests.alpha = val_4.x;
            UnityEngine.GameObject val_34 = this.badgeForests.gameObject;
            this.badgeForests.SetActive(value:  true);
            string val_35 = val_31.ToString();
            val_49 = 1056964608;
            DG.Tweening.Tweener val_36 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.badgeForests, endValue:  val_4.x, duration:  val_4.y);
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1069547520);
            UnityEngine.Transform val_38 = this.badgeForests.transform;
            UnityEngine.Vector3 val_39 = new UnityEngine.Vector3(x:  val_4.x, y:  val_4.y, z:  val_4.z);
            val_51 = 16281;
            val_51 = 1067030938;
            DG.Tweening.Tweener val_40 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.badgeForests, punch:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, duration:  val_4.x, vibrato:  val_51, elasticity:  val_4.y);
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1069547520);
            val_50 = 1152921504797581312;
        }
        
        }
        
        DG.Tweening.Tweener val_42 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.secondaryBarAcornsCanvasGroup, endValue:  val_4.x, duration:  val_4.y);
        DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_4.x, t:  1069547520);
        twelvegigs.Autopilot.AutopilotManager val_44 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_4.x);
            val_52 = val_50;
            val_53 = 1152921512824513888;
        }
        else
        {
                val_52 = null;
            val_53 = 1152921512824514912;
        }
        
        val_52 = new DG.Tweening.TweenCallback(object:  368209920, method:  new IntPtr(3922700640));
        object val_48 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private System.Collections.IEnumerator PlayEventProgressAnim()
    {
        object val_1 = new System.Object();
        typeof(WFOLevelClearPopup.<PlayEventProgressAnim>d__38).__il2cppRuntimeField_8 = 0;
        typeof(WFOLevelClearPopup.<PlayEventProgressAnim>d__38).__il2cppRuntimeField_10 = this;
    }
    private void PlayChapterProgressAnim()
    {
        float val_27;
        float val_28;
        var val_42;
        DG.Tweening.TweenCallback val_43;
        UnityEngine.RectTransform val_44;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        this.progressBarRootCanvasGroup.alpha = null;
        this.progressBarRootCanvasGroup.SetActive(value:  true);
        Player val_3 = App.Player;
        int val_4 = ChapterBookLogic.GetLevelWithinChapter(playerLevel:  -1);
        Player val_5 = App.Player;
        val_42 = ChapterBookLogic.ShowChapterComplete(playerLevel:  0);
        if(0 > 0)
        {
                0.current = 3.673424E-39f;
        }
        
        DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.progressBarRootCanvasGroup, endValue:  3.673424E-39f, duration:  null);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.progressBarRootCanvasGroup);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  3.673424E-39f);
        DG.Tweening.Core.DOGetter<System.Single> val_11 = new DG.Tweening.Core.DOGetter<System.Single>(object:  -371918304, method:  new IntPtr(3922991200));
        DG.Tweening.Core.DOSetter<System.Single> val_12 = new DG.Tweening.Core.DOSetter<System.Single>(object:  -371918304, method:  new IntPtr(3922992224));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_13 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  3.673424E-39f, duration:  null);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198828032, ease:  1);
        val_43 = null;
        val_43 = new DG.Tweening.TweenCallback(object:  -371918304, method:  new IntPtr(3922994272));
        object val_16 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198828032, action:  190734336);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198828032);
        if(val_42 != false)
        {
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            this.progressBarRays.localScale = new UnityEngine.Vector3();
            UnityEngine.GameObject val_19 = this.progressBarRays.gameObject;
            this.progressBarRays.SetActive(value:  true);
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_18.x, y:  val_18.y, z:  val_18.z);
            DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.progressBarRays, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  val_18.x, mode:  1084227584);
            object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.progressBarRays, ease:  1);
            object val_23 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.progressBarRays, loops:  0, loopType:  0);
            val_42 = 15897;
            val_42 = 1041865114;
            DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.progressBarCanvasGroup, endValue:  val_18.x, duration:  val_18.y);
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.progressBarCanvasGroup);
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
            val_44 = 0;
            if(this.progressBarGiftBox != 0)
        {
                if(null != null)
        {
                val_44 = 0;
        }
        else
        {
                val_44 = this.progressBarGiftBox;
        }
        
        }
        
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  val_44, endValue:  new UnityEngine.Vector2() {x = val_27, y = val_28}, duration:  val_26.x, snapping:  false);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_44, ease:  7);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_44);
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.progressBarRays, endValue:  new UnityEngine.Vector3(), duration:  val_32.x);
            object val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.progressBarRays, ease:  27);
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.progressBarRays);
            val_43 = this.progressBarGiftBox;
            UnityEngine.Vector3 val_36 = new UnityEngine.Vector3(x:  val_32.x, y:  val_32.y, z:  val_32.z);
            DG.Tweening.Tweener val_37 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_43, endValue:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, duration:  val_32.x);
            object val_38 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_43, ease:  28);
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_43);
        }
        
        DG.Tweening.TweenCallback val_40 = new DG.Tweening.TweenCallback(object:  -371918304, method:  new IntPtr(3923023968));
        object val_41 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void PlayConcludingAnimation()
    {
        float val_4;
        float val_5;
        float val_8;
        float val_9;
        UnityEngine.CanvasGroup val_32;
        var val_33;
        static_value_021FACD3.interactable = true;
        this.bottomRowCanvasGroup.alpha = null;
        UnityEngine.GameObject val_1 = this.bottomRowCanvasGroup.gameObject;
        this.bottomRowCanvasGroup.SetActive(value:  true);
        val_32 = 0;
        UnityEngine.Transform val_2 = this.topBarCanvasGroup.transform;
        if(this.topBarCanvasGroup != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_33 = 1;
        goto label_8;
        label_7:
        val_33 = 0;
        val_32 = this.topBarCanvasGroup;
        label_8:
        UnityEngine.Vector2 val_3 = anchoredPosition;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.y);
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.254921E+25f, y = val_4}, b:  new UnityEngine.Vector2() {x = val_5, y = val_6.x});
        val_32.anchoredPosition = new UnityEngine.Vector2() {x = val_8, y = val_9};
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  0, endValue:  val_7.x, duration:  val_7.y);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
        UnityEngine.Transform val_13 = val_32.transform;
        UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_7.x, y:  val_7.y, z:  null);
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  val_32, duration:  val_7.x, strength:  new UnityEngine.Vector3() {x = 0.65f, y = val_14.x, z = val_14.y}, vibrato:  val_14.z, randomness:  val_7.y, fadeOut:  true);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_32);
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOFade(target:  0, endValue:  val_7.x, duration:  val_7.y);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  0);
        UnityEngine.Transform val_19 = val_32.transform;
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_7.x, y:  val_7.y, z:  null);
        DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  val_32, duration:  val_7.x, strength:  new UnityEngine.Vector3() {x = 0.65f, y = val_20.x, z = val_20.y}, vibrato:  val_20.z, randomness:  val_7.y, fadeOut:  true);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_32);
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  val_32, endValue:  new UnityEngine.Vector2() {x = val_4, y = val_5}, duration:  val_7.x, snapping:  false);
        object val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_32, ease:  6);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_7.x, t:  1060320051);
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.topBarCanvasGroup, endValue:  val_7.x, duration:  val_7.y);
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_7.x, t:  1060320051);
        DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bottomRowCanvasGroup, endValue:  val_7.x, duration:  val_7.y);
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_7.x, t:  1060320051);
        DG.Tweening.TweenCallback val_30 = new DG.Tweening.TweenCallback(object:  -371747936, method:  new IntPtr(3923194336));
        object val_31 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public void CloseAndGoToScene(SceneType scene)
    {
        com.adjust.sdk.AdjustLogLevel val_2;
        var val_3;
        val_2 = scene;
        val_3 = 0;
        static_value_021FACF0.blocksRaycasts = false;
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  val_2);
        val_2 = 1152921504975163392;
        val_3 = 0;
        mem2[0] = val_1.HasValue;
        mem2[0] = val_3;
        if(this != 0)
        {
                return;
        }
    
    }
    public override void OnClick_TapToContinue()
    {
        this.CloseAndGoToScene(scene:  2);
    }
    private void OnClickForests()
    {
        var val_1;
        this.CloseAndGoToScene(scene:  5);
        var val_1 = 27251415;
        val_1 = 8374376 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 97;
    }
    protected override WGLevelClearPopup.OfferButton GetOfferButtonToShow()
    {
        GameEcon val_1 = App.getGameEcon;
        float val_5 = 7.86253E-39f;
        val_5 = val_5 * 10f;
        GameEcon val_2 = App.getGameEcon;
        float val_6 = 1.102051E-39f;
        val_6 = val_6 * 10f;
        if(0 == 0)
        {
                -D16 = -(-D16);
        }
        
        if((UnityEngine.Random.Range(min:  0, max:  val_6 + val_5)) > val_5)
        {
                3 = 1;
        }
    
    }
    public WFOLevelClearPopup()
    {
    
    }
    private float <PlayChapterProgressAnim>b__39_0()
    {
        if(R4 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void <PlayChapterProgressAnim>b__39_1(float x)
    {
        R5.current = x;
    }
    private void <PlayChapterProgressAnim>b__39_2()
    {
        if(35630295 == 0)
        {
                -D16 = -(-D16);
        }
        
        string val_1 = System.String.Format(format:  -1322846112, arg0:  13152256, arg1:  13152256);
        if((System.String.op_Inequality(a:  -370822128, b:  static_value_021FACD7)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -370846240, clipIndex:  0);
    }
    private void <PlayConcludingAnimation>b__40_0()
    {
        R5 + 28.blocksRaycasts = true;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  -370710128, punch:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  null, vibrato:  1063675494, elasticity:  null);
    }

}
