using UnityEngine;
public class FPHLevelCompletePopup : MonoBehaviour
{
    // Fields
    private const string lastChapterCollectedKey = "lastChapterCollected";
    private static int lastLevelCompletAnimShownAt;
    private UnityEngine.GameObject levelSuccessGroup;
    private UnityEngine.GameObject levelCompleteBanner;
    private UnityEngine.UI.Text pregameCointext;
    private UnityEngine.UI.Text pregameStarText;
    private UnityEngine.UI.Button pregameOpenButton;
    private UnityEngine.GameObject preminigameTapContinueObject;
    private UnityEngine.UI.Image openChestImage;
    private UnityEngine.UI.Image closedChestImage;
    private FPHPickerGameButton minigameButtonPrefab;
    private System.Collections.Generic.List<FPHPickerGameButton> gameButtons;
    private UnityEngine.GameObject chestRewardMultiParent;
    private UnityEngine.UI.Image minigameBackdrop;
    private UnityEngine.UI.Text minigameOpenText;
    private UnityEngine.CanvasGroup multiplierChestGroup;
    private UnityEngine.GameObject postMinigameGroup;
    private UnityEngine.UI.Text levelRewardAmountText;
    private UnityEngine.UI.Text unusedTokensAmountText;
    private UnityEngine.UI.Text starScoreAmountText;
    private UnityEngine.UI.Text eventNameAmountText;
    private UnityEngine.GameObject unusedTokensRewardGroup;
    private UnityEngine.GameObject starScoreRewardGroup;
    private UnityEngine.GameObject eventRewardGroup;
    private UnityEngine.UI.Text chapterProgressBarText;
    private UnityEngine.UI.Text nextGameButtonText;
    private UnityEngine.UI.Text nextQuizCostText;
    private UnityEngine.UI.Image postMinigameChestImage;
    private UnityEngine.UI.Image progressBarImage;
    private UnityEngine.UI.Image unusedTokensCardImage;
    private UnityEngine.UI.Image starScoreCardImage;
    private UnityEngine.UI.Button nextQuizButton;
    private System.Collections.Generic.List<UnityEngine.GameObject> statViews;
    private CoinCurrencyParticles coinParticle;
    private GoldenApplesParticles goldParticle;
    private CurrencyStatView starStatView;
    private CurrencyStatView coinStatView;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button gemStoreButton;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.Sprite WoodChestIcon;
    private UnityEngine.Sprite WoodChestOpen;
    private UnityEngine.Sprite SilverChestIcon;
    private UnityEngine.Sprite SilverChestOpen;
    private UnityEngine.Sprite GoldenChestIcon;
    private UnityEngine.Sprite GoldenChestOpen;
    private System.Collections.Generic.List<UnityEngine.Sprite> cardSpecificSprites;
    
    // Properties
    private int chapterLength { get; }
    private int playerLevel { get; }
    private bool ChapterRewardAvailable { get; }
    private FPHGameplayState currentGame { get; }
    private FPHEcon econ { get; }
    
    // Methods
    private int get_chapterLength()
    {
        FPHEcon val_1 = this.econ;
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    private int get_playerLevel()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return -1;
        }
        
