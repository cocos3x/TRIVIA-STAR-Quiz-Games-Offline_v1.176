using UnityEngine;
public class Notification
{
    // Fields
    public UnityEngine.Component sender;
    public string name;
    public System.Collections.Hashtable data;
    
    // Methods
    public Notification(UnityEngine.Component aSender, string aName)
    {
        val_1 = new System.Object();
        this.sender = aSender;
        this.name = val_1;
        this.data = 0;
    }
    public Notification(UnityEngine.Component aSender, string aName, System.Collections.Hashtable aData)
    {
        val_1 = new System.Object();
        this.sender = aSender;
        this.name = val_1;
        this.data = aData;
    }

}
