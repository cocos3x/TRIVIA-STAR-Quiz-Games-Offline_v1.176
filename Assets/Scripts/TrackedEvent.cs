using UnityEngine;
public class TrackedEvent
{
    // Fields
    private string eventName;
    private System.Collections.Generic.Dictionary<string, object> properties;
    private int index;
    
    // Methods
    public TrackedEvent(string eventName, System.Collections.Generic.Dictionary<string, object> properties, int index)
    {
        this.eventName = "";
        val_1 = new System.Object();
        this.eventName = eventName;
        this.properties = val_1;
        this.index = index;
    }
    public override string ToString()
    {
        string val_1 = this.index.ToString();
        string val_2 = MiniJSON.Json.Serialize(obj:  this.properties);
        string val_3 = this.properties.Replace(oldValue:  1634892480, newValue:  -1978839424);
        string val_4 = System.String.Format(format:  -1978839344, arg0:  this.index, arg1:  this.eventName, arg2:  this.properties);
    }

}
