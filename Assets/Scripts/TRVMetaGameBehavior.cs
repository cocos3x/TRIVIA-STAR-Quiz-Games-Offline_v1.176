using UnityEngine;
public class TRVMetaGameBehavior : MetaGameBehavior
{
    // Properties
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
    public override bool supportsBonusRewards { get; }
    public override bool supportsTournaments { get; }
    public override bool playMusicInLeaugues { get; }
    public override bool leaguesRewardsCoins { get; }
    public override bool supportsFBShare { get; }
    public override bool supportsSilverTicketDisplay { get; }
    public override bool canShowGoldenTicketStoreItem { get; }
    public override decimal FOMOCurrency { get; }
    public override string FOMOCurrencyType { get; }
    public override bool subscriptionGrantsGems { get; }
    public override decimal PlayerInitialCoins { get; }
    public override int PlayerInitialGems { get; }
    public override int RewardedVideoGemReward { get; }
    public override bool PiggyBankUsesGems { get; }
    private int timesShownThisSession { get; set; }
    public override float WindowManagerBackgroundAlpha { get; }
    public override bool CanShowUnPauseInterstitial { get; }
    public override bool canShowGameSceneEventUpdates { get; }
    public override bool supportsLocalization { get; }
    
    // Methods
    public override System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(344567808)});
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
        SceneType val_3 = this.GetSceneTypeFromSceneName(sceneName:  -724137652);
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
        val_4 = TRVMetaGameBehavior.<>c.<>9__11_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  TRVMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3571269760));
            TRVMetaGameBehavior.<>c.<>9__11_0 = val_4;
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
        return true;
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
    public override bool get_supportsBonusRewards()
    {
        return true;
    }
    public override bool get_supportsTournaments()
    {
        return true;
    }
    public override bool get_playMusicInLeaugues()
    {
        return false;
    }
    public override bool get_leaguesRewardsCoins()
    {
        return false;
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
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((hasSubscription(subPackage:  0)) == false)
        {
                return this.canShowGoldenTicketStoreItem;
        }
        
        return false;
    }
    public override decimal get_FOMOCurrency()
    {
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -720756416);
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    public override string get_FOMOCurrencyType()
    {
    
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
        
        val_12 = 10857028 + 24768763;
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
        val_17 = TRVMetaGameBehavior.<>c.<>9__64_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Action(object:  TRVMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3574410880));
            TRVMetaGameBehavior.<>c.<>9__64_0 = val_17;
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
    public override System.Collections.Generic.List<string[]> LeagueHints()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "trv_league_loading_hint";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Earn League Points by answering questions correctly!";
        Add(item:  477709520);
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
        bool val_31;
        bool val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        float val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        val_31 = ooc;
        val_32 = purchased;
        val_33 = 1152921504899551232;
        val_34 = 10859324 + 24766736;
        if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        val_36 = 1;
        if(PurchaseProxy.currentPurchasePoint != 1)
        {
                if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
            val_37 = null;
            val_37 = null;
            if(PurchaseProxy.currentPurchasePoint != 86)
        {
                if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
            val_38 = null;
            val_38 = null;
            if(PurchaseProxy.currentPurchasePoint != 87)
        {
                if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
            val_39 = null;
            val_39 = null;
            TrackerPurchasePoints val_31 = PurchaseProxy.currentPurchasePoint;
            val_31 = val_31 - 2;
            val_36 = val_31 >> 5;
        }
        
        }
        
        }
        
        bool val_1 = val_32 | val_31;
        val_1 = val_1 ^ 1;
        if(((val_36 & val_1) == 0) && ((FOMOPackEventHandler.<Instance>k__BackingField) != 0))
        {
                bool val_2 = FOMOPackEventHandler.<Instance>k__BackingField.TryShowPopup(isOOC:  false);
        }
        
        val_40 = 1152921504892043264;
        GameBehavior val_3 = App.getBehavior;
        if(0 != 1)
        {
            goto label_31;
        }
        
        Player val_4 = App.Player;
        var val_5 = 0 + 60;
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_7 = dynamicQuizEntryCost;
        decimal val_8 = System.Decimal.op_Implicit(value:  -719853652);
        val_34 = 35626060;
        val_33 = 1152921504899551232;
        val_40 = 1152921504892043264;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256}, d2:  new System.Decimal())) == true)
        {
            goto label_64;
        }
        
        label_31:
        GameBehavior val_10 = App.getBehavior;
        if(0 != 2)
        {
            goto label_57;
        }
        
        val_32 = 1152921504901095424;
        val_41 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
            goto label_57;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_32 = val_34;
        Player val_15 = App.Player;
        val_41 = 7.286752E-44f;
        WordForest.WFOGameEcon val_16 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_17 = dynamicQuizEntryCost;
        decimal val_18 = System.Decimal.op_Implicit(value:  -719853652);
        val_34 = val_32;
        val_33 = 1152921504899551232;
        val_31 = val_31;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) == true)
        {
            goto label_64;
        }
        
        label_57:
        GameBehavior val_20 = App.getBehavior;
        if(0 != 4)
        {
            goto label_69;
        }
        
        label_64:
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_42 = null;
        val_42 = null;
        TryShowPromptVideo(entryPoint:  PurchaseProxy.currentPurchasePoint, showAsFlyout:  false);
        return;
        label_69:
        val_43 = null;
        val_43 = null;
        if(PurchaseProxy.currentPurchasePoint == 114)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(VideoAdsAllowed == false)
        {
                return;
        }
        
            GameBehavior val_24 = App.getBehavior;
            val_44 = 0;
            val_45 = mem[1179403879];
            return;
        }
        
        val_46 = null;
        val_46 = null;
        val_32 = 32;
        if(PurchaseProxy.currentPurchasePoint != 98)
        {
                val_47 = null;
            val_47 = null;
            val_32 = 33;
            if(PurchaseProxy.currentPurchasePoint != 99)
        {
                val_48 = null;
            val_48 = null;
            if(val_31 == true)
        {
                35 = 34;
        }
        
            if(PurchaseProxy.currentPurchasePoint == 104)
        {
                val_32 = 37;
        }
        
        }
        
        }
        
        if(((val_32 != true) && (val_31 != false)) && ((FOMOPackEventHandler.<Instance>k__BackingField) != 0))
        {
                bool val_26 = FOMOPackEventHandler.<Instance>k__BackingField.TryShowPopup(isOOC:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(VideoAdsAllowed == false)
        {
                return;
        }
        
        GameBehavior val_29 = App.getBehavior;
        val_44 = 0;
        val_45 = mem[1179403879];
    }
    public override bool get_subscriptionGrantsGems()
    {
        return true;
    }
    public override decimal get_PlayerInitialCoins()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return new System.Decimal() {flags = -719865256, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = -719865256, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    public override int get_PlayerInitialGems()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916328];
        }
        
        return (int)mem[1152921512476916328];
    }
    public override int get_RewardedVideoGemReward()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916216];
        }
        
        return (int)mem[1152921512476916216];
    }
    public override void OnClickHome()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_15;
        System.Func<System.Boolean> val_17;
        var val_18;
        System.Func<System.Boolean> val_20;
        var val_21;
        val_11 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
            goto label_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlayingChallenge == false)
        {
            goto label_9;
        }
        
        val_12 = this;
        val_13 = null;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        typeof(System.Boolean[]).__il2cppRuntimeField_11 = 1;
        typeof(System.String[]).__il2cppRuntimeField_10 = "HOME";
        typeof(System.String[]).__il2cppRuntimeField_14 = "CANCEL";
        val_15 = null;
        val_15 = null;
        val_17 = TRVMetaGameBehavior.<>c.<>9__79_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<System.Boolean>(object:  TRVMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3575661936));
            val_12 = val_12;
            val_13 = val_13;
            TRVMetaGameBehavior.<>c.<>9__79_0 = val_17;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_17;
        val_18 = null;
        val_18 = null;
        val_20 = TRVMetaGameBehavior.<>c.<>9__79_1;
        if(val_20 != 0)
        {
            goto label_31;
        }
        
        val_20 = null;
        val_20 = new System.Func<System.Boolean>(object:  TRVMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3575662960));
        val_13 = val_13;
        val_12 = val_12;
        TRVMetaGameBehavior.<>c.<>9__79_1 = val_20;
        if(val_20 == 0)
        {
            goto label_34;
        }
        
        label_31:
        if(val_20 != 0)
        {
            goto label_36;
        }
        
        goto label_36;
        label_9:
        GameBehavior val_7 = App.getBehavior;
        if(0 == 2)
        {
                val_11 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AbortQuiz();
        }
        
        }
        
        this.OnClickHome();
        return;
        label_34:
        val_20 = 0;
        label_36:
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = val_20;
        val_21 = null;
        val_21 = null;
        this.SetupMessage(titleTxt:  -1637449984, messageTxt:  -719305520, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public override bool get_PiggyBankUsesGems()
    {
        return true;
    }
    public override bool CanAccessLimitedTimeBundles()
    {
        return true;
    }
    public override bool LTB_V2()
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
    public override bool ShouldShowLTBPopup(int levelSincePopup, int Interval)
    {
        var val_18;
        var val_19;
        var val_20;
        val_18 = this;
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_19 = 0;
        if(0 <= mem[1152921512476916148])
        {
                return (bool)val_19;
        }
        
        if(mem[1152921512476916148].timesShownThisSession > 7)
        {
                return (bool)val_19;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_19 = 0;
        if((-1566656096) == 0)
        {
                return (bool)val_19;
        }
        
        val_20 = null;
        val_20 = null;
        if(LimitedTimeBundlesManager.BundleLocKeys == 0)
        {
                return (bool)val_19;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_7 = LimitedTimeBundlesManager.BundlePackagesKeys;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = 0;
        val_18 = GetCurrentCountOfBundlePurchase(bundleId:  2621443);
        if(val_18 == 2)
        {
            goto label_22;
        }
        
        label_43:
        if(levelSincePopup < Interval)
        {
                return (bool)val_19;
        }
        
        if(val_18 != 0)
        {
                return (bool)val_19;
        }
        
        label_44:
        int val_9 = levelSincePopup.timesShownThisSession;
        val_9.timesShownThisSession = val_9 + 1;
        val_19 = 1;
        return (bool)val_19;
        label_22:
        Player val_11 = App.Player;
        WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        var val_18 = mem[1152921512476916148];
        val_18 = val_18 + 1;
        if(0 != val_18)
        {
            goto label_43;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
            goto label_43;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.successfullyCompletedQuiz) == false)
        {
            goto label_43;
        }
        
        goto label_44;
    }
    public override void AppendPurchaseTracking(ref System.Collections.Generic.Dictionary<string, object> tracking, PurchaseModel pm)
    {
        bool val_10;
        var val_12;
        var val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 0;
        if((-718511200) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = IsPlaying();
        }
        
        tracking.Add(key:  -718510176, value:  8945664);
        Player val_5 = App.Player;
        tracking.Add(key:  -763995120, value:  13152256);
        Player val_6 = App.Player;
        tracking.Add(key:  -763995024, value:  13152256);
        decimal val_7 = GoldenCurrency;
        val_12 = null;
        val_12 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
                return;
        }
        
        decimal val_9 = GoldenCurrency;
        val_14 = 1152921510535002416;
        tracking.Add(key:  -763994928, value:  10170368);
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
    public override void ShowDailyBonusPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        var val_12;
        object val_13;
        var val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-829531920) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Count;
            userProperties.Add(key:  -717907216, value:  13152256);
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1254191344) != 0)
        {
                WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            BonusRewardsContainer val_9 = GetCurrentRewards();
            userProperties.Add(key:  -1820396496, value:  13152256);
        }
        
        var val_11 = 24766897;
        val_11 = 10868296 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.String.IsNullOrEmpty(value:  AdjustPlugin.<Attribution_adgroup>k__BackingField)) != false)
        {
                val_13 = "none";
        }
        else
        {
                if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
            val_14 = null;
            val_14 = null;
            val_13 = 1152921504895189004;
        }
        
        userProperties.Add(key:  -717907088, value:  val_13);
    }
    public override bool ArePopupsAllowedForSceneType(SceneType type)
    {
        SceneType val_1 = type - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override string GetSpecialCurrencyLocalizationKey()
    {
    
    }
    public override void OnLevelAwarded()
    {
    
    }
    public override float get_WindowManagerBackgroundAlpha()
    {
        return (float)S0;
    }
    public override void ShowGameSpecificPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 != mem[1152921512476916284])
        {
                return;
        }
        
        if((CPlayerPrefs.GetBool(key:  -717330672, defaultValue:  false)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool get_CanShowUnPauseInterstitial()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-717217552) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.playingGame) == false)
        {
                val_7 = 1;
        }
        
            return (bool)val_7;
        }
        
        }
        
        val_7 = 1;
        return (bool)val_7;
    }
    public override bool get_canShowGameSceneEventUpdates()
    {
        var val_1;
        var val_1 = 24759942;
        val_1 = 10869796 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        string val_2 = TRVMainController.noAnswerSelectedCharacter;
        val_2 = val_2 >> 5;
        return (bool)val_2;
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
    }
    public TRVMetaGameBehavior()
    {
    
    }

}
