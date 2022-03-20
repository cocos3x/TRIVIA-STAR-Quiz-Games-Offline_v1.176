using UnityEngine;
public class BlurCanvas : MonoBehaviour
{
    // Fields
    private LeTai.Asset.TranslucentImage.TranslucentImageSource translucentImageSource;
    private UnityEngine.Camera camera;
    private float blurStrength;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.translucentImageSource = this;
        this.Strength = null;
        this.translucentImageSource.enabled = false;
        object val_2 = this.GetComponent<System.Object>();
        this.camera = this;
    }
    public void DoBlur()
    {
        this.translucentImageSource.Strength = null;
        this.translucentImageSource.enabled = true;
    }
    public void StopBlur()
    {
        this.translucentImageSource.enabled = false;
    }
    public BlurCanvas()
    {
    
    }

}
