using UnityEngine;
public class LimitedTimeframe
{
    // Fields
    private System.DateTime startDate;
    private int durationDays;
    
    // Methods
    public LimitedTimeframe(string date, string duration)
    {
        var val_7;
        int val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        val_9 = 0;
        this.startDate = System.DateTime.MinValue;
        mem[1152921512044398460] = System.DateTime.__il2cppRuntimeField_cctor_finished;
        val_1 = new System.Object();
        System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
        if((System.DateTime.TryParse(s:  date, provider:  0, styles:  0, result: out  new System.DateTime() {dateData = this.startDate})) != false)
        {
                if((System.Int32.TryParse(s:  string val_1 = duration, result: out  this.durationDays)) == true)
        {
                return;
        }
        
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "LimitedTimeframe failed to parse ";
        typeof(System.String[]).__il2cppRuntimeField_14 = date;
        typeof(System.String[]).__il2cppRuntimeField_18 = " to valid date, or ";
        typeof(System.String[]).__il2cppRuntimeField_1C = val_1;
        typeof(System.String[]).__il2cppRuntimeField_20 = " to valid int. Defaulting to minimum time and minimal duration.";
        string val_6 = +477709520;
        val_9 = 0;
        UnityEngine.Debug.LogError(message:  477709520);
        val_10 = null;
        val_10 = null;
        this.startDate = System.DateTime.MinValue;
        this.durationDays = val_9;
    }
    public System.DateTime GetEndDate()
    {
        var val_1 = R1 + 8;
        System.DateTime val_2 = this.AddDays(value:  null);
        return new System.DateTime() {dateData = val_2.dateData};
    }
    public bool IsWithinTimeFrame(System.DateTime time)
    {
        ulong val_2;
        var val_7;
        System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512044618584}, d2:  new System.DateTime() {dateData = R2});
        System.DateTime val_5 = AddDays(value:  val_2.TotalSeconds);
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512044618576}, d2:  new System.DateTime() {dateData = val_2});
        double val_9 = val_7.TotalSeconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished >= 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public override string ToString()
    {
        string val_2 = this.startDate.Month.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_4 = this.startDate.Day.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_6 = this.startDate.Year.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_7 = this.durationDays.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_1C = this.durationDays;
        string val_8 = System.String.Format(format:  -1152062928, args:  472754880);
    }

}
