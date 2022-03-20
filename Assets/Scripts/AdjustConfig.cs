using UnityEngine;
public class AdjustConfig : ScriptableObject
{
    // Fields
    public AdjustProductConfig Free_Android;
    public AdjustProductConfig Free_Ios;
    
    // Methods
    public void LinkTokens(AdjustTracking tracker)
    {
        System.Type val_1 = this.Free_Android.GetType();
        System.Reflection.FieldInfo[] val_2 = this.Free_Android.GetFields();
        goto label_2;
        label_9:
        tracker.AddEventToken(eventName:  mem[this.Free_Android.hint_used_16 + 0], eventToken:  mem[this.Free_Android.hint_used_16 + 0]);
        0 = 1;
        label_2:
        if(0 < this.Free_Android.hint_used)
        {
            goto label_9;
        }
    
    }
    private AdjustProductConfig ChooseConfig()
    {
    
    }
    public AdjustConfig()
    {
    
    }

}
