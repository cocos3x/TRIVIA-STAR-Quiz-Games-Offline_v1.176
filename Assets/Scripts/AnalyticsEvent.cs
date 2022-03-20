using UnityEngine;
public class AnalyticsEvent
{
    // Fields
    private string eventName;
    private double timestamp;
    private System.Collections.Generic.List<string> parameters;
    
    // Methods
    public AnalyticsEvent(string eventName, System.Collections.Generic.List<string> parameters)
    {
        ulong val_4;
        double val_7;
        val_1 = new System.Object();
        this.parameters = val_1;
        this.eventName = eventName;
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.DateTime val_3 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511429364584}, d2:  new System.DateTime() {dateData = val_4});
        double val_9 = val_7.TotalSeconds;
        this.timestamp = val_7;
    }
    public System.Collections.Generic.Dictionary<string, object> ToDictionary()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1982952528, value:  this.eventName);
        Add(key:  1470901296, value:  10489856);
        if(this.parameters == 0)
        {
                return;
        }
        
        set_Item(key:  1673410464, value:  this.parameters);
    }

}
