using UnityEngine;
public class FPHMetaGameBehavior : MetaGameBehavior
{
    // Fields
    private static bool hasShownBenefitsWindowThisSession;
    
    // Properties
    public override System.Collections.Generic.Dictionary<string, System.Type> DefaultEventTypes { get; }
    public override System.Collections.Generic.Dictionary<string, System.Type> EventHandlerTypeLookup { get; }
    public override int PlayerLevel { get; set; }
    public override bool supportsEvents { get; }
    public override bool supportsCategoryLevelPacks { get; }
    public override string NotifImgUrlDailyBonus { get; }
    public override string NotifImgUrlPostAd { get; }
    public override bool supportAdsControlV2 { get; }
    public override bool supportsAdaptiveRewardedVideoReward { get; }
    public override bool supportsMiniSettingsPopupSoundButtons { get; }
    public override bool supportsGOTDPopup { get; }
    public override bool supportsDailyLoginRewardPopup { get; }
    public override bool supportsEmailCollectPopup { get; }
    public override bool supportsWordIQ { get; }
    public override bool supportsRecommendPopup { get; }
    public override bool supportsFBConnect { get; }
    public override bool supportsChallenges { get; }
    public override bool supportsSubscriptions { get; }
    public override bool supportsRecaptureNotifications { get; }
    public override bool supportsLeaguesUnlockingAnimation { get; }
    public override bool supportsLeaguesLowPointJoinLock { get; }
    public override bool alwaysForceReviewTracking { get; }
    public override bool supportsLocalization { get; }
    public override bool playMusicInLeaugues { get; }
    public override bool leaguesRewardsCoins { get; }
    public override bool leaguesContributeCostCoins { get; }
    public override bool leaguesMultiplierCostCoins { get; }
    public override bool supportsFBShare { get; }
    public override bool supportsSilverTicketDisplay { get; }
    public override bool canShowGoldenTicketStoreItem { get; }
    public override bool subscriptionGrantsGems { get; }
    public override decimal PlayerInitialCoins { get; }
    public override int PlayerInitialGems { get; }
    public override int RewardedVideoGemReward { get; }
    public override bool PiggyBankUsesGems { get; }
    private int timesShownThisSession { get; set; }
    
