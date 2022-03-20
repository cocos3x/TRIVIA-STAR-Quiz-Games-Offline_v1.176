using UnityEngine;
public class ExtraProgress : MonoBehaviour
{
    // Fields
    public float target;
    public float _current;
    public float maxWidth;
    private UnityEngine.RectTransform sourceTransform;
    private UnityEngine.RectTransform rt;
    private bool hasInitialized;
    
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
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.sourceTransform, y:  0);
        if(val_2 == true)
        {
                this.sourceTransform = this.sourceTransform;
        }
        
        if(val_2 == false)
        {
                this.sourceTransform = this.rt;
        }
        
        UnityEngine.Rect val_3 = rect;
        float val_4 = width;
        this.hasInitialized = true;
        this.maxWidth = 2207174120;
    }
    private void UpdateUI()
    {
        if(this.hasInitialized == false)
        {
                this.hasInitialized = this;
            this.Init();
        }
        
        if(this.hasInitialized == false)
        {
                return;
        }
        
        float val_1 = this._current / this.target;
        float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  null, max:  null);
        UnityEngine.Vector2 val_3 = sizeDelta;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_1 * this.maxWidth, y:  val_3.y);
        this.rt.sizeDelta = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    public ExtraProgress()
    {
    
    }

}
