using UnityEngine;
public class MyButton : MonoBehaviour
{
    // Fields
    protected bool useCustomSound;
    protected UnityEngine.UI.Button button;
    
    // Methods
    protected virtual void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.button = this;
        if((-2114148224) == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -2114148224, method:  typeof(MyButton).__il2cppRuntimeField_E8);
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    public virtual void OnButtonClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = UnityEngine.Object.op_Equality(x:  -2114052032, y:  0);
        if(val_2 == false)
        {
                val_2 = this.useCustomSound;
            goto label_5;
        }
        
        return;
        label_5:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
    }
    public MyButton()
    {
    
    }

}
