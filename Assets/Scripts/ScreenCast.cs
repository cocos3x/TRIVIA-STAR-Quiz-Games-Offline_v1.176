using UnityEngine;
public class ScreenCast : MonoBehaviour
{
    // Methods
    public static UnityEngine.Vector3 GetObjectPosition(ScreenCast.ScreenCastMode mode, UnityEngine.Vector3 objectPosition)
    {
        float val_6;
        float val_7;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        val_13 = objectPosition.x;
        if(val_13 == 0f)
        {
            goto label_1;
        }
        
        if(val_13 != (1.401298E-45f))
        {
            goto label_2;
        }
        
        UnityEngine.Camera val_2 = SLCWindowManager<WGWindowManager>.monolithPopupCamera;
        val_13 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_monolithPopupCamera();
        val_14 = 0;
        UnityEngine.Camera val_3 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_4 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = objectPosition.y, z = objectPosition.z});
        val_15 = val_6;
        val_16 = val_7;
        goto label_7;
        label_1:
        UnityEngine.Camera val_8 = UnityEngine.Camera.main;
        val_13 = 0;
        UnityEngine.Camera val_9 = SLCWindowManager<WGWindowManager>.monolithPopupCamera;
        val_14 = 0;
        UnityEngine.Vector3 val_10 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = objectPosition.y, z = objectPosition.z});
        val_15 = val_6;
        val_16 = val_7;
        label_7:
        UnityEngine.Vector3 val_11 = mode.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_15, z = val_16});
        return new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        label_2:
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
    }
    public ScreenCast()
    {
    
    }

}
