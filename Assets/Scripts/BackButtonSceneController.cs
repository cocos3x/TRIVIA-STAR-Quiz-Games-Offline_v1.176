using UnityEngine;
public class BackButtonSceneController : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        System.Action val_1 = new System.Action(object:  -2045266864, method:  new IntPtr(2249675408));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -2045154864, method:  new IntPtr(2249675408));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    private void HandleBackAction()
    {
        var val_11;
        var val_12;
        val_11 = 1152921504901095424;
        val_12 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HasQueuedWindows() == true)
        {
            goto label_4;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
            goto label_10;
        }
        
        label_4:
        System.Action val_5 = new System.Action(object:  -2045041840, method:  new IntPtr(2249675408));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
        return;
        label_10:
        GameBehavior val_6 = App.getBehavior;
        if(0 == 1)
        {
                App.Quit();
            return;
        }
        
        GameBehavior val_8 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        GameBehavior val_9 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public BackButtonSceneController()
    {
    
    }

}
