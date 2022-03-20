using UnityEngine;
public class WGMyToggle : MonoBehaviour
{
    // Fields
    protected UnityEngine.Sprite on;
    protected UnityEngine.Sprite off;
    protected UnityEngine.UI.Toggle toggle;
    protected bool initialized;
    
    // Methods
    protected virtual void Start()
    {
        UnityEngine.UI.Toggle val_4;
        UnityEngine.UI.Toggle val_5;
        object val_1 = this.GetComponent<System.Object>();
        this.toggle = this;
        if((-153565024) == 0)
        {
                return;
        }
        
        val_4 = 1152921504811212800;
        val_4 = this.toggle;
        this.on = (UnityEngine.UI.Toggle.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Image.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        val_5 = val_4;
        this.off = (UnityEngine.UI.Toggle.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Image.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
        goto label_11;
        label_10:
        val_5 = this.toggle;
        this.off = (UnityEngine.UI.Toggle.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Image.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
        if(val_5 == 0)
        {
            goto label_12;
        }
        
        label_11:
        UnityEngine.Events.UnityAction<System.Boolean> val_3 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  -153565024, method:  typeof(WGMyToggle).__il2cppRuntimeField_E8);
        this.toggle.onValueChanged.AddListener(call:  162353152);
        this.initialized = true;
        return;
        label_12:
    }
    public virtual void OnToggleChange(bool state)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
        goto typeof(WGMyToggle).__il2cppRuntimeField_EC;
    }
    public virtual void UpdateVisual(bool state)
    {
        var val_2;
        UnityEngine.Sprite val_3;
        if(0 == 0)
        {
                return;
        }
        
        val_2 = 0;
        if(state != false)
        {
                val_2 = 0;
            val_3 = this.off;
        }
        else
        {
                val_3 = this.on;
        }
        
        val_2.sprite = mem[this.on];
    }
    public WGMyToggle()
    {
    
    }

}
