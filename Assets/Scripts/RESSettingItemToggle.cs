using UnityEngine;
public class RESSettingItemToggle : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image iconImage;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction<System.Boolean> val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  -655217264, method:  new IntPtr(3639722960));
        this.AddListener(call:  162353152);
    }
    public RESSettingItemToggle()
    {
    
    }
    private void <Awake>b__1_0(bool state)
    {
        if(state == true)
        {
                1065353216 = 1056964608;
        }
        
        if(state == true)
        {
                0 = 1056964608;
        }
        
        if(state == false)
        {
                0 = 1065353216;
            1065353216 = 1065353216;
            1056964608 = 1065353216;
        }
        
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        this.iconImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.r};
    }

}
