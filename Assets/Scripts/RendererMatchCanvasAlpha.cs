using UnityEngine;
public class RendererMatchCanvasAlpha : MonoBehaviour
{
    // Fields
    private bool mapToOriginalAlpha;
    private string colorProperty;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.Color originalColor;
    private UnityEngine.Renderer _renderer;
    
    // Properties
    private UnityEngine.Renderer _Renderer { get; }
    
    // Methods
    private UnityEngine.Renderer get__Renderer()
    {
        if(0 != this._renderer)
        {
                return;
        }
        
        object val_2 = this._renderer.GetComponent<System.Object>();
        this._renderer = this;
    }
    private void Awake()
    {
        object val_1 = this.GetComponentInParent<System.Object>();
        this.canvasGroup = this;
        UnityEngine.Renderer val_2 = this._Renderer;
        UnityEngine.Material val_3 = this.material;
        UnityEngine.Color val_4 = GetColor(name:  -223540048);
        this.ChangeAlpha();
    }
    private void ChangeAlpha()
    {
        var val_8;
        UnityEngine.CanvasGroup val_9;
        var val_10;
        float val_11;
        float val_12;
        UnityEngine.Renderer val_1 = this._Renderer;
        UnityEngine.Material val_2 = this.material;
        if(this.mapToOriginalAlpha != false)
        {
                val_8 = 0;
            val_9 = this.canvasGroup;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  UnityEngine.Mathf.Lerp(a:  this.canvasGroup.alpha, b:  null, t:  null), g:  null, b:  null, a:  null);
            val_10 = 0;
            val_11 = val_5.r;
            val_12 = val_5.g;
        }
        else
        {
                val_9 = this.canvasGroup;
            val_8 = 0;
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  val_9.alpha, g:  null, b:  null, a:  null);
            val_11 = val_7.r;
            val_12 = val_7.g;
        }
        
        this.SetColor(name:  this.colorProperty, value:  new UnityEngine.Color() {r = val_11, g = val_12, b = val_7.b, a = val_7.a});
    }
    private void Update()
    {
        this.ChangeAlpha();
    }
    public RendererMatchCanvasAlpha()
    {
        this.mapToOriginalAlpha = true;
        this.colorProperty = "_TintColor";
        UnityEngine.Color val_1 = UnityEngine.Color.magenta;
    }

}
