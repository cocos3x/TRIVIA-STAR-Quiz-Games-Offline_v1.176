using UnityEngine;
public class WGTaskDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text taskText;
    
    // Methods
    private void OnEnable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1145614560) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(isRelevent != false)
        {
                string val_5 = Localization.Localize(key:  -1145613392, defaultValue:  -1145613536, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_7 = getNextUnlockLevel();
            val_7 = val_7 - 1;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_9 = getNextUnlockableEvent();
            string val_10 = System.String.Format(format:  -1145613392, arg0:  13152256, arg1:  -1145614560);
            if(this.taskText != 0)
        {
                return;
        }
        
            return;
        }
        
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGTaskDisplay()
    {
    
    }

}
