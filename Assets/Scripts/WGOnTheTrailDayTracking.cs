using UnityEngine;
public class WGOnTheTrailDayTracking : MonoBehaviour
{
    // Methods
    public void Setup(int today, System.Collections.Generic.List<bool> daysRewarded, System.Collections.Generic.List<int> rewards)
    {
        int val_4;
        var val_5;
        int val_6;
        System.Collections.Generic.List<System.Int32> val_7;
        UnityEngine.Transform val_1 = this.transform;
        T[] val_2 = this.GetComponentsInChildren<System.Object>();
        if(R8 < 1)
        {
                return;
        }
        
        int val_4 = today;
        int val_3 = val_4 - 1;
        val_4 = this + (val_3 << 2);
        val_4 = val_4 + 16;
        label_24:
        if(0 >= val_3)
        {
            goto label_4;
        }
        
        if(val_4 <= 0)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        var val_6 = (0 + 0) + 16;
        val_6 = val_6 ^ 1;
        val_4 = 0 + 1;
        val_5 = val_6;
        val_6 = 0;
        goto label_10;
        label_4:
        if(0 != val_3)
        {
            goto label_14;
        }
        
        if(val_4 <= val_3)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + val_3;
        if(((0 + (today - 1)) + 16) == 0)
        {
            goto label_14;
        }
        
        val_4.Setup(status:  0, day:  today, reward:  0);
        val_4 = 0 + 1;
        goto label_18;
        label_14:
        val_7 = rewards;
        if(val_7 == 0)
        {
                val_7 = rewards;
        }
        
        if((rewards + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = rewards + 8;
        val_8 = val_8 + 0;
        val_4 = 0 + 1;
        val_5 = 2;
        val_6 = (rewards + 8 + 0) + 16;
        label_10:
        WGOnTheTrailDayTracking.__il2cppRuntimeField_byval_arg.Setup(status:  2, day:  val_4, reward:  val_6);
        label_18:
        if(val_4 != R8)
        {
            goto label_24;
        }
    
    }
    public WGOnTheTrailDayTracking()
    {
    
    }

}
