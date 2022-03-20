using UnityEngine;
public class OnTheTrailEventEcon
{
    // Fields
    public System.Collections.Generic.List<int> Goals;
    public System.Collections.Generic.List<int> Rewards;
    public int FixPrice;
    public int SecondsPerDay;
    
    // Methods
    public OnTheTrailEventEcon()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                Add(item:  10);
            Add(item:  15);
            Add(item:  20);
            Add(item:  25);
        }
        else
        {
                Add(item:  10);
            Add(item:  15);
            Add(item:  20);
            Add(item:  25);
        }
        
        Add(item:  30);
        this.Goals = val_1;
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        if(val_2 != 0)
        {
                Add(item:  50);
            Add(item:  100);
            Add(item:  250);
            Add(item:  500);
        }
        else
        {
                Add(item:  50);
            Add(item:  100);
            Add(item:  250);
            Add(item:  500);
        }
        
        Add(item:  1000);
        this.Rewards = val_2;
        this.FixPrice = 80;
        this.SecondsPerDay = 86400;
    }

}
