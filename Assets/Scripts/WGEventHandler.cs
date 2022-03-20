using UnityEngine;
public class WGEventHandler : IDisposable
{
    // Fields
    protected GameEventV2 myEvent;
    public System.Action OnMyPopupWasClosed_action;
    
    // Properties
    public string EventType { get; }
    public virtual bool SupportsGoldenApples { get; }
    public virtual bool IsEventValid { get; }
    public virtual bool IsEventHidden { get; }
    public virtual bool OverrideEventButton { get; }
    public virtual int getPriorityWeight { get; }
    public virtual int UnlockLevel { get; }
    public virtual bool IsPointCollection { get; }
    public virtual bool IsGoalCompletion { get; }
    public virtual int PointsCollected { get; set; }
    public virtual int PointsRequired { get; }
    
    // Methods
    public static string UnFuckTrackingName(string eventName)
    {
        var val_18;
        var val_19;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  eventName);
        if(val_1 > 2561595708)
        {
            goto label_1;
        }
        
        if(val_1 > 1314484049)
        {
            goto label_2;
        }
        
        if(val_1 > 813111565)
        {
            goto label_3;
        }
        
        if(val_1 == 386644468)
        {
            goto label_4;
        }
        
        if(val_1 != 813111565)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298909536);
        val_19 = "Trivia Masters Event";
        goto label_37;
        label_1:
        if(val_1 > 3548535312)
        {
            goto label_7;
        }
        
        if(val_1 > 3165936380)
        {
            goto label_8;
        }
        
        if(val_1 == 2763165661)
        {
            goto label_9;
        }
        
        if(val_1 != 3165936380)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298909328);
        val_19 = "Word Hunt";
        goto label_37;
        label_2:
        if(val_1 > 2102096662)
        {
            goto label_12;
        }
        
        if(val_1 == 1751534916)
        {
            goto label_13;
        }
        
        if(val_1 != 2102096662)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298909136);
        val_19 = "Crazy Categories Event";
        goto label_37;
        label_7:
        if(val_1 > 3988837984)
        {
            goto label_16;
        }
        
        if(val_1 == 3671570374)
        {
            goto label_17;
        }
        
        if(val_1 != 3988837984)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1648577792);
        val_19 = "Big Quiz Event";
        goto label_37;
        label_3:
        if(val_1 == 999457290)
        {
            goto label_20;
        }
        
        if(val_1 != 1314484049)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298908816);
        val_19 = "Season Event";
        goto label_37;
        label_8:
        if(val_1 == 3244402182)
        {
            goto label_23;
        }
        
        if(val_1 != 3548535312)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298908624);
        val_19 = "Star Championship Event";
        goto label_37;
        label_12:
        if(val_1 == 2337712501)
        {
            goto label_26;
        }
        
        if(val_1 != 2561595708)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298908384);
        val_19 = "Restaurant Master";
        goto label_37;
        label_16:
        if(val_1 == 4137344480)
        {
            goto label_29;
        }
        
        if(val_1 != 4241560753)
        {
                return;
        }
        
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298908160);
        val_19 = "Club Clash Event";
        goto label_37;
        label_4:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298908064);
        val_19 = "Bingo";
        goto label_37;
        label_9:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298907888);
        val_19 = "Piggy Bank Raid";
        goto label_37;
        label_13:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298907680);
        val_19 = "Hot N Spicy";
        goto label_37;
        label_17:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298907488);
        val_19 = "Raid Madness";
        goto label_37;
        label_20:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1549997168);
        val_19 = "Attack Madness";
        goto label_37;
        label_23:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1425319472);
        val_19 = "Forest Master";
        goto label_37;
        label_26:
        if((System.String.op_Equality(a:  eventName, b:  -1298907104)) == false)
        {
                "ApplePicking" = eventName;
        }
        
        return;
        label_29:
        val_18 = System.String.op_Equality(a:  eventName, b:  -1298907008);
        val_19 = "Trivia Pursuit";
        label_37:
        if(val_18 == false)
        {
                val_19 = eventName;
        }
    
    }
    public string get_EventType()
    {
        if(this.myEvent != 0)
        {
                "" = this.myEvent.type;
        }
    
    }
    public virtual bool get_SupportsGoldenApples()
    {
        return false;
    }
    public virtual bool get_IsEventValid()
    {
        return true;
    }
    public virtual bool get_IsEventHidden()
    {
        return false;
    }
    public virtual bool get_OverrideEventButton()
    {
        return false;
    }
    public virtual int get_getPriorityWeight()
    {
        return 0;
    }
    public virtual int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        return UnityEngine.Mathf.Max(a:  this.myEvent.minPlayerLevel, b:  983057);
    }
    public virtual void PreInit(GameEventV2 eventV2)
    {
    
    }
    public virtual void Init(GameEventV2 eventV2)
    {
        this.myEvent = eventV2;
    }
    public virtual void Dispose()
    {
    
    }
    public virtual void OnGameSceneInit()
    {
    
    }
    public virtual void OnGameSceneBegan()
    {
    
    }
    public virtual void OnMenuLoaded()
    {
    
    }
    public virtual void OnWordRegionLoaded()
    {
    
    }
    public virtual void OnMainMenuButtonPressed(bool connected)
    {
    
    }
    public virtual void OnGameButtonPressed(bool connected)
    {
    
    }
    public virtual bool IsChallengeCompleted()
    {
        return false;
    }
    public virtual bool IsRewardReadyToCollect()
    {
        return false;
    }
    public virtual int LastProgressTimestamp()
    {
        return 0;
    }
    public virtual bool IsExcludedFromGameSceneButtonOrdering()
    {
        return false;
    }
    public virtual void UpdateProgress()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnEventHandlerProgress();
    }
    public virtual bool IsEventEndedOffline()
    {
        return false;
    }
    public virtual void OnBeforeLevelComplete(int levelsProgressed = 1)
    {
    
    }
    public virtual void OnEventEnded()
    {
    
    }
    public virtual void OnDataUpdated(GameEventV2 eventV2)
    {
    
    }
    public virtual void OnProfileUpdated()
    {
    
    }
    public virtual void OnCategorySelected(TRVCategorySelectionInfo category)
    {
    
    }
    public virtual System.Collections.Generic.List<TRVCategorySelectionInfo> GetEventsRegisteredCategories(System.Collections.Generic.List<TRVCategorySelectionInfo> categories)
    {
    
    }
    public virtual string GetMainMenuButtonText()
    {
        if(this.myEvent != 0)
        {
                return this.myEvent.type + -1295593280(-1295593280);
        }
        
        return this.myEvent.type + -1295593280(-1295593280);
    }
    public virtual string GetGameButtonText()
    {
        if(this.myEvent != 0)
        {
                return this.myEvent.type + -1295593280(-1295593280);
        }
        
        return this.myEvent.type + -1295593280(-1295593280);
    }
    public virtual string GetEventDisplayName()
    {
        if(this.myEvent != 0)
        {
                return this.myEvent.type + -1295593280(-1295593280);
        }
        
        return this.myEvent.type + -1295593280(-1295593280);
    }
    public virtual void OnLevelComplete(int levelsProgressed = 1)
    {
    
    }
    public virtual void OnForestComplete(int levelsProgressed = 1)
    {
    
    }
    public virtual void OnNewForestShown()
    {
    
    }
    public virtual void OnForestUpdated()
    {
    
    }
    public virtual void OnMysteryChestCollected()
    {
    
    }
    public virtual void OnCategoryComplete()
    {
    
    }
    public virtual void OnDailyChallengeLevelComplete()
    {
    
    }
    public virtual void OnDailyChallengeRewardGranted()
    {
    
    }
    public virtual void OnBonusGameGoldCurrencyRewardGranted()
    {
    
    }
    public virtual void OnAppleAwarded(int appleAwarded)
    {
    
    }
    public virtual void OnSubmitWordWithHints(string word)
    {
    
    }
    public virtual void OnHintIncompleteWord(string word, Cell hintedCell)
    {
    
    }
    public virtual void OnHintForceMyEventLineWord(System.Collections.Generic.List<LineWord> lines, ref LineWord word, bool isPickerHint)
    {
    
    }
    public virtual void OnDailyChallengeInit()
    {
    
    }
    public virtual void HandleCollectAction()
    {
    
    }
    public virtual void HandleAdvertisedSeen()
    {
    
    }
    public virtual void HackAddLevels(int levelsHacked)
    {
    
    }
    public virtual void OnWindowsStateChange(bool anyActiveWindows)
    {
    
    }
    public virtual void OnVideoResponse(bool success)
    {
    
    }
    public virtual string DebugGetLevel()
    {
    
    }
    public virtual bool ActivelyPlayingGameMode()
    {
        return false;
    }
    public virtual System.DateTime GetTimeEnd()
    {
        this = R1 + 8 + 32;
        return new System.DateTime() {dateData = R1 + 8 + 32};
    }
    public virtual System.DateTime GetTimeStart()
    {
        this = R1 + 8 + 24;
        return new System.DateTime() {dateData = R1 + 8 + 24};
    }
    public virtual System.TimeSpan GetTimeLeft()
    {
        long val_7;
        long val_10;
        var val_11;
        var val_13;
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.TimeSpan val_6 = Subtract(value:  new System.DateTime() {dateData = 1152921511904198400});
        val_10 = val_7;
        val_11 = null;
        val_11 = null;
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_10}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == 1)
        {
                val_13 = null;
            val_13 = null;
            val_10 = System.TimeSpan.Zero;
        }
        
        this = val_10;
        return new System.TimeSpan() {_ticks = 1152921504622825472};
    }
    public virtual string GetCustomizedEventListItemTimerText()
    {
    
    }
    public virtual bool EventCompleted()
    {
        return false;
    }
    public virtual void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
    
    }
    public virtual void AppendDailyChallengeCompleteData(ref System.Collections.Generic.Dictionary<string, object> data)
    {
    
    }
    public virtual void AppendLeaguesRolloverData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
    
    }
    public virtual void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_4 = 35628029;
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
                return;
        }
        
        if(loader == 0)
        {
            
        }
    
    }
    public virtual void OnMyEventPopupClosed()
    {
        if(this.OnMyPopupWasClosed_action != 0)
        {
                this.OnMyPopupWasClosed_action.Invoke();
        }
        
        this.OnMyPopupWasClosed_action = 0;
    }
    public virtual string GetHackPanelEventData()
    {
    
    }
    public virtual bool TryShowFtux()
    {
        return false;
    }
    public virtual void MarkEventRewarded()
    {
    
    }
    public virtual GameLevel getGameLevel(GameLevel refLevel)
    {
    
    }
    public virtual bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return (bool)dailyChallengeState ^ 1;
    }
    public virtual bool ShouldShowInCategories(bool categoriesState)
    {
        return (bool)categoriesState;
    }
    public virtual bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        return false;
    }
    public virtual void ResetDCProgress()
    {
    
    }
    public virtual void OnPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
    
    }
    public virtual int GetMovingWordIndex()
    {
        return 0;
    }
    public virtual void OnValidWordSubmitted(string word)
    {
    
    }
    public virtual void OnInvalidWordSubmitted()
    {
    
    }
    public virtual void BreakStreak()
    {
    
    }
    public virtual void OnFacebookPluginUpdate()
    {
    
    }
    public virtual void OnPurchaseCompleted(PurchaseModel purchase)
    {
    
    }
    public virtual void OnPurchaseFailure(PurchaseModel purchase)
    {
    
    }
    public virtual void OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    public virtual void OnAnyHintUsed(bool free)
    {
    
    }
    public virtual UnityEngine.Sprite GetEventIcon()
    {
    
    }
    public virtual void OnLevelCompleteRewarded()
    {
    
    }
    public virtual void OnLevelCompleteRewardAnimFinished()
    {
    
    }
    public virtual System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
    
    }
    public virtual TRVQuizProgress GetCustomQuizLevel(TRVSubCategoryData data)
    {
    
    }
    public virtual WGWindow showPreQuestionWindow(TRVQuizProgress progress)
    {
    
    }
    public virtual bool HasMovingObject()
    {
        return false;
    }
    public virtual void AppendGemSpentTracking(ref System.Collections.Generic.Dictionary<string, object> refData)
    {
    
    }
    public virtual void AppendAmplitudeUserProperties(ref System.Collections.Generic.Dictionary<string, object> globals)
    {
    
    }
    public virtual string EventContentItemButtonText()
    {
        return Localization.Localize(key:  -1288494608, defaultValue:  -1288494704, useSingularKey:  false);
    }
    public virtual bool get_IsPointCollection()
    {
        return false;
    }
    public virtual bool get_IsGoalCompletion()
    {
        return false;
    }
    public virtual int get_PointsCollected()
    {
        return 0;
    }
    public virtual void set_PointsCollected(int value)
    {
    
    }
    public virtual int get_PointsRequired()
    {
        return 0;
    }
    public virtual RESEventRewardData GetCurrentReward()
    {
    
    }
    public virtual void OnSpinStarted()
    {
    
    }
    public virtual void OnSpinEnded()
    {
    
    }
    public virtual void OnReelStopped(Notification notif)
    {
    
    }
    public virtual void OnAllReelsStopped()
    {
    
    }
    public virtual void OnSpinAmountUpdate()
    {
    
    }
    public virtual void OnSpinBetUpdate()
    {
    
    }
    public WGEventHandler()
    {
    
    }

}
