using UnityEngine;
public class SLCDateTimeDisplay : MonoSingleton<SLCDateTimeDisplay>
{
    // Fields
    private UnityEngine.GameObject uiobject;
    private UnityEngine.UI.Text label;
    
    // Methods
    private void OnEnable()
    {
        var val_2;
        var val_2 = 24279933;
        val_2 = 11356368 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(DateTimeCheat._mSeconds != 0)
        {
                DateTimeCheat.__il2cppRuntimeField_cctor_finished = 1;
        }
        
        if(DateTimeCheat._mSeconds == 0)
        {
                DateTimeCheat.__il2cppRuntimeField_cctor_finished = 0;
        }
        
        this.uiobject.SetActive(value:  false);
        string val_1 = DateTimeCheat.GetSimulatedDate();
        if(this.label == 0)
        {
            
        }
    
    }
    public static void UpdateDateTimeDisplay()
    {
        var val_8;
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-908724304) == 0)
        {
                return;
        }
        
        var val_8 = 24279477;
        val_8 = 11356824 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(DateTimeCheat._mSeconds != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = 1;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = 0;
        }
        
        public static SLCDateTimeDisplay MonoSingleton<SLCDateTimeDisplay>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_7 = DateTimeCheat.GetSimulatedDate();
        goto public static SLCDateTimeDisplay MonoSingleton<SLCDateTimeDisplay>::get_Instance().__il2cppRuntimeField_10 + 788;
    }
    public SLCDateTimeDisplay()
    {
    
    }

}