        return -1;
    }
    private bool get_ChapterRewardAvailable()
    {
        FPHEcon val_2 = this.playerLevel.econ;
        if((val_1 + 1308) != 0)
        {
                return false;
        }
        
        int val_3 = CPlayerPrefs.GetInt(key:  -1631826336, defaultValue:  0);
        int val_4 = val_3.playerLevel;
        val_4 = val_3 - val_4;
        if(CPlayerPrefs.__il2cppRuntimeField_cctor_finished != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    private FPHGameplayState get_currentGame()
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(null != 0)
        {
                return;
        }
    
    }
    private FPHEcon get_econ()
    {
        return App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
    }
    private void Start()
    {
        var val_14;
        var val_15;
        System.Action<UnityEngine.GameObject> val_17;
        var val_18;
        UnityEngine.GameObject val_1 = this.levelSuccessGroup.gameObject;
        this.levelSuccessGroup.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.postMinigameGroup.gameObject;
        this.postMinigameGroup.SetActive(value:  false);
        this.storeButton.m_OnClick.RemoveAllListeners();
        val_14 = 1152921504769093632;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1631392496, method:  new IntPtr(2663501648));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        this.gemStoreButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1631392496, method:  new IntPtr(2663519056));
        this.gemStoreButton.m_OnClick.AddListener(call:  162246656);
        this.homeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1631392496, method:  new IntPtr(2663536464));
        this.homeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_6 = this.homeButton.gameObject;
        this.homeButton.SetActive(value:  false);
        val_15 = null;
        val_15 = null;
        val_17 = FPHLevelCompletePopup.<>c.<>9__57_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  FPHLevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2663545680));
            FPHLevelCompletePopup.<>c.<>9__57_0 = val_17;
        }
        
        this.statViews.ForEach(action:  7401472);
        FPHGameplayState val_8 = this.statViews.currentGame;
        if(this.statViews < 1)
        {
            goto label_26;
        }
        
        FPHGameplayState val_9 = this.statViews.currentGame;
        if(this.statViews == 0)
        {
            goto label_28;
        }
        
        label_26:
        val_18 = this;
        this.SetupPostMinigameState();
        goto label_29;
        label_28:
        val_18 = this;
        this.SetupPreGameState();
        label_29:
        FPHGameplayState val_10 = this.currentGame;
        if(this.preminigameTapContinueObject > 0)
        {
                return;
        }
        
        FPHGameplayState val_11 = this.preminigameTapContinueObject.currentGame;
        if(this.preminigameTapContinueObject != 0)
        {
                return;
        }
        
        FPHGameplayController val_12 = FPHGameplayController.Instance;
        RewardMultiPicked(multiplier:  1);
        FPHGameplayController val_13 = FPHGameplayController.Instance;
        TrackLevelComplete(isSuccess:  true, failReason:  null);
    }
    private void SetupPreGameState()
    {
        UnityEngine.GameObject val_1 = this.levelCompleteBanner.gameObject;
        this.levelCompleteBanner.SetActive(value:  true);
        this.setChestSprite(image:  this.closedChestImage, closed:  true);
        UnityEngine.GameObject val_2 = this.openChestImage.gameObject;
        this.openChestImage.SetActive(value:  false);
        FPHGameplayState val_3 = this.openChestImage.currentGame;
        string val_5 = this.openChestImage.GetTotalCoinReward().ToString();
        string val_6 = System.String.Format(format:  -1631218480, arg0:  -1631156252);
        FPHGameplayState val_7 = this.pregameCointext.currentGame;
        string val_8 = this.pregameCointext.ToString();
        string val_9 = System.String.Format(format:  -1631218480, arg0:  -1631156252);
        UnityEngine.GameObject val_10 = this.pregameCointext.gameObject;
        FPHGameplayState val_11 = this.pregameCointext.currentGame;
        if(this.pregameCointext.GetTotalCoinReward() > 0)
        {
                0 = 1;
        }
        
        this.pregameCointext.SetActive(value:  true);
        UnityEngine.GameObject val_13 = this.pregameStarText.gameObject;
        FPHGameplayState val_14 = this.pregameStarText.currentGame;
        if(this.pregameStarText > 0)
        {
                0 = 1;
        }
        
        this.pregameStarText.SetActive(value:  true);
        this.pregameOpenButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_15 = new UnityEngine.Events.UnityAction(object:  -1631144224, method:  new IntPtr(2663777568));
        this.pregameOpenButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_16 = this.levelSuccessGroup.gameObject;
        this.levelSuccessGroup.SetActive(value:  true);
        UnityEngine.UI.LayoutElement val_17 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.levelSuccessGroup);
        this.levelSuccessGroup.alpha = null;
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.levelSuccessGroup, endValue:  null, duration:  null);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.levelSuccessGroup, delay:  null);
        UnityEngine.GameObject val_20 = this.minigameBackdrop.gameObject;
        this.minigameBackdrop.SetActive(value:  false);
        UnityEngine.GameObject val_21 = this.minigameOpenText.gameObject;
        this.minigameOpenText.SetActive(value:  false);
        UnityEngine.GameObject val_22 = this.multiplierChestGroup.gameObject;
        this.multiplierChestGroup.SetActive(value:  false);
    }
    private void SetupPostMinigameState()
    {
        var val_72;
        System.Action<UnityEngine.GameObject> val_74;
        var val_75;
        var val_76;
        var val_79;
        UnityEngine.GameObject val_80;
        var val_81;
        var val_82;
        float val_83;
        FPHGameplayState val_1 = this.currentGame;
        if(184 == 0)
        {
                Player val_2 = App.Player;
            FPHGameplayState val_3 = this.currentGame;
            var val_6 = (4 - 83886592) - (0 * 0);
            decimal val_7 = System.Decimal.op_Implicit(value:  -1630840752);
            Player val_8 = App.Player;
            FPHGameplayState val_9 = this.currentGame;
            int val_10 = 0.GetTotalCoinReward();
            decimal val_11 = System.Decimal.op_Implicit(value:  -1630840768);
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1630840784, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        }
        
        val_72 = null;
        val_72 = null;
        val_74 = FPHLevelCompletePopup.<>c.<>9__59_0;
        if(val_74 == 0)
        {
                val_74 = null;
            val_74 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  FPHLevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2663988896));
            FPHLevelCompletePopup.<>c.<>9__59_0 = val_74;
        }
        
        this.statViews.ForEach(action:  7401472);
        UnityEngine.GameObject val_14 = this.homeButton.gameObject;
        this.homeButton.SetActive(value:  this.ChapterRewardAvailable ^ 1);
        FPHEcon val_17 = this.homeButton.econ;
        string val_18 = this.homeButton.ToString();
        FPHGameplayState val_19 = this.levelRewardAmountText.currentGame;
        FPHGameplayState val_20 = this.levelRewardAmountText.currentGame;
        string val_21 = (this.levelRewardAmountText * FPHLevelCompletePopup.<>c.<>9).ToString();
        FPHGameplayState val_22 = this.unusedTokensAmountText.currentGame;
        FPHGameplayState val_23 = this.unusedTokensAmountText.currentGame;
        string val_24 = (this.unusedTokensAmountText * FPHLevelCompletePopup.<>c.<>9).ToString();
        UnityEngine.UI.Text val_75 = this.starScoreAmountText;
        FPHGameplayState val_25 = val_75.currentGame;
        val_75 = val_75 + 36;
        string val_26 = val_75.ToString();
        FPHGameplayState val_27 = this.eventNameAmountText.currentGame;
        if(val_75 > 0)
        {
                0 = 1;
        }
        
        this.unusedTokensRewardGroup.SetActive(value:  true);
        FPHGameplayState val_28 = this.unusedTokensRewardGroup.currentGame;
        if(val_75 > 0)
        {
                0 = 1;
        }
        
        this.starScoreRewardGroup.SetActive(value:  true);
        FPHGameplayState val_29 = this.starScoreRewardGroup.currentGame;
        if(val_75 > 0)
        {
                0 = 1;
        }
        
        this.eventRewardGroup.SetActive(value:  true);
        val_75 = null;
        val_75 = null;
        if(FPHLevelCompletePopup.lastLevelCompletAnimShownAt != playerLevel)
        {
                UnityEngine.Transform val_31 = this.coinStatView.AppleIcon;
            UnityEngine.Transform val_32 = this.coinStatView.transform;
            UnityEngine.Vector3 val_33 = position;
            FPHGameplayState val_34 = currentGame;
            this.coinParticle.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  GetTotalCoinReward(), animateStatView:  true);
            FPHGameplayState val_36 = this.coinParticle.currentGame;
            if(this.coinParticle >= 1)
        {
                UnityEngine.Transform val_37 = this.starStatView.AppleIcon;
            UnityEngine.Transform val_38 = this.starStatView.transform;
            UnityEngine.Vector3 val_39 = position;
            FPHGameplayState val_40 = currentGame;
            this.goldParticle.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  null, animateStatView:  true);
        }
        
            val_79 = null;
            val_79 = null;
            FPHLevelCompletePopup.lastLevelCompletAnimShownAt = this.goldParticle.playerLevel;
            twelvegigs.Autopilot.AutopilotManager val_44 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1630928224, clipIndex:  0);
            System.Collections.IEnumerator val_45 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.OnRewardAnimFinished(delay:  val_39.x);
            val_76 = this;
            UnityEngine.Coroutine val_46 = this.StartCoroutine(routine:  public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C);
        }
        
        FPHGameplayState val_47 = this.currentGame;
        val_80 = this.eventRewardGroup;
        if(this.cardSpecificSprites >= val_80)
        {
                FPHGameplayState val_48 = val_80.currentGame;
            var val_76 = val_80;
            val_76 = val_76 - 1;
            if(val_80 <= val_76)
        {
                var val_77 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_77 = val_77 + (val_76 << 2);
            this.unusedTokensCardImage.sprite = (0 + ((this.eventRewardGroup - 1)) << 2) + 16;
            FPHGameplayState val_49 = this.unusedTokensCardImage.currentGame;
            UnityEngine.UI.Image val_78 = this.unusedTokensCardImage;
            val_78 = val_78 - 1;
            if(this.unusedTokensCardImage <= val_78)
        {
                var val_79 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_79 = val_79 + (val_78 << 2);
            val_80 = this.starScoreCardImage;
            val_80.sprite = (0 + ((this.unusedTokensCardImage - 1)) << 2) + 16;
        }
        
        FPHEcon val_50 = val_80.econ;
        string val_51 = val_80.ToString();
        if(this.ChapterRewardAvailable != false)
        {
                string val_53 = Localization.Localize(key:  -1630895248, defaultValue:  -1630895344, useSingularKey:  false);
            UnityEngine.GameObject val_54 = this.nextQuizCostText.gameObject;
            val_81 = 0;
        }
        else
        {
                string val_55 = Localization.Localize(key:  -1630890944, defaultValue:  -1630891040, useSingularKey:  false);
            UnityEngine.GameObject val_56 = this.nextQuizCostText.gameObject;
            val_81 = 1;
        }
        
        this.nextQuizCostText.SetActive(value:  true);
        bool val_57 = this.ChapterRewardAvailable;
        if(val_57 != false)
        {
                FPHEcon val_58 = val_57.econ;
            val_82 = mem[val_57 + 1308];
            val_82 = val_57 + 1308;
        }
        else
        {
                FPHEcon val_60 = val_57.playerLevel.econ;
            val_82 = mem[val_59 + 1308];
            val_82 = val_59 + 1308;
        }
        
        FPHEcon val_61 = econ;
        string val_62 = Localization.Localize(key:  -1630882544, defaultValue:  -1630882464, useSingularKey:  false);
        string val_63 = System.String.Format(format:  -1630882640, arg0:  13152256, arg1:  13152256, arg2:  -1630882544);
        int val_64 = this.chapterProgressBarText.playerLevel;
        FPHEcon val_65 = val_64.econ;
        FPHEcon val_66 = val_64.econ;
        val_64 = val_64 - 1;
        float val_80 = (float)val_64 + 1308;
        val_80 = ((float)val_64 + 1308) / val_80;
        this.progressBarImage.fillAmount = val_80;
        bool val_67 = this.ChapterRewardAvailable;
        if(val_67 != false)
        {
                val_83 = 1f;
        }
        else
        {
                int val_68 = val_67.playerLevel;
            FPHEcon val_69 = val_68.econ;
            FPHEcon val_70 = val_68.econ;
            var val_81 = val_68;
            val_81 = val_81 + 1308;
            val_83 = ((float)val_68 + 1308) / (float)val_81;
        }
        
        DG.Tweening.Tweener val_71 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.progressBarImage, endValue:  val_83, duration:  val_39.y);
        object val_72 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.progressBarImage, delay:  val_83);
        this.nextQuizButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_73 = new UnityEngine.Events.UnityAction(object:  -1630828688, method:  new IntPtr(2664109488));
        this.nextQuizButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_74 = this.postMinigameGroup.gameObject;
        this.postMinigameGroup.SetActive(value:  true);
    }
    private System.Collections.IEnumerator OnRewardAnimFinished(float delay = 0)
    {
        FPHLevelCompletePopup.<OnRewardAnimFinished>d__60 val_1 = new FPHLevelCompletePopup.<OnRewardAnimFinished>d__60(<>1__state:  0);
        typeof(FPHLevelCompletePopup.<OnRewardAnimFinished>d__60).__il2cppRuntimeField_10 = R1;
    }
    private System.Collections.IEnumerator StartMinigame()
    {
        FPHLevelCompletePopup.<StartMinigame>d__61 val_1 = new FPHLevelCompletePopup.<StartMinigame>d__61(<>1__state:  0);
        typeof(FPHLevelCompletePopup.<StartMinigame>d__61).__il2cppRuntimeField_10 = this;
    }
    private void MultiplierPicked(int multi, FPHPickerGameButton selectedButton)
    {
        UnityEngine.Object val_5;
        var val_17;
        var val_18;
        var val_21;
        var val_22;
        val_17 = 1152921504909881344;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(null == 0)
        {
            goto label_4;
        }
        
        FPHEcon val_2 = econ;
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        if(null != 0)
        {
                Add(item:  4);
        }
        else
        {
                Add(item:  4);
        }
        
        Add(item:  7);
        List.Enumerator<T> val_4 = GetEnumerator();
        val_18 = 0;
        goto label_9;
        label_21:
        if(val_5 == selectedButton)
        {
                val_21 = val_18;
        }
        else
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_21 = 1;
        }
        
        val_22 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_22 = mem[(mem[1152921511566431404] + 8 + ((List<T>.__il2cppRuntimeField_10 - 1)) << 2) + 16];
        val_22 = (mem[1152921511566431404] + 8 + ((List<T>.__il2cppRuntimeField_10 - 1)) << 2) + 16;
        mem2[0] = val_22;
        val_18 = val_21;
        label_9:
        if(MoveNext() == true)
        {
            goto label_21;
        }
        
        Dispose();
        val_17 = 1152921504909881344;
        label_4:
        FPHGameplayController val_9 = FPHGameplayController.Instance;
        RewardMultiPicked(multiplier:  typeof(FPHGameplayController).__il2cppRuntimeField_53C);
        FPHGameplayController val_10 = FPHGameplayController.Instance;
        TrackLevelComplete(isSuccess:  true, failReason:  null);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateSavedLevel(state:  0);
        List.Enumerator<T> val_12 = GetEnumerator();
        label_33:
        if(MoveNext() == false)
        {
            goto label_30;
        }
        
        UnityEngine.UI.Button val_14 = val_5.myButton;
        val_5.interactable = false;
        goto label_33;
        label_30:
        Dispose();
        System.Collections.IEnumerator val_15 = this.animateReveal(selected:  selectedButton);
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  -1630350352);
    }
    private System.Collections.IEnumerator animateReveal(FPHPickerGameButton selected)
    {
        if((new FPHLevelCompletePopup.<animateReveal>d__63(<>1__state:  0)) != 0)
        {
                typeof(FPHLevelCompletePopup.<animateReveal>d__63).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(FPHLevelCompletePopup.<animateReveal>d__63).__il2cppRuntimeField_10 = selected;
    }
    private void NextQuizButtonClicked()
    {
        CoinCurrencyParticles val_29;
        var val_30;
        var val_31;
        var val_32;
        System.Action val_34;
        bool val_1 = this.ChapterRewardAvailable;
        if(val_1 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  1, oneshot:  true, pitch:  null, vol:  null);
            string val_3 = Localization.Localize(key:  -1630890944, defaultValue:  -1630891040, useSingularKey:  false);
            UnityEngine.GameObject val_4 = this.nextQuizCostText.gameObject;
            this.nextQuizCostText.SetActive(value:  true);
            UnityEngine.GameObject val_5 = this.homeButton.gameObject;
            this.homeButton.SetActive(value:  true);
            GameBehavior val_6 = App.getBehavior;
            0.Setup(rewardSource:  3);
            CPlayerPrefs.SetInt(key:  -1631826336, val:  this.playerLevel);
            CPlayerPrefs.Save();
            return;
        }
        
        FPHEcon val_9 = val_1.econ;
        Player val_10 = App.Player;
        val_29 = 52;
        decimal val_11 = System.Decimal.op_Implicit(value:  -1630091204);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            FPHGameplayController val_14 = FPHGameplayController.Instance;
            Player val_15 = App.Player;
            .__il2cppRuntimeField_3C = 0;
            decimal val_16 = System.Decimal.op_Implicit(value:  -1630091204);
            bool val_17 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "Start Quiz", externalParams:  0, animated:  true);
            UnityEngine.Transform val_18 = this.coinParticle.transform;
            UnityEngine.Transform val_19 = this.coinStatView.AppleIcon;
            UnityEngine.Vector3 val_20 = position;
            this.coinParticle.position = new UnityEngine.Vector3();
            val_29 = this.coinParticle;
            UnityEngine.Transform val_21 = this.nextQuizButton.transform;
            UnityEngine.Vector3 val_22 = position;
            val_30 = 0;
            val_29.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.nextQuizButton.interactable = false;
            UUI_EventsController.DisableInputs();
            System.Collections.IEnumerator val_23 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  -1630079152);
            return;
        }
        
        var val_29 = 22353189;
        val_29 = 13272872 + val_29;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        PurchaseProxy.currentPurchasePoint = 93;
        GameBehavior val_25 = App.getBehavior;
        val_30 = 1152921504910733312;
        val_32 = null;
        val_32 = null;
        val_34 = FPHLevelCompletePopup.<>c.<>9__64_0;
        if(val_34 == 0)
        {
                val_34 = null;
            val_34 = new System.Action(object:  FPHLevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2664863120));
            FPHLevelCompletePopup.<>c.<>9__64_0 = val_34;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_28 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1630079152, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        FPHLevelCompletePopup.<WaitForCoinAnimation>d__65 val_1 = new FPHLevelCompletePopup.<WaitForCoinAnimation>d__65(<>1__state:  0);
        typeof(FPHLevelCompletePopup.<WaitForCoinAnimation>d__65).__il2cppRuntimeField_10 = this;
    }
    private void setChestSprite(UnityEngine.UI.Image image, bool closed)
    {
        var val_2;
        FPHGameplayState val_1 = this.currentGame;
        if(this.starScoreRewardGroup == 2)
        {
            goto label_1;
        }
        
        if(this.starScoreRewardGroup == 1)
        {
            goto label_2;
        }
        
        if(this.starScoreRewardGroup != 0)
        {
                return;
        }
        
        if(closed == true)
        {
                val_2 = 164;
        }
        
        goto label_5;
        label_1:
        if(closed == true)
        {
                val_2 = 180;
        }
        
        goto label_5;
        label_2:
        if(closed == true)
        {
                val_2 = 172;
        }
        
        label_5:
        image.sprite = this.SilverChestIcon;
    }
    private void StoreButtonClicked()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 22352409;
        val_5 = 13273652 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 2;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = FPHLevelCompletePopup.<>c.<>9__67_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  FPHLevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2665257488));
            FPHLevelCompletePopup.<>c.<>9__67_0 = val_8;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1629684784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void GemStoreButtonClicked()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        var val_6 = 22351821;
        val_6 = 13274240 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 2;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = FPHLevelCompletePopup.<>c.<>9__68_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  FPHLevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2665370512));
            FPHLevelCompletePopup.<>c.<>9__68_0 = val_9;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1629571760, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void HomeButtonClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        this.Close(showAd:  true);
    }
    private void Close(bool showAd = True)
    {
        if(showAd != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowInterstitial(context:  2);
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1629347760, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public FPHLevelCompletePopup()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.gameButtons = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.statViews = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.cardSpecificSprites = null;
    }
    private static FPHLevelCompletePopup()
    {
        FPHLevelCompletePopup.lastLevelCompletAnimShownAt = 0;
    }
    private void <SetupPreGameState>b__58_0()
    {
        System.Collections.IEnumerator val_1 = this.StartMinigame();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1629009712);
    }

}
