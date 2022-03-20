using UnityEngine;
public class CCamera : MonoBehaviour
{
    // Fields
    public bool landscape;
    public float minWidth;
    public float minHeight;
    public float maxWidth;
    public float maxHeight;
    public float virtualWidth;
    public float virtualHeight;
    private int screenWidth;
    private int screenHeight;
    private float aspect;
    private UnityEngine.Camera cam;
    private bool matchWidth;
    private float width;
    private float height;
    private float minAspect;
    private float maxAspect;
    public System.Action onScreenSizeChanged;
    
    // Methods
    protected virtual void Awake()
    {
        float val_6;
        float val_7;
        object val_1 = this.GetComponent<System.Object>();
        this.cam = this;
        if(static_value_021F9EA9 == false)
        {
                0 = 1;
        }
        
        this.matchWidth = true;
        if(this.landscape != false)
        {
                float val_2 = UnityEngine.Mathf.Min(a:  null, b:  null);
            float val_6 = this.minHeight;
            val_6 = this.minHeight;
            val_6 = this.minWidth / val_6;
            val_7 = this.maxWidth;
            this.minAspect = val_6;
            float val_3 = UnityEngine.Mathf.Max(a:  val_6, b:  null);
        }
        else
        {
                float val_4 = UnityEngine.Mathf.Max(a:  null, b:  null);
            float val_7 = this.minWidth;
            val_6 = this.minWidth;
            val_7 = this.minHeight / val_7;
            val_7 = this.maxHeight;
            this.minAspect = val_7;
            float val_5 = UnityEngine.Mathf.Min(a:  val_7, b:  null);
        }
        
        float val_8 = val_6;
        val_8 = val_7 / val_8;
        this.maxAspect = val_8;
        this.UpdateCamera();
    }
    private void Update()
    {
        var val_4 = this;
        if(this.screenWidth == UnityEngine.Screen.width)
        {
                if(this.screenHeight == UnityEngine.Screen.height)
        {
                return;
        }
        
        }
        
        R4.UpdateCamera();
    }
    private void UpdateCamera()
    {
        float val_8;
        this.screenWidth = UnityEngine.Screen.width;
        this.screenHeight = UnityEngine.Screen.height;
        if(this.landscape != false)
        {
                float val_8 = (float)UnityEngine.Screen.width;
            val_8 = val_8 / (float)UnityEngine.Screen.height;
            this.aspect = val_8;
            this.SetUpForLandscape();
        }
        else
        {
                float val_9 = (float)UnityEngine.Screen.height;
            val_9 = val_9 / (float)UnityEngine.Screen.width;
            this.aspect = val_9;
            this.SetUpForPortrait();
        }
        
        float val_7 = this.cam.orthographicSize;
        float val_10 = 200f;
        val_10 = this.cam * val_10;
        this.virtualHeight = val_10;
        if(this.landscape != false)
        {
                val_8 = val_10 * this.aspect;
        }
        else
        {
                val_8 = val_10 / this.aspect;
        }
        
        this.virtualWidth = val_8;
        if(this.onScreenSizeChanged == 0)
        {
                return;
        }
        
        this.onScreenSizeChanged.Invoke();
    }
    private void SetUpForPortrait()
    {
        float val_2;
        float val_3;
        float val_2 = this.aspect;
        float val_1 = UnityEngine.Mathf.Clamp(value:  null, min:  null, max:  null);
        if(this.matchWidth != false)
        {
                val_2 = this.minWidth / 200f;
            val_3 = val_2 * val_2;
        }
        else
        {
                val_3 = this.minHeight / 200f;
            val_2 = val_3 / val_2;
        }
        
        val_2 = this.aspect * val_2;
        this.width = val_2;
        this.height = val_3;
        if(this.matchWidth < 0)
        {
                val_2 = val_3;
        }
        
        this.cam.orthographicSize = val_3;
    }
    private void SetUpForLandscape()
    {
        float val_4;
        float val_5;
        float val_1 = UnityEngine.Mathf.Clamp(value:  null, min:  null, max:  null);
        if(this.matchWidth != false)
        {
                val_4 = this.minWidth / 200f;
            val_5 = val_4 / this.aspect;
        }
        else
        {
                val_5 = this.minHeight / 200f;
            val_4 = this.aspect * val_5;
        }
        
        this.width = val_4;
        this.height = val_5;
        if(this.matchWidth < false)
        {
                val_5 = val_4 / this.aspect;
        }
        
        this.cam.orthographicSize = val_4;
    }
    public float GetHeight()
    {
        return (float)S0;
    }
    public float GetWidth()
    {
        return (float)S0;
    }
    public CCamera()
    {
    
    }

}
