using UnityEngine;
public class DeviceKeypressManager : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.List<System.Action> BackStack;
    
    // Methods
    private void Update()
    {
    
    }
    private static void DoFirstValidBackAction()
    {
        var val_1;
        var val_2;
        var val_3;
        float val_4;
        var val_5;
        goto label_10;
        label_15:
        val_1 = null;
        val_1 = null;
        if(DeviceKeypressManager.BackStack != 0)
        {
                val_2 = mem[DeviceKeypressManager.BackStack + 12];
            val_2 = DeviceKeypressManager.BackStack + 12;
            val_3 = val_2;
        }
        else
        {
                val_3 = 0;
            val_2 = 0;
        }
        
        if(val_2 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = DeviceKeypressManager.BackStack + 8;
        val_2 = val_2 + 4294967292;
        if(DeviceKeypressManager.BackStack != 0)
        {
                val_4 = mem[DeviceKeypressManager.BackStack + 12];
            val_4 = DeviceKeypressManager.BackStack + 12;
        }
        else
        {
                val_4 = 0f;
        }
        
        DeviceKeypressManager.BackStack.RemoveAt(index:  val_4 - 1);
        if(((DeviceKeypressManager.BackStack + 8 + 4294967292) + 16) != 0)
        {
            goto label_8;
        }
        
        label_10:
        val_5 = null;
        val_5 = null;
        if((DeviceKeypressManager.BackStack + 12) >= 1)
        {
            goto label_15;
        }
        
        return;
        label_8:
        (DeviceKeypressManager.BackStack + 8 + 4294967292) + 16.Invoke();
    }
    public static void AddBackAction(System.Action backAction)
    {
    
    }
    public static void RemoveBackAction(System.Action backAction)
    {
    
    }
    private static string FormatAction(System.Action act)
    {
        var val_2;
        if(act != 0)
        {
            
        }
        else
        {
                val_2 = 2621443;
        }
        
        System.Reflection.MethodInfo val_1 = act.Method;
        if(act != 0)
        {
                return System.String.Format(format:  1401716112, arg0:  2621443, arg1:  act);
        }
        
        return System.String.Format(format:  1401716112, arg0:  2621443, arg1:  act);
    }
    public DeviceKeypressManager()
    {
    
    }
    private static DeviceKeypressManager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        DeviceKeypressManager.BackStack = null;
    }

}
