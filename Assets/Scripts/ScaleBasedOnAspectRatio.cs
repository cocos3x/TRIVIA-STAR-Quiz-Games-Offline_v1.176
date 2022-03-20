using UnityEngine;
public class ScaleBasedOnAspectRatio : MonoBehaviour
{
    // Fields
    public bool debugLog;
    public float aspectRatioMin;
    public float aspectRatioMax;
    public float scaleToAtMin;
    public float scaleToAtMax;
    public float scale;
    private float currentAspectRatio;
    public bool alsoScaleZAxis;
    public bool onlyUpdateOnce;
    
    // Methods
    private void Update()
    {
        var val_10;
        var val_11;
        var val_12;
        float val_10 = (float)UnityEngine.Screen.width;
        val_10 = val_10 / (float)UnityEngine.Screen.height;
        this.currentAspectRatio = val_10;
        float val_11 = this.aspectRatioMax;
        val_11 = val_11 - this.aspectRatioMin;
        val_10 = val_10 - this.aspectRatioMin;
        float val_3 = val_10 / val_11;
        float val_4 = UnityEngine.Mathf.Lerp(a:  val_10, b:  null, t:  this.aspectRatioMin);
        this.scale = this.scaleToAtMin;
        if(this.debugLog != false)
        {
                val_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = "currentAspectRatio = ";
            string val_5 = this.currentAspectRatio.ToString(format:  -2011286448);
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.currentAspectRatio;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "  (t = ";
            val_11 = 1152921504622129152;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = ")  scale: ";
            val_12 = null;
            typeof(System.Object[]).__il2cppRuntimeField_24 = ;
            string val_6 = +472754880;
            UnityEngine.Debug.LogError(message:  472754880);
        }
        
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  this.scale = 1f, y:  null, z:  1f);
        this.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        if(this.onlyUpdateOnce == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  -2011261760);
    }
    public ScaleBasedOnAspectRatio()
    {
        this.scale = 1f;
        this.currentAspectRatio = 1.33f;
    }

}
