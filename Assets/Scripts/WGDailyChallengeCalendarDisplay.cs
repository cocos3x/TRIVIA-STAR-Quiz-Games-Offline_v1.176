using UnityEngine;
public class WGDailyChallengeCalendarDisplay : UGUICalendarDisplay
{
    // Fields
    private WGDailyChallengePhaseBtn morningButton;
    private WGDailyChallengePhaseBtn eveningButton;
    private UnityEngine.UI.Button tooltipButton;
    private WGDailyChallengeCalendarDayDisplay lastClickedDay;
    private UnityEngine.Coroutine showTooltipCoroutine;
    private UnityEngine.Coroutine closeTooltipCoroutine;
    private DynamicToolTip tooltip;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1451883936, method:  new IntPtr(2843058208));
        this.tooltipButton.m_OnClick.AddListener(call:  162246656);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1451883936, name:  -1451908064);
    }
    public override void Setup(int month, int year, bool selectToday = False)
    {
        var val_2;
        float val_24;
        var val_25;
        ulong val_26;
        WGDailyChallengeCalendarDisplay val_27;
        float val_28;
        var val_29;
        if(0 != 0)
        {
                if(0 > 0)
        {
            goto label_2;
        }
        
        }
        
        this.InstantiateDayPrefabs();
        label_2:
        System.DateTime val_1 = DateTimeCheat.Now;
        val_24 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = val_2.Day;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = val_2.Month;
        System.Globalization.GregorianCalendar val_8 = new System.Globalization.GregorianCalendar();
        val_25 = GetDaysInMonth(year:  year, month:  month);
        System.DateTime val_10 = new System.DateTime(year:  year, month:  month, day:  1);
        val_26 = val_10.dateData;
        val_27 = this;
        val_28 = 1152921511080275808;
        if(this.DaysInGrid < 1)
        {
            goto label_13;
        }
        
        var val_32 = 0;
        val_25 = val_8 + val_25;
        goto label_72;
        label_63:
        label_68:
        0.Setup(day:  1152921504901095424, month:  month, year:  year, selectCurrentDate:  selectToday, dayProgress:  val_28);
        val_25 = val_26;
        val_24 = 1152921504901095424;
        val_28 = 1152921511080275808;
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_25 = mem[1152921511745021056] + 8;
        val_25 = val_25 + 0;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_26 = mem[1152921511745021056] + 8;
        val_26 = val_26 + 0;
        val_26 = mem[(mem[1152921511745021056] + 8 + 0) + 16 + 112];
        val_26 = (mem[1152921511745021056] + 8 + 0) + 16 + 112;
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_27 = mem[1152921511745021056] + 8;
        val_27 = val_27 + 0;
        val_29 = 0;
        if(((mem[1152921511745021056] + 8 + 0) + 16) != 0)
        {
                val_27 = this;
            if((((mem[1152921511745021056] + 8 + 0) + 16 + 100 + (WGDailyChallengeCalendarDayDisplay.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                (mem[1152921511745021056] + 8 + 0) + 16 = 0;
        }
        
            val_29 = (mem[1152921511745021056] + 8 + 0) + 16;
        }
        
        val_26.Invoke(arg1:  0, arg2:  false);
        goto label_47;
        label_72:
        if(val_32 >= val_8)
        {
            goto label_48;
        }
        
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_29 = mem[1152921511745021056] + 8;
        val_29 = val_29 + 0;
        val_26 = mem[(mem[1152921511745021056] + 8 + 0) + 16];
        val_26 = (mem[1152921511745021056] + 8 + 0) + 16;
        if(val_26 != 0)
        {
            goto label_52;
        }
        
        goto label_52;
        label_48:
        if(val_32 >= val_25)
        {
            goto label_53;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallenge_DayProgress val_17 = new DailyChallenge_DayProgress();
        var val_18 = (-1152921504642949119) + val_32;
        string val_19 = val_18.ToString();
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 16.ContainsKey(key:  -1451772604)) != false)
        {
                string val_21 = val_18.ToString();
            string val_22 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 16.Item[-1451772604];
        }
        
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_30 = mem[1152921511745021056] + 8;
        val_30 = val_30 + 0;
        if(((mem[1152921511745021056] + 8 + 0) + 16) == 0)
        {
            goto label_63;
        }
        
        goto label_68;
        label_53:
        if((mem[1152921511745021056] + 12) <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_31 = mem[1152921511745021056] + 8;
        val_31 = val_31 + 0;
        val_26 = mem[(mem[1152921511745021056] + 8 + 0) + 16];
        val_26 = (mem[1152921511745021056] + 8 + 0) + 16;
        label_52:
        label_47:
        val_32 = val_32 + 1;
        if(val_32 < this.DaysInGrid)
        {
            goto label_72;
        }
        
        label_13:
        NotificationCenter val_24 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1451760544, aName:  -1451784672);
    }
    public void HandleTooltipShowing()
    {
        this.StopTooltipCoroutines();
        this.DestroyTooltip();
        System.Collections.IEnumerator val_1 = this.ShowTooltipCoroutine();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1451648544);
        this.showTooltipCoroutine = this;
    }
    private void OnDayClicked(WGDailyChallengeCalendarDayDisplay dayClicked, bool showingTooltip = False)
    {
        float val_11;
        bool val_12;
        bool val_13;
        var val_14;
        WGDailyChallengePhaseBtn val_15;
        val_11 = this;
        val_12 = showingTooltip;
        val_13 = 1152921504901095424;
        val_14 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 20];
        val_15 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 20;
        bool val_2 = UnityEngine.Object.op_Equality(x:  dayClicked, y:  0);
        if(val_2 == true)
        {
                return;
        }
        
        if(val_2 > val_15)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = val_13;
        val_11 = 1152921504765685760;
        bool val_5 = val_12 + 144962064;
        string val_6 = Localization.Localize(key:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 2783935872) + 16, defaultValue:  (showingTooltip + 144962064) + 16, useSingularKey:  false);
        string val_7 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 2783935872) + 16.ToUpper();
        string val_8 = System.String.Format(format:  1592589744, arg0:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 2783935872) + 16, arg1:  13152256);
        val_13 = val_12;
        if(this.lastClickedDay != 0)
        {
                if(this.lastClickedDay != dayClicked)
        {
                this.lastClickedDay.ResetUI();
        }
        
        }
        
        this.lastClickedDay = dayClicked;
        if(val_13 != true)
        {
                this.StopTooltipCoroutines();
            this.DestroyTooltip();
        }
        
        val_15 = this.morningButton;
        if(val_11 == val_15)
        {
                val_15.UpdateUIForTodaysChallenge();
            this.eveningButton.UpdateUIForTodaysChallenge();
            return;
        }
        
        val_13 = dayClicked.<DayProgress>k__BackingField.stars_m;
        val_15.UpdateUIForPreviousChallenge(stars:  val_13);
        this.eveningButton.UpdateUIForPreviousChallenge(stars:  dayClicked.<DayProgress>k__BackingField.stars_e);
    }
    private void OnCloseTooltip()
    {
        var val_3;
        this.StopTooltipCoroutines();
        this.DestroyTooltip();
        UnityEngine.GameObject val_1 = this.tooltipButton.gameObject;
        this.tooltipButton.SetActive(value:  false);
        val_3 = null;
        val_3 = null;
        WGDailyChallengeV2Popup.onMainScreenBtnClicked = 0;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1451346608, aName:  -1451370720);
    }
    private void StopTooltipCoroutines()
    {
        if(this.showTooltipCoroutine != 0)
        {
                this.StopCoroutine(routine:  this.showTooltipCoroutine);
        }
        
        if(this.closeTooltipCoroutine == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.closeTooltipCoroutine);
    }
    private System.Collections.IEnumerator ShowTooltipCoroutine()
    {
        WGDailyChallengeCalendarDisplay.<ShowTooltipCoroutine>d__13 val_1 = new WGDailyChallengeCalendarDisplay.<ShowTooltipCoroutine>d__13(<>1__state:  0);
        typeof(WGDailyChallengeCalendarDisplay.<ShowTooltipCoroutine>d__13).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator CloseTooltipCoroutine()
    {
        WGDailyChallengeCalendarDisplay.<CloseTooltipCoroutine>d__14 val_1 = new WGDailyChallengeCalendarDisplay.<CloseTooltipCoroutine>d__14(<>1__state:  0);
        typeof(WGDailyChallengeCalendarDisplay.<CloseTooltipCoroutine>d__14).__il2cppRuntimeField_10 = this;
    }
    private void DestroyTooltip()
    {
        if(this.tooltip == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.tooltip.gameObject;
        UnityEngine.Object.Destroy(obj:  this.tooltip);
    }
    private WGDailyChallengeCalendarDayDisplay ShowTooltip()
    {
        var val_18;
        var val_19;
        System.Func<UGUICalendarDayDisplay, System.Boolean> val_21;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = 0;
        int val_2 = GetMatchingDayDistance();
        if(val_2 == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        val_21 = WGDailyChallengeCalendarDisplay.<>c.<>9__16_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGDailyChallengeCalendarDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2844193552));
            WGDailyChallengeCalendarDisplay.<>c.<>9__16_0 = val_21;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<System.Object>(source:  0, predicate:  7720960);
        object val_5 = System.Linq.Enumerable.First<System.Object>(source:  0);
        UnityEngine.Transform val_6 = 0.transform;
        UnityEngine.Transform val_7 = 0.parent;
        UnityEngine.Transform val_8 = 0.transform;
        UnityEngine.Transform val_11 = 0.GetChild(index:  0.GetSiblingIndex() + val_2);
        string val_12 = Localization.Localize(key:  -1450769648, defaultValue:  -1450769504, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_14 = PlaceGameObject<System.Object>(loc:  0);
        this.tooltip = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        if(new PopupViewportSettings() != 0)
        {
                typeof(PopupViewportSettings).__il2cppRuntimeField_8 = 1056964608;
            typeof(PopupViewportSettings).__il2cppRuntimeField_C = 1056964608;
            typeof(PopupViewportSettings).__il2cppRuntimeField_10 = 1020054733;
        }
        else
        {
                mem[8] = 1056964608;
            mem[12] = 1056964608;
            mem[16] = 1020054733;
        }
        
        typeof(PopupViewportSettings).__il2cppRuntimeField_14 = 1064514355;
        UnityEngine.GameObject val_16 = 0.gameObject;
        this.tooltip.ShowToolTip(objToToolTip:  0, text:  -1450769648, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1084227584, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
        object val_17 = 0.GetComponent<System.Object>();
        val_18 = 0;
    }
    private void InstantiateDayPrefabs()
    {
        var val_9;
        if(this.DaysInGrid < 1)
        {
                return;
        }
        
        label_11:
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  R6, parent:  R7);
        string val_3 = 0.ToString(format:  -1827641632);
        string val_4 = System.String.Format(format:  -1671354896, arg0:  -1450631992, arg1:  -1450646096);
        if(R6 != 0)
        {
                R6.name = -1671354896;
        }
        else
        {
                0.name = -1671354896;
        }
        
        object val_5 = R6.GetComponent<System.Object>();
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_6 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -1450619952, method:  new IntPtr(2844322320));
        System.Delegate val_7 = System.Delegate.Combine(a:  R6 + 112, b:  7507968);
        val_9 = R6 + 112;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_9;
        }
        
        }
        
        val_9 = 0;
        label_9:
        mem2[0] = val_9;
        val_9.Add(item:  R6);
        if(1 < this.DaysInGrid)
        {
            goto label_11;
        }
    
    }
    private void RefreshDailyChallengeCalendar()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleDayRollover();
        MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  -2116505760);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921511746274672] = null;
        System.DateTime val_3 = DateTimeCheat.Now;
        int val_6 = val_4.Month;
        int val_7 = val_4.Year;
    }
    public WGDailyChallengeCalendarDisplay()
    {
    
    }

}