    // Methods
    public override System.Collections.Generic.Dictionary<string, System.Type> get_DefaultEventTypes()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(364376064)});
        Add(key:  -1648577792, value:  364376064);
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(328380416)});
        Add(key:  -1648557216, value:  328380416);
    }
    public override System.Collections.Generic.Dictionary<string, System.Type> get_EventHandlerTypeLookup()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(354152448)});
        Add(key:  -1648524352, value:  354152448);
    }
    public override System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(343556096)});
    }
    public override int get_PlayerLevel()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public override void set_PlayerLevel(int value)
    {
        this.PlayerLevel = value;
    }
    public override string GetUrlSharePrefix()
    {
    
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
    }
    public override bool get_supportsEvents()
    {
        return true;
    }
    public override bool get_supportsCategoryLevelPacks()
    {
        return false;
    }
    public override UnityEngine.GameObject OpenPauseMenu()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return 0.gameObject;
        }
        
        return 0.gameObject;
    }
    public override System.Collections.Generic.List<PurchaseModel> FilterStoreCreditPacksPerGame(System.Collections.Generic.List<PurchaseModel> unfiltered)
    {
        var val_2;
        System.Predicate<PurchaseModel> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FPHMetaGameBehavior.<>c.<>9__15_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  FPHMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3525564304));
            FPHMetaGameBehavior.<>c.<>9__15_0 = val_4;
        }
        
        if(unfiltered != 0)
        {
                return unfiltered.FindAll(match:  8040448);
        }
        
        return unfiltered.FindAll(match:  8040448);
    }
    public override string get_NotifImgUrlDailyBonus()
    {
    
    }
    public override string get_NotifImgUrlPostAd()
    {
    
    }
    public override bool get_supportAdsControlV2()
    {
        return true;
    }
    public override bool get_supportsAdaptiveRewardedVideoReward()
    {
        return false;
    }
    public override bool get_supportsMiniSettingsPopupSoundButtons()
    {
        return false;
    }
    public override bool get_supportsGOTDPopup()
    {
        return false;
    }
    public override bool get_supportsDailyLoginRewardPopup()
    {
        return true;
    }
    public override bool get_supportsEmailCollectPopup()
    {
        return false;
    }
    public override bool get_supportsWordIQ()
    {
        return false;
    }
    public override bool get_supportsRecommendPopup()
    {
        return false;
    }
    public override bool get_supportsFBConnect()
    {
        return false;
    }
    public override bool get_supportsChallenges()
    {
        return false;
    }
    public override bool get_supportsSubscriptions()
    {
        return false;
    }
    public override bool get_supportsRecaptureNotifications()
    {
        return false;
    }
    public override bool get_supportsLeaguesUnlockingAnimation()
    {
        return true;
    }
    public override bool get_supportsLeaguesLowPointJoinLock()
    {
        return true;
    }
    public override bool LTB_V2()
    {
        return false;
    }
    public override bool get_alwaysForceReviewTracking()
    {
        return true;
    }
    public override bool get_supportsLocalization()
    {
        return true;
    }
    public override System.Collections.Generic.List<string> GetSupportedLanguageNames()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  1800251696);
        }
        else
        {
                Add(item:  1800251696);
        }
        
        Add(item:  -2101987568);
        if(null != 0)
        {
                Add(item:  -1655001408);
        }
        else
        {
                Add(item:  -1655001408);
        }
        
        Add(item:  -1655001248);
    }
    public override bool get_playMusicInLeaugues()
    {
        return false;
    }
    public override bool get_leaguesRewardsCoins()
    {
        return false;
    }
    public override bool get_leaguesContributeCostCoins()
    {
        return false;
    }
    public override bool get_leaguesMultiplierCostCoins()
    {
        return false;
    }
    public override System.Collections.Generic.List<string[]> LeagueHints()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "fph_league_loading_hint";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Earn stars each level from your remaining tokens!";
        Add(item:  477709520);
    }
    public override bool get_supportsFBShare()
    {
        return false;
    }
    public override bool GemsUnlocked()
    {
        return true;
    }
    public override bool AdsAllowedByScene()
    {
        return false;
    }
    public override bool get_supportsSilverTicketDisplay()
    {
        return false;
    }
    public override bool get_canShowGoldenTicketStoreItem()
    {
        return false;
    }
    public override UnityEngine.GameObject OnLeaguesEntryButtonClicked()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        System.Action val_17;
        System.Action val_18;
        var val_19;
        val_11 = 13;
        if(SceneDictator.IsInGameScene() != false)
        {
                GameBehavior val_2 = App.getBehavior;
            val_11 = 14;
            if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
        {
                val_11 = 15;
        }
        
        }
        
        }
        
        val_12 = 7091820 + 28533971;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 15;
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
        if(0 != 0)
        {
            goto label_20;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = null;
        val_15 = null;
        val_17 = FPHMetaGameBehavior.<>c.<>9__71_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Action(object:  FPHMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3529042000));
            FPHMetaGameBehavior.<>c.<>9__71_0 = val_17;
        }
        
        System.Delegate val_8 = System.Delegate.Combine(a:  SLC.Social.Leagues.LeaguesUIManager.DoOnStart, b:  7454720);
        val_18 = SLC.Social.Leagues.LeaguesUIManager.DoOnStart;
        val_19 = null;
        val_19 = null;
        if(val_18 != 0)
        {
                if(null == null)
        {
            goto label_31;
        }
        
        }
        
        val_18 = 0;
        label_31:
        SLC.Social.Leagues.LeaguesUIManager.DoOnStart = val_18;
        label_20:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_10 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return gameObject;
        }
        
        return gameObject;
    }
    public override string LeaguesBenefitsDescription()
    {
        string val_1 = System.Environment.NewLine;
        return System.String.Format(format:  -765812272, arg0:  0);
    }
    public override bool CanShowLeaguesJoinLeagueButton(SLC.Social.Leagues.Guild CurrentGuild)
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
        return false;
    }
    public override string GetGoldenAppleNameForGame()
    {
    
    }
    public override string GetGoldenAppleNameForGameUpper()
    {
    
    }
    public override string GetSpecialCurrencyLocalizationKey()
    {
    
    }
    public override System.Collections.Generic.Dictionary<string, object> FilterSubscriptionDictionary(System.Collections.Generic.Dictionary<string, object> dic)
    {
        if((dic.ContainsKey(key:  1624646480)) != false)
        {
                object val_2 = dic.Item[1624646480];
            string val_3 = dic.ToString();
            if((System.String.op_Equality(a:  dic, b:  -765239632)) != false)
        {
                if((dic.ContainsKey(key:  -1816221696)) != false)
        {
                dic.set_Item(key:  -1816221696, value:  15282176);
        }
        
            EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  dic, key:  1350423184, newValue:  15282176);
        }
        
        }
        
        if((dic.ContainsKey(key:  1624646480)) == false)
        {
                return;
        }
        
        object val_7 = dic.Item[1624646480];
        string val_8 = dic.ToString();
        if((System.String.op_Equality(a:  dic, b:  -1813741184)) == false)
        {
                return;
        }
        
        1152921510392296080 = "sale_price";
        if((dic.ContainsKey(key:  -1816221696)) != false)
        {
                dic.set_Item(key:  -1816221696, value:  15282176);
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  dic, key:  1350423184, newValue:  15282176);
    }
    public override void DoStoreCloseVideoLogic(bool purchased, bool ooc)
    {
        var val_29;
        float val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        TrackerPurchasePoints val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
            goto label_12;
        }
        
        Player val_2 = App.Player;
        var val_3 = 0 + 60;
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_32 = 0;
        decimal val_5 = System.Decimal.op_Implicit(value:  -765111380);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, d2:  new System.Decimal())) == false)
        {
            goto label_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        val_34 = 1152921504899551232;
        val_29 = 7094288 + 28531772;
        goto label_85;
        label_12:
        GameBehavior val_8 = App.getBehavior;
        if(0 != 2)
        {
            goto label_43;
        }
        
        FPHGameplayController val_9 = FPHGameplayController.Instance;
        if(0 == 0)
        {
            goto label_43;
        }
        
        FPHGameplayController val_11 = FPHGameplayController.Instance;
        if(0 == 0)
        {
            goto label_43;
        }
        
        FPHGameplayController val_12 = FPHGameplayController.Instance;
        if(184 == 0)
        {
            goto label_43;
        }
        
        Player val_13 = App.Player;
        var val_14 = 0 + 64;
        val_31 = 7.286752E-44f;
        WordForest.WFOGameEcon val_15 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_32 = 0;
        decimal val_16 = System.Decimal.op_Implicit(value:  -765111380);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal())) == false)
        {
            goto label_43;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = 7094972 + 28531088;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        val_36 = PurchaseProxy.currentPurchasePoint;
        val_37 = 1;
        goto label_52;
        label_43:
        GameBehavior val_19 = App.getBehavior;
        val_34 = 1152921504899551232;
        if(0 != 4)
        {
            goto label_57;
        }
        
        val_29 = 7095236 + 28530824;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_38 = null;
        val_38 = null;
        if(PurchaseProxy.currentPurchasePoint != 124)
        {
            goto label_63;
        }
        
        GameBehavior val_21 = App.getBehavior;
        val_39 = 0;
        val_40 = mem[1179403879];
        return;
        label_57:
        var val_31 = 28530536;
        val_31 = 7095524 + val_31;
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        val_41 = null;
        val_41 = null;
        if(PurchaseProxy.currentPurchasePoint != 126)
        {
            goto label_75;
        }
        
        GameBehavior val_23 = App.getBehavior;
        val_39 = 0;
        val_40 = mem[1179403879];
        return;
        label_63:
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        label_85:
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_42 = null;
        val_36 = PurchaseProxy.currentPurchasePoint;
        val_37 = 0;
        label_52:
        TryShowPromptVideo(entryPoint:  val_36, showAsFlyout:  false);
        return;
        label_75:
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        val_43 = null;
        val_43 = null;
        if(PurchaseProxy.currentPurchasePoint == 127)
        {
                GameBehavior val_27 = App.getBehavior;
            val_39 = 0;
            val_40 = mem[1179403879];
            return;
        }
        
        GameBehavior val_29 = App.getBehavior;
        val_39 = 0;
        if(ooc == true)
        {
                35 = 5;
        }
        
        val_40 = mem[1179403879];
    }
    public override bool get_subscriptionGrantsGems()
    {
        return true;
    }
    public override decimal get_PlayerInitialCoins()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return new System.Decimal() {flags = -1653670556, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = -1653670556, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    public override int get_PlayerInitialGems()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_134;
        }
        
        return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_134;
    }
    public override int get_RewardedVideoGemReward()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_138;
        }
        
        return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_138;
    }
    public override void OnClickHome()
    {
        var val_6;
        var val_7;
        val_6 = this;
        val_7 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 2)
        {
                FPHGameplayController val_2 = FPHGameplayController.Instance;
            FPHGameplayController val_3 = FPHGameplayController.Instance;
            GameBehavior val_4 = App.getBehavior;
            if(0 != 0)
        {
            goto mem[1179404171];
        }
        
        }
        else
        {
                R4.OnClickHome();
        }
    
    }
    public override bool get_PiggyBankUsesGems()
    {
        return true;
    }
    public override bool CanAccessLimitedTimeBundles()
    {
        return false;
    }
    private int get_timesShownThisSession()
    {
        return CPlayerPrefs.GetInt(key:  -764227328, defaultValue:  0);
    }
    private void set_timesShownThisSession(int value)
    {
        CPlayerPrefs.SetInt(key:  -764227328, val:  value);
        CPlayerPrefs.Save();
    }
    public override void AppendPurchaseTracking(ref System.Collections.Generic.Dictionary<string, object> tracking, PurchaseModel pm)
    {
        float val_9;
        var val_10;
        var val_11;
        var val_13;
        var val_14;
        val_9 = pm;
        Player val_1 = App.Player;
        tracking.Add(key:  -763995120, value:  13152256);
        Player val_2 = App.Player;
        tracking.Add(key:  -763995024, value:  13152256);
        decimal val_3 = GoldenCurrency;
        val_11 = null;
        val_11 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_5 = GoldenCurrency;
            tracking.Add(key:  -763994928, value:  10170368);
        }
        
        val_13 = 0;
        if(this == 2)
        {
                val_14 = null;
            val_14 = null;
            if(FPHGameplayController.currentGameplayMode == 1)
        {
                val_10 = 1152921504901095424;
            val_9 = 1152921511577970752;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            if((-1618810816) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static FPHPhraseOfTheDayController MonoSingleton<FPHPhraseOfTheDayController>::get_Instance().__il2cppRuntimeField_C) != 0)
        {
                val_13 = mem[public static FPHPhraseOfTheDayController MonoSingleton<FPHPhraseOfTheDayController>::get_Instance().__il2cppRuntimeField_C + 8];
            val_13 = public static FPHPhraseOfTheDayController MonoSingleton<FPHPhraseOfTheDayController>::get_Instance().__il2cppRuntimeField_C + 8;
        }
        
        }
        
        }
        
        }
        
        tracking.Add(key:  -1646909904, value:  8945664);
    }
    public override void SetToCreditsStatViewPos(UnityEngine.RectTransform rectTransform)
    {
        MonoExtensions.SetUIAnchor(rect:  rectTransform, anchor:  1);
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public override void SetToGemsStatViewPos(UnityEngine.RectTransform rectTransform)
    {
        MonoExtensions.SetUIAnchor(rect:  rectTransform, anchor:  1);
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public override void SetToGoldenStatViewPos(UnityEngine.RectTransform rectTransform)
    {
        MonoExtensions.SetUIAnchor(rect:  rectTransform, anchor:  1);
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        bool val_3 = static_value_021FA2C9;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        FPHPlayer val_1 = FPHPlayer.Instance;
        string val_2 = val_3.SuccessPercentageStandardModeString;
        userProperties.Add(key:  -763506032, value:  1);
    }
    public override bool ArePopupsAllowedForSceneType(SceneType type)
    {
        var val_2;
        FPHGameplayMode val_3;
        if(type == 2)
        {
                val_2 = null;
            val_2 = null;
            val_3 = FPHGameplayController.currentGameplayMode;
        }
        else
        {
                val_3 = type - 1;
        }
        
        val_3 = val_3 >> 5;
        return (bool)val_3;
    }
    public override string GetLevelForTracking()
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(0 == 0)
        {
                Player val_3 = App.Player;
            if(0 != 0)
        {
            goto label_9;
        }
        
        }
        else
        {
                FPHGameplayController val_4 = FPHGameplayController.Instance;
        }
        
        label_9:
        string val_6 = 0 + 60.ToString();
    }
    public override void ShowAdditionalSceneChangePopups(SceneType scene)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = 1152921504901095424;
        val_14 = 1152921511577970752;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1618810816) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckLPN();
        }
        
        if(scene != 1)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(FPHMetaGameBehavior.hasShownBenefitsWindowThisSession == true)
        {
                return;
        }
        
        val_13 = 1152921505048485888;
        if(SLC.Social.Leagues.LeaguesManager.IsAvailable() == false)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
        if(0 != 0)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_8 = 0.MyProfile;
        if(0.hasJoinedClub == true)
        {
                return;
        }
        
        GameBehavior val_10 = App.getBehavior;
        val_16 = mem[R5];
        val_16 = R5;
        if((((R5 + 187) & 2) == 0) && ((R5 + 116) == 0))
        {
                val_16 = mem[R5];
            val_16 = R5;
        }
        
        mem2[0] = 1;
    }
    public override void TrackAdditionalNonCoinAwardParams(System.Collections.Generic.Dictionary<string, object> data)
    {
    
    }
    public FPHMetaGameBehavior()
    {
    
    }
    private static FPHMetaGameBehavior()
    {
    
    }

}
