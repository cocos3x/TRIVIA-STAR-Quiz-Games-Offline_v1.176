using UnityEngine;
[Serializable]
public class CategoryPackInfo
{
    // Fields
    public int packId;
    public string title;
    public string suffix;
    public bool timeLimited;
    public System.DateTime availableDate;
    public float availableDuration;
    public decimal cost;
    public CategoryColorCode color;
    
    // Properties
    public string FullTitle { get; }
    public bool IsTimeLimited { get; }
    public System.DateTime ExpiryDate { get; }
    public bool IsAvailable { get; }
    
    // Methods
    public string get_FullTitle()
    {
        return System.String.Format(format:  1592589744, arg0:  this.title, arg1:  this.suffix);
    }
    public bool get_IsTimeLimited()
    {
        return (bool)this.timeLimited;
    }
    public System.DateTime get_ExpiryDate()
    {
        var val_1 = R1 + 24;
        System.DateTime val_2 = this.AddDays(value:  null);
        return new System.DateTime() {dateData = val_2.dateData};
    }
    public bool get_IsAvailable()
    {
        var val_2;
        var val_8;
        if(this.timeLimited != false)
        {
                val_8 = 0;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            long val_4 = val_2.Ticks;
            long val_5 = this.availableDate.Ticks;
            val_5 = val_4 - val_5;
            System.DateTime val_6 = AddDays(value:  null);
            long val_7 = val_2.Ticks;
            val_7 = val_7 - val_4;
            if(DateTimeCheat.__il2cppRuntimeField_cctor_finished >= 0)
        {
                val_8 = 1;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    public CategoryPackInfo(int id, string namePrefix, string nameSuffix, decimal price, CategoryColorCode colorType, bool limitedTime = False)
    {
        val_1 = new System.Object();
        this.packId = id;
        this.title = val_1;
        this.suffix = nameSuffix;
        this.cost = price;
        mem[1152921511704983352] = price.hi;
        this.timeLimited = limitedTime;
    }
    public void SetTimeLimited(System.DateTime startDate, float availDuration)
    {
        float val_1;
        this.availableDate = new System.DateTime();
        mem[1152921511705107628] = R3;
        this.timeLimited = true;
        this.availableDuration = val_1;
    }

}
