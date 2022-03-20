using UnityEngine;
public class WGDailyChallengeCalendarDayDisplay : UGUICalendarDayDisplay
{
    // Fields
    private UnityEngine.Color fullStarsBg;
    private UnityEngine.Color lessStarsBg;
    private UnityEngine.Sprite selectedBg;
    private UnityEngine.GameObject entire_group;
    private UnityEngine.UI.Image present_past_bg;
    private UnityEngine.UI.Image outline;
    private DailyChallengeStarGroup starGroup_m;
    private DailyChallengeStarGroup starGroup_e;
    public System.Action<WGDailyChallengeCalendarDayDisplay, bool> OnClicked;
    private DailyChallenge_DayProgress <DayProgress>k__BackingField;
    
    // Properties
    public DailyChallenge_DayProgress DayProgress { get; set; }
    
    // Methods
    public DailyChallenge_DayProgress get_DayProgress()
    {
    
    }
    private void set_DayProgress(DailyChallenge_DayProgress value)
    {
        this.<DayProgress>k__BackingField = value;
    }
    public void Setup(int day, int month, int year, bool selectCurrentDate, DailyChallenge_DayProgress dayProgress)
    {
        DailyChallenge_DayProgress val_6 = dayProgress;
        mem[1152921513092911484] = day;
        mem[1152921513092911480] = 0;
        if(val_6 == 0)
        {
                DailyChallenge_DayProgress val_1 = null;
            val_6 = val_1;
            val_1 = new DailyChallenge_DayProgress();
        }
        
        this.<DayProgress>k__BackingField = val_6;
        UnityEngine.GameObject val_2 = month.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  month)) != false)
        {
                string val_4 = mem[1152921513092911484].ToString();
            UnityEngine.GameObject val_5 = month.gameObject;
            month.SetActive(value:  false);
        }
    
    }
    public bool IsDayCompleted()
    {
        if((this.<DayProgress>k__BackingField.stars_m) != 3)
        {
                return (bool)0;
        }
        
        int val_1 = this.<DayProgress>k__BackingField.stars_e;
        val_1 = val_1 - 3;
        0 = val_1 >> 5;
        return (bool)0;
    }
    public void ResetUI()
    {
        var val_3;
        var val_4;
        var val_5;
        UnityEngine.Color val_6;
        if(this.IsDayCompleted() != false)
        {
                val_3 = 1152921513093164180;
            val_4 = 1152921513093164176;
            val_5 = 1152921513093164172;
            val_6 = this.fullStarsBg;
        }
        else
        {
                val_3 = 1152921513093164196;
            val_4 = 1152921513093164192;
            val_5 = 1152921513093164188;
            val_6 = this.lessStarsBg;
        }
        
        this.present_past_bg.color = new UnityEngine.Color() {r = this.lessStarsBg.r, g = 4.086426E-25f, b = 4.086426E-25f};
        UnityEngine.GameObject val_2 = this.outline.gameObject;
        this.outline.SetActive(value:  false);
    }
    private void SetupDayDisplay()
    {
        var val_6;
        var val_7;
        var val_8;
        UnityEngine.Color val_9;
        if(this.IsDayCompleted() != false)
        {
                val_6 = 1152921513093321236;
            val_7 = 1152921513093321232;
            val_8 = 1152921513093321228;
            val_9 = this.fullStarsBg;
        }
        else
        {
                val_6 = 1152921513093321252;
            val_7 = 1152921513093321248;
            val_8 = 1152921513093321244;
            val_9 = this.lessStarsBg;
        }
        
        this.present_past_bg.color = new UnityEngine.Color() {r = this.lessStarsBg.r, g = 4.086426E-25f, b = 4.086426E-25f};
        this.starGroup_m.Setup(stars:  this.<DayProgress>k__BackingField.stars_m);
        this.starGroup_e.Setup(stars:  this.<DayProgress>k__BackingField.stars_e);
        UnityEngine.GameObject val_2 = this.outline.gameObject;
        this.outline.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.starGroup_m.gameObject;
        this.starGroup_m.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.starGroup_e.gameObject;
        this.starGroup_e.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.present_past_bg.gameObject;
        this.present_past_bg.SetActive(value:  true);
    }
    private void OnDayClicked(UGUICalendarDayDisplay display, bool showingTooltip)
    {
        var val_3;
        var val_4;
        var val_5;
        UnityEngine.Color val_6;
        if(this.IsDayCompleted() != false)
        {
                val_3 = 1152921513093490580;
            val_4 = 1152921513093490576;
            val_5 = 1152921513093490572;
            val_6 = this.fullStarsBg;
        }
        else
        {
                val_3 = 1152921513093490596;
            val_4 = 1152921513093490592;
            val_5 = 1152921513093490588;
            val_6 = this.lessStarsBg;
        }
        
        this.present_past_bg.color = new UnityEngine.Color() {r = this.lessStarsBg.r, g = 4.086426E-25f, b = 4.086426E-25f};
        this.outline.sprite = this.selectedBg;
        UnityEngine.GameObject val_2 = this.outline.gameObject;
        this.outline.SetActive(value:  true);
    }
    public override void Deselect(bool selectCurrentDate)
    {
        var val_8;
        if(true != 0)
        {
                return;
        }
        
        System.DateTime val_1 = new System.DateTime(year:  selectCurrentDate, month:  0, day:  0);
        System.DateTime val_2 = AddDays(value:  null);
        System.DateTime val_5 = AddSeconds(value:  null);
        35627108 = 0;
        System.DateTime val_6 = DateTimeCheat.Today;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513093610912}, d2:  new System.DateTime());
        double val_10 = val_8.TotalSeconds;
        double val_11 = val_8.TotalHours;
        if(selectCurrentDate != false)
        {
                this.SetupDayDisplay();
            return;
        }
        
        this.SetupAsFuture();
    }
    public override void Select()
    {
        this.Select();
    }
    public override void SetupAsGridPlaceholder()
    {
        this.SetupAsGridPlaceholder();
        this.entire_group.SetActive(value:  false);
    }
    protected override void SetupAsPresent()
    {
        UnityEngine.GameObject val_1 = static_value_021FA065.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  static_value_021FA065)) != false)
        {
                UnityEngine.GameObject val_3 = static_value_021FA065.gameObject;
            static_value_021FA065.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  static_value_021FA065)) != false)
        {
                static_value_021FA065.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  static_value_021FA065)) != false)
        {
                static_value_021FA065.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  static_value_021FA065)) == false)
        {
                return;
        }
        
        this.SetActive(value:  false);
    }
    public override void OnButtonClick()
    {
        if(true != 0)
        {
                return;
        }
        
        R4.OnButtonClick();
        if((R4 + 112) == 0)
        {
                return;
        }
        
        R4 + 112.Invoke(arg1:  R4, arg2:  false);
    }
    private void Awake()
    {
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_1 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -102589360, method:  new IntPtr(4192352912));
        this.OnClicked = null;
    }
    public WGDailyChallengeCalendarDayDisplay()
    {
    
    }

}
