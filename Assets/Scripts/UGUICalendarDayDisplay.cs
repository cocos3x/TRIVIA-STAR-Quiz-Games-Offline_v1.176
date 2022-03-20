using UnityEngine;
public class UGUICalendarDayDisplay : MyButton
{
    // Fields
    protected UnityEngine.UI.Text dayText;
    protected UnityEngine.GameObject bg_past;
    protected UnityEngine.GameObject bg_present;
    protected UnityEngine.GameObject bg_future;
    public System.Action<UGUICalendarDayDisplay> OnClicked;
    public bool IsPlaceholder;
    public int Day;
    public int Month;
    public int Year;
    
    // Methods
    public override void OnButtonClick()
    {
        if(this.IsPlaceholder == true)
        {
                return;
        }
        
        R4.OnButtonClick();
        if((R4 + 36) == 0)
        {
                return;
        }
        
        R4 + 36.Invoke(obj:  R4);
    }
    public virtual void SetupAsInactive()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        this.IsPlaceholder = true;
    }
    public virtual void SetupAsGridPlaceholder()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  true);
        this.IsPlaceholder = true;
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_past)) != false)
        {
                this.bg_past.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_present)) != false)
        {
                this.bg_present.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_future)) != false)
        {
                this.bg_future.SetActive(value:  false);
        }
        
        UnityEngine.GameObject val_5 = this.dayText.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  this.dayText)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = this.dayText.gameObject;
        this.dayText.SetActive(value:  false);
    }
    public virtual void Setup(int day, int month, int year, bool selectCurrentDate)
    {
        int val_4;
        UnityEngine.UI.Text val_5;
        val_4 = day;
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  true);
        this.IsPlaceholder = false;
        this.Day = val_4;
        this.Month = month;
        this.Year = year;
        val_5 = this.dayText;
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
        {
                return;
        }
        
        val_5 = this.dayText;
        string val_3 = day.ToString(format:  2124620672);
        val_4;
    }
    protected virtual void SetupAsPast()
    {
        UnityEngine.GameObject val_1 = this.dayText.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  this.dayText)) != false)
        {
                UnityEngine.GameObject val_3 = this.dayText.gameObject;
            this.dayText.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_past)) != false)
        {
                this.bg_past.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_present)) != false)
        {
                this.bg_present.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_future)) == false)
        {
                return;
        }
        
        this.bg_future.SetActive(value:  false);
    }
    protected virtual void SetupAsPresent()
    {
        UnityEngine.GameObject val_1 = this.dayText.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  this.dayText)) != false)
        {
                UnityEngine.GameObject val_3 = this.dayText.gameObject;
            this.dayText.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_past)) != false)
        {
                this.bg_past.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_present)) != false)
        {
                this.bg_present.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_future)) == false)
        {
                return;
        }
        
        this.bg_future.SetActive(value:  false);
    }
    protected virtual void SetupAsFuture()
    {
        UnityEngine.GameObject val_1 = this.dayText.gameObject;
        if((UnityEngine.Object.op_Implicit(exists:  this.dayText)) != false)
        {
                UnityEngine.GameObject val_3 = this.dayText.gameObject;
            this.dayText.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_past)) != false)
        {
                this.bg_past.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_present)) != false)
        {
                this.bg_present.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg_future)) == false)
        {
                return;
        }
        
        this.bg_future.SetActive(value:  true);
    }
    public virtual void Select()
    {
        goto typeof(UGUICalendarDayDisplay).__il2cppRuntimeField_10C;
    }
    public virtual void Deselect(bool selectCurrentDate)
    {
        var val_8;
        if(this.IsPlaceholder == true)
        {
                return;
        }
        
        System.DateTime val_1 = new System.DateTime(year:  this.Year, month:  this.Month, day:  this.Day);
        System.DateTime val_2 = AddDays(value:  null);
        System.DateTime val_5 = AddSeconds(value:  null);
        35628286 = 0;
        System.DateTime val_6 = DateTimeCheat.Today;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513015653536}, d2:  new System.DateTime());
        double val_10 = val_8.TotalSeconds;
    }
    public UGUICalendarDayDisplay()
    {
        this.IsPlaceholder = true;
        this.Day = 0;
        this.Month = 0;
        this.Year = 0;
    }

}
