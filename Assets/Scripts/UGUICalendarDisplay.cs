using UnityEngine;
public class UGUICalendarDisplay : MonoBehaviour
{
    // Fields
    protected readonly string[] monthNames;
    protected UnityEngine.GameObject dayPrefab;
    protected UnityEngine.Transform dayGrid;
    protected UnityEngine.UI.Text monthText;
    protected int weeksToDisplay;
    protected System.Collections.Generic.List<UGUICalendarDayDisplay> instantiatedDays;
    private int currentMonth;
    private int currentYear;
    
    // Properties
    public int DaysInGrid { get; }
    
    // Methods
    public int get_DaysInGrid()
    {
        int val_1 = this.weeksToDisplay;
        val_1 = (val_1 << 3) - val_1;
        return (int)val_1;
    }
    private void Awake()
    {
        goto typeof(UGUICalendarDisplay).__il2cppRuntimeField_DC;
    }
    private void OnEnable()
    {
        goto typeof(UGUICalendarDisplay).__il2cppRuntimeField_E4;
    }
    protected virtual void DoOnAwake()
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.dayGrid);
        System.Action val_2 = new System.Action(object:  -180549808, method:  new IntPtr(4114392464));
        mem2[0] = null;
    }
    protected virtual void DoOnEnable()
    {
        var val_2;
        var val_6;
        System.DateTime val_1 = DateTimeCheat.Now;
        this.currentMonth = val_2.Month;
        System.DateTime val_5 = DateTimeCheat.Now;
        this.currentYear = val_6.Year;
    }
    private void MarkForRebuild()
    {
        System.Collections.IEnumerator val_1 = this.MarkForRebuildAfterFrame();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -180321712);
    }
    private System.Collections.IEnumerator MarkForRebuildAfterFrame()
    {
        object val_1 = new System.Object();
        typeof(UGUICalendarDisplay.<MarkForRebuildAfterFrame>d__15).__il2cppRuntimeField_8 = 0;
        typeof(UGUICalendarDisplay.<MarkForRebuildAfterFrame>d__15).__il2cppRuntimeField_10 = this;
    }
    protected virtual void RefreshRebuild()
    {
        UnityEngine.Transform val_1 = this.dayGrid.parent;
        if(this.dayGrid != 0)
        {
                if(null != null)
        {
                this.dayGrid = 0;
        }
        
            0 = this.dayGrid;
        }
        
        UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  0);
    }
    public virtual void Setup(int month, int year, bool selectToday = False)
    {
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = month;
        if(this.instantiatedDays != 0)
        {
                if(this.instantiatedDays > 0)
        {
            goto label_2;
        }
        
        }
        
        this.InstantiateDayPrefabs();
        label_2:
        string val_8 = this.monthNames[val_7];
        string val_1 = val_8.ToUpper();
        string val_2 = year.ToString();
        string val_3 = val_8 + 1297836560 + -179932216(-179932216);
        System.Globalization.GregorianCalendar val_4 = null;
        val_8 = 0;
        val_4 = new System.Globalization.GregorianCalendar();
        val_9 = GetDaysInMonth(year:  year, month:  val_7);
        System.DateTime val_6 = new System.DateTime(year:  year, month:  val_7, day:  1);
        int val_9 = this.weeksToDisplay;
        val_9 = (val_9 << 3) - val_9;
        if(val_9 < 1)
        {
                return;
        }
        
        val_9 = val_4 + val_9;
        label_21:
        if(0 >= val_4)
        {
            goto label_10;
        }
        
        if((-1152921504642949119) <= 0)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        val_10 = mem[(0 + 0) + 16];
        val_10 = (0 + 0) + 16;
        if(val_10 != 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_10:
        if((-1152921504642949119) <= 0)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        val_10 = mem[(0 + 0) + 16];
        val_10 = (0 + 0) + 16;
        if(0 >= val_9)
        {
            goto label_17;
        }
        
        var val_7 = (-1152921504642949119) + 0;
        goto label_19;
        label_17:
        label_14:
        label_19:
        int val_12 = this.weeksToDisplay;
        val_8 = 0 + 1;
        val_12 = (val_12 << 3) - val_12;
        if(val_8 < val_12)
        {
            goto label_21;
        }
    
    }
    private void InstantiateDayPrefabs()
    {
        var val_7;
        int val_7 = this.weeksToDisplay;
        val_7 = (val_7 << 3) - val_7;
        if(val_7 < 1)
        {
                return;
        }
        
        label_10:
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.dayPrefab, parent:  this.dayGrid);
        string val_2 = 0.ToString(format:  -1827641632);
        string val_3 = -179748536(-179748536) + -1450646096(-1450646096);
        if(this.dayPrefab != 0)
        {
                this.dayPrefab.name = -179748536;
        }
        else
        {
                0.name = -179748536;
        }
        
        object val_4 = this.dayPrefab.GetComponent<System.Object>();
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -179736496, method:  typeof(UGUICalendarDisplay).__il2cppRuntimeField_100);
        val_7 = ;
        System.Delegate val_6 = System.Delegate.Combine(a:  -179748536, b:  7401472);
        if(val_7 != 0)
        {
                if(0 == null)
        {
            goto label_8;
        }
        
        }
        
        val_7 = 0;
        label_8:
        mem2[0] = val_7;
        this.instantiatedDays.Add(item:  this.dayPrefab);
        int val_8 = this.weeksToDisplay;
        val_8 = (val_8 << 3) - val_8;
        if(1 < val_8)
        {
            goto label_10;
        }
    
    }
    public virtual void OnDayClicked(UGUICalendarDayDisplay dayClicked)
    {
        var val_1 = 35628293;
        int val_1 = this.weeksToDisplay;
        val_1 = (val_1 << 3) - val_1;
        if(val_1 >= 1)
        {
                var val_3 = 0;
            do
        {
            if(val_1 <= val_3)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_2 = val_2 + 0;
            val_1 = mem[(0 + 0) + 16];
            val_1 = (0 + 0) + 16;
            int val_4 = this.weeksToDisplay;
            val_3 = val_3 + 1;
            val_4 = (val_4 << 3) - val_4;
        }
        while(val_3 < val_4);
        
        }
        
        if(dayClicked == 0)
        {
            
        }
    
    }
    public void PrevMonth()
    {
        int val_2 = this.currentMonth;
        if(val_2 == 1)
        {
                int val_1 = this.currentYear;
            this.currentMonth = 12;
            val_1 = val_1 - 1;
            this.currentYear = val_1;
            return;
        }
        
        val_2 = val_2 - 1;
        this.currentMonth = val_2;
    }
    public void NextMonth()
    {
        int val_2 = this.currentMonth;
        if(val_2 == 12)
        {
                int val_1 = this.currentYear;
            this.currentMonth = 1;
            val_1 = val_1 + 1;
            this.currentYear = val_1;
            return;
        }
        
        val_2 = val_2 + 1;
        this.currentMonth = val_2;
    }
    public UGUICalendarDisplay()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "---";
        typeof(System.String[]).__il2cppRuntimeField_14 = "january";
        typeof(System.String[]).__il2cppRuntimeField_18 = "february";
        typeof(System.String[]).__il2cppRuntimeField_1C = "march";
        typeof(System.String[]).__il2cppRuntimeField_20 = "april";
        typeof(System.String[]).__il2cppRuntimeField_24 = "may";
        typeof(System.String[]).__il2cppRuntimeField_28 = "june";
        typeof(System.String[]).__il2cppRuntimeField_2C = "july";
        typeof(System.String[]).__il2cppRuntimeField_30 = "august";
        typeof(System.String[]).__il2cppRuntimeField_34 = "september";
        typeof(System.String[]).__il2cppRuntimeField_38 = "october";
        typeof(System.String[]).__il2cppRuntimeField_3C = "november";
        typeof(System.String[]).__il2cppRuntimeField_40 = "december";
        this.weeksToDisplay = 6;
        this.monthNames = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.instantiatedDays = null;
        this.currentMonth = 0;
        this.currentYear = 0;
    }

}
