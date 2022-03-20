using UnityEngine;
public class ExtraProgressFlexible : MonoBehaviour
{
    // Fields
    public float target;
    public float _current;
    public float maxWidth;
    private UnityEngine.RectTransform sourceTransform;
    private UnityEngine.RectTransform rt;
    private bool hasInitialized;
    private FrameSkipper skipper;
    
    // Properties
    public float current { get; set; }
    
    // Methods
    public float get_current()
    {
        return (float)S0;
    }
    public void set_current(float value)
    {
        this._current = ;
        this.UpdateUI();
    }
    private void Init()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.rt = this;
        bool val_2 = UnityEngine.Object.op_Equality(x:  this.sourceTransform, y:  0);
        if(val_2 == true)
        {
                this.sourceTransform = this.rt;
            this.sourceTransform = this.sourceTransform;
        }
        
        if(val_2 == false)
        {
                this.sourceTransform = this.sourceTransform;
        }
        
        UnityEngine.Rect val_3 = rect;
        float val_4 = width;
        this.maxWidth = ;
        object val_5 = this.sourceTransform.GetComponent<System.Object>();
        this.skipper = this;
        System.Action val_6 = new System.Action(object:  -2087186320, method:  new IntPtr(2207755952));
        this.sourceTransform = null;
        this.hasInitialized = true;
    }
    private void UpdateUI()
    {
        if(this.hasInitialized == false)
        {
                this.hasInitialized = this;
            this.Init();
        }
        
        if((UnityEngine.Mathf.Approximately(a:  null, b:  null)) == true)
        {
                return;
        }
        
        UnityEngine.Rect val_2 = rect;
        float val_3 = width;
        this.maxWidth = ;
        float val_4 = this._current / this.target;
        float val_5 = UnityEngine.Mathf.Clamp(value:  val_4, min:  val_2.m_YMin, max:  val_2.m_Width);
        UnityEngine.Vector2 val_6 = sizeDelta;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_4 * this.maxWidth, y:  val_6.y);
        this.rt.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
    }
    private void CheckDimensions()
    {
        if(this.hasInitialized == false)
        {
                return;
        }
        
        if((UnityEngine.Mathf.Approximately(a:  null, b:  null)) == true)
        {
                return;
        }
        
        UnityEngine.Rect val_2 = rect;
        bool val_4 = UnityEngine.Mathf.Approximately(a:  width, b:  val_2.m_YMin);
        if(val_4 == false)
        {
                val_4 = this;
            this.UpdateUI();
        }
    
    }
    public ExtraProgressFlexible()
    {
    
    }

}
