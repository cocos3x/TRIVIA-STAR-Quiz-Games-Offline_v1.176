using UnityEngine;
public class WGButtonSound : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    
    // Methods
    private void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.button = this;
        if((UnityEngine.Object.op_Implicit(exists:  -298628144)) != false)
        {
                UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -298628144, method:  new IntPtr(3996314128));
            this.button.m_OnClick.AddListener(call:  162246656);
            return;
        }
        
        this.enabled = false;
    }
    private void PlaySound()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2114052032) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
    }
    public WGButtonSound()
    {
    
    }

}
